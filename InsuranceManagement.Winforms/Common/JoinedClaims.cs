using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceManagement.Winforms.Common
{
    public class JoinedClaim
    {

        //public int Id { get; set; }
        public DateTime AdmissionDate { get; set; }
        public string InsuranceCardNumber { get; set; }
        public string BeneficiaryName { get; set; }
        public string HealthcareProviderName { get; set; }
        public string MedicalCase { get; set; }
        public decimal EstimatedCost { get; set; }
        public string Status { get; set; }

    }
}
