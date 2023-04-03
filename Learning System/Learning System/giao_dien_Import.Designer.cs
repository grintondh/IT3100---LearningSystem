namespace Learning_System
{
    partial class giao_dien_Import
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
            panel1 = new Panel();
            label_Add_Category = new Label();
            panel2 = new Panel();
            button_File_format = new Button();
            label_File_format = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            button_General = new Button();
            button_format = new Button();
            label_Import = new Label();
            button_select_file = new Button();
            button_IMPORT = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label_Add_Category);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1112, 75);
            panel1.TabIndex = 2;
            // 
            // label_Add_Category
            // 
            label_Add_Category.AutoSize = true;
            label_Add_Category.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label_Add_Category.Location = new Point(3, 9);
            label_Add_Category.Name = "label_Add_Category";
            label_Add_Category.Size = new Size(410, 46);
            label_Add_Category.TabIndex = 3;
            label_Add_Category.Text = "Import questions from file\r\n";
            // 
            // panel2
            // 
            panel2.Controls.Add(label_File_format);
            panel2.Controls.Add(button_File_format);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 75);
            panel2.Name = "panel2";
            panel2.Size = new Size(1112, 74);
            panel2.TabIndex = 3;
            // 
            // button_File_format
            // 
            button_File_format.FlatAppearance.BorderSize = 0;
            button_File_format.FlatStyle = FlatStyle.Flat;
            button_File_format.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button_File_format.Location = new Point(14, 16);
            button_File_format.Name = "button_File_format";
            button_File_format.Size = new Size(106, 28);
            button_File_format.TabIndex = 0;
            button_File_format.Text = "File format";
            button_File_format.UseVisualStyleBackColor = true;
            // 
            // label_File_format
            // 
            label_File_format.AutoSize = true;
            label_File_format.Location = new Point(573, 31);
            label_File_format.Name = "label_File_format";
            label_File_format.Size = new Size(136, 20);
            label_File_format.TabIndex = 1;
            label_File_format.Text = "Viewing file format";
            // 
            // panel3
            // 
            panel3.Controls.Add(button_General);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 149);
            panel3.Name = "panel3";
            panel3.Size = new Size(1112, 69);
            panel3.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.Controls.Add(button_IMPORT);
            panel4.Controls.Add(button_select_file);
            panel4.Controls.Add(label_Import);
            panel4.Controls.Add(button_format);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 218);
            panel4.Name = "panel4";
            panel4.Size = new Size(1112, 367);
            panel4.TabIndex = 5;
            // 
            // button_General
            // 
            button_General.FlatAppearance.BorderSize = 0;
            button_General.FlatStyle = FlatStyle.Flat;
            button_General.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button_General.Location = new Point(14, 18);
            button_General.Name = "button_General";
            button_General.Size = new Size(86, 28);
            button_General.TabIndex = 2;
            button_General.Text = "General";
            button_General.UseVisualStyleBackColor = true;
            // 
            // button_format
            // 
            button_format.FlatAppearance.BorderSize = 0;
            button_format.FlatStyle = FlatStyle.Flat;
            button_format.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button_format.Location = new Point(14, 6);
            button_format.Name = "button_format";
            button_format.Size = new Size(219, 28);
            button_format.TabIndex = 2;
            button_format.Text = "Import questions from file";
            button_format.UseVisualStyleBackColor = true;
            // 
            // label_Import
            // 
            label_Import.AutoSize = true;
            label_Import.Location = new Point(39, 76);
            label_Import.Name = "label_Import";
            label_Import.Size = new Size(54, 20);
            label_Import.TabIndex = 2;
            label_Import.Text = "Import";
            // 
            // button_select_file
            // 
            button_select_file.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_select_file.Location = new Point(445, 76);
            button_select_file.Name = "button_select_file";
            button_select_file.Size = new Size(216, 53);
            button_select_file.TabIndex = 3;
            button_select_file.Text = "CHOOSE A FILE ...";
            button_select_file.UseVisualStyleBackColor = true;
            // 
            // button_IMPORT
            // 
            button_IMPORT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_IMPORT.Location = new Point(473, 298);
            button_IMPORT.Name = "button_IMPORT";
            button_IMPORT.Size = new Size(159, 53);
            button_IMPORT.TabIndex = 4;
            button_IMPORT.Text = "IMPORT";
            button_IMPORT.UseVisualStyleBackColor = true;
            // 
            // giao_dien_Import
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "giao_dien_Import";
            Size = new Size(1112, 585);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label_Add_Category;
        private Panel panel2;
        private Label label_File_format;
        private Button button_File_format;
        private Panel panel3;
        private Button button_General;
        private Panel panel4;
        private Button button_select_file;
        private Label label_Import;
        private Button button_format;
        private Button button_IMPORT;
    }
}
