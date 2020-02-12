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
    public class ForaController : BaseController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Fora
        public ActionResult Index()
        {
            var id = User.Identity.GetUserId();
            var userId = db.Clients.Where(c => c.ApplicationId == id).Select(c => c.Id).SingleOrDefault();
            var fora = db.Fora.Include(f => f.Client).Include(f => f.Client.ApplicationUser);
            ViewBag.UserId = userId;
            return View(fora.ToList());
        }

        // GET: Fora/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Forum forum = db.Fora.Find(id);
            if (forum == null)
            {
                return HttpNotFound();
            }
            return View(forum);
        }

        // GET: Fora/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Fora/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Forum forum)
        {
            if (ModelState.IsValid)
            {
                var id = User.Identity.GetUserId();
                var userId = db.Clients.Where(c => c.ApplicationId == id).Select(c => c.Id).SingleOrDefault();
                forum.ClientId = userId;
                db.Fora.Add(forum);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(forum);
        }

        // GET: Fora/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Forum forum = db.Fora.Find(id);
            if (forum == null)
            {
                return HttpNotFound();
            }
            return View(forum);
        }

        // POST: Fora/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Forum forum)
        {
            if (ModelState.IsValid)
            {
                db.Entry(forum).State = EntityState.Modified;
                var contents = db.Contents.Where(c => c.ForumId == forum.Id).Select(c => c).ToList();
                List<Client> checkedClient = new List<Client>();
                foreach (var item in contents)
                {
                    var client = db.Clients.Where(c => c.Id == item.ClientId).Select(c => c).SingleOrDefault();
                    if (!checkedClient.Contains(client))
                    {
                        InboxMessege messege = new InboxMessege();
                        messege.Messege = "The forum '" + forum.Name + "' has been altered.";
                        messege.InboxId = client.InboxId;
                        db.InboxMesseges.Add(messege);
                        checkedClient.Add(client);
                    }
                }
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(forum);
        }

        // GET: Fora/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Forum forum = db.Fora.Find(id);
            if (forum == null)
            {
                return HttpNotFound();
            }
            return View(forum);
        }

        // POST: Fora/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Forum forum = db.Fora.Find(id);
            var contents = db.Contents.Where(c => c.ForumId == id).Select(c => c).ToList();
            List<Client> checkedClient = new List<Client>();
            foreach (var item in contents)
            {
                var client = db.Clients.Where(c => c.Id == item.ClientId).Select(c => c).SingleOrDefault();
                if (!checkedClient.Contains(client) && client.Id != forum.ClientId)
                {
                    InboxMessege messege = new InboxMessege();
                    messege.Messege = "The forum '" + forum.Name + "' and all its contents has been deleted.";
                    messege.InboxId = client.InboxId;
                    db.InboxMesseges.Add(messege);
                    checkedClient.Add(client);
                }
                db.Contents.Remove(item);
            }
            db.Fora.Remove(forum);
            db.SaveChanges();
            return RedirectToAction("Index");
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
