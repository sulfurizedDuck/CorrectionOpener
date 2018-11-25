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
        public static String rootDirectory="";
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

        public void initTree(String rootDir)
        {
            if ((File.GetAttributes(rootDir) & FileAttributes.Directory) != FileAttributes.Directory)
            {
                MessageBox.Show("Please Drop Directory!");
                return;
            }

            List<String> children = getDirectories(rootDir);

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

            ((SplitContainer)Parent.Parent).Panel1Collapsed = false;
        } 

        public List<String> getDirectories(String rootDir)
        {
            rootDirectory = rootDir;
            List<String> childDirs = Directory
                .GetDirectories(rootDir)
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

            ((Template)Parent.Parent.Parent).setCurrentDirectory(target.Text);

            String selectedProject = rootDirectory + @"\" + target.Text;
            List<String> files = Directory
                .GetFiles(selectedProject, "*.*", SearchOption.AllDirectories)
                .Where(c => Matkul.getSelectedMatkul().extensions.Any(x => c.EndsWith(x)))
                .Where(c => Matkul.getSelectedMatkul().checkedDirectories.FirstOrDefault(a => c.Contains(a)) != null)
                .Where(c => Matkul.getSelectedMatkul().ignoredDirectories.FirstOrDefault(a => c.Contains(a)) == null)
                .ToList();
            Template.panelMain.readFiles(files);
        }
    }
}
