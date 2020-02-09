using CapStoneApp.Models;
using Microsoft.AspNet.Identity;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace CapStoneApp.Controllers
{
    public class ClientsController : Controller
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

        public ActionResult Inbox()
        {
            var userId = User.Identity.GetUserId();
            var clientInbox = db.Clients.Where(c => c.ApplicationId == userId).Select(c => c.InboxId).SingleOrDefault();
            var inbox = db.Inboxes.Where(i => i.Id == clientInbox).Select(i => i).SingleOrDefault();
            var messeges = db.InboxMesseges.Where(m => m.InboxId == inbox.Id).Select(m => m).ToList();
            return View(messeges);
        }

        public ActionResult ShowCandidate(int? id, string type)
        {
            var userId = User.Identity.GetUserId();
            var client = db.Clients.Where(c => c.ApplicationId == userId).Select(c => c).SingleOrDefault();
            ViewBag.ClientCandidate = client.CandidateName;
            List<ApiViewModel> list = null;
            switch (type)
            {
                case "candidate":
                    list = GetCandidates();
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

        public ActionResult Vote()
        {
            return View();
        }

        public int FindLikes(int? id)
        {
            int percentage;
            var clients = db.Clients.Select(c => c).Count();
            var likes = db.Clients.Where(c => c.CandidateId == id).Select(c => c).Count();
            percentage = (likes / clients) * 100;
            return percentage;
        }

        public int FindDislikes(int? id)
        {
            int percentage;
            var clients = db.Clients.Select(c => c).Count();
            var likes = db.Clients.Where(c => c.DislikeId == id).Select(c => c).Count();
            percentage = (likes / clients) * 100;
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
                        Name = (string)item["Issue"],
                        Position = (string)item["Stance"],
                        Location = (string)item["Location"],
                        Party = (string)item["Party"],
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

        public ActionResult Details(int? id, bool delete)
        {
            Client user = null;
            if (id == null)
            {
                var userId = User.Identity.GetUserId();
                user = db.Clients.Where(c => c.ApplicationId == userId).Select(c => c).SingleOrDefault();
            }
            else
            {
                user = db.Clients.Where(c => c.Id == id).Select(c => c).SingleOrDefault();
            }
            ViewBag.Delete = delete;
            return View(user);
        }

        public ActionResult Delete(bool delete)
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
    }
}