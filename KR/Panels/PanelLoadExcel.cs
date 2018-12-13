using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KR.Functionalities;
using System.IO;

namespace KR.Panels
{
    public partial class PanelLoadExcel : UserControl
    {

        public PanelLoadExcel()
        {
            InitializeComponent();
        }

        private void PanelLoadExcel_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;
        }

        public void adjustPosition()
        {
            int parentX = GlobalVariables.formMain.splitContainerExcel.Width;
            int parentY = GlobalVariables.formMain.splitContainerExcel.Panel2.Height;
            int x = (parentX - btnChooseExcel.Width) / 2;
            int y = (parentY - btnChooseExcel.Height) / 2;
            btnChooseExcel.Location = new Point(x, y);
        }

        private void btnChooseExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Excel Files(*.xlsx, *.xls)|*.xlsx;*.xls";
            DialogResult result = of.ShowDialog();

            if (result == DialogResult.OK)
            {
                loadExcel(of.FileName);
            }
        }

        private void loadExcel(string excelPath)
        {
            GlobalVariables.excelPath = excelPath;
            GlobalVariables.formMain.splitContainerExcel.Panel2Collapsed = true;

            //TODO: Add some open excel logic here

            GlobalVariables.formMain.splitContainerExcel.Panel2Collapsed = false;
        }

        private void PanelLoadExcel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string excel = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];

                FileAttributes attr = File.GetAttributes(excel);
                if (!attr.HasFlag(FileAttributes.Directory)
                        && (excel.EndsWith(".xlsx") || excel.EndsWith(".xls"))    
                    )
                {
                    e.Effect = DragDropEffects.Copy;
                    return;
                }
            }
            e.Effect = DragDropEffects.None;
        }

        private void PanelLoadExcel_DragDrop(object sender, DragEventArgs e)
        {
            string excel = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
            loadExcel(excel);
        }
    }
}
