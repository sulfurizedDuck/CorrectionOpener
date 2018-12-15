using KR.Functionalities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Excel = Microsoft.Office.Interop.Excel;

namespace KR.Settings
{
    public partial class FormCustomizeExcel : Form
    {
        public FormCustomizeExcel()
        {
            InitializeComponent();
            Show();
        }

        private void initExcel()
        {
            string excelPath = GlobalVariables.excelPath;

            //Excel.Application app = new Excel.Application();
            //Excel.Workbook book = app.Workbooks.Open(excelPath);
            //Excel.Worksheet sheet = book.Sheets[1];
            //Excel.Range usedRange = sheet.UsedRange;

            //int rowCount = usedRange.Rows.Count;
            //int colCount = usedRange.Columns.Count;
            
            //for (int i=0; i<colCount; i++)
            //{
            //    string a = (char)(65 + i) + "";
            //    dgvFullExcel.Columns.Add(a, "A");
            //}

            //for (int i=1; i<=rowCount; i++)
            //{
            //    dgvFullExcel.Rows.Add();
            //    for (int j=1; j<=colCount; j++)
            //    {
            //        var temp = ((Excel.Range)usedRange.Cells[i, j]).Value;
            //        if (temp != null)
            //        {
            //            string val = temp.ToString();
            //            dgvFullExcel.Rows[i-1].Cells[j-1].Value = val;
            //        }
            //    }
            //}

            //book.Close();
            //app.Quit();

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string headerRange = txtHeader.Text;
            //TODO: Add validation here later

            GlobalVariables.panelExcel.setHeader(headerRange);
            Dispose();
        }
    }
}
