using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using CapStone.Models;

namespace CapStone.Controllers
{
    public class CampaignThemesController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/CampaignThemes
        public IQueryable<CampaignTheme> GetCampaignThemes()
        {
            return db.CampaignThemes;
        }

        // GET: api/CampaignThemes/5
        [ResponseType(typeof(CampaignTheme))]
        public IHttpActionResult GetCampaignTheme(int id)
        {
            CampaignTheme campaignTheme = db.CampaignThemes.Find(id);
            if (campaignTheme == null)
            {
                return NotFound();
            }

            return Ok(campaignTheme);
        }

        // PUT: api/CampaignThemes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCampaignTheme(int id, CampaignTheme campaignTheme)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != campaignTheme.Id)
            {
                return BadRequest();
            }

            db.Entry(campaignTheme).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CampaignThemeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/CampaignThemes
        [ResponseType(typeof(CampaignTheme))]
        public IHttpActionResult PostCampaignTheme(CampaignTheme campaignTheme)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.CampaignThemes.Add(campaignTheme);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = campaignTheme.Id }, campaignTheme);
        }

        // DELETE: api/CampaignThemes/5
        [ResponseType(typeof(CampaignTheme))]
        public IHttpActionResult DeleteCampaignTheme(int id)
        {
            CampaignTheme campaignTheme = db.CampaignThemes.Find(id);
            if (campaignTheme == null)
            {
                return NotFound();
            }

            db.CampaignThemes.Remove(campaignTheme);
            db.SaveChanges();

            return Ok(campaignTheme);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CampaignThemeExists(int id)
        {
            return db.CampaignThemes.Count(e => e.Id == id) > 0;
        }
    }
}