﻿namespace Learning_System
{
    partial class QuestionsForm
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
            QuestionsForm_CreateNewQuestionBtn = new Button();
            QuestionsForm_ShowOldQuestionsCb = new CheckBox();
            QuestionsForm_ShowFromSubcategoriesCb = new CheckBox();
            QuestionsForm_Lbl = new Label();
            QuestionsForm_SelectCategoryCbo = new ComboBox();
            QuestionsForm_SelectCategoryLbl = new Label();
            QuestionsForm_QuestionsBankLbl = new Label();
            QuestionForm_ShowQuestionsDtg = new DataGridView();
            CheckBoxes = new DataGridViewCheckBoxColumn();
            QuestionName = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewButtonColumn();
            ID = new DataGridViewTextBoxColumn();
            CheckBox = new DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)QuestionForm_ShowQuestionsDtg).BeginInit();
            SuspendLayout();
            // 
            // QuestionsForm_CreateNewQuestionBtn
            // 
            QuestionsForm_CreateNewQuestionBtn.BackColor = Color.FromArgb(0, 159, 229);
            QuestionsForm_CreateNewQuestionBtn.FlatStyle = FlatStyle.Flat;
            QuestionsForm_CreateNewQuestionBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            QuestionsForm_CreateNewQuestionBtn.ForeColor = Color.White;
            QuestionsForm_CreateNewQuestionBtn.Location = new Point(51, 242);
            QuestionsForm_CreateNewQuestionBtn.Name = "QuestionsForm_CreateNewQuestionBtn";
            QuestionsForm_CreateNewQuestionBtn.Size = new Size(265, 51);
            QuestionsForm_CreateNewQuestionBtn.TabIndex = 13;
            QuestionsForm_CreateNewQuestionBtn.Text = "CREATE A NEW QUESTION";
            QuestionsForm_CreateNewQuestionBtn.UseVisualStyleBackColor = false;
            QuestionsForm_CreateNewQuestionBtn.Click += QuestionsForm_CreateNewQuestionBtn_Click;
            // 
            // QuestionsForm_ShowOldQuestionsCb
            // 
            QuestionsForm_ShowOldQuestionsCb.AutoSize = true;
            QuestionsForm_ShowOldQuestionsCb.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            QuestionsForm_ShowOldQuestionsCb.ForeColor = Color.Black;
            QuestionsForm_ShowOldQuestionsCb.Location = new Point(71, 197);
            QuestionsForm_ShowOldQuestionsCb.Name = "QuestionsForm_ShowOldQuestionsCb";
            QuestionsForm_ShowOldQuestionsCb.Size = new Size(237, 29);
            QuestionsForm_ShowOldQuestionsCb.TabIndex = 12;
            QuestionsForm_ShowOldQuestionsCb.Text = "Also show old questions";
            QuestionsForm_ShowOldQuestionsCb.UseVisualStyleBackColor = true;
            // 
            // QuestionsForm_ShowFromSubcategoriesCb
            // 
            QuestionsForm_ShowFromSubcategoriesCb.AutoSize = true;
            QuestionsForm_ShowFromSubcategoriesCb.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            QuestionsForm_ShowFromSubcategoriesCb.ForeColor = Color.Black;
            QuestionsForm_ShowFromSubcategoriesCb.Location = new Point(72, 165);
            QuestionsForm_ShowFromSubcategoriesCb.Name = "QuestionsForm_ShowFromSubcategoriesCb";
            QuestionsForm_ShowFromSubcategoriesCb.Size = new Size(372, 29);
            QuestionsForm_ShowFromSubcategoriesCb.TabIndex = 11;
            QuestionsForm_ShowFromSubcategoriesCb.Text = "Also show questions from subcategories";
            QuestionsForm_ShowFromSubcategoriesCb.UseVisualStyleBackColor = true;
            QuestionsForm_ShowFromSubcategoriesCb.CheckedChanged += QuestionsForm_ShowFromSubcategoriesCb_CheckedChanged;
            // 
            // QuestionsForm_Lbl
            // 
            QuestionsForm_Lbl.AutoSize = true;
            QuestionsForm_Lbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            QuestionsForm_Lbl.ForeColor = Color.Black;
            QuestionsForm_Lbl.Location = new Point(47, 127);
            QuestionsForm_Lbl.Name = "QuestionsForm_Lbl";
            QuestionsForm_Lbl.Size = new Size(464, 28);
            QuestionsForm_Lbl.TabIndex = 10;
            QuestionsForm_Lbl.Text = "The default category for questions shared in context";
            // 
            // QuestionsForm_SelectCategoryCbo
            // 
            QuestionsForm_SelectCategoryCbo.DrawMode = DrawMode.OwnerDrawFixed;
            QuestionsForm_SelectCategoryCbo.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            QuestionsForm_SelectCategoryCbo.FormattingEnabled = true;
            QuestionsForm_SelectCategoryCbo.Location = new Point(217, 76);
            QuestionsForm_SelectCategoryCbo.Name = "QuestionsForm_SelectCategoryCbo";
            QuestionsForm_SelectCategoryCbo.Size = new Size(332, 33);
            QuestionsForm_SelectCategoryCbo.TabIndex = 9;
            QuestionsForm_SelectCategoryCbo.DropDown += QuestionsForm_SelectCategoryCbo_DropDown;
            QuestionsForm_SelectCategoryCbo.SelectedIndexChanged += QuestionsForm_SelectCategoryCbo_SelectedIndexChanged;
            QuestionsForm_SelectCategoryCbo.Click += QuestionsForm_SelectCategoryCbo_Click;
            // 
            // QuestionsForm_SelectCategoryLbl
            // 
            QuestionsForm_SelectCategoryLbl.AutoSize = true;
            QuestionsForm_SelectCategoryLbl.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            QuestionsForm_SelectCategoryLbl.ForeColor = Color.Black;
            QuestionsForm_SelectCategoryLbl.Location = new Point(47, 79);
            QuestionsForm_SelectCategoryLbl.Name = "QuestionsForm_SelectCategoryLbl";
            QuestionsForm_SelectCategoryLbl.Size = new Size(164, 25);
            QuestionsForm_SelectCategoryLbl.TabIndex = 8;
            QuestionsForm_SelectCategoryLbl.Text = "Select a category :";
            // 
            // QuestionsForm_QuestionsBankLbl
            // 
            QuestionsForm_QuestionsBankLbl.AutoSize = true;
            QuestionsForm_QuestionsBankLbl.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            QuestionsForm_QuestionsBankLbl.ForeColor = Color.FromArgb(194, 36, 36);
            QuestionsForm_QuestionsBankLbl.Location = new Point(40, 21);
            QuestionsForm_QuestionsBankLbl.Name = "QuestionsForm_QuestionsBankLbl";
            QuestionsForm_QuestionsBankLbl.Size = new Size(251, 46);
            QuestionsForm_QuestionsBankLbl.TabIndex = 7;
            QuestionsForm_QuestionsBankLbl.Text = "Questions Bank";
            // 
            // QuestionForm_ShowQuestionsDtg
            // 
            QuestionForm_ShowQuestionsDtg.AllowUserToAddRows = false;
            QuestionForm_ShowQuestionsDtg.AllowUserToDeleteRows = false;
            QuestionForm_ShowQuestionsDtg.AllowUserToResizeColumns = false;
            QuestionForm_ShowQuestionsDtg.AllowUserToResizeRows = false;
            QuestionForm_ShowQuestionsDtg.BackgroundColor = SystemColors.ButtonFace;
            QuestionForm_ShowQuestionsDtg.BorderStyle = BorderStyle.None;
            QuestionForm_ShowQuestionsDtg.CellBorderStyle = DataGridViewCellBorderStyle.None;
            QuestionForm_ShowQuestionsDtg.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            QuestionForm_ShowQuestionsDtg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            QuestionForm_ShowQuestionsDtg.Columns.AddRange(new DataGridViewColumn[] { CheckBoxes, QuestionName, Edit, ID });
            QuestionForm_ShowQuestionsDtg.GridColor = SystemColors.ButtonFace;
            QuestionForm_ShowQuestionsDtg.Location = new Point(51, 337);
            QuestionForm_ShowQuestionsDtg.Name = "QuestionForm_ShowQuestionsDtg";
            QuestionForm_ShowQuestionsDtg.ReadOnly = true;
            QuestionForm_ShowQuestionsDtg.RowHeadersVisible = false;
            QuestionForm_ShowQuestionsDtg.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            QuestionForm_ShowQuestionsDtg.RowTemplate.Height = 29;
            QuestionForm_ShowQuestionsDtg.Size = new Size(1597, 400);
            QuestionForm_ShowQuestionsDtg.TabIndex = 15;
            QuestionForm_ShowQuestionsDtg.CellContentClick += QuestionForm_ShowQuestionsDtg_CellContentClick;
            QuestionForm_ShowQuestionsDtg.CellMouseEnter += QuestionForm_ShowQuestionsDtg_CellMouseEnter;
            QuestionForm_ShowQuestionsDtg.CellMouseLeave += QuestionForm_ShowQuestionsDtg_CellMouseLeave;
            // 
            // CheckBoxes
            // 
            CheckBoxes.HeaderText = "T";
            CheckBoxes.MinimumWidth = 6;
            CheckBoxes.Name = "CheckBoxes";
            CheckBoxes.ReadOnly = true;
            CheckBoxes.Width = 40;
            // 
            // QuestionName
            // 
            QuestionName.HeaderText = "Question";
            QuestionName.MinimumWidth = 6;
            QuestionName.Name = "QuestionName";
            QuestionName.ReadOnly = true;
            QuestionName.SortMode = DataGridViewColumnSortMode.NotSortable;
            QuestionName.Width = 1400;
            // 
            // Edit
            // 
            Edit.HeaderText = "Actions";
            Edit.MinimumWidth = 6;
            Edit.Name = "Edit";
            Edit.ReadOnly = true;
            Edit.Text = "";
            Edit.ToolTipText = "Edit question";
            Edit.Width = 150;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            ID.Width = 125;
            // 
            // CheckBox
            // 
            CheckBox.HeaderText = "T";
            CheckBox.MinimumWidth = 6;
            CheckBox.Name = "CheckBox";
            CheckBox.Width = 125;
            // 
            // QuestionsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(QuestionForm_ShowQuestionsDtg);
            Controls.Add(QuestionsForm_CreateNewQuestionBtn);
            Controls.Add(QuestionsForm_ShowOldQuestionsCb);
            Controls.Add(QuestionsForm_ShowFromSubcategoriesCb);
            Controls.Add(QuestionsForm_Lbl);
            Controls.Add(QuestionsForm_SelectCategoryCbo);
            Controls.Add(QuestionsForm_SelectCategoryLbl);
            Controls.Add(QuestionsForm_QuestionsBankLbl);
            Name = "QuestionsForm";
            Size = new Size(1691, 738);
            ((System.ComponentModel.ISupportInitialize)QuestionForm_ShowQuestionsDtg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button QuestionsForm_CreateNewQuestionBtn;
        private CheckBox QuestionsForm_ShowOldQuestionsCb;
        private CheckBox QuestionsForm_ShowFromSubcategoriesCb;
        private Label QuestionsForm_Lbl;
        private ComboBox QuestionsForm_SelectCategoryCbo;
        private Label QuestionsForm_SelectCategoryLbl;
        private Label QuestionsForm_QuestionsBankLbl;
        private DataGridView QuestionForm_ShowQuestionsDtg;
        private DataGridViewCheckBoxColumn CheckBox;
        private DataGridViewCheckBoxColumn CheckBoxes;
        private DataGridViewTextBoxColumn QuestionName;
        private DataGridViewButtonColumn Edit;
        private DataGridViewTextBoxColumn ID;
    }
}
