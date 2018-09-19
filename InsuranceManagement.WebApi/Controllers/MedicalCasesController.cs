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
    public class MedicalCasesController : ApiController
    {
        private NextCareEntities db = new NextCareEntities();

        // GET: api/MedicalCases
        public IQueryable<MedicalCase> GetMedicalCases()
        {
            return db.MedicalCases;
        }

        // GET: api/MedicalCases/5
        [ResponseType(typeof(MedicalCase))]
        public IHttpActionResult GetMedicalCase(int id)
        {
            MedicalCase medicalCase = db.MedicalCases.Find(id);
            if (medicalCase == null)
            {
                return NotFound();
            }

            return Ok(medicalCase);
        }

        // PUT: api/MedicalCases/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutMedicalCase(int id, MedicalCase medicalCase)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != medicalCase.Id)
            {
                return BadRequest();
            }

            db.Entry(medicalCase).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MedicalCaseExists(id))
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

        // POST: api/MedicalCases
        [ResponseType(typeof(MedicalCase))]
        public IHttpActionResult PostMedicalCase(MedicalCase medicalCase)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.MedicalCases.Add(medicalCase);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = medicalCase.Id }, medicalCase);
        }

        // DELETE: api/MedicalCases/5
        [ResponseType(typeof(MedicalCase))]
        public IHttpActionResult DeleteMedicalCase(int id)
        {
            MedicalCase medicalCase = db.MedicalCases.Find(id);
            if (medicalCase == null)
            {
                return NotFound();
            }

            db.MedicalCases.Remove(medicalCase);
            db.SaveChanges();

            return Ok(medicalCase);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool MedicalCaseExists(int id)
        {
            return db.MedicalCases.Count(e => e.Id == id) > 0;
        }
    }
}