using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using KR.Functionalities;

namespace KR
{
    public partial class PanelDirectory : UserControl
    {
        private static TreeNode _selectedNode;
        public static TreeNode selectedNode
        {
            get
            {
                return _selectedNode;
            }
            set
            {
                TreeNode oldTree = _selectedNode;
                TreeNode newTree = value;

                if (oldTree != null)
                {
                    oldTree.BackColor = Color.White;
                }
                newTree.BackColor = Color.DarkGray;
                _selectedNode = value;
            }
        }

        public PanelDirectory()
        {
            InitializeComponent();
        }

        public void initTree()
        {
            string rootDir = GlobalVariables.rootDirectory;
            if ((File.GetAttributes(rootDir) & FileAttributes.Directory) != FileAttributes.Directory)
            {
                MessageBox.Show("Please Drop Directory!");
                return;
            }

            List<String> children = getDirectories();

            if (children.Count == 0)
            {
                MessageBox.Show("Invalid Project Directory");
                return;
            }

            tree.Nodes.Clear();

            foreach(String child in children)
            {
                tree.Nodes.Add(child);
            }

            switchProject(tree.Nodes[0]);

            GlobalVariables.formMain.toggleSplitContainerCollapse(false);
            
        } 

        public List<String> getDirectories()
        {
            List<String> childDirs = Directory
                .GetDirectories(GlobalVariables.rootDirectory)
                .ToList();

            for (int i=0; i<childDirs.Count; i++)
            {
                childDirs[i] = childDirs[i]
                    .Substring(childDirs[i].LastIndexOf('\\') + 1);
            }

            return childDirs;
        }

        private void PanelDirectory_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        private void tree_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            switchProject(e.Node);
        }

        public void switchProject(bool isNext)
        {
            if (tree.Nodes.Count == 0)
                return;

            int currentIndex = tree.Nodes.IndexOf(selectedNode);
            int targetedIndex = currentIndex;

            if (isNext && currentIndex < tree.Nodes.Count - 1)
            {
                targetedIndex += 1;
            } else if (!isNext && currentIndex > 0)
            {
                targetedIndex -= 1;
            }

            TreeNode targetedNode = tree.Nodes[targetedIndex];

            switchProject(targetedNode);
        }

        public void switchProject(TreeNode target)
        {
            if (selectedNode == target)
                return;

            selectedNode = target;
            GlobalVariables.formMain.setCurrentDirectory(target.Text);
            GlobalVariables.currProject = target.Text;

            String selectedProject = GlobalVariables.currProject;

            #region Getting files that should be shown 
            List<String> files = Directory
                .GetFiles(selectedProject, "*.*", SearchOption.AllDirectories)
                .Where(c => GlobalVariables.selectedMatkul.extensions.Any(x => c.EndsWith(x)))
                .ToList();
            if (GlobalVariables.selectedMatkul.checkedDirectories.Count > 0)
            {
                files = files
                    .Where(c => GlobalVariables.selectedMatkul.checkedDirectories.FirstOrDefault(a => c.Contains(a)) != null)
                    .ToList();
            }
            if (GlobalVariables.selectedMatkul.ignoredDirectories.Count > 0)
            {
                files = files
                    .Where(c => GlobalVariables.selectedMatkul.ignoredDirectories.FirstOrDefault(a => c.Contains(a)) == null)
                    .ToList();
            }
            GlobalVariables.panelMain.readFiles(files);
            #endregion

            #region Set suggestion for Goto
            GlobalVariables.panelSearchFiles.loadSuggestions();
            #endregion

            #region getting all files in folders
            GlobalVariables.panelProject.loadProject(selectedProject);
            #endregion
        }
    }
}
