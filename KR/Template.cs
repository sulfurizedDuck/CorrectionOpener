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
        public static PanelDirectory panelDirectory;
        public static PanelSelectedDirectories panelIgnored;
        public static PanelFileTabs panelMain;
        public static SearchFiles panelSearchFiles;

        private ToolStripItem clickedItem = null;

        public Template()
        {
            InitializeComponent();
            initPanels();
            configureSplitContainer();
        }

        private void initPanels()
        {
            panelDirectory = new PanelDirectory();
            panelIgnored = new PanelSelectedDirectories();
            panelMain = new PanelFileTabs();
        }

        private void configureSplitContainer()
        {
            splitContainer1.Panel1Collapsed = true;
            splitContainer1.SplitterDistance = 50;

            panelMain = new PanelFileTabs();
            splitContainer1.Panel2.Controls.Add(panelMain);
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
            loadFolders(rootDir);
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
            if (panelDirectory == null)
            {
                panelDirectory = new PanelDirectory();
            }

            splitContainer1.Panel1.Controls.Add(panelDirectory);
        }

        private void ignoredDirectoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (panelIgnored == null)
            {
                panelIgnored = new PanelSelectedDirectories();
            }

            splitContainer1.Panel1.Controls.Add(panelIgnored);
        }

        private void addMatkulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formInsertMatkul == null || formInsertMatkul.IsDisposed)
            {
                formInsertMatkul = new AddMatkul();
            }
            formInsertMatkul.Show();
        }

        private void Template_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.W && panelMain != null)
            {
                panelMain.PanelFileTabs_KeyDown(sender, e);
            }
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
            foreach(Matkul matkul in Matkul.matkuls)
            {
                ToolStripMenuItem tsmi = new ToolStripMenuItem(matkul.matkulName);
                tsmi.Click += Tsmi_Click;
                matkulToolStripMenuItem.DropDownItems.Add(tsmi);
            }
        }

        private void Tsmi_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem clicker = ((ToolStripMenuItem)sender);
            int index = matkulToolStripMenuItem.DropDownItems.IndexOf(clicker);

            Matkul.selectedMatkul = Matkul.matkuls[index];
            panelIgnored.initListView();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateListMatkuls();
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
                loadFolders(fbd.SelectedPath);
            }
        }

        private void loadFolders(String rootDir)
        {
            if (panelDirectory == null)
            {
                panelDirectory = new PanelDirectory();
            }
            splitContainer1.Panel1.Controls.Add(panelDirectory);
            panelDirectory.initTree(rootDir);
        }

        private void nextProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (panelDirectory == null)
                return;
            panelDirectory.switchProject(true);
        }

        private void previousProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (panelDirectory == null)
                return;
            panelDirectory.switchProject(false);
        }

        private void gotoAnythingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (panelSearchFiles == null || panelSearchFiles.IsDisposed)
            {
                panelSearchFiles = new SearchFiles();
                
            }
            panelSearchFiles.Show();
            panelSearchFiles.BringToFront();
            MessageBox.Show(panelSearchFiles.Location.X + " " + panelSearchFiles.Location.Y);
        }
    }
}
