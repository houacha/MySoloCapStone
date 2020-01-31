using CapStoneApp.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CapStoneApp.Controllers
{
    public class ClientsController : Controller
    {
        // GET: Clients
        ApplicationDbContext db;
        public ClientsController()
        {
            db = new ApplicationDbContext();
        }
        public ActionResult Index()
        {
            return View();
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