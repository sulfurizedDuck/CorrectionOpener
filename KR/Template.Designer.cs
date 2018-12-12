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
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.changeProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previousProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matkulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMatkulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCurrDirectory = new System.Windows.Forms.Label();
            this.directoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ignoredDirectoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GotoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gotoAnythingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripAbove.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripAbove
            // 
            this.menuStripAbove.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripAbove.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.GotoMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStripAbove.Location = new System.Drawing.Point(0, 0);
            this.menuStripAbove.Name = "menuStripAbove";
            this.menuStripAbove.Size = new System.Drawing.Size(510, 24);
            this.menuStripAbove.TabIndex = 2;
            this.menuStripAbove.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeProjectToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(56, 20);
            this.toolStripMenuItem2.Text = "Project";
            // 
            // changeProjectToolStripMenuItem
            // 
            this.changeProjectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nextProjectToolStripMenuItem,
            this.previousProjectToolStripMenuItem});
            this.changeProjectToolStripMenuItem.Name = "changeProjectToolStripMenuItem";
            this.changeProjectToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.changeProjectToolStripMenuItem.Text = "Change Project";
            // 
            // nextProjectToolStripMenuItem
            // 
            this.nextProjectToolStripMenuItem.Name = "nextProjectToolStripMenuItem";
            this.nextProjectToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Right)));
            this.nextProjectToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.nextProjectToolStripMenuItem.Text = "Next Project";
            this.nextProjectToolStripMenuItem.Click += new System.EventHandler(this.nextProjectToolStripMenuItem_Click);
            // 
            // previousProjectToolStripMenuItem
            // 
            this.previousProjectToolStripMenuItem.Name = "previousProjectToolStripMenuItem";
            this.previousProjectToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Left)));
            this.previousProjectToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.previousProjectToolStripMenuItem.Text = "Previous Project";
            this.previousProjectToolStripMenuItem.Click += new System.EventHandler(this.previousProjectToolStripMenuItem_Click);
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
            this.lblCurrDirectory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCurrDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrDirectory.Location = new System.Drawing.Point(0, 0);
            this.lblCurrDirectory.Name = "lblCurrDirectory";
            this.lblCurrDirectory.Size = new System.Drawing.Size(477, 27);
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
            this.menuStrip1.Size = new System.Drawing.Size(33, 394);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip";
            this.menuStrip1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(33, 51);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitContainer1.Size = new System.Drawing.Size(477, 367);
            this.splitContainer1.SplitterDistance = 155;
            this.splitContainer1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblCurrDirectory);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(33, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(477, 27);
            this.panel1.TabIndex = 4;
            // 
            // GotoMenuItem
            // 
            this.GotoMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gotoAnythingToolStripMenuItem});
            this.GotoMenuItem.Name = "GotoMenuItem";
            this.GotoMenuItem.Size = new System.Drawing.Size(45, 20);
            this.GotoMenuItem.Text = "Goto";
            // 
            // gotoAnythingToolStripMenuItem
            // 
            this.gotoAnythingToolStripMenuItem.Name = "gotoAnythingToolStripMenuItem";
            this.gotoAnythingToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.gotoAnythingToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.gotoAnythingToolStripMenuItem.Text = "Goto Anything";
            this.gotoAnythingToolStripMenuItem.Click += new System.EventHandler(this.gotoAnythingToolStripMenuItem_Click);
            // 
            // Template
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 418);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStripAbove);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Template";
            this.Text = "Correction Opener";
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
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem changeProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nextProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previousProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GotoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gotoAnythingToolStripMenuItem;
    }
}

