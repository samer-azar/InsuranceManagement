using InsuranceManagement.DataModel;
using InsuranceManagement.Winforms.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceManagement.Winforms.BusinessController
{
    public static class OperationsBlo
    {
        #region Global_Variables
        static HttpClient _Client = new HttpClient();
        #endregion

        #region API_Call_Methods
        public static async Task<Beneficiary> GetBeneficiary(string PolicyNumber)
        {
            string servicePath, sResponse;
            Beneficiary beneficiary = null;
            HttpResponseMessage response;
            
            try
            {
                //Build the URI
                servicePath = string.Format("{0}{1}{2}",Constants.UriConstants._ServicePath, Constants.UriConstants._GetBeneficiary, PolicyNumber);

                //Asynchronous call the WEB API GetByPolicyNumber method to get the Beneficiary by Policy NUmber
                response = await _Client.GetAsync(servicePath);
                if (response.IsSuccessStatusCode)
                {
                    //Deserialize JSON response to Beneficiary
                    sResponse = await response.Content.ReadAsStringAsync();
                    beneficiary = JsonConvert.DeserializeObject<Beneficiary>(sResponse);
                }
                return beneficiary;
                
            }
            catch (Exception ex)
            {
                LoggerLibrary.Logger.Log(LoggerLibrary.Logger.GetCurrentMethod(), ex.Message, ex.StackTrace);
                throw;
            }
        }

        public static async Task<List<HealthCareProvider>> GetAllHospitals()
        {
            string servicePath, sResponse;
            List<HealthCareProvider> Hospitals = null;
            HttpResponseMessage response;

            try
            {
                //Build the URI
                servicePath = string.Format("{0}{1}", Constants.UriConstants._ServicePath, Constants.UriConstants._GetAllHospitals);

                //Asynchronous call the WEB API GetHealthCareProviders method to get all HealthCareProviders
                response = await _Client.GetAsync(servicePath);
                if (response.IsSuccessStatusCode)
                {
                    //Deserialize JSON response to List<HealthCareProviders>
                    sResponse = await response.Content.ReadAsStringAsync();
                    Hospitals = JsonConvert.DeserializeObject<List<HealthCareProvider>>(sResponse);
                }
                return Hospitals;

            }
            catch (Exception ex)
            {
                LoggerLibrary.Logger.Log(LoggerLibrary.Logger.GetCurrentMethod(), ex.Message, ex.StackTrace);
                throw;
            }
        }

        public static async Task<List<Physician>> GetAllPhysicians()
        {
            string servicePath, sResponse;
            List<Physician> physicians = null;
            HttpResponseMessage response;

            try
            {
                //Build the URI
                servicePath = string.Format("{0}{1}", Constants.UriConstants._ServicePath, Constants.UriConstants._GetAllPhysicians);

                //Asynchronous call the WEB API GetPhysicians method to get all physicians
                response = await _Client.GetAsync(servicePath);
                if (response.IsSuccessStatusCode)
                {
                    //Deserialize JSON response to List<Physicians>
                    sResponse = await response.Content.ReadAsStringAsync();
                    physicians = JsonConvert.DeserializeObject<List<Physician>>(sResponse);
                }
                return physicians;

            }
            catch (Exception ex)
            {
                LoggerLibrary.Logger.Log(LoggerLibrary.Logger.GetCurrentMethod(), ex.Message, ex.StackTrace);
                throw;
            }
        }

        public static async Task<List<MedicalCase>> GetAllMedicalCases()
        {
            string servicePath, sResponse;
            List<MedicalCase> medicalCases = null;
            HttpResponseMessage response;

            try
            {
                //Build the URI
                servicePath = string.Format("{0}{1}", Constants.UriConstants._ServicePath, Constants.UriConstants._GetAllMedicalCases);

                //Asynchronous call the WEB API GetMedicalCases method to get all medical cases
                response = await _Client.GetAsync(servicePath);
                if (response.IsSuccessStatusCode)
                {
                    //Deserialize JSON response to List<MedicalCases>
                    sResponse = await response.Content.ReadAsStringAsync();
                    medicalCases = JsonConvert.DeserializeObject<List<MedicalCase>>(sResponse);
                }
                return medicalCases;

            }
            catch (Exception ex)
            {
                LoggerLibrary.Logger.Log(LoggerLibrary.Logger.GetCurrentMethod(), ex.Message, ex.StackTrace);
                throw;
            }
        }

        public static async Task<bool> AddClaim(Claim claim)
        {
            bool addSuccess = false;
            string servicePath, sResponse, claimJson;
            HttpResponseMessage response;

            try
            {
                //Build the URI
                servicePath = string.Format("{0}{1}", Constants.UriConstants._ServicePath, Constants.UriConstants._PostClaim);
                
                //Serialize object to JSON string
                claimJson = JsonConvert.SerializeObject(claim);
                
                //Build Content containing headers and JSON string
                var content = new StringContent(claimJson.ToString(), Encoding.UTF8, "application/json");

                //Asynchronous call the WEB API PostClaim method to insert a new claim record
                response = await _Client.PostAsync(servicePath, content);

                if (response.IsSuccessStatusCode)
                    addSuccess = true;

                return addSuccess;
            }
            catch (Exception ex)
            {
                LoggerLibrary.Logger.Log(LoggerLibrary.Logger.GetCurrentMethod(), ex.Message, ex.StackTrace);
                throw;
            }
        }

        public static async Task<List<JoinedClaim>> GetSpecificClaims(int IdHealthCareProvider, string PolicyNumber, DateTime DateFrom, DateTime DateTo)
        {
            string servicePath, sResponse;
            List<JoinedClaim> claims = null;
            HttpResponseMessage response;

            try
            {
                //Build the URI
                servicePath = string.Format(Constants.UriConstants._GetBSpecificClaims, IdHealthCareProvider, PolicyNumber, DateFrom, DateTo);
                servicePath = string.Format("{0}{1}", Constants.UriConstants._ServicePath, servicePath);

                //Asynchronous call the WEB API GetPhysicians method to get all physicians
                response = await _Client.GetAsync(servicePath);
                if (response.IsSuccessStatusCode)
                {
                    //Deserialize JSON response to List<Physicians>
                    sResponse = await response.Content.ReadAsStringAsync();
                    claims = JsonConvert.DeserializeObject<List<JoinedClaim>>(sResponse);
                }
                return claims;

            }
            catch (Exception ex)
            {
                LoggerLibrary.Logger.Log(LoggerLibrary.Logger.GetCurrentMethod(), ex.Message, ex.StackTrace);
                throw;
            }
        }

        public static async Task<List<JoinedClaim>> GetSpecificClaims(int IdHealthCareProvider, DateTime DateFrom, DateTime DateTo)
        {
            string servicePath, sResponse;
            List<JoinedClaim> claims = null;
            HttpResponseMessage response;

            try
            {
                //Build the URI
                servicePath = string.Format(Constants.UriConstants._GetBSpecificClaimsAllPolicies, IdHealthCareProvider, DateFrom, DateTo);
                servicePath = string.Format("{0}{1}", Constants.UriConstants._ServicePath, servicePath);

                //Asynchronous call the WEB API GetPhysicians method to get all physicians
                response = await _Client.GetAsync(servicePath);
                if (response.IsSuccessStatusCode)
                {
                    //Deserialize JSON response to List<Physicians>
                    sResponse = await response.Content.ReadAsStringAsync();
                    claims = JsonConvert.DeserializeObject<List<JoinedClaim>>(sResponse);
                }
                return claims;

            }
            catch (Exception ex)
            {
                LoggerLibrary.Logger.Log(LoggerLibrary.Logger.GetCurrentMethod(), ex.Message, ex.StackTrace);
                throw;
            }
        }


        #endregion



    }
}
