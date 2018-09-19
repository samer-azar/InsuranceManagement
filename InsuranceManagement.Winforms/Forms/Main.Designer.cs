namespace InsuranceManagement.Winforms.Forms
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbClaim = new System.Windows.Forms.TabPage();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnClearControls = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.rbPending = new System.Windows.Forms.RadioButton();
            this.rbNotCovered = new System.Windows.Forms.RadioButton();
            this.rbCovered = new System.Windows.Forms.RadioButton();
            this.dtAdmissionDate = new System.Windows.Forms.DateTimePicker();
            this.cmbMedicalCase = new System.Windows.Forms.ComboBox();
            this.cmbPhysician = new System.Windows.Forms.ComboBox();
            this.cmbHospital = new System.Windows.Forms.ComboBox();
            this.txtEstimatedCost = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDOB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInsuranceCardNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoadBeneficiary = new System.Windows.Forms.Button();
            this.tbReport = new System.Windows.Forms.TabPage();
            this.btnExport = new System.Windows.Forms.Button();
            this.lblClaimTotalCost = new System.Windows.Forms.Label();
            this.btnCancelReport = new System.Windows.Forms.Button();
            this.grdClaims = new System.Windows.Forms.DataGridView();
            this.lblReportMessage = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.txtPolicyNumber = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnLoadClaims = new System.Windows.Forms.Button();
            this.cmbHealthCareProviders = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tbClaim.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbStatus.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tbReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdClaims)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tbClaim);
            this.tabControl1.Controls.Add(this.tbReport);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(582, 677);
            this.tabControl1.TabIndex = 0;
            // 
            // tbClaim
            // 
            this.tbClaim.Controls.Add(this.lblMessage);
            this.tbClaim.Controls.Add(this.btnClearControls);
            this.tbClaim.Controls.Add(this.btnSave);
            this.tbClaim.Controls.Add(this.btnCancel);
            this.tbClaim.Controls.Add(this.groupBox2);
            this.tbClaim.Controls.Add(this.groupBox1);
            this.tbClaim.Controls.Add(this.txtInsuranceCardNumber);
            this.tbClaim.Controls.Add(this.label1);
            this.tbClaim.Controls.Add(this.btnLoadBeneficiary);
            this.tbClaim.Location = new System.Drawing.Point(4, 29);
            this.tbClaim.Name = "tbClaim";
            this.tbClaim.Padding = new System.Windows.Forms.Padding(3);
            this.tbClaim.Size = new System.Drawing.Size(574, 644);
            this.tbClaim.TabIndex = 0;
            this.tbClaim.Text = "Claim";
            this.tbClaim.UseVisualStyleBackColor = true;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.ForeColor = System.Drawing.Color.Maroon;
            this.lblMessage.Location = new System.Drawing.Point(6, 22);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 20);
            this.lblMessage.TabIndex = 22;
            // 
            // btnClearControls
            // 
            this.btnClearControls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClearControls.AutoSize = true;
            this.btnClearControls.Location = new System.Drawing.Point(207, 597);
            this.btnClearControls.Name = "btnClearControls";
            this.btnClearControls.Size = new System.Drawing.Size(109, 30);
            this.btnClearControls.TabIndex = 21;
            this.btnClearControls.Text = "New";
            this.btnClearControls.UseVisualStyleBackColor = true;
            this.btnClearControls.Click += new System.EventHandler(this.btnClearControls_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.AutoSize = true;
            this.btnSave.Location = new System.Drawing.Point(327, 597);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(109, 30);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.AutoSize = true;
            this.btnCancel.Location = new System.Drawing.Point(447, 597);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 30);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtRemarks);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.gbStatus);
            this.groupBox2.Controls.Add(this.dtAdmissionDate);
            this.groupBox2.Controls.Add(this.cmbMedicalCase);
            this.groupBox2.Controls.Add(this.cmbPhysician);
            this.groupBox2.Controls.Add(this.cmbHospital);
            this.groupBox2.Controls.Add(this.txtEstimatedCost);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(10, 301);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(558, 280);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Claim";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(195, 176);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(351, 98);
            this.txtRemarks.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(192, 153);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 20);
            this.label12.TabIndex = 19;
            this.label12.Text = "Remarks";
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.rbPending);
            this.gbStatus.Controls.Add(this.rbNotCovered);
            this.gbStatus.Controls.Add(this.rbCovered);
            this.gbStatus.Location = new System.Drawing.Point(6, 155);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(161, 119);
            this.gbStatus.TabIndex = 22;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Status";
            // 
            // rbPending
            // 
            this.rbPending.AutoSize = true;
            this.rbPending.Location = new System.Drawing.Point(10, 85);
            this.rbPending.Name = "rbPending";
            this.rbPending.Size = new System.Drawing.Size(92, 24);
            this.rbPending.TabIndex = 2;
            this.rbPending.TabStop = true;
            this.rbPending.Text = "Pending";
            this.rbPending.UseVisualStyleBackColor = true;
            // 
            // rbNotCovered
            // 
            this.rbNotCovered.AutoSize = true;
            this.rbNotCovered.Location = new System.Drawing.Point(10, 55);
            this.rbNotCovered.Name = "rbNotCovered";
            this.rbNotCovered.Size = new System.Drawing.Size(122, 24);
            this.rbNotCovered.TabIndex = 1;
            this.rbNotCovered.TabStop = true;
            this.rbNotCovered.Text = "Not Covered";
            this.rbNotCovered.UseVisualStyleBackColor = true;
            // 
            // rbCovered
            // 
            this.rbCovered.AutoSize = true;
            this.rbCovered.Location = new System.Drawing.Point(10, 25);
            this.rbCovered.Name = "rbCovered";
            this.rbCovered.Size = new System.Drawing.Size(93, 24);
            this.rbCovered.TabIndex = 0;
            this.rbCovered.TabStop = true;
            this.rbCovered.Text = "Covered";
            this.rbCovered.UseVisualStyleBackColor = true;
            // 
            // dtAdmissionDate
            // 
            this.dtAdmissionDate.Location = new System.Drawing.Point(6, 113);
            this.dtAdmissionDate.Name = "dtAdmissionDate";
            this.dtAdmissionDate.Size = new System.Drawing.Size(351, 26);
            this.dtAdmissionDate.TabIndex = 21;
            // 
            // cmbMedicalCase
            // 
            this.cmbMedicalCase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMedicalCase.FormattingEnabled = true;
            this.cmbMedicalCase.Location = new System.Drawing.Point(385, 53);
            this.cmbMedicalCase.Name = "cmbMedicalCase";
            this.cmbMedicalCase.Size = new System.Drawing.Size(161, 28);
            this.cmbMedicalCase.TabIndex = 20;
            // 
            // cmbPhysician
            // 
            this.cmbPhysician.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPhysician.FormattingEnabled = true;
            this.cmbPhysician.Location = new System.Drawing.Point(196, 53);
            this.cmbPhysician.Name = "cmbPhysician";
            this.cmbPhysician.Size = new System.Drawing.Size(161, 28);
            this.cmbPhysician.TabIndex = 19;
            // 
            // cmbHospital
            // 
            this.cmbHospital.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHospital.FormattingEnabled = true;
            this.cmbHospital.Location = new System.Drawing.Point(6, 53);
            this.cmbHospital.Name = "cmbHospital";
            this.cmbHospital.Size = new System.Drawing.Size(161, 28);
            this.cmbHospital.TabIndex = 18;
            // 
            // txtEstimatedCost
            // 
            this.txtEstimatedCost.Location = new System.Drawing.Point(385, 113);
            this.txtEstimatedCost.Name = "txtEstimatedCost";
            this.txtEstimatedCost.Size = new System.Drawing.Size(161, 26);
            this.txtEstimatedCost.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(385, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Estimated Cost (USD)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Admission Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(385, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Medical Case";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(196, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "Treating Physician";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 20);
            this.label11.TabIndex = 9;
            this.label11.Text = "Hospital";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtGender);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtDOB);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMiddleName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(10, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(558, 159);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Beneficiary";
            // 
            // txtGender
            // 
            this.txtGender.Enabled = false;
            this.txtGender.Location = new System.Drawing.Point(385, 113);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(161, 26);
            this.txtGender.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(385, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Gender";
            // 
            // txtDOB
            // 
            this.txtDOB.Enabled = false;
            this.txtDOB.Location = new System.Drawing.Point(6, 113);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(351, 26);
            this.txtDOB.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Date Of Birth";
            // 
            // txtLastName
            // 
            this.txtLastName.Enabled = false;
            this.txtLastName.Location = new System.Drawing.Point(385, 53);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(161, 26);
            this.txtLastName.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(385, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Last Name";
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Enabled = false;
            this.txtMiddleName.Location = new System.Drawing.Point(196, 53);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(161, 26);
            this.txtMiddleName.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Middle Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Enabled = false;
            this.txtFirstName.Location = new System.Drawing.Point(6, 53);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(161, 26);
            this.txtFirstName.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "First Name";
            // 
            // txtInsuranceCardNumber
            // 
            this.txtInsuranceCardNumber.Location = new System.Drawing.Point(6, 94);
            this.txtInsuranceCardNumber.Name = "txtInsuranceCardNumber";
            this.txtInsuranceCardNumber.Size = new System.Drawing.Size(262, 26);
            this.txtInsuranceCardNumber.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Insurance Card No.";
            // 
            // btnLoadBeneficiary
            // 
            this.btnLoadBeneficiary.AutoSize = true;
            this.btnLoadBeneficiary.Location = new System.Drawing.Point(274, 92);
            this.btnLoadBeneficiary.Name = "btnLoadBeneficiary";
            this.btnLoadBeneficiary.Size = new System.Drawing.Size(93, 30);
            this.btnLoadBeneficiary.TabIndex = 1;
            this.btnLoadBeneficiary.Text = "Load";
            this.btnLoadBeneficiary.UseVisualStyleBackColor = true;
            this.btnLoadBeneficiary.Click += new System.EventHandler(this.btnLoadBeneficiary_Click);
            // 
            // tbReport
            // 
            this.tbReport.Controls.Add(this.btnExport);
            this.tbReport.Controls.Add(this.lblClaimTotalCost);
            this.tbReport.Controls.Add(this.btnCancelReport);
            this.tbReport.Controls.Add(this.grdClaims);
            this.tbReport.Controls.Add(this.lblReportMessage);
            this.tbReport.Controls.Add(this.label16);
            this.tbReport.Controls.Add(this.label15);
            this.tbReport.Controls.Add(this.dtTo);
            this.tbReport.Controls.Add(this.label14);
            this.tbReport.Controls.Add(this.dtFrom);
            this.tbReport.Controls.Add(this.txtPolicyNumber);
            this.tbReport.Controls.Add(this.label13);
            this.tbReport.Controls.Add(this.btnLoadClaims);
            this.tbReport.Controls.Add(this.cmbHealthCareProviders);
            this.tbReport.Location = new System.Drawing.Point(4, 29);
            this.tbReport.Name = "tbReport";
            this.tbReport.Padding = new System.Windows.Forms.Padding(3);
            this.tbReport.Size = new System.Drawing.Size(574, 644);
            this.tbReport.TabIndex = 1;
            this.tbReport.Text = "Report";
            this.tbReport.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.AutoSize = true;
            this.btnExport.Location = new System.Drawing.Point(325, 603);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(109, 30);
            this.btnExport.TabIndex = 153;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // lblClaimTotalCost
            // 
            this.lblClaimTotalCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblClaimTotalCost.AutoSize = true;
            this.lblClaimTotalCost.ForeColor = System.Drawing.Color.Black;
            this.lblClaimTotalCost.Location = new System.Drawing.Point(6, 608);
            this.lblClaimTotalCost.Name = "lblClaimTotalCost";
            this.lblClaimTotalCost.Size = new System.Drawing.Size(0, 20);
            this.lblClaimTotalCost.TabIndex = 34;
            // 
            // btnCancelReport
            // 
            this.btnCancelReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelReport.AutoSize = true;
            this.btnCancelReport.Location = new System.Drawing.Point(450, 603);
            this.btnCancelReport.Name = "btnCancelReport";
            this.btnCancelReport.Size = new System.Drawing.Size(109, 30);
            this.btnCancelReport.TabIndex = 152;
            this.btnCancelReport.Text = "Cancel";
            this.btnCancelReport.UseVisualStyleBackColor = true;
            this.btnCancelReport.Click += new System.EventHandler(this.btnCancelReport_Click);
            // 
            // grdClaims
            // 
            this.grdClaims.AllowUserToAddRows = false;
            this.grdClaims.AllowUserToDeleteRows = false;
            this.grdClaims.AllowUserToOrderColumns = true;
            this.grdClaims.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdClaims.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdClaims.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdClaims.Location = new System.Drawing.Point(10, 254);
            this.grdClaims.Name = "grdClaims";
            this.grdClaims.ReadOnly = true;
            this.grdClaims.RowTemplate.Height = 28;
            this.grdClaims.Size = new System.Drawing.Size(558, 337);
            this.grdClaims.TabIndex = 31;
            // 
            // lblReportMessage
            // 
            this.lblReportMessage.AutoSize = true;
            this.lblReportMessage.ForeColor = System.Drawing.Color.Maroon;
            this.lblReportMessage.Location = new System.Drawing.Point(6, 20);
            this.lblReportMessage.Name = "lblReportMessage";
            this.lblReportMessage.Size = new System.Drawing.Size(0, 20);
            this.lblReportMessage.TabIndex = 30;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(313, 138);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(146, 20);
            this.label16.TabIndex = 29;
            this.label16.Text = "Insurance Card No.";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(313, 66);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(148, 20);
            this.label15.TabIndex = 28;
            this.label15.Text = "Healthcare Provider";
            // 
            // dtTo
            // 
            this.dtTo.Location = new System.Drawing.Point(7, 161);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(276, 26);
            this.dtTo.TabIndex = 102;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 137);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 20);
            this.label14.TabIndex = 26;
            this.label14.Text = "Date To";
            // 
            // dtFrom
            // 
            this.dtFrom.Location = new System.Drawing.Point(7, 91);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(276, 26);
            this.dtFrom.TabIndex = 101;
            // 
            // txtPolicyNumber
            // 
            this.txtPolicyNumber.Location = new System.Drawing.Point(317, 161);
            this.txtPolicyNumber.Name = "txtPolicyNumber";
            this.txtPolicyNumber.Size = new System.Drawing.Size(251, 26);
            this.txtPolicyNumber.TabIndex = 104;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 67);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 20);
            this.label13.TabIndex = 23;
            this.label13.Text = "Date From";
            // 
            // btnLoadClaims
            // 
            this.btnLoadClaims.AutoSize = true;
            this.btnLoadClaims.Location = new System.Drawing.Point(460, 203);
            this.btnLoadClaims.Name = "btnLoadClaims";
            this.btnLoadClaims.Size = new System.Drawing.Size(108, 30);
            this.btnLoadClaims.TabIndex = 105;
            this.btnLoadClaims.Text = "Load";
            this.btnLoadClaims.UseVisualStyleBackColor = true;
            this.btnLoadClaims.Click += new System.EventHandler(this.btnLoadClaims_Click);
            // 
            // cmbHealthCareProviders
            // 
            this.cmbHealthCareProviders.FormattingEnabled = true;
            this.cmbHealthCareProviders.Location = new System.Drawing.Point(317, 89);
            this.cmbHealthCareProviders.Name = "cmbHealthCareProviders";
            this.cmbHealthCareProviders.Size = new System.Drawing.Size(251, 28);
            this.cmbHealthCareProviders.TabIndex = 103;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 701);
            this.Controls.Add(this.tabControl1);
            this.Name = "Main";
            this.Text = "Main";
            this.tabControl1.ResumeLayout(false);
            this.tbClaim.ResumeLayout(false);
            this.tbClaim.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tbReport.ResumeLayout(false);
            this.tbReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdClaims)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbClaim;
        private System.Windows.Forms.TabPage tbReport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDOB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInsuranceCardNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoadBeneficiary;
        private System.Windows.Forms.Button btnClearControls;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.RadioButton rbPending;
        private System.Windows.Forms.RadioButton rbNotCovered;
        private System.Windows.Forms.RadioButton rbCovered;
        private System.Windows.Forms.DateTimePicker dtAdmissionDate;
        private System.Windows.Forms.ComboBox cmbMedicalCase;
        private System.Windows.Forms.ComboBox cmbPhysician;
        private System.Windows.Forms.ComboBox cmbHospital;
        private System.Windows.Forms.TextBox txtEstimatedCost;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.DataGridView grdClaims;
        private System.Windows.Forms.Label lblReportMessage;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.TextBox txtPolicyNumber;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnLoadClaims;
        private System.Windows.Forms.ComboBox cmbHealthCareProviders;
        private System.Windows.Forms.Button btnCancelReport;
        private System.Windows.Forms.Label lblClaimTotalCost;
        private System.Windows.Forms.Button btnExport;
    }
}