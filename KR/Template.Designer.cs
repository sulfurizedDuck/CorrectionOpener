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
            this.menuStripAbove = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matkulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMatkulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCurrDirectory = new System.Windows.Forms.Label();
            this.directoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ignoredDirectoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.menuStripAbove.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripAbove
            // 
            this.menuStripAbove.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripAbove.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStripAbove.Location = new System.Drawing.Point(0, 0);
            this.menuStripAbove.Name = "menuStripAbove";
            this.menuStripAbove.Size = new System.Drawing.Size(284, 24);
            this.menuStripAbove.TabIndex = 2;
            this.menuStripAbove.Text = "menuStrip2";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.matkulToolStripMenuItem,
            this.addMatkulToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // matkulToolStripMenuItem
            // 
            this.matkulToolStripMenuItem.Name = "matkulToolStripMenuItem";
            this.matkulToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.matkulToolStripMenuItem.Text = "Matkuls";
            // 
            // addMatkulToolStripMenuItem
            // 
            this.addMatkulToolStripMenuItem.Name = "addMatkulToolStripMenuItem";
            this.addMatkulToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addMatkulToolStripMenuItem.Text = "Add Matkul";
            this.addMatkulToolStripMenuItem.Click += new System.EventHandler(this.addMatkulToolStripMenuItem_Click);
            // 
            // lblCurrDirectory
            // 
            this.lblCurrDirectory.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCurrDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrDirectory.Location = new System.Drawing.Point(33, 24);
            this.lblCurrDirectory.Name = "lblCurrDirectory";
            this.lblCurrDirectory.Size = new System.Drawing.Size(251, 25);
            this.lblCurrDirectory.TabIndex = 3;
            this.lblCurrDirectory.Text = "Current Directory";
            // 
            // directoryToolStripMenuItem
            // 
            this.directoryToolStripMenuItem.Name = "directoryToolStripMenuItem";
            this.directoryToolStripMenuItem.Size = new System.Drawing.Size(20, 59);
            this.directoryToolStripMenuItem.Text = "Directory";
            this.directoryToolStripMenuItem.Click += new System.EventHandler(this.directoryToolStripMenuItem_Click);
            // 
            // ignoredDirectoriesToolStripMenuItem
            // 
            this.ignoredDirectoriesToolStripMenuItem.Name = "ignoredDirectoriesToolStripMenuItem";
            this.ignoredDirectoriesToolStripMenuItem.Size = new System.Drawing.Size(20, 114);
            this.ignoredDirectoriesToolStripMenuItem.Text = "Selected Directories";
            this.ignoredDirectoriesToolStripMenuItem.Click += new System.EventHandler(this.ignoredDirectoriesToolStripMenuItem_Click);
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
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(33, 237);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip";
            this.menuStrip1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(33, 49);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitContainer1.Size = new System.Drawing.Size(251, 212);
            this.splitContainer1.SplitterDistance = 82;
            this.splitContainer1.TabIndex = 1;
            // 
            // Template
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.lblCurrDirectory);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStripAbove);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Template";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Template_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Template_DragEnter);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Template_KeyDown);
            this.menuStripAbove.ResumeLayout(false);
            this.menuStripAbove.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStripAbove;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matkulToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMatkulToolStripMenuItem;
        private System.Windows.Forms.Label lblCurrDirectory;
        private System.Windows.Forms.ToolStripMenuItem directoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ignoredDirectoriesToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

