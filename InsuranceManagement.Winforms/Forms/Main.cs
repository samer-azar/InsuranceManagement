using InsuranceManagement.DataModel;
using InsuranceManagement.Winforms.BusinessController;
using InsuranceManagement.Winforms.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsuranceManagement.Winforms.Forms
{
    public partial class Main : Form
    {
        #region Global_Variables

        List<HealthCareProvider> _HealthCareProviders;
        List<Physician> _Physicians;
        List<MedicalCase> _MedicalCases;
        List<JoinedClaim> _Claims;

        #endregion

        #region Constructors

        public Main()
        {
            InitializeComponent();
            FillComboBoxes();
            dtFrom.Value = DateTime.Today.AddDays(-30);
        }

        #endregion

        #region Methods

        private void FillComboBoxes()
        {
            //Pre-fill all the form's combo boxes
            FillCmbHospital();
            FillCmbPhysician();
            FillCmbMedicalCase();
        }

        private async void FillCmbHospital()
        {
            List<ComboBoxItem> items = new List<ComboBoxItem>();

            if (_HealthCareProviders == null)
                _HealthCareProviders = await OperationsBlo.GetAllHospitals();

            if (_HealthCareProviders.Count > 0)
            {
                foreach (HealthCareProvider hospital in _HealthCareProviders)
                    items.Add(new ComboBoxItem { Text = hospital.Name, Value = hospital.Id });

                cmbHospital.DisplayMember = "Text";
                cmbHospital.ValueMember = "Value";
                cmbHospital.DataSource = items;
                cmbHospital.SelectedIndex = 0;

                cmbHealthCareProviders.DisplayMember = "Text";
                cmbHealthCareProviders.ValueMember = "Value";
                cmbHealthCareProviders.DataSource = items;
                cmbHealthCareProviders.SelectedIndex = 0;
            }
        }

        private async void FillCmbPhysician()
        {
            List<ComboBoxItem> items = new List<ComboBoxItem>();

            if (_Physicians == null)
                _Physicians = await OperationsBlo.GetAllPhysicians();

            if (_Physicians.Count > 0)
            {
                foreach (Physician physician in _Physicians)
                    items.Add(new ComboBoxItem
                    {
                        Text = string.Format("{0} {1}", physician.FirstName, physician.LastName),
                        Value = physician.Id
                    });

                cmbPhysician.DisplayMember = "Text";
                cmbPhysician.ValueMember = "Value";
                cmbPhysician.DataSource = items;
                cmbPhysician.SelectedIndex = 0;
            }
        }

        private async void FillCmbMedicalCase()
        {
            List<ComboBoxItem> items = new List<ComboBoxItem>();

            if (_MedicalCases == null)
                _MedicalCases = await OperationsBlo.GetAllMedicalCases();

            if (_MedicalCases.Count > 0)
            {
                foreach (MedicalCase medicalCase in _MedicalCases)
                    items.Add(new ComboBoxItem { Text = medicalCase.Value, Value = medicalCase.Id });

                cmbMedicalCase.DisplayMember = "Text";
                cmbMedicalCase.ValueMember = "Value";
                cmbMedicalCase.DataSource = items;
                cmbMedicalCase.SelectedIndex = 0;
            }
        }

        private bool CheckRequiredFieldPopulationAndValidation()
        {
            //Check the population and the validity of the form's required fields
            if (!txtInsuranceCardNumber.Text.Trim().Equals(string.Empty)
                && !txtEstimatedCost.Text.Trim().Equals(string.Empty)
                && !ValidateDecimal(txtEstimatedCost.Text.Trim()).Equals(-1)
                && !CheckRadioButtonSelected(gbStatus).Equals(-1))
                return true;
            else
                return false;
        }

        private decimal ValidateDecimal(string stringInput)
        {
            //Validate the input string if it is parsed as decimal and return the decimal value
            decimal decimalInput;
            if (decimal.TryParse(stringInput, out decimalInput))
                return decimalInput;

            return -1;
        }

        private int CheckRadioButtonSelected(Control GroupBox)
        {
            //Check if any of the group box's radio buttons is selected, and return the status integer
            int status = (int)Enumerations._ClaimStatus.Unprocessed;
            foreach (RadioButton radioButton in GroupBox.Controls.OfType<RadioButton>())
            {
                if (radioButton.Checked)
                {
                    switch (radioButton.Name)
                    {
                        case "rbCovered":
                            status = (int)Enumerations._ClaimStatus.Covered;
                            break;
                        case "rbNotCovered":
                            status = (int)Enumerations._ClaimStatus.NotCovered;
                            break;
                        case "rbPending":
                            status = (int)Enumerations._ClaimStatus.Pending;
                            break;
                    }
                    break;
                }
            }

            return status;
        }

        private async Task<bool> AddClaim()
        {
            bool addSuccess = false;

            //Check if all required fields are filled with valid data
            if (CheckRequiredFieldPopulationAndValidation())
            {
                //Build the claim object
                Claim claim = new Claim
                {
                    IdHealthCareProvider = (int)cmbHospital.SelectedValue,
                    IdPhysician = (int)cmbPhysician.SelectedValue,
                    IdMedicalCase = (int)cmbMedicalCase.SelectedValue,
                    InsuranceCardNumber = txtInsuranceCardNumber.Text.Trim(),
                    EstimatedCost = ValidateDecimal(txtEstimatedCost.Text.Trim()),
                    Remarks = txtRemarks.Text.Trim(),
                    CreatedDate = DateTime.Now,
                    AdmissionDate = dtAdmissionDate.Value,
                    Status = CheckRadioButtonSelected(gbStatus)
                };

                //Insert new object by calling WEB API Post method
                addSuccess = await OperationsBlo.AddClaim(claim);
            }
            else
            {
                lblMessage.Text = Constants.MessageConstants._RequiredFields;
            }
            return addSuccess;
        }

        #endregion

        #region Events

        private async void btnLoadBeneficiary_Click(object sender, EventArgs e)
        {
            lblMessage.Text = string.Empty;

            if (!txtInsuranceCardNumber.Text.Equals(string.Empty))
            {
                txtInsuranceCardNumber.Enabled = false;
                //Get the Beneficiary information by policy number
                Beneficiary beneficiary = await OperationsBlo.GetBeneficiary(txtInsuranceCardNumber.Text.Trim());

                if (beneficiary == null)
                    lblMessage.Text = Constants.MessageConstants._GeneralError;
                else
                {
                    lblMessage.Text = string.Empty;
                    txtFirstName.Text = beneficiary.FirstName;
                    txtMiddleName.Text = beneficiary.FatherName;
                    txtLastName.Text = beneficiary.LastName;
                    txtDOB.Text = beneficiary.DateOfBirth.Value.ToString("dddd, dd MMMM yyyy");
                    txtGender.Text = beneficiary.Gender;
                }
            }
            else
            {
                lblMessage.Text = Constants.MessageConstants._EmptyInsuranceCardNumber;
            }
        }

        private void btnClearControls_Click(object sender, EventArgs e)
        {
            foreach (Control control in tbClaim.Controls)
            {
                if (control is TextBox)
                    control.Text = string.Empty;

                if (control is GroupBox)
                {
                    foreach (Control gbControl in control.Controls)
                    {
                        if (gbControl is TextBox)
                            gbControl.Text = string.Empty;
                    }
                }
            }

            lblMessage.Text = string.Empty;
            txtInsuranceCardNumber.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            bool addSuccess = await AddClaim();
            if (addSuccess)
                lblMessage.Text = Constants.MessageConstants._AddedRecordSuccessfully;
            else
                lblMessage.Text = Constants.MessageConstants._AddRecordError;
        }

        private void btnCancelReport_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }
        
        private async void btnLoadClaims_Click(object sender, EventArgs e)
        {
            lblReportMessage.Text = string.Empty;
            lblClaimTotalCost.Text = string.Empty;
            decimal totalEstimatedCost;

            //Get specific claims
            if (!txtPolicyNumber.Text.Equals(string.Empty))
                _Claims = await OperationsBlo.GetSpecificClaims((int)cmbHealthCareProviders.SelectedValue, txtPolicyNumber.Text.Trim(), dtFrom.Value, dtTo.Value);
            else
                _Claims = await OperationsBlo.GetSpecificClaims((int)cmbHealthCareProviders.SelectedValue, dtFrom.Value, dtTo.Value);

            if (_Claims.Count == 0)
                lblReportMessage.Text = Constants.MessageConstants._GeneralError;
            else
            {
                grdClaims.DataSource = _Claims;
                totalEstimatedCost = _Claims.Where(a => a.Status == "Covered" || a.Status == "Pending").Sum(x => x.EstimatedCost);
                lblClaimTotalCost.Text = "Total estimated cost: $" + totalEstimatedCost.ToString();
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (_Claims.Equals(null) || _Claims.Count == 0)
                lblReportMessage.Text = Constants.MessageConstants._EmptyResults;
            else
            {
                DownloadScreen dsForm = new DownloadScreen(_Claims);
                dsForm.ShowDialog();
            }
        }

        #endregion


    }
}
