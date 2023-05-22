namespace Learning_System
{
    partial class FromQuestionBank
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
            FromQuestionBank_Header = new Label();
            FromQuestionBank_CategoryLbl = new Label();
            FromQuestionBank_CategoryCbo = new ComboBox();
            FromQuestionBank_OptionLbl = new Label();
            FromQuestionBank_SubcategoriesCbx = new CheckBox();
            FromQuestionBank_OldQuestionCbx = new CheckBox();
            FromQuestionBank_AddBtn = new Button();
            SuspendLayout();
            // 
            // FromQuestionBank_Header
            // 
            FromQuestionBank_Header.AutoSize = true;
            FromQuestionBank_Header.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            FromQuestionBank_Header.ForeColor = Color.FromArgb(194, 36, 36);
            FromQuestionBank_Header.Location = new Point(3, 5);
            FromQuestionBank_Header.Name = "FromQuestionBank_Header";
            FromQuestionBank_Header.Size = new Size(743, 60);
            FromQuestionBank_Header.TabIndex = 17;
            FromQuestionBank_Header.Text = "Add from a question bank at the end";
            // 
            // FromQuestionBank_CategoryLbl
            // 
            FromQuestionBank_CategoryLbl.AutoSize = true;
            FromQuestionBank_CategoryLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            FromQuestionBank_CategoryLbl.Location = new Point(14, 88);
            FromQuestionBank_CategoryLbl.Name = "FromQuestionBank_CategoryLbl";
            FromQuestionBank_CategoryLbl.Size = new Size(144, 23);
            FromQuestionBank_CategoryLbl.TabIndex = 18;
            FromQuestionBank_CategoryLbl.Text = "Select a category:";
            // 
            // FromQuestionBank_CategoryCbo
            // 
            FromQuestionBank_CategoryCbo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            FromQuestionBank_CategoryCbo.FormattingEnabled = true;
            FromQuestionBank_CategoryCbo.Location = new Point(164, 88);
            FromQuestionBank_CategoryCbo.Name = "FromQuestionBank_CategoryCbo";
            FromQuestionBank_CategoryCbo.Size = new Size(190, 31);
            FromQuestionBank_CategoryCbo.TabIndex = 19;
            // 
            // FromQuestionBank_OptionLbl
            // 
            FromQuestionBank_OptionLbl.AutoSize = true;
            FromQuestionBank_OptionLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            FromQuestionBank_OptionLbl.ForeColor = Color.FromArgb(44, 171, 230);
            FromQuestionBank_OptionLbl.Location = new Point(14, 189);
            FromQuestionBank_OptionLbl.Name = "FromQuestionBank_OptionLbl";
            FromQuestionBank_OptionLbl.Size = new Size(128, 23);
            FromQuestionBank_OptionLbl.TabIndex = 20;
            FromQuestionBank_OptionLbl.Text = "Search options";
            // 
            // FromQuestionBank_SubcategoriesCbx
            // 
            FromQuestionBank_SubcategoriesCbx.AutoSize = true;
            FromQuestionBank_SubcategoriesCbx.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            FromQuestionBank_SubcategoriesCbx.Location = new Point(14, 217);
            FromQuestionBank_SubcategoriesCbx.Name = "FromQuestionBank_SubcategoriesCbx";
            FromQuestionBank_SubcategoriesCbx.Size = new Size(337, 27);
            FromQuestionBank_SubcategoriesCbx.TabIndex = 25;
            FromQuestionBank_SubcategoriesCbx.Text = "Also show questions form subcategories";
            FromQuestionBank_SubcategoriesCbx.UseVisualStyleBackColor = true;
            // 
            // FromQuestionBank_OldQuestionCbx
            // 
            FromQuestionBank_OldQuestionCbx.AutoSize = true;
            FromQuestionBank_OldQuestionCbx.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            FromQuestionBank_OldQuestionCbx.Location = new Point(14, 247);
            FromQuestionBank_OldQuestionCbx.Name = "FromQuestionBank_OldQuestionCbx";
            FromQuestionBank_OldQuestionCbx.Size = new Size(215, 27);
            FromQuestionBank_OldQuestionCbx.TabIndex = 26;
            FromQuestionBank_OldQuestionCbx.Text = "Also show old questions";
            FromQuestionBank_OldQuestionCbx.UseVisualStyleBackColor = true;
            // 
            // FromQuestionBank_AddBtn
            // 
            FromQuestionBank_AddBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            FromQuestionBank_AddBtn.BackColor = Color.FromArgb(0, 115, 165);
            FromQuestionBank_AddBtn.FlatStyle = FlatStyle.Flat;
            FromQuestionBank_AddBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FromQuestionBank_AddBtn.ForeColor = Color.White;
            FromQuestionBank_AddBtn.Location = new Point(14, 601);
            FromQuestionBank_AddBtn.Name = "FromQuestionBank_AddBtn";
            FromQuestionBank_AddBtn.Size = new Size(378, 40);
            FromQuestionBank_AddBtn.TabIndex = 27;
            FromQuestionBank_AddBtn.Text = "ADD SELECTED QUESTIONS TO THE QUIZ";
            FromQuestionBank_AddBtn.UseVisualStyleBackColor = false;
            FromQuestionBank_AddBtn.Click += FromQuestionBank_AddBtn_Click;
            // 
            // FromQuestionBank
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(FromQuestionBank_AddBtn);
            Controls.Add(FromQuestionBank_OldQuestionCbx);
            Controls.Add(FromQuestionBank_SubcategoriesCbx);
            Controls.Add(FromQuestionBank_OptionLbl);
            Controls.Add(FromQuestionBank_CategoryCbo);
            Controls.Add(FromQuestionBank_CategoryLbl);
            Controls.Add(FromQuestionBank_Header);
            Name = "FromQuestionBank";
            Size = new Size(1411, 661);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label FromQuestionBank_Header;
        private Label FromQuestionBank_CategoryLbl;
        private ComboBox FromQuestionBank_CategoryCbo;
        private Label FromQuestionBank_OptionLbl;
        private CheckBox FromQuestionBank_SubcategoriesCbx;
        private CheckBox FromQuestionBank_OldQuestionCbx;
        private Button FromQuestionBank_AddBtn;
    }
}
