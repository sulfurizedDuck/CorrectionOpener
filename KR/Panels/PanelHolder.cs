using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KR.Panels
{
    public partial class PanelHolder : Form
    {
        public PanelHolder(UserControl uc)
        {
            InitializeComponent();
            this.Controls.Add(uc);
        }
    }
}
