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
    public class BeneficiariesController : ApiController
    {
        private NextCareEntities db = new NextCareEntities();

        // GET: api/Beneficiaries
        public IQueryable<Beneficiary> GetBeneficiaries()
        {
            return db.Beneficiaries;
        }

        // GET: api/Beneficiaries/5
        /*[ResponseType(typeof(Beneficiary))]
        public IHttpActionResult GetBeneficiary(long id)
        {
            Beneficiary beneficiary = db.Beneficiaries.Find(id);
            if (beneficiary == null)
            {
                return NotFound();
            }

            return Ok(beneficiary);
        }*/

        //api/Beneficiaries/GetByPolicyNumber?Policynumber=A777B777
        [ResponseType(typeof(Beneficiary))]
        public IHttpActionResult GetByPolicyNumber(string PolicyNumber)
        {
            Beneficiary beneficiary;
            using (var context = new NextCareEntities())
            {
                var query = from b in context.Beneficiaries
                            join ip in context.InsurancePolicies on b.Id equals ip.IdBeneficiary
                            where ip.InsuranceCardNumber == PolicyNumber
                            select b;

                beneficiary = query.FirstOrDefault();
            }

            if (beneficiary == null)
            {
                return NotFound();
            }

            return Ok(beneficiary);
        }

        // PUT: api/Beneficiaries/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutBeneficiary(long id, Beneficiary beneficiary)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != beneficiary.Id)
            {
                return BadRequest();
            }

            db.Entry(beneficiary).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BeneficiaryExists(id))
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

        // POST: api/Beneficiaries
        [ResponseType(typeof(Beneficiary))]
        public IHttpActionResult PostBeneficiary(Beneficiary beneficiary)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Beneficiaries.Add(beneficiary);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = beneficiary.Id }, beneficiary);
        }

        // DELETE: api/Beneficiaries/5
        [ResponseType(typeof(Beneficiary))]
        public IHttpActionResult DeleteBeneficiary(long id)
        {
            Beneficiary beneficiary = db.Beneficiaries.Find(id);
            if (beneficiary == null)
            {
                return NotFound();
            }

            db.Beneficiaries.Remove(beneficiary);
            db.SaveChanges();

            return Ok(beneficiary);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool BeneficiaryExists(long id)
        {
            return db.Beneficiaries.Count(e => e.Id == id) > 0;
        }
    }
}