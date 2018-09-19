namespace InsuranceManagement.Winforms.Forms
{
    partial class DownloadScreen
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
            this.gbDownloadOptions = new System.Windows.Forms.GroupBox();
            this.rbPdf = new System.Windows.Forms.RadioButton();
            this.rbExcel = new System.Windows.Forms.RadioButton();
            this.btnDownload = new System.Windows.Forms.Button();
            this.grdData = new System.Windows.Forms.DataGridView();
            this.gbDownloadOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDownloadOptions
            // 
            this.gbDownloadOptions.Controls.Add(this.rbPdf);
            this.gbDownloadOptions.Controls.Add(this.rbExcel);
            this.gbDownloadOptions.Location = new System.Drawing.Point(12, 12);
            this.gbDownloadOptions.Name = "gbDownloadOptions";
            this.gbDownloadOptions.Size = new System.Drawing.Size(288, 100);
            this.gbDownloadOptions.TabIndex = 0;
            this.gbDownloadOptions.TabStop = false;
            this.gbDownloadOptions.Text = "Download Option";
            // 
            // rbPdf
            // 
            this.rbPdf.AutoSize = true;
            this.rbPdf.Location = new System.Drawing.Point(6, 55);
            this.rbPdf.Name = "rbPdf";
            this.rbPdf.Size = new System.Drawing.Size(66, 24);
            this.rbPdf.TabIndex = 1;
            this.rbPdf.Text = "PDF";
            this.rbPdf.UseVisualStyleBackColor = true;
            // 
            // rbExcel
            // 
            this.rbExcel.AutoSize = true;
            this.rbExcel.Checked = true;
            this.rbExcel.Location = new System.Drawing.Point(6, 25);
            this.rbExcel.Name = "rbExcel";
            this.rbExcel.Size = new System.Drawing.Size(72, 24);
            this.rbExcel.TabIndex = 0;
            this.rbExcel.TabStop = true;
            this.rbExcel.Text = "Excel";
            this.rbExcel.UseVisualStyleBackColor = true;
            // 
            // btnDownload
            // 
            this.btnDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDownload.Location = new System.Drawing.Point(12, 118);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(112, 37);
            this.btnDownload.TabIndex = 1;
            this.btnDownload.Text = "Export";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // grdData
            // 
            this.grdData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdData.Location = new System.Drawing.Point(306, 12);
            this.grdData.Name = "grdData";
            this.grdData.RowTemplate.Height = 28;
            this.grdData.Size = new System.Drawing.Size(31, 100);
            this.grdData.TabIndex = 2;
            this.grdData.Visible = false;
            // 
            // DownloadScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 167);
            this.Controls.Add(this.grdData);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.gbDownloadOptions);
            this.Name = "DownloadScreen";
            this.Text = "DownloadScreen";
            this.gbDownloadOptions.ResumeLayout(false);
            this.gbDownloadOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDownloadOptions;
        private System.Windows.Forms.RadioButton rbPdf;
        private System.Windows.Forms.RadioButton rbExcel;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.DataGridView grdData;
    }
}