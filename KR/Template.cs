using KR.Functionalities;
using KR.Panels;
using KR.Settings;
using KR.Style;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KR
{
    public partial class Template : Form
    {
        AddMatkul formInsertMatkul;

        private ToolStripItem clickedItem = null;
        

        public Template()
        {
            InitializeComponent();
            configureSplitContainer();
            updateListMatkuls();
        }

        private void configureSplitContainer()
        {
            splitContainer1.Panel1Collapsed = true;
            splitContainer1.SplitterDistance = 50;
            
            splitContainer1.Panel2.Controls.Add(GlobalVariables.panelMain);

            panelHolder.Controls.Add(GlobalVariables.panelSearchFiles);
        }

        private void Template_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void Template_DragDrop(object sender, DragEventArgs e)
        {
            String rootDir = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
            GlobalVariables.rootDirectory = rootDir;
            loadFolders();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //Toggle Visibility and Clear item for use of the next component
            if (e.ClickedItem == clickedItem)
            {
                splitContainer1.Panel1Collapsed = !splitContainer1.Panel1Collapsed;
            } else
            {
                splitContainer1.Panel1Collapsed = false;
            }
            clickedItem = e.ClickedItem;

            splitContainer1.Panel1.Controls.Clear();
        }

        private void directoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel1.Controls.Add(GlobalVariables.panelDirectory);
        }

        private void projectMenuItem_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel1.Controls.Add(GlobalVariables.panelProject);
        }

        private void ignoredDirectoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel1.Controls.Add(GlobalVariables.panelSelectedDirectories);
        }

        private void addMatkulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formInsertMatkul == null || formInsertMatkul.IsDisposed)
            {
                formInsertMatkul = new AddMatkul();
            }
            formInsertMatkul.Show();
        }

        public void toggleSplitContainerCollapse(bool isCollapse)
        {
            splitContainer1.Panel1Collapsed = isCollapse;
        }

        public void setCurrentDirectory(String root)
        {
            lblCurrDirectory.Text = "Current Directory: " + root;
        }

        public void setCurrentPath(String path)
        {
            this.Text = path + " - Correction Opener";
        }

        public void updateListMatkuls()
        {
            Matkul.initMatkuls();
            matkulToolStripMenuItem.DropDownItems.Clear();
            foreach(Matkul matkul in GlobalVariables.matkuls)
            {
                ToolStripMenuItem tsmi = new ToolStripMenuItem(matkul.matkulName);
                tsmi.Click += Tsmi_Click;
                matkulToolStripMenuItem.DropDownItems.Add(tsmi);
            }
            foreach (ToolStripMenuItem item in matkulToolStripMenuItem.DropDownItems)
            {
                item.Checked = false;
            }
            ((ToolStripMenuItem)matkulToolStripMenuItem.DropDownItems[0]).Checked = true;
        }

        private void Tsmi_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem clicker = ((ToolStripMenuItem)sender);

            foreach (ToolStripMenuItem item in clicker.Owner.Items)
            {
                item.Checked = false;
            }
            clicker.Checked = true;


            int index = matkulToolStripMenuItem.DropDownItems.IndexOf(clicker);

            GlobalVariables.selectedMatkul = GlobalVariables.matkuls[index];
            GlobalVariables.panelSelectedDirectories.initListView();
        }

        private void Template_Load(object sender, EventArgs e)
        {
            //menuStripAbove.Renderer = new ToolStripProfessionalRenderer(new MenuStripColor());
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                GlobalVariables.rootDirectory = fbd.SelectedPath;
                loadFolders();
            }
        }

        private void loadFolders()
        {
            splitContainer1.Panel1.Controls.Clear();
            splitContainer1.Panel1.Controls.Add(GlobalVariables.panelDirectory);
            GlobalVariables.panelDirectory.initTree();
        }

        private void nextProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.panelDirectory == null)
                return;
            GlobalVariables.panelDirectory.switchProject(true);
        }

        private void previousProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.panelDirectory == null)
                return;
            GlobalVariables.panelDirectory.switchProject(false);
        }

        private void gotoAnythingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region Change Location of Panel2's panelHolder For Goto
            int panelWidth = splitContainer1.Panel2.Width;
            int holderWidth = panelHolder.Width;
            int x = (panelWidth - holderWidth) / 2;
            int y = panelHolder.Location.Y;
            panelHolder.Location = new Point(x, y);
            #endregion

            panelHolder.Visible = true;
        }

        private void closeFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GlobalVariables.panelMain.closeTab();
        }

        private void closeWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
