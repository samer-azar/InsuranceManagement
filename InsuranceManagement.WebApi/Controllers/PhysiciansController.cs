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
using InsuranceManagement.DataModel;

namespace InsuranceManagement.WebApi.Controllers
{
    public class PhysiciansController : ApiController
    {
        private NextCareEntities db = new NextCareEntities();

        // GET: api/Physicians
        public IQueryable<Physician> GetPhysicians()
        {
            return db.Physicians;
        }

        // GET: api/Physicians/5
        [ResponseType(typeof(Physician))]
        public IHttpActionResult GetPhysician(int id)
        {
            Physician physician = db.Physicians.Find(id);
            if (physician == null)
            {
                return NotFound();
            }

            return Ok(physician);
        }

        // PUT: api/Physicians/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPhysician(int id, Physician physician)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != physician.Id)
            {
                return BadRequest();
            }

            db.Entry(physician).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PhysicianExists(id))
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

        // POST: api/Physicians
        [ResponseType(typeof(Physician))]
        public IHttpActionResult PostPhysician(Physician physician)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Physicians.Add(physician);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = physician.Id }, physician);
        }

        // DELETE: api/Physicians/5
        [ResponseType(typeof(Physician))]
        public IHttpActionResult DeletePhysician(int id)
        {
            Physician physician = db.Physicians.Find(id);
            if (physician == null)
            {
                return NotFound();
            }

            db.Physicians.Remove(physician);
            db.SaveChanges();

            return Ok(physician);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PhysicianExists(int id)
        {
            return db.Physicians.Count(e => e.Id == id) > 0;
        }
    }
}