namespace Learning_System
{
    partial class CategoriesForm
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
            CategoriesForm_HeadingLbl = new Label();
            CategoriesForm_ParentCategoryLbl = new Label();
            CategoriesForm_ParentCategoryCbo = new ComboBox();
            CategoriesForm_NameLbl = new Label();
            CategoriesForm_NameTxt = new TextBox();
            CategoriesForm_CategoryInfoTxt = new TextBox();
            CategoriesForm_IDNumberTxt = new TextBox();
            CategoriesForm_CategoryInfoLbl = new Label();
            CategoriesForm_IDNumberLbl = new Label();
            CategoriesForm_AddCategoryBtn = new Button();
            CategoriesForm_errorTextLbl = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // CategoriesForm_HeadingLbl
            // 
            CategoriesForm_HeadingLbl.AutoSize = true;
            CategoriesForm_HeadingLbl.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            CategoriesForm_HeadingLbl.ForeColor = Color.FromArgb(194, 36, 36);
            CategoriesForm_HeadingLbl.Location = new Point(42, 19);
            CategoriesForm_HeadingLbl.Name = "CategoriesForm_HeadingLbl";
            CategoriesForm_HeadingLbl.Size = new Size(227, 46);
            CategoriesForm_HeadingLbl.TabIndex = 0;
            CategoriesForm_HeadingLbl.Text = "Add Category";
            // 
            // CategoriesForm_ParentCategoryLbl
            // 
            CategoriesForm_ParentCategoryLbl.AutoSize = true;
            CategoriesForm_ParentCategoryLbl.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            CategoriesForm_ParentCategoryLbl.Location = new Point(46, 88);
            CategoriesForm_ParentCategoryLbl.Name = "CategoriesForm_ParentCategoryLbl";
            CategoriesForm_ParentCategoryLbl.Size = new Size(172, 25);
            CategoriesForm_ParentCategoryLbl.TabIndex = 1;
            CategoriesForm_ParentCategoryLbl.Text = "Parent Category (*)";
            // 
            // CategoriesForm_ParentCategoryCbo
            // 
            CategoriesForm_ParentCategoryCbo.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            CategoriesForm_ParentCategoryCbo.FormattingEnabled = true;
            CategoriesForm_ParentCategoryCbo.IntegralHeight = false;
            CategoriesForm_ParentCategoryCbo.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            CategoriesForm_ParentCategoryCbo.Location = new Point(262, 85);
            CategoriesForm_ParentCategoryCbo.Name = "CategoriesForm_ParentCategoryCbo";
            CategoriesForm_ParentCategoryCbo.Size = new Size(721, 33);
            CategoriesForm_ParentCategoryCbo.TabIndex = 2;
            // 
            // CategoriesForm_NameLbl
            // 
            CategoriesForm_NameLbl.AutoSize = true;
            CategoriesForm_NameLbl.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            CategoriesForm_NameLbl.Location = new Point(45, 146);
            CategoriesForm_NameLbl.Name = "CategoriesForm_NameLbl";
            CategoriesForm_NameLbl.Size = new Size(87, 25);
            CategoriesForm_NameLbl.TabIndex = 3;
            CategoriesForm_NameLbl.Text = "Name (*)";
            // 
            // CategoriesForm_NameTxt
            // 
            CategoriesForm_NameTxt.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            CategoriesForm_NameTxt.Location = new Point(262, 143);
            CategoriesForm_NameTxt.Name = "CategoriesForm_NameTxt";
            CategoriesForm_NameTxt.Size = new Size(721, 32);
            CategoriesForm_NameTxt.TabIndex = 4;
            // 
            // CategoriesForm_CategoryInfoTxt
            // 
            CategoriesForm_CategoryInfoTxt.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            CategoriesForm_CategoryInfoTxt.Location = new Point(262, 213);
            CategoriesForm_CategoryInfoTxt.MaxLength = 100;
            CategoriesForm_CategoryInfoTxt.Multiline = true;
            CategoriesForm_CategoryInfoTxt.Name = "CategoriesForm_CategoryInfoTxt";
            CategoriesForm_CategoryInfoTxt.Size = new Size(721, 163);
            CategoriesForm_CategoryInfoTxt.TabIndex = 5;
            // 
            // CategoriesForm_IDNumberTxt
            // 
            CategoriesForm_IDNumberTxt.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            CategoriesForm_IDNumberTxt.Location = new Point(262, 417);
            CategoriesForm_IDNumberTxt.Name = "CategoriesForm_IDNumberTxt";
            CategoriesForm_IDNumberTxt.Size = new Size(721, 32);
            CategoriesForm_IDNumberTxt.TabIndex = 6;
            // 
            // CategoriesForm_CategoryInfoLbl
            // 
            CategoriesForm_CategoryInfoLbl.AutoSize = true;
            CategoriesForm_CategoryInfoLbl.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            CategoriesForm_CategoryInfoLbl.Location = new Point(45, 216);
            CategoriesForm_CategoryInfoLbl.Name = "CategoriesForm_CategoryInfoLbl";
            CategoriesForm_CategoryInfoLbl.Size = new Size(126, 25);
            CategoriesForm_CategoryInfoLbl.TabIndex = 7;
            CategoriesForm_CategoryInfoLbl.Text = "Category info";
            // 
            // CategoriesForm_IDNumberLbl
            // 
            CategoriesForm_IDNumberLbl.AutoSize = true;
            CategoriesForm_IDNumberLbl.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            CategoriesForm_IDNumberLbl.Location = new Point(45, 420);
            CategoriesForm_IDNumberLbl.Name = "CategoriesForm_IDNumberLbl";
            CategoriesForm_IDNumberLbl.Size = new Size(126, 25);
            CategoriesForm_IDNumberLbl.TabIndex = 8;
            CategoriesForm_IDNumberLbl.Text = "ID number (*)";
            // 
            // CategoriesForm_AddCategoryBtn
            // 
            CategoriesForm_AddCategoryBtn.BackColor = Color.FromArgb(194, 36, 36);
            CategoriesForm_AddCategoryBtn.FlatStyle = FlatStyle.Flat;
            CategoriesForm_AddCategoryBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CategoriesForm_AddCategoryBtn.ForeColor = Color.White;
            CategoriesForm_AddCategoryBtn.Location = new Point(509, 526);
            CategoriesForm_AddCategoryBtn.Name = "CategoriesForm_AddCategoryBtn";
            CategoriesForm_AddCategoryBtn.Size = new Size(185, 51);
            CategoriesForm_AddCategoryBtn.TabIndex = 9;
            CategoriesForm_AddCategoryBtn.Text = "ADD CATEGORY";
            CategoriesForm_AddCategoryBtn.UseVisualStyleBackColor = false;
            CategoriesForm_AddCategoryBtn.Click += CategoriesForm_AddCategoryBtn_Click;
            // 
            // CategoriesForm_errorTextLbl
            // 
            CategoriesForm_errorTextLbl.AutoSize = true;
            CategoriesForm_errorTextLbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            CategoriesForm_errorTextLbl.Location = new Point(46, 469);
            CategoriesForm_errorTextLbl.Name = "CategoriesForm_errorTextLbl";
            CategoriesForm_errorTextLbl.Size = new Size(0, 25);
            CategoriesForm_errorTextLbl.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(870, 469);
            label1.Name = "label1";
            label1.Size = new Size(113, 25);
            label1.TabIndex = 19;
            label1.Text = "(*): required";
            // 
            // CategoriesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(CategoriesForm_errorTextLbl);
            Controls.Add(CategoriesForm_AddCategoryBtn);
            Controls.Add(CategoriesForm_IDNumberLbl);
            Controls.Add(CategoriesForm_CategoryInfoLbl);
            Controls.Add(CategoriesForm_IDNumberTxt);
            Controls.Add(CategoriesForm_CategoryInfoTxt);
            Controls.Add(CategoriesForm_NameTxt);
            Controls.Add(CategoriesForm_NameLbl);
            Controls.Add(CategoriesForm_ParentCategoryCbo);
            Controls.Add(CategoriesForm_ParentCategoryLbl);
            Controls.Add(CategoriesForm_HeadingLbl);
            Name = "CategoriesForm";
            Size = new Size(1178, 585);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CategoriesForm_HeadingLbl;
        private Label CategoriesForm_ParentCategoryLbl;
        private ComboBox CategoriesForm_ParentCategoryCbo;
        private Label CategoriesForm_NameLbl;
        private TextBox CategoriesForm_NameTxt;
        private TextBox CategoriesForm_CategoryInfoTxt;
        private TextBox CategoriesForm_IDNumberTxt;
        private Label CategoriesForm_CategoryInfoLbl;
        private Label CategoriesForm_IDNumberLbl;
        private Button CategoriesForm_AddCategoryBtn;
        private Label CategoriesForm_errorTextLbl;
        private Label label1;
    }
}
