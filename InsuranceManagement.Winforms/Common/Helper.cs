using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace InsuranceManagement.Winforms.Common
{
    public static class Helper
    {
        public static void ExportToCsv(DataGridView DataGridView, string filename)
        {
            string stOutput = "";
            // Export titles:
            string sHeaders = "";

            for (int j = 0; j < DataGridView.Columns.Count; j++)
                sHeaders = sHeaders.ToString() + Convert.ToString(DataGridView.Columns[j].HeaderText) + "\t";
            stOutput += sHeaders + "\r\n";
            // Export data.
            for (int i = 0; i < DataGridView.RowCount - 1; i++)
            {
                string stLine = "";
                for (int j = 0; j < DataGridView.Rows[i].Cells.Count; j++)
                    stLine = stLine.ToString() + Convert.ToString(DataGridView.Rows[i].Cells[j].Value) + "\t";
                stOutput += stLine + "\r\n";
            }
            Encoding utf16 = Encoding.GetEncoding(1254);
            byte[] output = utf16.GetBytes(stOutput);
            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryWriter binaryWriter = new BinaryWriter(fs);
            binaryWriter.Write(output, 0, output.Length); //write the encoded file
            binaryWriter.Flush();
            binaryWriter.Close();
            fs.Close();
        }

        public static void ExportToPdf(DataGridView DataGridView, string filename)
        {
            Document document = new Document(PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter write = PdfWriter.GetInstance(document, new FileStream(filename, FileMode.Create));

            //Open Document to write
            document.Open();

            PdfPTable pdfTable = new PdfPTable(7);
            foreach (DataGridViewRow row in DataGridView.Rows)
            {
                foreach (DataGridViewCell celli in row.Cells)
                {
                    try
                    {
                        pdfTable.AddCell(celli.Value.ToString());
                    }
                    catch { }
                }
                document.Add(pdfTable);
            }

            //Close document
            document.Close();
        }

    }
}
