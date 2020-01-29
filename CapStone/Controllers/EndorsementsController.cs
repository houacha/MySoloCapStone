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
    public class EndorsementsController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/Endorsements
        public IQueryable<Endorsement> GetEndorsements()
        {
            return db.Endorsements;
        }

        // GET: api/Endorsements/5
        [ResponseType(typeof(Endorsement))]
        public IHttpActionResult GetEndorsement(int id)
        {
            Endorsement endorsement = db.Endorsements.Find(id);
            if (endorsement == null)
            {
                return NotFound();
            }

            return Ok(endorsement);
        }

        // PUT: api/Endorsements/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutEndorsement(int id, Endorsement endorsement)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != endorsement.Id)
            {
                return BadRequest();
            }

            db.Entry(endorsement).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EndorsementExists(id))
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

        // POST: api/Endorsements
        [ResponseType(typeof(Endorsement))]
        public IHttpActionResult PostEndorsement(Endorsement endorsement)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Endorsements.Add(endorsement);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = endorsement.Id }, endorsement);
        }

        // DELETE: api/Endorsements/5
        [ResponseType(typeof(Endorsement))]
        public IHttpActionResult DeleteEndorsement(int id)
        {
            Endorsement endorsement = db.Endorsements.Find(id);
            if (endorsement == null)
            {
                return NotFound();
            }

            db.Endorsements.Remove(endorsement);
            db.SaveChanges();

            return Ok(endorsement);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EndorsementExists(int id)
        {
            return db.Endorsements.Count(e => e.Id == id) > 0;
        }
    }
}