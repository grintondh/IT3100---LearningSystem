namespace Learning_System
{
    partial class RandomQuestion
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
            RandomQuestion_Header = new Label();
            RandomQuestion_CategoryLbl = new Label();
            RandomQuestion_CategoryCbo = new ComboBox();
            RandomQuestion_SubcategoriesCbx = new CheckBox();
            RandomQuestion_NumberOfQuestionLbl = new Label();
            RandomQuestion_AddBtn = new Button();
            SuspendLayout();
            // 
            // RandomQuestion_Header
            // 
            RandomQuestion_Header.AutoSize = true;
            RandomQuestion_Header.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            RandomQuestion_Header.ForeColor = Color.FromArgb(194, 36, 36);
            RandomQuestion_Header.Location = new Point(3, 10);
            RandomQuestion_Header.Name = "RandomQuestion_Header";
            RandomQuestion_Header.Size = new Size(470, 60);
            RandomQuestion_Header.TabIndex = 18;
            RandomQuestion_Header.Text = "Add random questions";
            // 
            // RandomQuestion_CategoryLbl
            // 
            RandomQuestion_CategoryLbl.AutoSize = true;
            RandomQuestion_CategoryLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            RandomQuestion_CategoryLbl.Location = new Point(13, 79);
            RandomQuestion_CategoryLbl.Name = "RandomQuestion_CategoryLbl";
            RandomQuestion_CategoryLbl.Size = new Size(79, 23);
            RandomQuestion_CategoryLbl.TabIndex = 19;
            RandomQuestion_CategoryLbl.Text = "Category";
            // 
            // RandomQuestion_CategoryCbo
            // 
            RandomQuestion_CategoryCbo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            RandomQuestion_CategoryCbo.FormattingEnabled = true;
            RandomQuestion_CategoryCbo.Location = new Point(283, 79);
            RandomQuestion_CategoryCbo.Name = "RandomQuestion_CategoryCbo";
            RandomQuestion_CategoryCbo.Size = new Size(190, 31);
            RandomQuestion_CategoryCbo.TabIndex = 20;
            RandomQuestion_CategoryCbo.SelectedIndexChanged += RandomQuestion_CategoryCbo_SelectedIndexChanged;
            RandomQuestion_CategoryCbo.Click += RandomQuestion_CategoryCbo_Click;
            // 
            // RandomQuestion_SubcategoriesCbx
            // 
            RandomQuestion_SubcategoriesCbx.AutoSize = true;
            RandomQuestion_SubcategoriesCbx.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            RandomQuestion_SubcategoriesCbx.Location = new Point(283, 124);
            RandomQuestion_SubcategoriesCbx.Name = "RandomQuestion_SubcategoriesCbx";
            RandomQuestion_SubcategoriesCbx.Size = new Size(348, 27);
            RandomQuestion_SubcategoriesCbx.TabIndex = 26;
            RandomQuestion_SubcategoriesCbx.Text = "Include questions from subcategories too";
            RandomQuestion_SubcategoriesCbx.UseVisualStyleBackColor = true;
            // 
            // RandomQuestion_NumberOfQuestionLbl
            // 
            RandomQuestion_NumberOfQuestionLbl.AutoSize = true;
            RandomQuestion_NumberOfQuestionLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            RandomQuestion_NumberOfQuestionLbl.Location = new Point(13, 327);
            RandomQuestion_NumberOfQuestionLbl.Name = "RandomQuestion_NumberOfQuestionLbl";
            RandomQuestion_NumberOfQuestionLbl.Size = new Size(236, 23);
            RandomQuestion_NumberOfQuestionLbl.TabIndex = 27;
            RandomQuestion_NumberOfQuestionLbl.Text = "Number of random questions";
            // 
            // RandomQuestion_AddBtn
            // 
            RandomQuestion_AddBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RandomQuestion_AddBtn.BackColor = Color.FromArgb(0, 115, 165);
            RandomQuestion_AddBtn.FlatStyle = FlatStyle.Flat;
            RandomQuestion_AddBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RandomQuestion_AddBtn.ForeColor = Color.White;
            RandomQuestion_AddBtn.Location = new Point(13, 568);
            RandomQuestion_AddBtn.Name = "RandomQuestion_AddBtn";
            RandomQuestion_AddBtn.Size = new Size(393, 40);
            RandomQuestion_AddBtn.TabIndex = 28;
            RandomQuestion_AddBtn.Text = "ADD RANDOM QUESTIONS TO THE QUIZ";
            RandomQuestion_AddBtn.UseVisualStyleBackColor = false;
            RandomQuestion_AddBtn.Click += RandomQuestion_AddBtn_Click;
            // 
            // RandomQuestion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(RandomQuestion_AddBtn);
            Controls.Add(RandomQuestion_NumberOfQuestionLbl);
            Controls.Add(RandomQuestion_SubcategoriesCbx);
            Controls.Add(RandomQuestion_CategoryCbo);
            Controls.Add(RandomQuestion_CategoryLbl);
            Controls.Add(RandomQuestion_Header);
            Name = "RandomQuestion";
            Size = new Size(1428, 623);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label RandomQuestion_Header;
        private Label RandomQuestion_CategoryLbl;
        private ComboBox RandomQuestion_CategoryCbo;
        private CheckBox RandomQuestion_SubcategoriesCbx;
        private Label RandomQuestion_NumberOfQuestionLbl;
        private Button RandomQuestion_AddBtn;
    }
}
