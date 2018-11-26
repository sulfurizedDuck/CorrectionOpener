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

namespace KR.Settings
{
    public partial class AddMatkul : Form
    {
        private List<String> extensions;
        private List<String> checkedDirs;
        private List<String> ignoredDirs;
        public AddMatkul()
        {
            InitializeComponent();
            extensions = new List<string>();
            checkedDirs = new List<string>();
            ignoredDirs = new List<string>();
            updateList();
        }

        private void txtExtensions_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return && !txtExtensions.Text.Equals(""))
            {
                extensions.Add(txtExtensions.Text);
                txtExtensions.Text = "";
                updateList();
            }
        }

        private void txtCheckedDirectories_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return && !txtCheckedDirectories.Text.Equals(""))
            {
                checkedDirs.Add(txtCheckedDirectories.Text);
                txtCheckedDirectories.Text = "";
                updateList();
            }
        }

        private void txtIgnoredDirectories_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return && !txtIgnoredDirectories.Text.Equals(""))
            {
                ignoredDirs.Add(txtIgnoredDirectories.Text);
                txtIgnoredDirectories.Text = "";
                updateList();
            }
        }

        private void updateList()
        {
            lvExtensions.Items.Clear();
            
            foreach(String s in extensions)
            {
                lvExtensions.Items.Add(s);
            }

            lvCheckedDirectories.Items.Clear();
            foreach (String s in checkedDirs)
            {
                lvCheckedDirectories.Items.Add(s);
            }

            lvIgnoredDirectories.Items.Clear();
            foreach (String s in ignoredDirs)
            {
                lvIgnoredDirectories.Items.Add(s);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String path = txtMatkulName.Text;
            bool isValid = true;

            if (path.Length == 0)
            {
                MessageBox.Show("Matkul Name can't be empty!");
                isValid = false;
            }
            else if (extensions.Count == 0)
            {
                MessageBox.Show("Extensions can't be empty!");
                isValid = false;
            }
            else if (checkedDirs.Count == 0)
            {
                MessageBox.Show("Checked Directories can't be empty!");
                isValid = false;
            }

            if (!isValid)
            {
                return;
            }

            String fileName = @"Matkul\" + path + ".txt";
            String ex = String.Join("#", extensions);
            String cd = String.Join("#", checkedDirs);
            String id = String.Join("#", ignoredDirs);

            List<String> toWrite = new List<string>();
            toWrite.Add(ex);
            toWrite.Add(cd);
            toWrite.Add(id);

            File.WriteAllLines(fileName, toWrite);

            txtMatkulName.Text = "";
            extensions.Clear();
            checkedDirs.Clear();
            ignoredDirs.Clear();

            MessageBox.Show("Success");
        }
    }
}
