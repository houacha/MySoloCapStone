using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CapStoneApp.Models;
using Microsoft.AspNet.Identity;

namespace CapStoneApp.Controllers
{
    public class ContentsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Contents
        public ActionResult Index(int? forumId, bool? isTrue, int? contentId)
        {
            var id = User.Identity.GetUserId();
            var userId = db.Clients.Where(c => c.ApplicationId == id).Select(c => c.Id).SingleOrDefault();
            var contents = db.Contents.Include(c => c.Client).Include(c => c.Forum).Include(f => f.Client.ApplicationUser).Where(c => c.ForumId == forumId).ToList();
            ViewBag.Forum = forumId;
            ViewBag.Name = contents.First().Forum.Name;
            ViewBag.UserId = userId;
            if (isTrue != null)
            {
                ViewBag.IsTrue = true;
                ViewBag.ContentId = contentId;
            }
            return View(contents);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(Content content, int? id, string message)
        {
            if (ModelState.IsValid)
            {
                var userId = User.Identity.GetUserId();
                var clientId = db.Clients.Where(c => c.ApplicationId == userId).Select(c => c.Id).SingleOrDefault();
                if (message != null)
                {
                    var newContent = db.Contents.Where(c => c.Id == content.Id).SingleOrDefault();
                    newContent.Message = message;
                    db.SaveChanges();
                }
                else
                {
                    content.ClientId = clientId;
                    db.Contents.Add(content);
                    db.SaveChanges();
                }
                return RedirectToAction("Index", new { forumId = content.ForumId, contentId = content.Id });
            }
            ViewBag.Forum = content.ForumId;
            return View(content);
        }

        public void ContentEdit(Content content)
        {
            if (ModelState.IsValid)
            {
                db.Entry(content).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        // GET: Contents/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Content content = db.Contents.Find(id);
            if (content == null)
            {
                return HttpNotFound();
            }
            return View(content);
        }

        // GET: Contents/Create
        public ActionResult Create(int? id)
        {
            ViewBag.Forum = id;
            return View();
        }

        // GET: Contents/Delete/5
        public ActionResult Delete(int? id, bool? isTrue)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Content content = db.Contents.Find(id);
            if (content == null)
            {
                return View(content);
            }
            else
            {
                db.Contents.Remove(content);
                db.SaveChanges();
                return RedirectToAction("Index", new { forumId = content.ForumId, contentId = content.Id, isTrue });
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
