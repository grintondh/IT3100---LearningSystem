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
            this.CategoriesForm_HeadingLbl = new System.Windows.Forms.Label();
            this.CategoriesForm_ParentCategoryLbl = new System.Windows.Forms.Label();
            this.CategoriesForm_ParentCategoryCbo = new System.Windows.Forms.ComboBox();
            this.CategoriesForm_NameLbl = new System.Windows.Forms.Label();
            this.CategoriesForm_NameTxt = new System.Windows.Forms.TextBox();
            this.CategoriesForm_CategoryInfoTxt = new System.Windows.Forms.TextBox();
            this.CategoriesForm_IDNumberTxt = new System.Windows.Forms.TextBox();
            this.CategoriesForm_CategoryInfoLbl = new System.Windows.Forms.Label();
            this.CategoriesForm_IDNumberLbl = new System.Windows.Forms.Label();
            this.CategoriesForm_AddCategoryBtn = new System.Windows.Forms.Button();
            this.CategoriesForm_errorTextLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CategoriesForm_HeadingLbl
            // 
            this.CategoriesForm_HeadingLbl.AutoSize = true;
            this.CategoriesForm_HeadingLbl.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CategoriesForm_HeadingLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.CategoriesForm_HeadingLbl.Location = new System.Drawing.Point(52, 24);
            this.CategoriesForm_HeadingLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CategoriesForm_HeadingLbl.Name = "CategoriesForm_HeadingLbl";
            this.CategoriesForm_HeadingLbl.Size = new System.Drawing.Size(268, 54);
            this.CategoriesForm_HeadingLbl.TabIndex = 0;
            this.CategoriesForm_HeadingLbl.Text = "Add Category";
            // 
            // CategoriesForm_ParentCategoryLbl
            // 
            this.CategoriesForm_ParentCategoryLbl.AutoSize = true;
            this.CategoriesForm_ParentCategoryLbl.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CategoriesForm_ParentCategoryLbl.Location = new System.Drawing.Point(58, 110);
            this.CategoriesForm_ParentCategoryLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CategoriesForm_ParentCategoryLbl.Name = "CategoriesForm_ParentCategoryLbl";
            this.CategoriesForm_ParentCategoryLbl.Size = new System.Drawing.Size(198, 30);
            this.CategoriesForm_ParentCategoryLbl.TabIndex = 1;
            this.CategoriesForm_ParentCategoryLbl.Text = "Parent Category (*)";
            // 
            // CategoriesForm_ParentCategoryCbo
            // 
            this.CategoriesForm_ParentCategoryCbo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CategoriesForm_ParentCategoryCbo.FormattingEnabled = true;
            this.CategoriesForm_ParentCategoryCbo.IntegralHeight = false;
            this.CategoriesForm_ParentCategoryCbo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.CategoriesForm_ParentCategoryCbo.Location = new System.Drawing.Point(328, 106);
            this.CategoriesForm_ParentCategoryCbo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CategoriesForm_ParentCategoryCbo.Name = "CategoriesForm_ParentCategoryCbo";
            this.CategoriesForm_ParentCategoryCbo.Size = new System.Drawing.Size(900, 38);
            this.CategoriesForm_ParentCategoryCbo.TabIndex = 2;
            // 
            // CategoriesForm_NameLbl
            // 
            this.CategoriesForm_NameLbl.AutoSize = true;
            this.CategoriesForm_NameLbl.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CategoriesForm_NameLbl.Location = new System.Drawing.Point(56, 182);
            this.CategoriesForm_NameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CategoriesForm_NameLbl.Name = "CategoriesForm_NameLbl";
            this.CategoriesForm_NameLbl.Size = new System.Drawing.Size(100, 30);
            this.CategoriesForm_NameLbl.TabIndex = 3;
            this.CategoriesForm_NameLbl.Text = "Name (*)";
            // 
            // CategoriesForm_NameTxt
            // 
            this.CategoriesForm_NameTxt.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CategoriesForm_NameTxt.Location = new System.Drawing.Point(328, 179);
            this.CategoriesForm_NameTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CategoriesForm_NameTxt.Name = "CategoriesForm_NameTxt";
            this.CategoriesForm_NameTxt.Size = new System.Drawing.Size(900, 37);
            this.CategoriesForm_NameTxt.TabIndex = 4;
            // 
            // CategoriesForm_CategoryInfoTxt
            // 
            this.CategoriesForm_CategoryInfoTxt.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CategoriesForm_CategoryInfoTxt.Location = new System.Drawing.Point(328, 266);
            this.CategoriesForm_CategoryInfoTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CategoriesForm_CategoryInfoTxt.MaxLength = 100;
            this.CategoriesForm_CategoryInfoTxt.Multiline = true;
            this.CategoriesForm_CategoryInfoTxt.Name = "CategoriesForm_CategoryInfoTxt";
            this.CategoriesForm_CategoryInfoTxt.Size = new System.Drawing.Size(900, 203);
            this.CategoriesForm_CategoryInfoTxt.TabIndex = 5;
            // 
            // CategoriesForm_IDNumberTxt
            // 
            this.CategoriesForm_IDNumberTxt.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CategoriesForm_IDNumberTxt.Location = new System.Drawing.Point(328, 521);
            this.CategoriesForm_IDNumberTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CategoriesForm_IDNumberTxt.Name = "CategoriesForm_IDNumberTxt";
            this.CategoriesForm_IDNumberTxt.Size = new System.Drawing.Size(900, 37);
            this.CategoriesForm_IDNumberTxt.TabIndex = 6;
            // 
            // CategoriesForm_CategoryInfoLbl
            // 
            this.CategoriesForm_CategoryInfoLbl.AutoSize = true;
            this.CategoriesForm_CategoryInfoLbl.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CategoriesForm_CategoryInfoLbl.Location = new System.Drawing.Point(56, 270);
            this.CategoriesForm_CategoryInfoLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CategoriesForm_CategoryInfoLbl.Name = "CategoriesForm_CategoryInfoLbl";
            this.CategoriesForm_CategoryInfoLbl.Size = new System.Drawing.Size(145, 30);
            this.CategoriesForm_CategoryInfoLbl.TabIndex = 7;
            this.CategoriesForm_CategoryInfoLbl.Text = "Category info";
            // 
            // CategoriesForm_IDNumberLbl
            // 
            this.CategoriesForm_IDNumberLbl.AutoSize = true;
            this.CategoriesForm_IDNumberLbl.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CategoriesForm_IDNumberLbl.Location = new System.Drawing.Point(56, 525);
            this.CategoriesForm_IDNumberLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CategoriesForm_IDNumberLbl.Name = "CategoriesForm_IDNumberLbl";
            this.CategoriesForm_IDNumberLbl.Size = new System.Drawing.Size(145, 30);
            this.CategoriesForm_IDNumberLbl.TabIndex = 8;
            this.CategoriesForm_IDNumberLbl.Text = "ID number (*)";
            // 
            // CategoriesForm_AddCategoryBtn
            // 
            this.CategoriesForm_AddCategoryBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.CategoriesForm_AddCategoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CategoriesForm_AddCategoryBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CategoriesForm_AddCategoryBtn.ForeColor = System.Drawing.Color.White;
            this.CategoriesForm_AddCategoryBtn.Location = new System.Drawing.Point(636, 658);
            this.CategoriesForm_AddCategoryBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CategoriesForm_AddCategoryBtn.Name = "CategoriesForm_AddCategoryBtn";
            this.CategoriesForm_AddCategoryBtn.Size = new System.Drawing.Size(231, 64);
            this.CategoriesForm_AddCategoryBtn.TabIndex = 9;
            this.CategoriesForm_AddCategoryBtn.Text = "ADD CATEGORY";
            this.CategoriesForm_AddCategoryBtn.UseVisualStyleBackColor = false;
            // 
            // CategoriesForm_errorTextLbl
            // 
            this.CategoriesForm_errorTextLbl.AutoSize = true;
            this.CategoriesForm_errorTextLbl.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CategoriesForm_errorTextLbl.Location = new System.Drawing.Point(58, 586);
            this.CategoriesForm_errorTextLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CategoriesForm_errorTextLbl.Name = "CategoriesForm_errorTextLbl";
            this.CategoriesForm_errorTextLbl.Size = new System.Drawing.Size(0, 30);
            this.CategoriesForm_errorTextLbl.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(1088, 586);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 30);
            this.label1.TabIndex = 19;
            this.label1.Text = "(*): required";
            // 
            // CategoriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CategoriesForm_errorTextLbl);
            this.Controls.Add(this.CategoriesForm_AddCategoryBtn);
            this.Controls.Add(this.CategoriesForm_IDNumberLbl);
            this.Controls.Add(this.CategoriesForm_CategoryInfoLbl);
            this.Controls.Add(this.CategoriesForm_IDNumberTxt);
            this.Controls.Add(this.CategoriesForm_CategoryInfoTxt);
            this.Controls.Add(this.CategoriesForm_NameTxt);
            this.Controls.Add(this.CategoriesForm_NameLbl);
            this.Controls.Add(this.CategoriesForm_ParentCategoryCbo);
            this.Controls.Add(this.CategoriesForm_ParentCategoryLbl);
            this.Controls.Add(this.CategoriesForm_HeadingLbl);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CategoriesForm";
            this.Size = new System.Drawing.Size(1472, 731);
            this.ResumeLayout(false);
            this.PerformLayout();

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
