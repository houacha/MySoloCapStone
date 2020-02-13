using CapStoneApp.Models;
using Microsoft.AspNet.Identity;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace CapStoneApp.Controllers
{
    public class ClientsController : BaseController
    {
        // GET: Clients
        ApplicationDbContext db;
        HttpClient client;
        public ClientsController()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44359/api/");
            db = new ApplicationDbContext();
        }

        public ActionResult Index()
        {
            var clients = db.Clients.ToList();
            return View(clients);
        }

        public ActionResult Details(int? id, bool? delete)
        {
            Client user = null;
            var candidates = GetCandidates();
            if (id == null)
            {
                var userId = User.Identity.GetUserId();
                user = db.Clients.Include(c=>c.ApplicationUser).Where(c => c.ApplicationId == userId).Select(c => c).SingleOrDefault();
            }
            else
            {
                user = db.Clients.Include(c => c.ApplicationUser).Where(c => c.Id == id).Select(c => c).SingleOrDefault();
            }
            ViewBag.Delete = delete;
            var voteFor = candidates.Where(c => c.Name == user.CandidateName).Select(c => c).SingleOrDefault();
            var like = candidates.Where(c => c.Id == user.CandidateId).Select(c => c).SingleOrDefault();
            var dislike = candidates.Where(c => c.Id == user.DislikeId).Select(c => c).SingleOrDefault();
            if (like != null)
            {
                ViewBag.Liked = like.Name;
                if (like.Party == "Democratic" || like.Party == "Independent/Democratic" || like.Party == "Democratic/Independent")
                {
                    ViewBag.Dem = "true";
                    ViewBag.Rep = "false";
                }
                else
                {
                    ViewBag.Dem = "false";
                    ViewBag.Rep = "true";
                }
            }
            if (dislike != null)
            {
                ViewBag.Dislike = dislike.Name;
            }
            if (voteFor != null)
            {
                ViewBag.VoteFor = voteFor.Name;
            }
            return View(user);
        }

        public ActionResult Delete(bool? delete)
        {
            ViewBag.Delete = delete;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int? id)
        {
            var client = db.Clients.Where(c => c.Id == id).Select(c => c).SingleOrDefault();
            var user = db.Users.Where(u => u.Id == client.ApplicationId).Select(u => u).SingleOrDefault();
            var forums = db.Fora.Where(f => f.ClientId == client.Id).Select(f => f).ToList();
            foreach (var item in forums)
            {
                var contents = db.Contents.Where(c => c.ForumId == item.Id).Select(c => c).ToList();
                List<Client> checkedClient = new List<Client>();
                foreach (var content in contents)
                {
                    var contentclient = db.Clients.Where(c => c.Id == item.ClientId).Select(c => c).SingleOrDefault();
                    if (!checkedClient.Contains(contentclient))
                    {
                        InboxMessege messege = new InboxMessege();
                        messege.Messege = "The forum '" + item.Name + "' and all its contents has been deleted.";
                        messege.InboxId = contentclient.InboxId;
                        db.InboxMesseges.Add(messege);
                        checkedClient.Add(contentclient);
                    }
                    db.Contents.Remove(content);
                }
                db.Fora.Remove(item);
            }
            db.Users.Remove(user);
            db.Clients.Remove(client);
            db.SaveChanges();
            return View("Index", "Home");
        }

        #region Inbox stuff
        public ActionResult Inbox()
        {
            var userId = User.Identity.GetUserId();
            var clientInbox = db.Clients.Where(c => c.ApplicationId == userId).Select(c => c.InboxId).SingleOrDefault();
            var inbox = db.Inboxes.Where(i => i.Id == clientInbox).Select(i => i).SingleOrDefault();
            var messeges = db.InboxMesseges.Where(m => m.InboxId == inbox.Id).Select(m => m).ToList();
            return View(messeges);
        }

        public ActionResult MessegeDelete(int? id)
        {
            var messege = db.InboxMesseges.Where(m => m.Id == id).Select(m => m).SingleOrDefault();
            db.InboxMesseges.Remove(messege);
            db.SaveChanges();
            return RedirectToAction("Inbox");
        }

        #endregion

        #region Candidates Stuff

        public ActionResult ShowCandidate(int? id, string type, bool? candidates, string name)
        {
            var userId = User.Identity.GetUserId();
            var client = db.Clients.Where(c => c.ApplicationId == userId).Select(c => c).SingleOrDefault();
            ViewBag.ClientCandidate = client.CandidateName;
            List<ApiViewModel> list = null;
            switch (type)
            {
                case "candidate":
                    if (candidates == true)
                    {
                        ViewBag.Candidates = true;
                        list = GetCandidates();
                        list = list.Where(c => c.Name.Contains(name)).Select(c => c).ToList();
                    }
                    else
                    {
                        list = new List<ApiViewModel>();
                        var candidate = new ApiViewModel()
                        {
                            Name = ""
                        };
                        list.Add(candidate);
                    }
                    ViewBag.Like = client.CandidateId;
                    ViewBag.Info = "Candidate";
                    break;
                case "policy":
                    list = GetPolicies();
                    list = list.Where(p => p.CandidateId == id).ToList();
                    ViewBag.Info = "Policy";
                    break;
                case "ad":
                    list = GetAds();
                    list = list.Where(a => a.CandidateId == id).ToList();
                    ViewBag.Info = "Ad";
                    break;
                case "theme":
                    list = GetCampaignTheme();
                    list = list.Where(t => t.CandidateId == id).ToList();
                    ViewBag.Info = "Theme";
                    break;
                case "finance":
                    list = GetFinances();
                    list = list.Where(f => f.CandidateId == id).ToList();
                    ViewBag.Info = "Finance";
                    break;
                case "staff":
                    list = GetStaff();
                    list = list.Where(s => s.CandidateId == id).ToList();
                    ViewBag.Info = "Staff";
                    break;
                case "endorsement":
                    list = GetEndorsements();
                    list = list.Where(e => e.CandidateId == id).ToList();
                    ViewBag.Info = "Endorsement";
                    break;
                default:
                    break;
            }
            return View(list);
        }

        [HttpPost]
        public ActionResult ShowCandidate(string name)
        {
            var list = ConvertName(name);
            List<ApiViewModel> candids = null;
            var candidates = GetCandidates();
            int candidateId;
            if ( list.Count > 1)
            {
                var first = list[0];
                var last = list.Last();
                candidateId = candidates.Where(c => c.Name.Contains(first) && c.Name.Contains(last)).Select(c => c.Id).SingleOrDefault();
            }
            else
            {                
                candids = candidates.Where(c => c.Name.Contains(list[0])).Select(c => c).ToList();
                if (candids.Count > 1)
                {
                    return RedirectToAction("ShowCandidate", new { type = "candidate", candidates = true, name = list[0] });
                }
                else
                {
                    candidateId = candidates.Where(c => c.Name.Contains(list[0])).Select(c => c.Id).SingleOrDefault();
                }
            }
            return RedirectToAction("CandidatesDetails", new { id = candidateId});
        }

        public List<string> ConvertName(string name)
        {
            var newName = name.ToLower();
            var arr = newName.Split(' ');
            List<string> list = new List<string>();
            foreach (var item in arr)
            {
                var firstLet = item[0].ToString().ToUpper();
                var removed = item.Remove(0, 1);
                var newStr = removed.Insert(0, firstLet);
                list.Add(newStr);
            }
            return list;
        }

        public ActionResult CandidatesDetails(int? id)
        {
            var userId = User.Identity.GetUserId();
            var client = db.Clients.Where(c => c.ApplicationId == userId).Select(c => c).SingleOrDefault();
            ApiViewModel api = null;
            List<ApiViewModel> list = null;
            if (client.CandidateId == id)
            {
                ViewBag.Liked = client.CandidateId;
            }
            else if (client.DislikeId == id)
            {
                ViewBag.Dislike = client.DislikeId;
            }
            ViewBag.Likes = FindLikes(id);
            ViewBag.Dislikes = FindDislikes(id);
            list = GetCandidates();
            api = list.Where(c => c.Id == id).SingleOrDefault();
            if (api == null)
            {
                api = new ApiViewModel();
                ViewBag.NoSearch = true;
            }
            return View(api);
        }

        [HttpPost]
        public ActionResult CandidatesDetails(int? id, string method, string type, string wasTrue)
        {
            switch (type)
            {
                case "like":
                    Like(id, method, wasTrue);
                    break;
                case "dislike":
                    Dislike(id, method, wasTrue);
                    break;
                default:
                    break;
            }
            return RedirectToAction("CandidatesDetails", new { id });
        }

        public ActionResult Compare()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Compare(string name, string name2)
        {
            var list = ConvertName(name);
            var list2 = ConvertName(name2);
            var candidates = GetCandidates();
            ApiViewModel person = null;
            ApiViewModel person2 = null;
            int candidateId = 0;
            int candidate2Id = 0;
            if (list.Count > 1)
            {
                var first = list[0];
                var last = list.Last();
                candidateId = candidates.Where(c => c.Name.Contains(first) && c.Name.Contains(last)).Select(c => c.Id).SingleOrDefault();
            }
            else
            {
                var candids = candidates.Where(c => c.Name.Contains(list[0])).Select(c => c).ToList();
                if (candids.Count > 1)
                {
                    person = candids.FirstOrDefault();
                }
                else
                {
                    candidateId = candidates.Where(c => c.Name.Contains(list[0])).Select(c => c.Id).SingleOrDefault();
                }
            }
            if (list2.Count > 1)
            {
                var first = list2[0];
                var last = list2.Last();
                candidate2Id = candidates.Where(c => c.Name.Contains(first) && c.Name.Contains(last)).Select(c => c.Id).SingleOrDefault();
            }
            else
            {
                var candids2 = candidates.Where(c => c.Name.Contains(list2[0])).Select(c => c).ToList();
                if (candids2.Count > 1)
                {
                    person2 = candids2.FirstOrDefault();
                }
                else
                {
                    candidate2Id = candidates.Where(c => c.Name.Contains(list2[0])).Select(c => c.Id).SingleOrDefault();
                }
            }
            return RedirectToAction("CompCandidates", new { id = candidateId, id2 = candidate2Id});
        }

        public ActionResult CompCandidates(int? id, int? id2)
        {
            var candidates = GetCandidates();
            var policies = GetPolicies();
            var themes = GetCampaignTheme();
            List<ApiViewModel> list = new List<ApiViewModel>();
            var candidate1 = candidates.Where(c => c.Id == id).Select(c => c).SingleOrDefault();
            var candidate2 = candidates.Where(c => c.Id == id2).Select(c => c).SingleOrDefault();
            var themes1 = themes.Where(t => t.CandidateId == candidate1.Id).ToList();
            var themes2 = themes.Where(t => t.CandidateId == candidate2.Id).ToList();
            var policy1 = policies.Where(p => p.CandidateId == candidate1.Id).ToList();
            var policy2 = policies.Where(p => p.CandidateId == candidate2.Id).ToList();
            candidate1.Theme = themes1;
            candidate1.Policy = policy1;
            candidate2.Theme = themes2;
            candidate2.Policy = policy2;
            list.Add(candidate1);
            list.Add(candidate2);
            return View(list);
        }

        public ActionResult Vote()
        {
            var userId = User.Identity.GetUserId();
            var currentUser = db.Clients.Where(c => c.ApplicationId == userId).Select(c => c).SingleOrDefault();
            if (currentUser.CandidateName != null)
            {
                var clients = db.Clients.Select(c => c);
                ViewBag.Voted = true;
                ViewBag.Yang = clients.Where(c=>c.CandidateName == "Andrew Yang").Select(c=>c).ToList().Count;
                ViewBag.Weld = clients.Where(c => c.CandidateName == "William Floyd Weld").Select(c => c).ToList().Count;
                ViewBag.Trump = clients.Where(c => c.CandidateName == "Donald John Trump").Select(c => c).ToList().Count;
                ViewBag.Rocky = clients.Where(c => c.CandidateName == "Roque 'Rocky' De La Fuente").Select(c => c).ToList().Count;
                ViewBag.Tom = clients.Where(c => c.CandidateName == "Thomas Fahr Steyer").Select(c => c).ToList().Count;
                ViewBag.Peter = clients.Where(c => c.CandidateName == "Peter Paul Montgomery Buttigieg").Select(c => c).ToList().Count;
                ViewBag.Bloom = clients.Where(c => c.CandidateName == "Michael Rubens Bloomberg").Select(c => c).ToList().Count;
                ViewBag.Deval = clients.Where(c => c.CandidateName == "Deval Laurdine Patrick").Select(c => c).ToList().Count;
                ViewBag.Amy = clients.Where(c => c.CandidateName == "Amy Jean Klobuchar").Select(c => c).ToList().Count;
                ViewBag.Joe = clients.Where(c => c.CandidateName == "Joseph Robinette Biden Jr.").Select(c => c).ToList().Count;
                ViewBag.Tulsi = clients.Where(c => c.CandidateName == "Tulsi Gabbard").Select(c => c).ToList().Count;
                ViewBag.Liz = clients.Where(c => c.CandidateName == "Elizabeth Ann Warren").Select(c => c).ToList().Count;
                ViewBag.Bennet = clients.Where(c => c.CandidateName == "Michael Farrand Bennet").Select(c => c).ToList().Count;
                ViewBag.Bernie = clients.Where(c => c.CandidateName == "Bernard 'Bernie' Sanders").Select(c => c).ToList().Count;
            }
            var list = GetCandidates();
            return View(list);
        }

        [HttpPost]
        public ActionResult Vote(string name)
        {
            var userId = User.Identity.GetUserId();
            var currentUser = db.Clients.Where(c => c.ApplicationId == userId).Select(c => c).SingleOrDefault();
            currentUser.CandidateName = name;
            db.SaveChanges();
            return RedirectToAction("Vote");
        }

        public double FindLikes(int? id)
        {
            double percentage;
            var clients = db.Clients.Where(c => c.CandidateId == id || c.DislikeId == id).Select(c => c).Count();
            if (clients < 1)
            {
                percentage = 0;
            }
            else
            {
                var likes = db.Clients.Where(c => c.CandidateId == id).Select(c => c).Count();
                percentage = (Convert.ToDouble(likes) / Convert.ToDouble(clients)) * 100;
            }
            return percentage;
        }

        public double FindDislikes(int? id)
        {
            double percentage;
            var clients = db.Clients.Where(c => c.CandidateId == id || c.DislikeId == id).Select(c => c).Count();
            if (clients < 1)
            {
                percentage = 0;
            }
            else
            {
                var dislikes = db.Clients.Where(c => c.DislikeId == id).Select(c => c).Count();
                percentage = (Convert.ToDouble(dislikes) / Convert.ToDouble(clients)) * 100;
            }
            return percentage;
        }

        public void Like(int? id, string method, string wasTrue)
        {
            var userId = User.Identity.GetUserId();
            var client = db.Clients.Where(c => c.ApplicationId == userId).Select(c => c).SingleOrDefault();
            switch (method)
            {
                case "add":
                    if (wasTrue == "yes")
                    {
                        Dislike(id, "remove", null);
                    }
                    client.CandidateId = id;
                    break;
                case "remove":
                    client.CandidateId = null;
                    break;
                default:
                    break;
            }
            db.SaveChanges();
        }

        public void Dislike(int? id, string method, string wasTrue)
        {
            var userId = User.Identity.GetUserId();
            var client = db.Clients.Where(c => c.ApplicationId == userId).Select(c => c).SingleOrDefault();
            switch (method)
            {
                case "add":
                    if (wasTrue == "yes")
                    {
                        Like(id, "remove", null);
                    }
                    client.DislikeId = id;
                    break;
                case "remove":
                    client.DislikeId = null;
                    break;
                default:
                    break;
            }
            db.SaveChanges();
        }

        #endregion

        #region API Get Methods
        public List<ApiViewModel> GetCandidates()
        {
            List<ApiViewModel> candidates = new List<ApiViewModel>();
            var response = client.GetAsync("Candidates");
            response.Wait();
            var result = response.Result;
            if (result.IsSuccessStatusCode)
            {
                var read = result.Content.ReadAsStringAsync();
                read.Wait();
                JArray jArray = JArray.Parse(read.Result);
                foreach (var item in jArray)
                {
                    var candidate = new ApiViewModel()
                    {
                        Id = (int)item["Id"],
                        Name = (string)item["Name"],
                        Description = (string)item["Description"],
                        Gender = (string)item["Gender"],
                        Occupation = (string)item["Occupation"],
                        Birthdate = (string)item["Birthdate"],
                        BirthPlace = (string)item["BirthPlace"],
                        Hometown = (string)item["Hometown"],
                        Religion = (string)item["Religion"],
                        MaritalStatus = (string)item["MaritalStatus"],
                        Children = (string)item["Children"],
                        Education = (string)item["Education"],
                        Polling = (double?)item["Polling"],
                        ImgPath = (string)item["ImgPath"],
                        Party = (string)item["Party"]
                    };
                    candidates.Add(candidate);
                }
            }
            return candidates;
        }

        public List<ApiViewModel> GetPolicies()
        {
            List<ApiViewModel> policies = new List<ApiViewModel>();
            var response = client.GetAsync("Policies");
            response.Wait();
            var result = response.Result;
            if (result.IsSuccessStatusCode)
            {
                var read = result.Content.ReadAsStringAsync();
                read.Wait();
                JArray jArray = JArray.Parse(read.Result);
                foreach (var item in jArray)
                {
                    var policy = new ApiViewModel()
                    {
                        Id = (int)item["Id"],
                        Issue = (string)item["Issue"],
                        Stance = (string)item["Stance"],
                        CandidateId = (int?)item["CandidateId"]
                    };
                    policies.Add(policy);
                }
            }
            return policies;
        }

        public List<ApiViewModel> GetCampaignTheme()
        {
            List<ApiViewModel> themes = new List<ApiViewModel>();
            var response = client.GetAsync("CampaignThemes");
            response.Wait();
            var result = response.Result;
            if (result.IsSuccessStatusCode)
            {
                var read = result.Content.ReadAsStringAsync();
                read.Wait();
                JArray jArray = JArray.Parse(read.Result);
                foreach (var item in jArray)
                {
                    var theme = new ApiViewModel()
                    {
                        Id = (int)item["Id"],
                        Issue = (string)item["Issue"],
                        Stance = (string)item["Stance"],
                        CandidateId = (int?)item["CandidateId"]
                    };
                    themes.Add(theme);
                }
            }
            return themes;
        }

        public List<ApiViewModel> GetFinances()
        {
            List<ApiViewModel> finances = new List<ApiViewModel>();
            var response = client.GetAsync("CampaignFinances");
            response.Wait();
            var result = response.Result;
            if (result.IsSuccessStatusCode)
            {
                var read = result.Content.ReadAsStringAsync();
                read.Wait();
                JArray jArray = JArray.Parse(read.Result);
                foreach (var item in jArray)
                {
                    var finance = new ApiViewModel()
                    {
                        Id = (int)item["Id"],
                        Amount = (double?)item["Amount"],
                        Type = (string)item["Type"],
                        CandidateId = (int?)item["CandidateId"]
                    };
                    finances.Add(finance);
                }
            }
            return finances;
        }

        public List<ApiViewModel> GetStaff()
        {
            List<ApiViewModel> staffs = new List<ApiViewModel>();
            var response = client.GetAsync("CampaignStaffs");
            response.Wait();
            var result = response.Result;
            if (result.IsSuccessStatusCode)
            {
                var read = result.Content.ReadAsStringAsync();
                read.Wait();
                JArray jArray = JArray.Parse(read.Result);
                foreach (var item in jArray)
                {
                    var staff = new ApiViewModel()
                    {
                        Id = (int)item["Id"],
                        Name = (string)item["Name"],
                        Position = (string)item["Position"],
                        Experience = (string)item["Experience"],
                        CandidateId = (int?)item["CandidateId"]
                    };
                    staffs.Add(staff);
                }
            }
            return staffs;
        }

        public List<ApiViewModel> GetAds()
        {
            List<ApiViewModel> ads = new List<ApiViewModel>();
            var response = client.GetAsync("Ads");
            response.Wait();
            var result = response.Result;
            if (result.IsSuccessStatusCode)
            {
                var read = result.Content.ReadAsStringAsync();
                read.Wait();
                JArray jArray = JArray.Parse(read.Result);
                foreach (var item in jArray)
                {
                    var ad = new ApiViewModel()
                    {
                        Id = (int)item["Id"],
                        WebsiteUrl = (string)item["WebsiteUrl"],
                        CandidateId = (int?)item["CandidateId"]
                    };
                    ads.Add(ad);
                }
            }
            return ads;
        }

        public List<ApiViewModel> GetEndorsements()
        {
            List<ApiViewModel> endorsements = new List<ApiViewModel>();
            var response = client.GetAsync("Endorsements");
            response.Wait();
            var result = response.Result;
            if (result.IsSuccessStatusCode)
            {
                var read = result.Content.ReadAsStringAsync();
                read.Wait();
                JArray jArray = JArray.Parse(read.Result);
                foreach (var item in jArray)
                {
                    var endorsement = new ApiViewModel()
                    {
                        Id = (int)item["Id"],
                        Issue = (string)item["Issue"],
                        Stance = (string)item["Stance"],
                        CandidateId = (int?)item["CandidateId"]
                    };
                    endorsements.Add(endorsement);
                }
            }
            return endorsements;
        }
        #endregion

    }
}