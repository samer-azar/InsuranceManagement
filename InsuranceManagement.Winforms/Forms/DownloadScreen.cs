using InsuranceManagement.Winforms.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsuranceManagement.Winforms.Forms
{
    public partial class DownloadScreen : Form
    {
        #region GlobalVariables

        List<Common.JoinedClaim> _Claims;

        #endregion

        #region Constructors

        public DownloadScreen()
        {
            InitializeComponent();
        }

        public DownloadScreen(List<Common.JoinedClaim> Claims)
        {
            InitializeComponent();
            _Claims = Claims;
        }

        #endregion

        #region Events

        private void btnDownload_Click(object sender, EventArgs e)
        {
            if (rbExcel.Checked)
            {
                ExportToExcel();
            }
            else
                ExportToPdf();
        }

        #endregion

        #region Methods

        private void ExportToExcel()
        {
            grdData.DataSource = _Claims;

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Documents (*.xls)|*.xls";
            saveFileDialog.FileName = "export.xls";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Helper.ExportToCsv(grdData, saveFileDialog.FileName);
                this.Dispose();
                this.Close();
            }
        }

        private void ExportToPdf()
        {
            grdData.DataSource = _Claims;

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Pdf Documents (*.pdf)|*.pdf";
            saveFileDialog.FileName = "export.pdf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Helper.ExportToPdf(grdData, saveFileDialog.FileName);
                this.Dispose();
                this.Close();
            }
        }

        #endregion

    }
}
