using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceManagement.Winforms.Common
{
    public static class Constants
    {
        public static class UriConstants
        {
            public const string _ServicePath = "http://localhost:55693/";
            public const string _GetBeneficiary = "api/Beneficiaries/GetByPolicyNumber?Policynumber=";
            public const string _GetAllHospitals = "api/HealthCareProviders";
            public const string _GetAllPhysicians = "api/Physicians";
            public const string _GetAllMedicalCases = "api/MedicalCases";
            public const string _PostClaim = "api/Claims";
            public const string _GetBSpecificClaims = "api/Claims/GetSpecificClaims?IdHealthCareProvider={0}&PolicyNumber={1}&DateFrom={2}&DateTo={3}";
            public const string _GetBSpecificClaimsAllPolicies = "api/Claims/GetSpecificClaims?IdHealthCareProvider={0}&DateFrom={1}&DateTo={2}";
        }

        public static class MessageConstants
        {
            public const string _GeneralError = "An unknown error occured";
            public const string _InvalidRequestParameters = "";
            public const string _EmptyInsuranceCardNumber = "Please enter an insurance card number";
            public const string _RequiredFields = "Please fill all the required fields with valid data";
            public const string _AddedRecordSuccessfully = "Record was successfully added";
            public const string _AddRecordError = "Error adding record";
            public const string _EmptyResults = "There are no results to process";
        }

    }
}
