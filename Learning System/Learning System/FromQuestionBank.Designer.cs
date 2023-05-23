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
            this.panel1 = new System.Windows.Forms.Panel();
            this.FromQuestionBank_ShowQuestionsDtg = new System.Windows.Forms.DataGridView();
            this.Checkbox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuestionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FromQuestionBank_AddBtn = new System.Windows.Forms.Button();
            this.FromQuestionBank_OldQuestionCbx = new System.Windows.Forms.CheckBox();
            this.FromQuestionBank_SubcategoriesCbx = new System.Windows.Forms.CheckBox();
            this.FromQuestionBank_OptionLbl = new System.Windows.Forms.Label();
            this.FromQuestionBank_SelectCategoryCbo = new System.Windows.Forms.ComboBox();
            this.FromQuestionBank_CategoryLbl = new System.Windows.Forms.Label();
            this.FromQuestionBank_Header = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FromQuestionBank_ShowQuestionsDtg)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.FromQuestionBank_ShowQuestionsDtg);
            this.panel1.Controls.Add(this.FromQuestionBank_AddBtn);
            this.panel1.Controls.Add(this.FromQuestionBank_OldQuestionCbx);
            this.panel1.Controls.Add(this.FromQuestionBank_SubcategoriesCbx);
            this.panel1.Controls.Add(this.FromQuestionBank_OptionLbl);
            this.panel1.Controls.Add(this.FromQuestionBank_SelectCategoryCbo);
            this.panel1.Controls.Add(this.FromQuestionBank_CategoryLbl);
            this.panel1.Controls.Add(this.FromQuestionBank_Header);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1764, 826);
            this.panel1.TabIndex = 0;
            // 
            // FromQuestionBank_ShowQuestionsDtg
            // 
            this.FromQuestionBank_ShowQuestionsDtg.AllowUserToAddRows = false;
            this.FromQuestionBank_ShowQuestionsDtg.AllowUserToOrderColumns = true;
            this.FromQuestionBank_ShowQuestionsDtg.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FromQuestionBank_ShowQuestionsDtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FromQuestionBank_ShowQuestionsDtg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Checkbox,
            this.Content,
            this.QuestionID});
            this.FromQuestionBank_ShowQuestionsDtg.Location = new System.Drawing.Point(18, 489);
            this.FromQuestionBank_ShowQuestionsDtg.Name = "FromQuestionBank_ShowQuestionsDtg";
            this.FromQuestionBank_ShowQuestionsDtg.ReadOnly = true;
            this.FromQuestionBank_ShowQuestionsDtg.RowHeadersWidth = 4;
            this.FromQuestionBank_ShowQuestionsDtg.RowTemplate.Height = 33;
            this.FromQuestionBank_ShowQuestionsDtg.Size = new System.Drawing.Size(1083, 303);
            this.FromQuestionBank_ShowQuestionsDtg.TabIndex = 36;
            // 
            // Checkbox
            // 
            this.Checkbox.HeaderText = "";
            this.Checkbox.MinimumWidth = 8;
            this.Checkbox.Name = "Checkbox";
            this.Checkbox.ReadOnly = true;
            this.Checkbox.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Checkbox.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Checkbox.Width = 60;
            // 
            // Content
            // 
            this.Content.HeaderText = "Câu hỏi";
            this.Content.MinimumWidth = 8;
            this.Content.Name = "Content";
            this.Content.ReadOnly = true;
            this.Content.Width = 1019;
            // 
            // QuestionID
            // 
            this.QuestionID.HeaderText = "QuestionID";
            this.QuestionID.MinimumWidth = 8;
            this.QuestionID.Name = "QuestionID";
            this.QuestionID.ReadOnly = true;
            this.QuestionID.Visible = false;
            this.QuestionID.Width = 150;
            // 
            // FromQuestionBank_AddBtn
            // 
            this.FromQuestionBank_AddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FromQuestionBank_AddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(165)))));
            this.FromQuestionBank_AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FromQuestionBank_AddBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FromQuestionBank_AddBtn.ForeColor = System.Drawing.Color.White;
            this.FromQuestionBank_AddBtn.Location = new System.Drawing.Point(230, 432);
            this.FromQuestionBank_AddBtn.Margin = new System.Windows.Forms.Padding(4);
            this.FromQuestionBank_AddBtn.Name = "FromQuestionBank_AddBtn";
            this.FromQuestionBank_AddBtn.Size = new System.Drawing.Size(472, 50);
            this.FromQuestionBank_AddBtn.TabIndex = 35;
            this.FromQuestionBank_AddBtn.Text = "ADD SELECTED QUESTIONS TO THE QUIZ";
            this.FromQuestionBank_AddBtn.UseVisualStyleBackColor = false;
            this.FromQuestionBank_AddBtn.Click += new System.EventHandler(this.FromQuestionBank_AddBtn_Click_1);
            // 
            // FromQuestionBank_OldQuestionCbx
            // 
            this.FromQuestionBank_OldQuestionCbx.AutoSize = true;
            this.FromQuestionBank_OldQuestionCbx.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FromQuestionBank_OldQuestionCbx.Location = new System.Drawing.Point(18, 312);
            this.FromQuestionBank_OldQuestionCbx.Margin = new System.Windows.Forms.Padding(4);
            this.FromQuestionBank_OldQuestionCbx.Name = "FromQuestionBank_OldQuestionCbx";
            this.FromQuestionBank_OldQuestionCbx.Size = new System.Drawing.Size(263, 34);
            this.FromQuestionBank_OldQuestionCbx.TabIndex = 34;
            this.FromQuestionBank_OldQuestionCbx.Text = "Also show old questions";
            this.FromQuestionBank_OldQuestionCbx.UseVisualStyleBackColor = true;
            // 
            // FromQuestionBank_SubcategoriesCbx
            // 
            this.FromQuestionBank_SubcategoriesCbx.AutoSize = true;
            this.FromQuestionBank_SubcategoriesCbx.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FromQuestionBank_SubcategoriesCbx.Location = new System.Drawing.Point(18, 274);
            this.FromQuestionBank_SubcategoriesCbx.Margin = new System.Windows.Forms.Padding(4);
            this.FromQuestionBank_SubcategoriesCbx.Name = "FromQuestionBank_SubcategoriesCbx";
            this.FromQuestionBank_SubcategoriesCbx.Size = new System.Drawing.Size(412, 34);
            this.FromQuestionBank_SubcategoriesCbx.TabIndex = 33;
            this.FromQuestionBank_SubcategoriesCbx.Text = "Also show questions form subcategories";
            this.FromQuestionBank_SubcategoriesCbx.UseVisualStyleBackColor = true;
            this.FromQuestionBank_SubcategoriesCbx.CheckedChanged += new System.EventHandler(this.FromQuestionBank_SubcategoriesCbx_CheckedChanged);
            // 
            // FromQuestionBank_OptionLbl
            // 
            this.FromQuestionBank_OptionLbl.AutoSize = true;
            this.FromQuestionBank_OptionLbl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FromQuestionBank_OptionLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(171)))), ((int)(((byte)(230)))));
            this.FromQuestionBank_OptionLbl.Location = new System.Drawing.Point(18, 239);
            this.FromQuestionBank_OptionLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FromQuestionBank_OptionLbl.Name = "FromQuestionBank_OptionLbl";
            this.FromQuestionBank_OptionLbl.Size = new System.Drawing.Size(159, 30);
            this.FromQuestionBank_OptionLbl.TabIndex = 32;
            this.FromQuestionBank_OptionLbl.Text = "Search options";
            // 
            // FromQuestionBank_SelectCategoryCbo
            // 
            this.FromQuestionBank_SelectCategoryCbo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FromQuestionBank_SelectCategoryCbo.FormattingEnabled = true;
            this.FromQuestionBank_SelectCategoryCbo.Location = new System.Drawing.Point(205, 113);
            this.FromQuestionBank_SelectCategoryCbo.Margin = new System.Windows.Forms.Padding(4);
            this.FromQuestionBank_SelectCategoryCbo.Name = "FromQuestionBank_SelectCategoryCbo";
            this.FromQuestionBank_SelectCategoryCbo.Size = new System.Drawing.Size(236, 36);
            this.FromQuestionBank_SelectCategoryCbo.TabIndex = 31;
            this.FromQuestionBank_SelectCategoryCbo.SelectedIndexChanged += new System.EventHandler(this.FromQuestionBank_SelectCategoryCbo_SelectedIndexChanged);
            this.FromQuestionBank_SelectCategoryCbo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FromQuestionBank_SelectCategoryCbo_MouseClick);
            // 
            // FromQuestionBank_CategoryLbl
            // 
            this.FromQuestionBank_CategoryLbl.AutoSize = true;
            this.FromQuestionBank_CategoryLbl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FromQuestionBank_CategoryLbl.Location = new System.Drawing.Point(18, 113);
            this.FromQuestionBank_CategoryLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FromQuestionBank_CategoryLbl.Name = "FromQuestionBank_CategoryLbl";
            this.FromQuestionBank_CategoryLbl.Size = new System.Drawing.Size(176, 30);
            this.FromQuestionBank_CategoryLbl.TabIndex = 30;
            this.FromQuestionBank_CategoryLbl.Text = "Select a category:";
            // 
            // FromQuestionBank_Header
            // 
            this.FromQuestionBank_Header.AutoSize = true;
            this.FromQuestionBank_Header.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FromQuestionBank_Header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.FromQuestionBank_Header.Location = new System.Drawing.Point(4, 9);
            this.FromQuestionBank_Header.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FromQuestionBank_Header.Name = "FromQuestionBank_Header";
            this.FromQuestionBank_Header.Size = new System.Drawing.Size(875, 70);
            this.FromQuestionBank_Header.TabIndex = 29;
            this.FromQuestionBank_Header.Text = "Add from a question bank at the end";
            // 
            // FromQuestionBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FromQuestionBank";
            this.Size = new System.Drawing.Size(1764, 826);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FromQuestionBank_ShowQuestionsDtg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private DataGridView FromQuestionBank_ShowQuestionsDtg;
        private DataGridViewCheckBoxColumn Checkbox;
        private DataGridViewTextBoxColumn Content;
        private DataGridViewTextBoxColumn QuestionID;
        private Button FromQuestionBank_AddBtn;
        private CheckBox FromQuestionBank_OldQuestionCbx;
        private CheckBox FromQuestionBank_SubcategoriesCbx;
        private Label FromQuestionBank_OptionLbl;
        private ComboBox FromQuestionBank_SelectCategoryCbo;
        private Label FromQuestionBank_CategoryLbl;
        private Label FromQuestionBank_Header;
    }
}
