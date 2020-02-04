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
            return View();
        }

        public ActionResult ShowCandidate()
        {
            var candidates = GetCandidates();
            return View(candidates);
        }

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
                        Bio = (string)item["Bio"],
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

        public void GetEndorsements()
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
        }

        public ActionResult Details(int? id, bool delete)
        {
            Client user = null;
            if (id == null)
            {
                user = db.Clients.Where(c => c.ApplicationId == User.Identity.GetUserId()).Select(c => c).SingleOrDefault();
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