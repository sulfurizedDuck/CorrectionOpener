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
                RichTextBox rtb = new RichTextBox()
                {
                    Dock = DockStyle.Fill,
                    Font = new Font("Times New Roman", 14, FontStyle.Regular)
                };
                rtb.Text = File.ReadAllText(file);
                tabFiles.TabPages.Add(file.Substring(file.LastIndexOf('\\')+1));
                tabFiles.TabPages[tabFiles.TabPages.Count - 1].Controls.Add(rtb);
            }
        }

        private void PanelFileTabs_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }
    }
}
