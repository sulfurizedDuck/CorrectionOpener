namespace KR.Panels
{
    partial class PanelLoadExcel
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
            this.btnChooseExcel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnChooseExcel
            // 
            this.btnChooseExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseExcel.Location = new System.Drawing.Point(3, 3);
            this.btnChooseExcel.Name = "btnChooseExcel";
            this.btnChooseExcel.Size = new System.Drawing.Size(271, 52);
            this.btnChooseExcel.TabIndex = 0;
            this.btnChooseExcel.Text = "Choose Excel File";
            this.btnChooseExcel.UseVisualStyleBackColor = true;
            this.btnChooseExcel.Click += new System.EventHandler(this.btnChooseExcel_Click);
            // 
            // PanelLoadExcel
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnChooseExcel);
            this.Name = "PanelLoadExcel";
            this.Size = new System.Drawing.Size(382, 150);
            this.Load += new System.EventHandler(this.PanelLoadExcel_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.PanelLoadExcel_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.PanelLoadExcel_DragEnter);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChooseExcel;
    }
}
