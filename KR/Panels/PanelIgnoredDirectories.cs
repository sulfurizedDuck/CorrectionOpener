﻿using System;
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
    public partial class PanelIgnoredDirectories : UserControl
    {
        public PanelIgnoredDirectories()
        {
            InitializeComponent();
        }

        private void PanelIgnoredDirectories_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }
    }
}
