using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KR.Panels
{
    public partial class SearchFiles : UserControl
    {
        public SearchFiles()
        {
            InitializeComponent();
            List<String> suggestions = new List<string>();
            suggestions.Add("Kentang");
            suggestions.Add("Kentut");
            suggestions.Add("Patrick");
            suggestions.Add("Tebe");

            AutoCompleteStringCollection testing = new AutoCompleteStringCollection();
            testing.AddRange(suggestions.ToArray());

            txtSearch.AutoCompleteCustomSource = testing;
            txtSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void SearchFiles_Load(object sender, EventArgs e)
        {

        }

        private void SearchFiles_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Left");
        }
    }
}
