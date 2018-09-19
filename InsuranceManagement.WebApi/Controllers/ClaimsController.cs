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
using InsuranceManagement.WebApi.Models;

namespace InsuranceManagement.WebApi.Controllers
{
    public class ClaimsController : ApiController
    {
        private NextCareEntities db = new NextCareEntities();

        // GET: api/Claims
        public IQueryable<Claim> GetClaims()
        {
            return db.Claims;
        }

        //api/Claims/GetSpecificClaims?IdHealthCareProvider={0}&PolicyNumber={1}&DateFrom={2}&DateTo={3}
        [ResponseType(typeof(List<JoinedClaim>))]
        public IHttpActionResult GetSpecificClaims(int IdHealthCareProvider, string PolicyNumber, DateTime DateFrom, DateTime DateTo)
        {
            using (var context = new NextCareEntities())
            {
                var claims = (from c in context.Claims
                              join ip in context.InsurancePolicies on c.InsuranceCardNumber equals ip.InsuranceCardNumber
                              join b in context.Beneficiaries on ip.IdBeneficiary equals b.Id
                              join h in context.HealthCareProviders on c.IdHealthCareProvider equals h.Id
                              join mc in context.MedicalCases on c.IdMedicalCase equals mc.Id
                              where c.IdHealthCareProvider == IdHealthCareProvider
                              & c.InsuranceCardNumber == PolicyNumber
                              & c.AdmissionDate >= DateFrom
                              & c.AdmissionDate <= DateTo
                              select new
                              {
                                  c.AdmissionDate,
                                  c.InsuranceCardNumber,
                                  BeneficiaryName = b.FirstName + " " + b.FatherName + " " + b.LastName,
                                  HealthcareProviderName = h.Name,
                                  MedicalCase = mc.Value,
                                  c.EstimatedCost,
                                  Status = c.Status == 0 ? "Not Covered" : c.Status == 1 ? "Covered" : "Pending"
                              }).ToList();

                if (claims == null)
                {
                    return NotFound();
                }

                return Ok(claims);
            }
        }

        //api/Claims/GetSpecificClaims?IdHealthCareProvider={0}&DateFrom={1}&DateTo={2}
        [ResponseType(typeof(List<JoinedClaim>))]
        public IHttpActionResult GetSpecificClaims(int IdHealthCareProvider, DateTime DateFrom, DateTime DateTo)
        {
            using (var context = new NextCareEntities())
            {
                var claims = (from c in context.Claims
                              join ip in context.InsurancePolicies on c.InsuranceCardNumber equals ip.InsuranceCardNumber
                              join b in context.Beneficiaries on ip.IdBeneficiary equals b.Id
                              join h in context.HealthCareProviders on c.IdHealthCareProvider equals h.Id
                              join mc in context.MedicalCases on c.IdMedicalCase equals mc.Id
                              where c.IdHealthCareProvider == IdHealthCareProvider
                              & c.AdmissionDate >= DateFrom
                              & c.AdmissionDate <= DateTo
                              select new
                              {
                                  c.AdmissionDate,
                                  c.InsuranceCardNumber,
                                  BeneficiaryName = b.FirstName + " " + b.FatherName + " " + b.LastName,
                                  HealthcareProviderName = h.Name,
                                  MedicalCase = mc.Value,
                                  c.EstimatedCost,
                                  Status = c.Status == 0 ? "Not Covered" : c.Status == 1 ? "Covered" : "Pending"
                              }).ToList();

                if (claims == null)
                {
                    return NotFound();
                }

                return Ok(claims);
            }
        }


        // GET: api/Claims/5
        [ResponseType(typeof(Claim))]
        public IHttpActionResult GetClaim(long id)
        {
            Claim claim = db.Claims.Find(id);
            if (claim == null)
            {
                return NotFound();
            }

            return Ok(claim);
        }

        // PUT: api/Claims/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutClaim(long id, Claim claim)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != claim.Id)
            {
                return BadRequest();
            }

            db.Entry(claim).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClaimExists(id))
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

        // POST: api/Claims
        [ResponseType(typeof(Claim))]
        public IHttpActionResult PostClaim(Claim claim)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Claims.Add(claim);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = claim.Id }, claim);
        }

        // DELETE: api/Claims/5
        [ResponseType(typeof(Claim))]
        public IHttpActionResult DeleteClaim(long id)
        {
            Claim claim = db.Claims.Find(id);
            if (claim == null)
            {
                return NotFound();
            }

            db.Claims.Remove(claim);
            db.SaveChanges();

            return Ok(claim);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ClaimExists(long id)
        {
            return db.Claims.Count(e => e.Id == id) > 0;
        }
    }
}