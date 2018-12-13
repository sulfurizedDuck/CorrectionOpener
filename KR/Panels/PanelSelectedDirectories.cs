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

namespace KR.Panels
{
    public partial class PanelSelectedDirectories : UserControl
    {
        private List<String> checkedDirectories;
        private List<String> ignoredDirectories;
        public PanelSelectedDirectories()
        {
            InitializeComponent();
            initListView();
        }

        private void PanelIgnoredDirectories_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }
        
        public void initListView()
        {
            checkedDirectories = GlobalVariables.selectedMatkul.checkedDirectories;
            listSelected.Items.Clear();
            foreach (String s in checkedDirectories)
            {
                listSelected.Items.Add(s);
            }

            ignoredDirectories = GlobalVariables.selectedMatkul.ignoredDirectories;
            listIgnored.Items.Clear();
            foreach(String s in ignoredDirectories)
            {
                listIgnored.Items.Add(s);
            }
        }
    }
}
