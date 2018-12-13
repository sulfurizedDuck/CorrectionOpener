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
using KR.Functionalities;

namespace KR.Panels
{
    public partial class SearchFiles : UserControl
    {
        private AutoCompleteStringCollection suggestions;
        private List<string> filePath;

        public SearchFiles()
        {
            InitializeComponent();
            suggestions = new AutoCompleteStringCollection();
            filePath = new List<string>();

            txtSearch.AutoCompleteCustomSource = suggestions;
            txtSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void SearchFiles_Load(object sender, EventArgs e)
        {
            txtSearch.Select();
        }

        private void SearchFiles_Leave(object sender, EventArgs e)
        {
            dispose();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                dispose();
            } else if (e.KeyCode == Keys.Return)
            {
                string fileName = txtSearch.Text;

                string path = filePath.Where(c => c.EndsWith(fileName)).FirstOrDefault();
                if (path == null)
                    return;

                int index = GlobalVariables.panelMain.addTab(path);
                GlobalVariables.panelMain.switchTab(index);
            }
        }

        public void loadSuggestions()
        {
            string rootDir = GlobalVariables.currProject;
            string[] files = Directory.GetFiles(rootDir, "*.*", SearchOption.AllDirectories);
            int fileCount = files.Count();

            filePath.Clear();
            filePath.AddRange(files);

            for (int i=0; i<fileCount; i++)
            {
                files[i] = files[i].Substring(files[i].LastIndexOf('\\') + 1);
            }

            suggestions.Clear();
            suggestions.AddRange(files);
        }

        private void dispose()
        {
            txtSearch.Text = "";
            Parent.Visible = false;
        }
    }
}
