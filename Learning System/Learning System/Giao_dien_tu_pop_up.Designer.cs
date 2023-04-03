namespace Learning_System
{
    partial class Giao_dien_tu_pop_up
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
            panel_chuc_nang = new Panel();
            button_Export = new Button();
            button_Import = new Button();
            button_Categories = new Button();
            button_Questions = new Button();
            panel1 = new Panel();
            giao_dien_Import = new giao_dien_Import();
            giao_dien_Categories = new Giao_dien_Categories();
            giao_dien_xem_danh_sach_cau_hoi = new Giao_dien_xem_danh_sach_cau_hoi();
            giao_dien_Export = new giao_dien_Export();
            panel_chuc_nang.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel_chuc_nang
            // 
            panel_chuc_nang.Controls.Add(button_Export);
            panel_chuc_nang.Controls.Add(button_Import);
            panel_chuc_nang.Controls.Add(button_Categories);
            panel_chuc_nang.Controls.Add(button_Questions);
            panel_chuc_nang.Dock = DockStyle.Top;
            panel_chuc_nang.Location = new Point(0, 0);
            panel_chuc_nang.Name = "panel_chuc_nang";
            panel_chuc_nang.Size = new Size(1089, 66);
            panel_chuc_nang.TabIndex = 0;
            // 
            // button_Export
            // 
            button_Export.Dock = DockStyle.Left;
            button_Export.FlatAppearance.BorderSize = 0;
            button_Export.FlatAppearance.MouseOverBackColor = Color.Silver;
            button_Export.FlatStyle = FlatStyle.Flat;
            button_Export.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_Export.ForeColor = Color.Black;
            button_Export.Location = new Point(561, 0);
            button_Export.Name = "button_Export";
            button_Export.Size = new Size(187, 66);
            button_Export.TabIndex = 3;
            button_Export.Text = "Export";
            button_Export.UseVisualStyleBackColor = true;
            button_Export.Click += button_Export_Click;
            // 
            // button_Import
            // 
            button_Import.Dock = DockStyle.Left;
            button_Import.FlatAppearance.BorderSize = 0;
            button_Import.FlatAppearance.MouseOverBackColor = Color.Silver;
            button_Import.FlatStyle = FlatStyle.Flat;
            button_Import.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_Import.ForeColor = Color.Black;
            button_Import.Location = new Point(374, 0);
            button_Import.Name = "button_Import";
            button_Import.Size = new Size(187, 66);
            button_Import.TabIndex = 2;
            button_Import.Text = "Import";
            button_Import.UseVisualStyleBackColor = true;
            button_Import.Click += button_Import_Click;
            // 
            // button_Categories
            // 
            button_Categories.Dock = DockStyle.Left;
            button_Categories.FlatAppearance.BorderSize = 0;
            button_Categories.FlatAppearance.MouseOverBackColor = Color.Silver;
            button_Categories.FlatStyle = FlatStyle.Flat;
            button_Categories.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_Categories.ForeColor = Color.Black;
            button_Categories.Location = new Point(187, 0);
            button_Categories.Name = "button_Categories";
            button_Categories.Size = new Size(187, 66);
            button_Categories.TabIndex = 1;
            button_Categories.Text = "Categories";
            button_Categories.UseVisualStyleBackColor = true;
            button_Categories.Click += button_Categories_Click;
            // 
            // button_Questions
            // 
            button_Questions.Dock = DockStyle.Left;
            button_Questions.FlatAppearance.BorderSize = 0;
            button_Questions.FlatAppearance.MouseOverBackColor = Color.Silver;
            button_Questions.FlatStyle = FlatStyle.Flat;
            button_Questions.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_Questions.ForeColor = Color.Black;
            button_Questions.Location = new Point(0, 0);
            button_Questions.Name = "button_Questions";
            button_Questions.Size = new Size(187, 66);
            button_Questions.TabIndex = 0;
            button_Questions.Text = "Questions";
            button_Questions.UseVisualStyleBackColor = true;
            button_Questions.Click += button_Questions_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(giao_dien_Export);
            panel1.Controls.Add(giao_dien_Import);
            panel1.Controls.Add(giao_dien_Categories);
            panel1.Controls.Add(giao_dien_xem_danh_sach_cau_hoi);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 66);
            panel1.Name = "panel1";
            panel1.Size = new Size(1089, 559);
            panel1.TabIndex = 1;
            // 
            // giao_dien_Import
            // 
            giao_dien_Import.Dock = DockStyle.Fill;
            giao_dien_Import.Location = new Point(0, 0);
            giao_dien_Import.Name = "giao_dien_Import";
            giao_dien_Import.Size = new Size(1089, 559);
            giao_dien_Import.TabIndex = 4;
            giao_dien_Import.Visible = false;
            giao_dien_Import.Load += giao_dien_Import_Load;
            // 
            // giao_dien_Categories
            // 
            giao_dien_Categories.AutoScroll = true;
            giao_dien_Categories.Dock = DockStyle.Fill;
            giao_dien_Categories.Location = new Point(0, 0);
            giao_dien_Categories.Name = "giao_dien_Categories";
            giao_dien_Categories.Size = new Size(1089, 559);
            giao_dien_Categories.TabIndex = 4;
            giao_dien_Categories.Visible = false;
            giao_dien_Categories.Load += giao_dien_Categories_Load;
            // 
            // giao_dien_xem_danh_sach_cau_hoi
            // 
            giao_dien_xem_danh_sach_cau_hoi.Dock = DockStyle.Fill;
            giao_dien_xem_danh_sach_cau_hoi.Location = new Point(0, 0);
            giao_dien_xem_danh_sach_cau_hoi.Name = "giao_dien_xem_danh_sach_cau_hoi";
            giao_dien_xem_danh_sach_cau_hoi.Size = new Size(1089, 559);
            giao_dien_xem_danh_sach_cau_hoi.TabIndex = 0;
            giao_dien_xem_danh_sach_cau_hoi.Load += giao_dien_xem_danh_sach_cau_hoi_Load;
            // 
            // giao_dien_Export
            // 
            giao_dien_Export.Dock = DockStyle.Fill;
            giao_dien_Export.Location = new Point(0, 0);
            giao_dien_Export.Name = "giao_dien_Export";
            giao_dien_Export.Size = new Size(1089, 559);
            giao_dien_Export.TabIndex = 4;
            giao_dien_Export.Visible = false;
            giao_dien_Export.Load += giao_dien_Export_Load;
            // 
            // Giao_dien_tu_pop_up
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(panel_chuc_nang);
            Name = "Giao_dien_tu_pop_up";
            Size = new Size(1089, 625);
            panel_chuc_nang.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_chuc_nang;
        private Button button_Export;
        private Button button_Import;
        private Button button_Categories;
        private Button button_Questions;
        private Panel panel1;
        private Giao_dien_xem_danh_sach_cau_hoi giao_dien_xem_danh_sach_cau_hoi;
        private Giao_dien_Categories giao_dien_Categories;
        private giao_dien_Import giao_dien_Import;
        private giao_dien_Export giao_dien_Export;
    }
}
