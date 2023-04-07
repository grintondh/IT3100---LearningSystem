namespace Learning_System
{
    partial class PopUpForm
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
            PopUpForm_ExportBtn = new Button();
            PopUpForm_ImportBtn = new Button();
            PopUpForm_CategoriesBtn = new Button();
            PopUpForm_QuestionsBtn = new Button();
            ExportForm = new ExportForm();
            panel_heading = new Panel();
            PopUpForm_ITLbl = new Label();
            PopUpForm_PathLbl = new Label();
            panel_chuc_nang = new Panel();
            QuestionsForm = new QuestionsForm();
            CategoriesForm = new CategoriesForm();
            ImportForm = new ImportForm();
            panel_giao_dien = new Panel();
            panel_heading.SuspendLayout();
            panel_chuc_nang.SuspendLayout();
            panel_giao_dien.SuspendLayout();
            SuspendLayout();
            // 
            // PopUpForm_ExportBtn
            // 
            PopUpForm_ExportBtn.FlatAppearance.BorderSize = 0;
            PopUpForm_ExportBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            PopUpForm_ExportBtn.FlatStyle = FlatStyle.Flat;
            PopUpForm_ExportBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PopUpForm_ExportBtn.ForeColor = Color.FromArgb(30, 170, 232);
            PopUpForm_ExportBtn.Location = new Point(560, 3);
            PopUpForm_ExportBtn.Name = "PopUpForm_ExportBtn";
            PopUpForm_ExportBtn.Size = new Size(187, 61);
            PopUpForm_ExportBtn.TabIndex = 3;
            PopUpForm_ExportBtn.Text = "Export";
            PopUpForm_ExportBtn.UseVisualStyleBackColor = true;
            PopUpForm_ExportBtn.Click += button_Export_Click;
            // 
            // PopUpForm_ImportBtn
            // 
            PopUpForm_ImportBtn.FlatAppearance.BorderSize = 0;
            PopUpForm_ImportBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            PopUpForm_ImportBtn.FlatStyle = FlatStyle.Flat;
            PopUpForm_ImportBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PopUpForm_ImportBtn.ForeColor = Color.FromArgb(30, 170, 232);
            PopUpForm_ImportBtn.Location = new Point(373, 3);
            PopUpForm_ImportBtn.Name = "PopUpForm_ImportBtn";
            PopUpForm_ImportBtn.Size = new Size(187, 61);
            PopUpForm_ImportBtn.TabIndex = 2;
            PopUpForm_ImportBtn.Text = "Import";
            PopUpForm_ImportBtn.UseVisualStyleBackColor = true;
            PopUpForm_ImportBtn.Click += button_Import_Click;
            // 
            // PopUpForm_CategoriesBtn
            // 
            PopUpForm_CategoriesBtn.FlatAppearance.BorderSize = 0;
            PopUpForm_CategoriesBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            PopUpForm_CategoriesBtn.FlatStyle = FlatStyle.Flat;
            PopUpForm_CategoriesBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PopUpForm_CategoriesBtn.ForeColor = Color.FromArgb(30, 170, 232);
            PopUpForm_CategoriesBtn.Location = new Point(186, 3);
            PopUpForm_CategoriesBtn.Name = "PopUpForm_CategoriesBtn";
            PopUpForm_CategoriesBtn.Size = new Size(187, 61);
            PopUpForm_CategoriesBtn.TabIndex = 1;
            PopUpForm_CategoriesBtn.Text = "Categories";
            PopUpForm_CategoriesBtn.UseVisualStyleBackColor = true;
            PopUpForm_CategoriesBtn.Click += button_Categories_Click;
            // 
            // PopUpForm_QuestionsBtn
            // 
            PopUpForm_QuestionsBtn.FlatAppearance.BorderSize = 0;
            PopUpForm_QuestionsBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            PopUpForm_QuestionsBtn.FlatStyle = FlatStyle.Flat;
            PopUpForm_QuestionsBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PopUpForm_QuestionsBtn.ForeColor = Color.FromArgb(30, 170, 232);
            PopUpForm_QuestionsBtn.Location = new Point(-1, 3);
            PopUpForm_QuestionsBtn.Name = "PopUpForm_QuestionsBtn";
            PopUpForm_QuestionsBtn.Size = new Size(187, 61);
            PopUpForm_QuestionsBtn.TabIndex = 0;
            PopUpForm_QuestionsBtn.Text = "Questions";
            PopUpForm_QuestionsBtn.UseVisualStyleBackColor = true;
            PopUpForm_QuestionsBtn.Click += button_Questions_Click;
            // 
            // ExportForm
            // 
            ExportForm.Dock = DockStyle.Fill;
            ExportForm.Location = new Point(0, 0);
            ExportForm.Name = "ExportForm";
            ExportForm.Size = new Size(1089, 434);
            ExportForm.TabIndex = 4;
            ExportForm.Visible = false;
            ExportForm.Load += giao_dien_Export_Load;
            // 
            // panel_heading
            // 
            panel_heading.Controls.Add(PopUpForm_ITLbl);
            panel_heading.Controls.Add(PopUpForm_PathLbl);
            panel_heading.Dock = DockStyle.Top;
            panel_heading.Location = new Point(0, 0);
            panel_heading.Name = "panel_heading";
            panel_heading.Size = new Size(1089, 121);
            panel_heading.TabIndex = 3;
            // 
            // PopUpForm_ITLbl
            // 
            PopUpForm_ITLbl.AutoSize = true;
            PopUpForm_ITLbl.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            PopUpForm_ITLbl.ForeColor = Color.FromArgb(194, 36, 36);
            PopUpForm_ITLbl.Location = new Point(22, 3);
            PopUpForm_ITLbl.Name = "PopUpForm_ITLbl";
            PopUpForm_ITLbl.Size = new Size(60, 60);
            PopUpForm_ITLbl.TabIndex = 0;
            PopUpForm_ITLbl.Text = "IT";
            // 
            // PopUpForm_PathLbl
            // 
            PopUpForm_PathLbl.AutoSize = true;
            PopUpForm_PathLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            PopUpForm_PathLbl.Location = new Point(22, 77);
            PopUpForm_PathLbl.Name = "PopUpForm_PathLbl";
            PopUpForm_PathLbl.Size = new Size(291, 23);
            PopUpForm_PathLbl.TabIndex = 1;
            PopUpForm_PathLbl.Text = "Home  /  My courses  /  THI CUỐI KỲ";
            // 
            // panel_chuc_nang
            // 
            panel_chuc_nang.BorderStyle = BorderStyle.FixedSingle;
            panel_chuc_nang.Controls.Add(PopUpForm_QuestionsBtn);
            panel_chuc_nang.Controls.Add(PopUpForm_ImportBtn);
            panel_chuc_nang.Controls.Add(PopUpForm_ExportBtn);
            panel_chuc_nang.Controls.Add(PopUpForm_CategoriesBtn);
            panel_chuc_nang.Dock = DockStyle.Top;
            panel_chuc_nang.Location = new Point(0, 121);
            panel_chuc_nang.Name = "panel_chuc_nang";
            panel_chuc_nang.Size = new Size(1089, 70);
            panel_chuc_nang.TabIndex = 4;
            // 
            // QuestionsForm
            // 
            QuestionsForm.Dock = DockStyle.Fill;
            QuestionsForm.Location = new Point(0, 0);
            QuestionsForm.Name = "QuestionsForm";
            QuestionsForm.Size = new Size(1089, 434);
            QuestionsForm.TabIndex = 0;
            QuestionsForm.Load += giao_dien_xem_danh_sach_cau_hoi_Load;
            // 
            // CategoriesForm
            // 
            CategoriesForm.AutoScroll = true;
            CategoriesForm.Dock = DockStyle.Fill;
            CategoriesForm.Location = new Point(0, 0);
            CategoriesForm.Name = "CategoriesForm";
            CategoriesForm.Size = new Size(1089, 434);
            CategoriesForm.TabIndex = 4;
            CategoriesForm.Visible = false;
            CategoriesForm.Load += giao_dien_Categories_Load;
            // 
            // ImportForm
            // 
            ImportForm.Dock = DockStyle.Fill;
            ImportForm.Location = new Point(0, 0);
            ImportForm.Name = "ImportForm";
            ImportForm.Size = new Size(1089, 434);
            ImportForm.TabIndex = 4;
            ImportForm.Visible = false;
            ImportForm.Load += giao_dien_Import_Load;
            // 
            // panel_giao_dien
            // 
            panel_giao_dien.Controls.Add(QuestionsForm);
            panel_giao_dien.Controls.Add(ImportForm);
            panel_giao_dien.Controls.Add(ExportForm);
            panel_giao_dien.Controls.Add(CategoriesForm);
            panel_giao_dien.Dock = DockStyle.Fill;
            panel_giao_dien.Location = new Point(0, 191);
            panel_giao_dien.Name = "panel_giao_dien";
            panel_giao_dien.Size = new Size(1089, 434);
            panel_giao_dien.TabIndex = 5;
            // 
            // PopUpForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel_giao_dien);
            Controls.Add(panel_chuc_nang);
            Controls.Add(panel_heading);
            Name = "PopUpForm";
            Size = new Size(1089, 625);
            panel_heading.ResumeLayout(false);
            panel_heading.PerformLayout();
            panel_chuc_nang.ResumeLayout(false);
            panel_giao_dien.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button PopUpForm_ExportBtn;
        private Button PopUpForm_ImportBtn;
        private Button PopUpForm_CategoriesBtn;
        private Button PopUpForm_QuestionsBtn;
        private ExportForm ExportForm;
        private Panel panel_heading;
        private Label PopUpForm_ITLbl;
        public Label PopUpForm_PathLbl;
        private Panel panel_chuc_nang;
        private QuestionsForm QuestionsForm;
        private CategoriesForm CategoriesForm;
        private ImportForm ImportForm;
        private Panel panel_giao_dien;
    }
}
