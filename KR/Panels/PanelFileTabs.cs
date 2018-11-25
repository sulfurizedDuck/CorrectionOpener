using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace KR.Panels
{
    public partial class PanelFileTabs : UserControl
    {
        public PanelFileTabs()
        {
            InitializeComponent();
            tabFiles.TabPages.Clear();
        }

        public void readFiles(List<String> files)
        {
            tabFiles.TabPages.Clear();
            foreach (String file in files)
            {
                RichTextBox rtb = createRichTextBox(File.ReadAllText(file));
                tabFiles.TabPages.Add(file.Substring(file.LastIndexOf('\\')+1));
                tabFiles.TabPages[tabFiles.TabPages.Count - 1].Controls.Add(rtb);
            }
        }

        private RichTextBox createRichTextBox(String text)
        {
            RichTextBox myCustomRTB = new RichTextBox()
            {
                Dock = DockStyle.Fill,
                Font = new Font("Consolas", 14, FontStyle.Regular),
                AcceptsTab = true,
            };
            myCustomRTB.KeyDown += MyCustomRTB_KeyDown; ;
            myCustomRTB.SelectionTabs = new int[] { 40, 80, 120, 160, 200, 240, 280, 320, 360, 400 };
            myCustomRTB.Text = text;
            return myCustomRTB;
        }

        private void MyCustomRTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.F)
            {
                pnlFind.Visible = true;
                pnlFindAll.Visible = false;
            }
            else if (e.Control && e.Shift && e.KeyCode == Keys.F)
            {
                pnlFind.Visible = false;
                pnlFindAll.Visible = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                pnlFind.Visible = false;
                pnlFindAll.Visible = false;
            }
        }

        private void PanelFileTabs_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFindAll_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
