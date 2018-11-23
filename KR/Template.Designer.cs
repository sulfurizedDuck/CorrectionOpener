namespace KR
{
    partial class Template
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.directoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ignoredDirectoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.menuStripAbove = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matkulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMatkulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            this.menuStripAbove.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.directoryToolStripMenuItem,
            this.ignoredDirectoriesToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 28);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(40, 293);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip";
            this.menuStrip1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // directoryToolStripMenuItem
            // 
            this.directoryToolStripMenuItem.Name = "directoryToolStripMenuItem";
            this.directoryToolStripMenuItem.Size = new System.Drawing.Size(23, 74);
            this.directoryToolStripMenuItem.Text = "Directory";
            this.directoryToolStripMenuItem.Click += new System.EventHandler(this.directoryToolStripMenuItem_Click);
            // 
            // ignoredDirectoriesToolStripMenuItem
            // 
            this.ignoredDirectoriesToolStripMenuItem.Name = "ignoredDirectoriesToolStripMenuItem";
            this.ignoredDirectoriesToolStripMenuItem.Size = new System.Drawing.Size(23, 146);
            this.ignoredDirectoriesToolStripMenuItem.Text = "Selected Directories";
            this.ignoredDirectoriesToolStripMenuItem.Click += new System.EventHandler(this.ignoredDirectoriesToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(40, 28);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitContainer1.Size = new System.Drawing.Size(339, 293);
            this.splitContainer1.SplitterDistance = 112;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 1;
            // 
            // menuStripAbove
            // 
            this.menuStripAbove.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripAbove.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStripAbove.Location = new System.Drawing.Point(0, 0);
            this.menuStripAbove.Name = "menuStripAbove";
            this.menuStripAbove.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStripAbove.Size = new System.Drawing.Size(379, 28);
            this.menuStripAbove.TabIndex = 2;
            this.menuStripAbove.Text = "menuStrip2";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.matkulToolStripMenuItem,
            this.addMatkulToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // matkulToolStripMenuItem
            // 
            this.matkulToolStripMenuItem.Name = "matkulToolStripMenuItem";
            this.matkulToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.matkulToolStripMenuItem.Text = "Matkuls";
            // 
            // addMatkulToolStripMenuItem
            // 
            this.addMatkulToolStripMenuItem.Name = "addMatkulToolStripMenuItem";
            this.addMatkulToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.addMatkulToolStripMenuItem.Text = "Add Matkul";
            this.addMatkulToolStripMenuItem.Click += new System.EventHandler(this.addMatkulToolStripMenuItem_Click);
            // 
            // Template
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 321);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStripAbove);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Template";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Template_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Template_DragEnter);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Template_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStripAbove.ResumeLayout(false);
            this.menuStripAbove.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem directoryToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripMenuItem ignoredDirectoriesToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStripAbove;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matkulToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMatkulToolStripMenuItem;
    }
}

