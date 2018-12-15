using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StackedHeader;
using Excel = Microsoft.Office.Interop.Excel;
using KR.Functionalities;

namespace KR.Panels
{
    public partial class PanelExcel : UserControl
    {
        public Excel.Application xlApp;
        public Excel.Workbook xlBook;
        public Excel.Worksheet xlSheet;
        public Excel.Range range;
        public PanelExcel()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            StackedHeaderDecorator decorator = new StackedHeaderDecorator(dgvExcel);
            dgvExcel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            xlApp = new Excel.Application();
            xlBook = xlApp.Workbooks.Open(GlobalVariables.excelPath);
            xlSheet = xlBook.Sheets[1];
        }

        public async void setHeader(string headerRange)
        {
            string[] cells = headerRange.Split(':');

            range = xlSheet.get_Range(headerRange);

            int rowCount = range.Rows.Count;
            int colCount = range.Columns.Count;

            int y0 = range.Row;

            dgvExcel.Columns.Clear();
            int rowIndex = range.Rows.Count ;
            for (int i = 1; i <= colCount; i++)
            {
                Excel.Range temp = range.Cells[rowIndex, i];
                string colName = getCellName(temp, y0, 0);
                dgvExcel.Columns.Add("Column" + i, colName);
            }
        }

        private string getCellName(Excel.Range cell, int header, int loop)
        {
            string name = "";

            if (cell.Value == null)
            {
                cell = cell.MergeArea.Cells[1, 1];
            }

            if (cell.Row > header)
                name += getCellName(xlSheet.Cells[cell.Row - 1, cell.Column], header, loop+1);
            if (name != "") name += ".";
            name += cell.Value;

            return name;
        }
    }
}
