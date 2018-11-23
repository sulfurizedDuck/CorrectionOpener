using KR.Panels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KR
{
    public partial class Template : Form
    {
        PanelDirectory panelDirectory;
        PanelIgnoredDirectories panelIgnored;

        private ToolStripItem clickedItem = null;

        public Template()
        {
            InitializeComponent();
            configureSplitContainer();
        }

        private void configureSplitContainer()
        {
            splitContainer1.Panel1Collapsed = true;
            splitContainer1.SplitterDistance = 50;
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
            panelDirectory.initTree(rootDir);
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
                panelIgnored = new PanelIgnoredDirectories();
            }

            splitContainer1.Panel1.Controls.Add(panelIgnored);
        }
    }
}
