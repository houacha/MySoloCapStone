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
    public class CampaignFinancesController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/CampaignFinances
        public IQueryable<CampaignFinance> GetCampaignFinances()
        {
            return db.CampaignFinances;
        }

        // GET: api/CampaignFinances/5
        [ResponseType(typeof(CampaignFinance))]
        public IHttpActionResult GetCampaignFinance(int id)
        {
            CampaignFinance campaignFinance = db.CampaignFinances.Find(id);
            if (campaignFinance == null)
            {
                return NotFound();
            }

            return Ok(campaignFinance);
        }

        // PUT: api/CampaignFinances/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCampaignFinance(int id, CampaignFinance campaignFinance)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != campaignFinance.Id)
            {
                return BadRequest();
            }

            db.Entry(campaignFinance).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CampaignFinanceExists(id))
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

        // POST: api/CampaignFinances
        [ResponseType(typeof(CampaignFinance))]
        public IHttpActionResult PostCampaignFinance(CampaignFinance campaignFinance)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.CampaignFinances.Add(campaignFinance);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = campaignFinance.Id }, campaignFinance);
        }

        // DELETE: api/CampaignFinances/5
        [ResponseType(typeof(CampaignFinance))]
        public IHttpActionResult DeleteCampaignFinance(int id)
        {
            CampaignFinance campaignFinance = db.CampaignFinances.Find(id);
            if (campaignFinance == null)
            {
                return NotFound();
            }

            db.CampaignFinances.Remove(campaignFinance);
            db.SaveChanges();

            return Ok(campaignFinance);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CampaignFinanceExists(int id)
        {
            return db.CampaignFinances.Count(e => e.Id == id) > 0;
        }
    }
}