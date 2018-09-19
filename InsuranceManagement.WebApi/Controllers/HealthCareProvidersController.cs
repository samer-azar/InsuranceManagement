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
    public class HealthCareProvidersController : ApiController
    {
        private NextCareEntities db = new NextCareEntities();

        // GET: api/HealthCareProviders
        public IQueryable<HealthCareProvider> GetHealthCareProviders()
        {
            return db.HealthCareProviders;
        }

        // GET: api/HealthCareProviders/5
        [ResponseType(typeof(HealthCareProvider))]
        public IHttpActionResult GetHealthCareProvider(int id)
        {
            HealthCareProvider healthCareProvider = db.HealthCareProviders.Find(id);
            if (healthCareProvider == null)
            {
                return NotFound();
            }

            return Ok(healthCareProvider);
        }

        // PUT: api/HealthCareProviders/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutHealthCareProvider(int id, HealthCareProvider healthCareProvider)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != healthCareProvider.Id)
            {
                return BadRequest();
            }

            db.Entry(healthCareProvider).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HealthCareProviderExists(id))
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

        // POST: api/HealthCareProviders
        [ResponseType(typeof(HealthCareProvider))]
        public IHttpActionResult PostHealthCareProvider(HealthCareProvider healthCareProvider)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.HealthCareProviders.Add(healthCareProvider);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = healthCareProvider.Id }, healthCareProvider);
        }

        // DELETE: api/HealthCareProviders/5
        [ResponseType(typeof(HealthCareProvider))]
        public IHttpActionResult DeleteHealthCareProvider(int id)
        {
            HealthCareProvider healthCareProvider = db.HealthCareProviders.Find(id);
            if (healthCareProvider == null)
            {
                return NotFound();
            }

            db.HealthCareProviders.Remove(healthCareProvider);
            db.SaveChanges();

            return Ok(healthCareProvider);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool HealthCareProviderExists(int id)
        {
            return db.HealthCareProviders.Count(e => e.Id == id) > 0;
        }
    }
}