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
            panel_chuc_nang = new Panel();
            PopUpForm_ExportBtn = new Button();
            PopUpForm_ImportBtn = new Button();
            PopUpForm_CategoriesBtn = new Button();
            PopUpForm_QuestionsBtn = new Button();
            panel1 = new Panel();
            ExportForm = new ExportForm();
            ImportForm = new ImportForm();
            CategoriesForm = new CategoriesForm();
            QuestionsForm = new QuestionsForm();
            panel_chuc_nang.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel_chuc_nang
            // 
            panel_chuc_nang.Controls.Add(PopUpForm_ExportBtn);
            panel_chuc_nang.Controls.Add(PopUpForm_ImportBtn);
            panel_chuc_nang.Controls.Add(PopUpForm_CategoriesBtn);
            panel_chuc_nang.Controls.Add(PopUpForm_QuestionsBtn);
            panel_chuc_nang.Dock = DockStyle.Top;
            panel_chuc_nang.Location = new Point(0, 0);
            panel_chuc_nang.Name = "panel_chuc_nang";
            panel_chuc_nang.Size = new Size(1089, 66);
            panel_chuc_nang.TabIndex = 0;
            // 
            // PopUpForm_ExportBtn
            // 
            PopUpForm_ExportBtn.Dock = DockStyle.Left;
            PopUpForm_ExportBtn.FlatAppearance.BorderSize = 0;
            PopUpForm_ExportBtn.FlatAppearance.MouseOverBackColor = Color.Silver;
            PopUpForm_ExportBtn.FlatStyle = FlatStyle.Flat;
            PopUpForm_ExportBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PopUpForm_ExportBtn.ForeColor = Color.Black;
            PopUpForm_ExportBtn.Location = new Point(561, 0);
            PopUpForm_ExportBtn.Name = "PopUpForm_ExportBtn";
            PopUpForm_ExportBtn.Size = new Size(187, 66);
            PopUpForm_ExportBtn.TabIndex = 3;
            PopUpForm_ExportBtn.Text = "Export";
            PopUpForm_ExportBtn.UseVisualStyleBackColor = true;
            PopUpForm_ExportBtn.Click += button_Export_Click;
            // 
            // PopUpForm_ImportBtn
            // 
            PopUpForm_ImportBtn.Dock = DockStyle.Left;
            PopUpForm_ImportBtn.FlatAppearance.BorderSize = 0;
            PopUpForm_ImportBtn.FlatAppearance.MouseOverBackColor = Color.Silver;
            PopUpForm_ImportBtn.FlatStyle = FlatStyle.Flat;
            PopUpForm_ImportBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PopUpForm_ImportBtn.ForeColor = Color.Black;
            PopUpForm_ImportBtn.Location = new Point(374, 0);
            PopUpForm_ImportBtn.Name = "PopUpForm_ImportBtn";
            PopUpForm_ImportBtn.Size = new Size(187, 66);
            PopUpForm_ImportBtn.TabIndex = 2;
            PopUpForm_ImportBtn.Text = "Import";
            PopUpForm_ImportBtn.UseVisualStyleBackColor = true;
            PopUpForm_ImportBtn.Click += button_Import_Click;
            // 
            // PopUpForm_CategoriesBtn
            // 
            PopUpForm_CategoriesBtn.Dock = DockStyle.Left;
            PopUpForm_CategoriesBtn.FlatAppearance.BorderSize = 0;
            PopUpForm_CategoriesBtn.FlatAppearance.MouseOverBackColor = Color.Silver;
            PopUpForm_CategoriesBtn.FlatStyle = FlatStyle.Flat;
            PopUpForm_CategoriesBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PopUpForm_CategoriesBtn.ForeColor = Color.Black;
            PopUpForm_CategoriesBtn.Location = new Point(187, 0);
            PopUpForm_CategoriesBtn.Name = "PopUpForm_CategoriesBtn";
            PopUpForm_CategoriesBtn.Size = new Size(187, 66);
            PopUpForm_CategoriesBtn.TabIndex = 1;
            PopUpForm_CategoriesBtn.Text = "Categories";
            PopUpForm_CategoriesBtn.UseVisualStyleBackColor = true;
            PopUpForm_CategoriesBtn.Click += button_Categories_Click;
            // 
            // PopUpForm_QuestionsBtn
            // 
            PopUpForm_QuestionsBtn.Dock = DockStyle.Left;
            PopUpForm_QuestionsBtn.FlatAppearance.BorderSize = 0;
            PopUpForm_QuestionsBtn.FlatAppearance.MouseOverBackColor = Color.Silver;
            PopUpForm_QuestionsBtn.FlatStyle = FlatStyle.Flat;
            PopUpForm_QuestionsBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PopUpForm_QuestionsBtn.ForeColor = Color.Black;
            PopUpForm_QuestionsBtn.Location = new Point(0, 0);
            PopUpForm_QuestionsBtn.Name = "PopUpForm_QuestionsBtn";
            PopUpForm_QuestionsBtn.Size = new Size(187, 66);
            PopUpForm_QuestionsBtn.TabIndex = 0;
            PopUpForm_QuestionsBtn.Text = "Questions";
            PopUpForm_QuestionsBtn.UseVisualStyleBackColor = true;
            PopUpForm_QuestionsBtn.Click += button_Questions_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(ExportForm);
            panel1.Controls.Add(ImportForm);
            panel1.Controls.Add(CategoriesForm);
            panel1.Controls.Add(QuestionsForm);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 66);
            panel1.Name = "panel1";
            panel1.Size = new Size(1089, 559);
            panel1.TabIndex = 1;
            // 
            // ExportForm
            // 
            ExportForm.Dock = DockStyle.Fill;
            ExportForm.Location = new Point(0, 0);
            ExportForm.Name = "ExportForm";
            ExportForm.Size = new Size(1089, 559);
            ExportForm.TabIndex = 4;
            ExportForm.Visible = false;
            ExportForm.Load += giao_dien_Export_Load;
            // 
            // ImportForm
            // 
            ImportForm.Dock = DockStyle.Fill;
            ImportForm.Location = new Point(0, 0);
            ImportForm.Name = "ImportForm";
            ImportForm.Size = new Size(1089, 559);
            ImportForm.TabIndex = 4;
            ImportForm.Visible = false;
            ImportForm.Load += giao_dien_Import_Load;
            // 
            // CategoriesForm
            // 
            CategoriesForm.AutoScroll = true;
            CategoriesForm.Dock = DockStyle.Fill;
            CategoriesForm.Location = new Point(0, 0);
            CategoriesForm.Name = "CategoriesForm";
            CategoriesForm.Size = new Size(1089, 559);
            CategoriesForm.TabIndex = 4;
            CategoriesForm.Visible = false;
            CategoriesForm.Load += giao_dien_Categories_Load;
            // 
            // QuestionsForm
            // 
            QuestionsForm.Dock = DockStyle.Fill;
            QuestionsForm.Location = new Point(0, 0);
            QuestionsForm.Name = "QuestionsForm";
            QuestionsForm.Size = new Size(1089, 559);
            QuestionsForm.TabIndex = 0;
            QuestionsForm.Load += giao_dien_xem_danh_sach_cau_hoi_Load;
            // 
            // PopUpForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(panel_chuc_nang);
            Name = "PopUpForm";
            Size = new Size(1089, 625);
            panel_chuc_nang.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_chuc_nang;
        private Button PopUpForm_ExportBtn;
        private Button PopUpForm_ImportBtn;
        private Button PopUpForm_CategoriesBtn;
        private Button PopUpForm_QuestionsBtn;
        private Panel panel1;
        private QuestionsForm QuestionsForm;
        private CategoriesForm CategoriesForm;
        private ImportForm ImportForm;
        private ExportForm ExportForm;
    }
}
