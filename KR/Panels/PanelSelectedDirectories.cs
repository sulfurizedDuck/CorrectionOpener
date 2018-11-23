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
        private List<String> selectedDirectories;
        public PanelSelectedDirectories()
        {
            InitializeComponent();
            initListView();
        }

        private void PanelIgnoredDirectories_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }
        
        private void initListView()
        {
            selectedDirectories = Matkul.matkuls[0].getCheckedDirectories();
            foreach (String s in selectedDirectories)
            {
                listDirectories.Items.Add(s);
            }
        }
    }
}
