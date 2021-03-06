﻿using System;
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
    public class ContentsController : BaseController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Contents
        public ActionResult Index(int? forumId, bool? isTrue, int? contentId)
        {
            var id = User.Identity.GetUserId();
            var userId = db.Clients.Where(c => c.ApplicationId == id).Select(c => c.Id).SingleOrDefault();
            var contents = db.Contents.Include(c => c.Client).Include(c => c.Forum).Include(f => f.Client.ApplicationUser).Where(c => c.ForumId == forumId).ToList();
            var forum = db.Fora.Where(f => f.Id == forumId).Select(f => f).SingleOrDefault();
            ViewBag.Forum = forumId;
            ViewBag.Name = forum.Name;
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
        public ActionResult Index(Content content, string IsCreate, string message)
        {
            if (ModelState.IsValid)
            {
                var userId = User.Identity.GetUserId();
                var clientId = db.Clients.Where(c => c.ApplicationId == userId).Select(c => c.Id).SingleOrDefault();
                var forum = db.Fora.Where(f => f.Id == content.ForumId).Select(f => f).SingleOrDefault();
                var contents = db.Contents.Where(c => c.ForumId == forum.Id).Select(c => c).ToList();
                List<Client> checkedClient = new List<Client>();
                if (message != null && IsCreate != "yes")
                {
                    var newContent = db.Contents.Where(c => c.Id == content.Id).SingleOrDefault();
                    newContent.Message = message;
                    foreach (var item in contents)
                    {
                        var client = db.Clients.Where(c => c.Id == item.ClientId).Select(c => c).SingleOrDefault();
                        if (!checkedClient.Contains(client) && client.Id != clientId)
                        {
                            InboxMessege messege = new InboxMessege();
                            messege.Messege = "A message has been edited from '" + forum.Name + "'.";
                            messege.InboxId = client.InboxId;
                            db.InboxMesseges.Add(messege);
                            checkedClient.Add(client);
                        }
                    }
                    db.SaveChanges();
                }
                else
                {
                    content.ClientId = clientId;
                    db.Contents.Add(content);
                    foreach (var item in contents)
                    {
                        var client = db.Clients.Where(c => c.Id == item.ClientId).Select(c => c).SingleOrDefault();
                        if (!checkedClient.Contains(client) && client.Id != clientId)
                        {
                            InboxMessege messege = new InboxMessege();
                            messege.Messege = "A message has been added to '" + forum.Name + "'.";
                            messege.InboxId = client.InboxId;
                            db.InboxMesseges.Add(messege);
                            checkedClient.Add(client);
                        }
                    }
                    db.SaveChanges();
                }
                return RedirectToAction("Index", new { forumId = content.ForumId, contentId = content.Id });
            }
            ViewBag.Forum = content.ForumId;
            return View(content);
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
            var forumId = content.ForumId;
            if (content == null)
            {
                return View(content);
            }
            else
            {
                var forum = db.Fora.Where(f => f.Id == content.ForumId).Select(f => f).SingleOrDefault();
                var contents = db.Contents.Where(c => c.ForumId == forum.Id).Select(c => c).ToList();
                List<Client> checkedClient = new List<Client>();
                foreach (var item in contents)
                {
                    var client = db.Clients.Where(c => c.Id == item.ClientId).Select(c => c).SingleOrDefault();
                    if (client != null)
                    {
                        if (!checkedClient.Contains(client) && client.Id != content.ClientId)
                        {
                            InboxMessege messege = new InboxMessege();
                            messege.Messege = "A message has been deleted from '" + forum.Name + "'.";
                            messege.InboxId = client.InboxId;
                            db.InboxMesseges.Add(messege);
                            checkedClient.Add(client);
                        }
                    }
                }
                db.Contents.Remove(content);
                db.SaveChanges();
                return RedirectToAction("Index", new { forumId, contentId = content.Id, isTrue });
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
