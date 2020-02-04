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
            var contents = db.Contents.Include(c => c.Client).Include(c => c.Forum).Include(f => f.Client.ApplicationUser).ToList();
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
        public ActionResult Index(Content content, bool? isTrue)
        {
            if (ModelState.IsValid)
            {
                var id = User.Identity.GetUserId();
                var userId = db.Clients.Where(c => c.ApplicationId == id).Select(c => c.Id).SingleOrDefault();
                content.ClientId = userId;
                db.Contents.Add(content);
                db.SaveChanges();
                var contents = db.Contents.Include(c => c.Client).Include(c => c.Forum).Include(f => f.Client.ApplicationUser);
                ViewBag.UserId = userId;
                ViewBag.Name = contents.First().Forum.Name;
                ViewBag.Forum = content.ForumId;
                return View(contents);
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

        // GET: Contents/Edit/5
        public ActionResult Edit(int? id)
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

        // POST: Contents/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Content content)
        {
            if (ModelState.IsValid)
            {
                db.Entry(content).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(content);
        }

        // GET: Contents/Delete/5
        public ActionResult Delete(int? id)
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

        // POST: Contents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Content content = db.Contents.Find(id);
            db.Contents.Remove(content);
            db.SaveChanges();
            return RedirectToAction("Index", new { forumId = content.ForumId });
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
