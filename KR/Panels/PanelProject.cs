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
    public partial class PanelProject : UserControl
    {
        string rootDir;

        public PanelProject()
        {
            InitializeComponent();
        }

        public void loadProject(string root)
        {
            tree.Nodes.Clear();
            this.rootDir = root;

            string[] folders = Directory.GetDirectories(root);
            string[] files = Directory.GetFiles(root, "*.*");

            foreach(string folder in folders)
            {
                TreeNode newNode = addNode(folder);
                loadProject(newNode, folder);
            }

            foreach(string file in files)
            {
                addNode(file);
            }

        }

        private void loadProject(TreeNode owner, string root)
        {
            string[] folders = Directory.GetDirectories(root);
            string[] files = Directory.GetFiles(root, "*.*");

            foreach (string folder in folders)
            {
                TreeNode newNode = addNode(owner, folder);
                loadProject(newNode, folder);
            }

            foreach (string file in files)
            {
                addNode(owner, file);
            }
        }

        private TreeNode addNode(string path)
        {
            string trimmedPath = path.Substring(path.LastIndexOf("\\") + 1);
            TreeNode newNode = new TreeNode(trimmedPath);
            newNode.Name = path;
            
            tree.Nodes.Add(newNode);

            return newNode;
        }

        private TreeNode addNode(TreeNode owner, string path)
        {
            string trimmedPath = path.Substring(path.LastIndexOf("\\") + 1);
            TreeNode newNode = new TreeNode(trimmedPath);
            newNode.Name = path;
            owner.Nodes.Add(newNode);

            return newNode;
        }

        private void PanelProject_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;
        }

        private void tree_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Nodes.Count != 0)
                return;

            int index = Template.panelMain.addTab(e.Node.Name);
            Template.panelMain.switchTab(index);
        }
    }
}
