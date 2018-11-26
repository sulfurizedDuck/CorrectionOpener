namespace KR.Settings
{
    partial class AddMatkul
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
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelButton = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMatkulName = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtExtensions = new System.Windows.Forms.TextBox();
            this.lvExtensions = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lvCheckedDirectories = new System.Windows.Forms.ListBox();
            this.txtCheckedDirectories = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lvIgnoredDirectories = new System.Windows.Forms.ListBox();
            this.txtIgnoredDirectories = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelButton.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(555, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Matkul";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 30);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(555, 470);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panelButton
            // 
            this.panelButton.Controls.Add(this.btnAdd);
            this.panelButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButton.Location = new System.Drawing.Point(0, 500);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(555, 44);
            this.panelButton.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(0, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(555, 44);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add Matkul";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtMatkulName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(549, 41);
            this.panel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 41);
            this.label2.TabIndex = 0;
            this.label2.Text = "Matkul Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMatkulName
            // 
            this.txtMatkulName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMatkulName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatkulName.Location = new System.Drawing.Point(136, 0);
            this.txtMatkulName.Name = "txtMatkulName";
            this.txtMatkulName.Size = new System.Drawing.Size(413, 41);
            this.txtMatkulName.TabIndex = 1;
            this.txtMatkulName.Text = "";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lvExtensions);
            this.panel2.Controls.Add(this.txtExtensions);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(549, 135);
            this.panel2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(549, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Extensions Accepted";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtExtensions
            // 
            this.txtExtensions.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtExtensions.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExtensions.Location = new System.Drawing.Point(0, 32);
            this.txtExtensions.Name = "txtExtensions";
            this.txtExtensions.Size = new System.Drawing.Size(549, 27);
            this.txtExtensions.TabIndex = 2;
            this.txtExtensions.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtExtensions_KeyDown);
            // 
            // lvExtensions
            // 
            this.lvExtensions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvExtensions.FormattingEnabled = true;
            this.lvExtensions.Location = new System.Drawing.Point(0, 59);
            this.lvExtensions.Name = "lvExtensions";
            this.lvExtensions.Size = new System.Drawing.Size(549, 76);
            this.lvExtensions.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lvCheckedDirectories);
            this.panel3.Controls.Add(this.txtCheckedDirectories);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 191);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(549, 135);
            this.panel3.TabIndex = 8;
            // 
            // lvCheckedDirectories
            // 
            this.lvCheckedDirectories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvCheckedDirectories.FormattingEnabled = true;
            this.lvCheckedDirectories.Location = new System.Drawing.Point(0, 59);
            this.lvCheckedDirectories.Name = "lvCheckedDirectories";
            this.lvCheckedDirectories.Size = new System.Drawing.Size(549, 76);
            this.lvCheckedDirectories.TabIndex = 3;
            // 
            // txtCheckedDirectories
            // 
            this.txtCheckedDirectories.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCheckedDirectories.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCheckedDirectories.Location = new System.Drawing.Point(0, 32);
            this.txtCheckedDirectories.Name = "txtCheckedDirectories";
            this.txtCheckedDirectories.Size = new System.Drawing.Size(549, 27);
            this.txtCheckedDirectories.TabIndex = 2;
            this.txtCheckedDirectories.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCheckedDirectories_KeyDown);
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(549, 32);
            this.label4.TabIndex = 1;
            this.label4.Text = "Checked Directories";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lvIgnoredDirectories);
            this.panel4.Controls.Add(this.txtIgnoredDirectories);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 332);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(549, 135);
            this.panel4.TabIndex = 9;
            // 
            // lvIgnoredDirectories
            // 
            this.lvIgnoredDirectories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvIgnoredDirectories.FormattingEnabled = true;
            this.lvIgnoredDirectories.Location = new System.Drawing.Point(0, 59);
            this.lvIgnoredDirectories.Name = "lvIgnoredDirectories";
            this.lvIgnoredDirectories.Size = new System.Drawing.Size(549, 76);
            this.lvIgnoredDirectories.TabIndex = 3;
            // 
            // txtIgnoredDirectories
            // 
            this.txtIgnoredDirectories.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtIgnoredDirectories.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIgnoredDirectories.Location = new System.Drawing.Point(0, 32);
            this.txtIgnoredDirectories.Name = "txtIgnoredDirectories";
            this.txtIgnoredDirectories.Size = new System.Drawing.Size(549, 27);
            this.txtIgnoredDirectories.TabIndex = 2;
            this.txtIgnoredDirectories.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIgnoredDirectories_KeyDown);
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(549, 32);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ignored Directories";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddMatkul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 544);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelButton);
            this.Name = "AddMatkul";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddMatkul";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelButton.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtMatkulName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtExtensions;
        private System.Windows.Forms.ListBox lvExtensions;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListBox lvIgnoredDirectories;
        private System.Windows.Forms.TextBox txtIgnoredDirectories;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox lvCheckedDirectories;
        private System.Windows.Forms.TextBox txtCheckedDirectories;
        private System.Windows.Forms.Label label4;
    }
}