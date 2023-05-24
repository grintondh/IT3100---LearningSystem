namespace Learning_System
{
    partial class ImportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportForm));
            panel1 = new Panel();
            ImportForm_HeadingLbl = new Label();
            panel2 = new Panel();
            ImportForm_FileFormatLbl = new Label();
            ImportForm_FileFormatBtn = new Button();
            panel3 = new Panel();
            ImportForm_GeneralBtn = new Button();
            panel4 = new Panel();
            ImportForm_ImportBtn = new Button();
            ImportForm_SelectFileBtn = new Button();
            ImportForm_ImportLbl = new Label();
            ImportForm_ShowImportBtn = new Button();
            ImportForm_ExpandPic1 = new PictureBox();
            ImportForm_ExpandPic2 = new PictureBox();
            ImportForm_ExpandPic3 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ImportForm_ExpandPic1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ImportForm_ExpandPic2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ImportForm_ExpandPic3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(ImportForm_HeadingLbl);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1112, 75);
            panel1.TabIndex = 2;
            // 
            // ImportForm_HeadingLbl
            // 
            ImportForm_HeadingLbl.AutoSize = true;
            ImportForm_HeadingLbl.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            ImportForm_HeadingLbl.ForeColor = Color.FromArgb(194, 36, 36);
            ImportForm_HeadingLbl.Location = new Point(3, 9);
            ImportForm_HeadingLbl.Name = "ImportForm_HeadingLbl";
            ImportForm_HeadingLbl.Size = new Size(410, 46);
            ImportForm_HeadingLbl.TabIndex = 3;
            ImportForm_HeadingLbl.Text = "Import questions from file\r\n";
            // 
            // panel2
            // 
            panel2.Controls.Add(ImportForm_ExpandPic1);
            panel2.Controls.Add(ImportForm_FileFormatLbl);
            panel2.Controls.Add(ImportForm_FileFormatBtn);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 75);
            panel2.Name = "panel2";
            panel2.Size = new Size(1112, 58);
            panel2.TabIndex = 3;
            // 
            // ImportForm_FileFormatLbl
            // 
            ImportForm_FileFormatLbl.AutoSize = true;
            ImportForm_FileFormatLbl.Location = new Point(566, 21);
            ImportForm_FileFormatLbl.Name = "ImportForm_FileFormatLbl";
            ImportForm_FileFormatLbl.Size = new Size(95, 20);
            ImportForm_FileFormatLbl.TabIndex = 1;
            ImportForm_FileFormatLbl.Text = "Aiken format";
            // 
            // ImportForm_FileFormatBtn
            // 
            ImportForm_FileFormatBtn.FlatAppearance.BorderSize = 0;
            ImportForm_FileFormatBtn.FlatStyle = FlatStyle.Flat;
            ImportForm_FileFormatBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            ImportForm_FileFormatBtn.ForeColor = Color.FromArgb(194, 36, 36);
            ImportForm_FileFormatBtn.Location = new Point(14, 16);
            ImportForm_FileFormatBtn.Name = "ImportForm_FileFormatBtn";
            ImportForm_FileFormatBtn.Size = new Size(106, 28);
            ImportForm_FileFormatBtn.TabIndex = 0;
            ImportForm_FileFormatBtn.Text = "File format";
            ImportForm_FileFormatBtn.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(ImportForm_ExpandPic2);
            panel3.Controls.Add(ImportForm_GeneralBtn);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 133);
            panel3.Name = "panel3";
            panel3.Size = new Size(1112, 69);
            panel3.TabIndex = 4;
            // 
            // ImportForm_GeneralBtn
            // 
            ImportForm_GeneralBtn.FlatAppearance.BorderSize = 0;
            ImportForm_GeneralBtn.FlatStyle = FlatStyle.Flat;
            ImportForm_GeneralBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            ImportForm_GeneralBtn.ForeColor = Color.FromArgb(194, 36, 36);
            ImportForm_GeneralBtn.Location = new Point(14, 18);
            ImportForm_GeneralBtn.Name = "ImportForm_GeneralBtn";
            ImportForm_GeneralBtn.Size = new Size(86, 28);
            ImportForm_GeneralBtn.TabIndex = 2;
            ImportForm_GeneralBtn.Text = "General";
            ImportForm_GeneralBtn.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(ImportForm_ExpandPic3);
            panel4.Controls.Add(ImportForm_ImportBtn);
            panel4.Controls.Add(ImportForm_SelectFileBtn);
            panel4.Controls.Add(ImportForm_ImportLbl);
            panel4.Controls.Add(ImportForm_ShowImportBtn);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 202);
            panel4.Name = "panel4";
            panel4.Size = new Size(1112, 383);
            panel4.TabIndex = 5;
            // 
            // ImportForm_ImportBtn
            // 
            ImportForm_ImportBtn.BackColor = Color.FromArgb(194, 36, 36);
            ImportForm_ImportBtn.FlatStyle = FlatStyle.Flat;
            ImportForm_ImportBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ImportForm_ImportBtn.ForeColor = Color.White;
            ImportForm_ImportBtn.Location = new Point(473, 298);
            ImportForm_ImportBtn.Name = "ImportForm_ImportBtn";
            ImportForm_ImportBtn.Size = new Size(159, 53);
            ImportForm_ImportBtn.TabIndex = 4;
            ImportForm_ImportBtn.Text = "IMPORT";
            ImportForm_ImportBtn.UseVisualStyleBackColor = false;
            // 
            // ImportForm_SelectFileBtn
            // 
            ImportForm_SelectFileBtn.BackColor = Color.FromArgb(0, 159, 229);
            ImportForm_SelectFileBtn.FlatStyle = FlatStyle.Flat;
            ImportForm_SelectFileBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ImportForm_SelectFileBtn.ForeColor = Color.White;
            ImportForm_SelectFileBtn.Location = new Point(445, 76);
            ImportForm_SelectFileBtn.Name = "ImportForm_SelectFileBtn";
            ImportForm_SelectFileBtn.Size = new Size(216, 53);
            ImportForm_SelectFileBtn.TabIndex = 3;
            ImportForm_SelectFileBtn.Text = "CHOOSE A FILE ...";
            ImportForm_SelectFileBtn.UseVisualStyleBackColor = false;
            // 
            // ImportForm_ImportLbl
            // 
            ImportForm_ImportLbl.AutoSize = true;
            ImportForm_ImportLbl.Location = new Point(25, 76);
            ImportForm_ImportLbl.Name = "ImportForm_ImportLbl";
            ImportForm_ImportLbl.Size = new Size(54, 20);
            ImportForm_ImportLbl.TabIndex = 2;
            ImportForm_ImportLbl.Text = "Import";
            // 
            // ImportForm_ShowImportBtn
            // 
            ImportForm_ShowImportBtn.FlatAppearance.BorderSize = 0;
            ImportForm_ShowImportBtn.FlatStyle = FlatStyle.Flat;
            ImportForm_ShowImportBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            ImportForm_ShowImportBtn.ForeColor = Color.FromArgb(194, 36, 36);
            ImportForm_ShowImportBtn.Location = new Point(15, 6);
            ImportForm_ShowImportBtn.Name = "ImportForm_ShowImportBtn";
            ImportForm_ShowImportBtn.Size = new Size(219, 28);
            ImportForm_ShowImportBtn.TabIndex = 2;
            ImportForm_ShowImportBtn.Text = "Import questions from file";
            ImportForm_ShowImportBtn.UseVisualStyleBackColor = true;
            // 
            // ImportForm_ExpandPic1
            // 
            ImportForm_ExpandPic1.Image = (Image)resources.GetObject("ImportForm_ExpandPic1.Image");
            ImportForm_ExpandPic1.Location = new Point(8, 26);
            ImportForm_ExpandPic1.Name = "ImportForm_ExpandPic1";
            ImportForm_ExpandPic1.Size = new Size(15, 10);
            ImportForm_ExpandPic1.SizeMode = PictureBoxSizeMode.Zoom;
            ImportForm_ExpandPic1.TabIndex = 17;
            ImportForm_ExpandPic1.TabStop = false;
            // 
            // ImportForm_ExpandPic2
            // 
            ImportForm_ExpandPic2.Image = (Image)resources.GetObject("ImportForm_ExpandPic2.Image");
            ImportForm_ExpandPic2.Location = new Point(8, 30);
            ImportForm_ExpandPic2.Name = "ImportForm_ExpandPic2";
            ImportForm_ExpandPic2.Size = new Size(15, 10);
            ImportForm_ExpandPic2.SizeMode = PictureBoxSizeMode.Zoom;
            ImportForm_ExpandPic2.TabIndex = 17;
            ImportForm_ExpandPic2.TabStop = false;
            // 
            // ImportForm_ExpandPic3
            // 
            ImportForm_ExpandPic3.Image = (Image)resources.GetObject("ImportForm_ExpandPic3.Image");
            ImportForm_ExpandPic3.Location = new Point(8, 18);
            ImportForm_ExpandPic3.Name = "ImportForm_ExpandPic3";
            ImportForm_ExpandPic3.Size = new Size(15, 10);
            ImportForm_ExpandPic3.SizeMode = PictureBoxSizeMode.Zoom;
            ImportForm_ExpandPic3.TabIndex = 17;
            ImportForm_ExpandPic3.TabStop = false;
            // 
            // ImportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ImportForm";
            Size = new Size(1112, 585);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ImportForm_ExpandPic1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ImportForm_ExpandPic2).EndInit();
            ((System.ComponentModel.ISupportInitialize)ImportForm_ExpandPic3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label ImportForm_HeadingLbl;
        private Panel panel2;
        private Label ImportForm_FileFormatLbl;
        private Button ImportForm_FileFormatBtn;
        private Panel panel3;
        private Button ImportForm_GeneralBtn;
        private Panel panel4;
        private Button ImportForm_SelectFileBtn;
        private Label ImportForm_ImportLbl;
        private Button ImportForm_ShowImportBtn;
        private Button ImportForm_ImportBtn;
        private PictureBox ImportForm_ExpandPic1;
        private PictureBox ImportForm_ExpandPic2;
        private PictureBox ImportForm_ExpandPic3;
    }
}
