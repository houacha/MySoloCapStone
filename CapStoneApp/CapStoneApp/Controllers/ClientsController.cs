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

        public ActionResult ShowCandidate(int? id, string type)
        {
            List<ApiViewModel> list = null;
            switch (type)
            {
                case "candidate":
                    list = GetCandidates();
                    break;
                case "policy":
                    list = GetPolicies();
                    list = list.Where(p => p.CandidateId == id).ToList();
                    break;
                case "ad":
                    list = GetAds();
                    list = list.Where(a => a.CandidateId == id).ToList();
                    break;
                case "theme":
                    list = GetCampaignTheme();
                    list = list.Where(t => t.CandidateId == id).ToList();
                    break;
                case "finance":
                    list = GetFinances();
                    list = list.Where(f => f.CandidateId == id).ToList();
                    break;
                case "staff":
                    list = GetStaff();
                    list = list.Where(s => s.CandidateId == id).ToList();
                    break;
                case "endorsement":
                    list = GetEndorsements();
                    list = list.Where(e => e.CandidateId == id).ToList();
                    break;
                default:
                    break;
            }
            return View(list);
        }

        public ActionResult CandidatesDetails(int? id)
        {
            ApiViewModel api = null;
            List<ApiViewModel> list = null;
            list = GetCandidates();
            api = list.Where(c => c.Id == id).SingleOrDefault();
            return View(api);
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
            db.Users.Remove(user);
            db.Clients.Remove(client);
            db.SaveChanges();
            return View("Index", "Home");
        }
    }
}