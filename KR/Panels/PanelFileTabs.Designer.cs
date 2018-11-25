namespace KR.Panels
{
    partial class PanelFileTabs
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabFiles = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pnlFind = new System.Windows.Forms.Panel();
            this.pnlFindAll = new System.Windows.Forms.Panel();
            this.txtFindAll = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFind = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabFiles.SuspendLayout();
            this.pnlFind.SuspendLayout();
            this.pnlFindAll.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabFiles
            // 
            this.tabFiles.Controls.Add(this.tabPage1);
            this.tabFiles.Controls.Add(this.tabPage2);
            this.tabFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabFiles.Location = new System.Drawing.Point(0, 0);
            this.tabFiles.Name = "tabFiles";
            this.tabFiles.SelectedIndex = 0;
            this.tabFiles.Size = new System.Drawing.Size(645, 472);
            this.tabFiles.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(637, 443);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(637, 443);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pnlFind
            // 
            this.pnlFind.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlFind.Controls.Add(this.pnlFindAll);
            this.pnlFind.Controls.Add(this.txtFind);
            this.pnlFind.Controls.Add(this.label1);
            this.pnlFind.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFind.Location = new System.Drawing.Point(0, 427);
            this.pnlFind.Name = "pnlFind";
            this.pnlFind.Padding = new System.Windows.Forms.Padding(5);
            this.pnlFind.Size = new System.Drawing.Size(645, 45);
            this.pnlFind.TabIndex = 0;
            this.pnlFind.Visible = false;
            // 
            // pnlFindAll
            // 
            this.pnlFindAll.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlFindAll.Controls.Add(this.txtFindAll);
            this.pnlFindAll.Controls.Add(this.label2);
            this.pnlFindAll.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFindAll.Location = new System.Drawing.Point(102, -5);
            this.pnlFindAll.Name = "pnlFindAll";
            this.pnlFindAll.Padding = new System.Windows.Forms.Padding(5);
            this.pnlFindAll.Size = new System.Drawing.Size(538, 45);
            this.pnlFindAll.TabIndex = 2;
            this.pnlFindAll.Visible = false;
            // 
            // txtFindAll
            // 
            this.txtFindAll.AcceptsTab = true;
            this.txtFindAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFindAll.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFindAll.Location = new System.Drawing.Point(165, 5);
            this.txtFindAll.Name = "txtFindAll";
            this.txtFindAll.Size = new System.Drawing.Size(368, 35);
            this.txtFindAll.TabIndex = 1;
            this.txtFindAll.Text = "";
            this.txtFindAll.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFindAll_KeyDown);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 35);
            this.label2.TabIndex = 0;
            this.label2.Text = "Find All:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFind
            // 
            this.txtFind.AcceptsTab = true;
            this.txtFind.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFind.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFind.Location = new System.Drawing.Point(102, 5);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(538, 35);
            this.txtFind.TabIndex = 1;
            this.txtFind.Text = "";
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelFileTabs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlFind);
            this.Controls.Add(this.tabFiles);
            this.Name = "PanelFileTabs";
            this.Size = new System.Drawing.Size(645, 472);
            this.Load += new System.EventHandler(this.PanelFileTabs_Load);
            this.tabFiles.ResumeLayout(false);
            this.pnlFind.ResumeLayout(false);
            this.pnlFindAll.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabFiles;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel pnlFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtFind;
        private System.Windows.Forms.Panel pnlFindAll;
        private System.Windows.Forms.RichTextBox txtFindAll;
        private System.Windows.Forms.Label label2;
    }
}
