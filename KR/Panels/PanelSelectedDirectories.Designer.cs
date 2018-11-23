namespace KR.Panels
{
    partial class PanelSelectedDirectories
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
            this.label1 = new System.Windows.Forms.Label();
            this.listDirectories = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selected Directories";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listDirectories
            // 
            this.listDirectories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listDirectories.FormattingEnabled = true;
            this.listDirectories.Location = new System.Drawing.Point(5, 29);
            this.listDirectories.Name = "listDirectories";
            this.listDirectories.Size = new System.Drawing.Size(357, 377);
            this.listDirectories.TabIndex = 6;
            // 
            // PanelSelectedDirectories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listDirectories);
            this.Controls.Add(this.label1);
            this.Name = "PanelSelectedDirectories";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(367, 411);
            this.Load += new System.EventHandler(this.PanelIgnoredDirectories_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listDirectories;
    }
}
