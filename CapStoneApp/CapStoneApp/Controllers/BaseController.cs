using CapStoneApp.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CapStoneApp.Controllers
{
    public class BaseController : Controller
    {
        // GET: Base
        public BaseController()
        {
            if (System.Web.HttpContext.Current.User.Identity.Name != "")
            {
                ApplicationDbContext db = new ApplicationDbContext();
                var cId = System.Web.HttpContext.Current.User.Identity.GetUserId();
                var currentId = db.Clients.Where(c => c.ApplicationId == cId).Select(c => c.InboxId).SingleOrDefault();
                var inboxMesseges = db.InboxMesseges.Where(m => m.InboxId == currentId).Select(m => m).ToList();
                ViewBag.Messeges = inboxMesseges.Count;
            }
        }
    }
}