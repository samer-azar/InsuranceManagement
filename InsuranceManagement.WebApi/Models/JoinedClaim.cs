using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InsuranceManagement.WebApi.Models
{
    public class JoinedClaim
    {
        public int Id { get; set; }
        public DateTime AdmissionDate { get; set; }
        public string InsuranceCardNumber { get; set; }
        public string BeneficiaryName { get; set; }
        public string HealthcareProviderName { get; set; }
        public string MedicalCase { get; set; }
        public decimal EstimatedCost { get; set; }
        public int Status { get; set; }

    }
}