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
    public class CampaignStaffsController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/CampaignStaffs
        public IQueryable<CampaignStaff> GetCampaignStaffs()
        {
            return db.CampaignStaffs;
        }

        // GET: api/CampaignStaffs/5
        [ResponseType(typeof(CampaignStaff))]
        public IHttpActionResult GetCampaignStaff(int id)
        {
            CampaignStaff campaignStaff = db.CampaignStaffs.Find(id);
            if (campaignStaff == null)
            {
                return NotFound();
            }

            return Ok(campaignStaff);
        }

        // PUT: api/CampaignStaffs/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCampaignStaff(int id, CampaignStaff campaignStaff)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != campaignStaff.Id)
            {
                return BadRequest();
            }

            db.Entry(campaignStaff).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CampaignStaffExists(id))
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

        // POST: api/CampaignStaffs
        [ResponseType(typeof(CampaignStaff))]
        public IHttpActionResult PostCampaignStaff(CampaignStaff campaignStaff)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.CampaignStaffs.Add(campaignStaff);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = campaignStaff.Id }, campaignStaff);
        }

        // DELETE: api/CampaignStaffs/5
        [ResponseType(typeof(CampaignStaff))]
        public IHttpActionResult DeleteCampaignStaff(int id)
        {
            CampaignStaff campaignStaff = db.CampaignStaffs.Find(id);
            if (campaignStaff == null)
            {
                return NotFound();
            }

            db.CampaignStaffs.Remove(campaignStaff);
            db.SaveChanges();

            return Ok(campaignStaff);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CampaignStaffExists(int id)
        {
            return db.CampaignStaffs.Count(e => e.Id == id) > 0;
        }
    }
}