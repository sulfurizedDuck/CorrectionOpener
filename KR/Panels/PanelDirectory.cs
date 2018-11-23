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
        public static String rootDirectory="";
        public PanelDirectory()
        {
            InitializeComponent();
        }

        public void initTree(String rootDir)
        {
            List<TreeNode> treeNodes = new List<TreeNode>();
            List<String> children = getDirectories(rootDir);
            
            foreach(String child in children)
            {
                tree.Nodes.Add(child);
            }
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
            String selectedProject = rootDirectory + @"\" + e.Node.Text;
            List<String> files = Directory
                .GetFiles(selectedProject, "*.java", SearchOption.AllDirectories)
                .Where(c => Matkul.getSelectedMatkul().getCheckedDirectories().FirstOrDefault(a => c.Contains(a)) != null)
                .ToList();
            Template.panelMain.readFiles(files);
        }
    }
}
