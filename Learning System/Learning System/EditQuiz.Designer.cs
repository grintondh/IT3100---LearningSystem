﻿namespace Learning_System
{
    partial class EditQuiz
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
            panel_edit = new Panel();
            flowLayoutPanel_popup = new FlowLayoutPanel();
            EditForm_NewQuestionBtn = new Button();
            EditQuiz_BankBtn = new Button();
            EditQuiz_RandomBtn = new Button();
            EditQuiz_AddBtn = new Button();
            EditQuiz_ShuffleCbx = new CheckBox();
            EditQuiz_TotalofMarkLbl = new Label();
            EditQuiz_MaxGradeTxt = new TextBox();
            EditQuiz_SaveBtn = new Button();
            EditQuiz_MaxGradeLbl = new Label();
            EditQuiz_MultipleItemsBtn = new Button();
            EditQuiz_RepaginateBtn = new Button();
            EditQuiz_NumberofQuestionLbl = new Label();
            EditQuiz_ContestNameLbl = new Label();
            randomQuestion = new RandomQuestion();
            fromQuestionBank = new FromQuestionBank();
            panel_edit.SuspendLayout();
            flowLayoutPanel_popup.SuspendLayout();
            SuspendLayout();
            // 
            // panel_edit
            // 
            panel_edit.Controls.Add(flowLayoutPanel_popup);
            panel_edit.Controls.Add(EditQuiz_AddBtn);
            panel_edit.Controls.Add(EditQuiz_ShuffleCbx);
            panel_edit.Controls.Add(EditQuiz_TotalofMarkLbl);
            panel_edit.Controls.Add(EditQuiz_MaxGradeTxt);
            panel_edit.Controls.Add(EditQuiz_SaveBtn);
            panel_edit.Controls.Add(EditQuiz_MaxGradeLbl);
            panel_edit.Controls.Add(EditQuiz_MultipleItemsBtn);
            panel_edit.Controls.Add(EditQuiz_RepaginateBtn);
            panel_edit.Controls.Add(EditQuiz_NumberofQuestionLbl);
            panel_edit.Controls.Add(EditQuiz_ContestNameLbl);
            panel_edit.Dock = DockStyle.Fill;
            panel_edit.Location = new Point(0, 0);
            panel_edit.Name = "panel_edit";
            panel_edit.Size = new Size(1379, 651);
            panel_edit.TabIndex = 0;
            // 
            // flowLayoutPanel_popup
            // 
            flowLayoutPanel_popup.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            flowLayoutPanel_popup.Controls.Add(EditForm_NewQuestionBtn);
            flowLayoutPanel_popup.Controls.Add(EditQuiz_BankBtn);
            flowLayoutPanel_popup.Controls.Add(EditQuiz_RandomBtn);
            flowLayoutPanel_popup.Location = new Point(1146, 258);
            flowLayoutPanel_popup.Name = "flowLayoutPanel_popup";
            flowLayoutPanel_popup.Size = new Size(217, 139);
            flowLayoutPanel_popup.TabIndex = 26;
            flowLayoutPanel_popup.Visible = false;
            // 
            // EditForm_NewQuestionBtn
            // 
            EditForm_NewQuestionBtn.FlatAppearance.BorderSize = 0;
            EditForm_NewQuestionBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            EditForm_NewQuestionBtn.FlatStyle = FlatStyle.Flat;
            EditForm_NewQuestionBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EditForm_NewQuestionBtn.ForeColor = Color.FromArgb(44, 171, 230);
            EditForm_NewQuestionBtn.Location = new Point(3, 3);
            EditForm_NewQuestionBtn.Name = "EditForm_NewQuestionBtn";
            EditForm_NewQuestionBtn.Size = new Size(210, 39);
            EditForm_NewQuestionBtn.TabIndex = 5;
            EditForm_NewQuestionBtn.Text = "a new question";
            EditForm_NewQuestionBtn.UseVisualStyleBackColor = true;
            // 
            // EditQuiz_BankBtn
            // 
            EditQuiz_BankBtn.FlatAppearance.BorderSize = 0;
            EditQuiz_BankBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            EditQuiz_BankBtn.FlatStyle = FlatStyle.Flat;
            EditQuiz_BankBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EditQuiz_BankBtn.ForeColor = Color.FromArgb(44, 171, 230);
            EditQuiz_BankBtn.Location = new Point(3, 48);
            EditQuiz_BankBtn.Name = "EditQuiz_BankBtn";
            EditQuiz_BankBtn.Size = new Size(210, 39);
            EditQuiz_BankBtn.TabIndex = 6;
            EditQuiz_BankBtn.Text = "from question bank";
            EditQuiz_BankBtn.UseVisualStyleBackColor = true;
            EditQuiz_BankBtn.Click += EditQuiz_BankBtn_Click;
            // 
            // EditQuiz_RandomBtn
            // 
            EditQuiz_RandomBtn.FlatAppearance.BorderSize = 0;
            EditQuiz_RandomBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            EditQuiz_RandomBtn.FlatStyle = FlatStyle.Flat;
            EditQuiz_RandomBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EditQuiz_RandomBtn.ForeColor = Color.FromArgb(44, 171, 230);
            EditQuiz_RandomBtn.Location = new Point(3, 93);
            EditQuiz_RandomBtn.Name = "EditQuiz_RandomBtn";
            EditQuiz_RandomBtn.Size = new Size(210, 39);
            EditQuiz_RandomBtn.TabIndex = 7;
            EditQuiz_RandomBtn.Text = "a random question";
            EditQuiz_RandomBtn.UseVisualStyleBackColor = true;
            EditQuiz_RandomBtn.Click += EditQuiz_RandomBtn_Click;
            // 
            // EditQuiz_AddBtn
            // 
            EditQuiz_AddBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            EditQuiz_AddBtn.BackColor = SystemColors.Control;
            EditQuiz_AddBtn.FlatAppearance.BorderColor = SystemColors.Control;
            EditQuiz_AddBtn.FlatStyle = FlatStyle.Flat;
            EditQuiz_AddBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            EditQuiz_AddBtn.ForeColor = Color.FromArgb(44, 171, 230);
            EditQuiz_AddBtn.Location = new Point(1297, 221);
            EditQuiz_AddBtn.Name = "EditQuiz_AddBtn";
            EditQuiz_AddBtn.Size = new Size(66, 31);
            EditQuiz_AddBtn.TabIndex = 25;
            EditQuiz_AddBtn.Text = "Add";
            EditQuiz_AddBtn.UseVisualStyleBackColor = false;
            EditQuiz_AddBtn.Click += EditQuiz_AddBtn_Click;
            // 
            // EditQuiz_ShuffleCbx
            // 
            EditQuiz_ShuffleCbx.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            EditQuiz_ShuffleCbx.AutoSize = true;
            EditQuiz_ShuffleCbx.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            EditQuiz_ShuffleCbx.Location = new Point(1279, 179);
            EditQuiz_ShuffleCbx.Name = "EditQuiz_ShuffleCbx";
            EditQuiz_ShuffleCbx.Size = new Size(84, 27);
            EditQuiz_ShuffleCbx.TabIndex = 24;
            EditQuiz_ShuffleCbx.Text = "Shuffle";
            EditQuiz_ShuffleCbx.UseVisualStyleBackColor = true;
            // 
            // EditQuiz_TotalofMarkLbl
            // 
            EditQuiz_TotalofMarkLbl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            EditQuiz_TotalofMarkLbl.AutoSize = true;
            EditQuiz_TotalofMarkLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            EditQuiz_TotalofMarkLbl.Location = new Point(1214, 126);
            EditQuiz_TotalofMarkLbl.Name = "EditQuiz_TotalofMarkLbl";
            EditQuiz_TotalofMarkLbl.Size = new Size(149, 23);
            EditQuiz_TotalofMarkLbl.TabIndex = 23;
            EditQuiz_TotalofMarkLbl.Text = "Total of mark: 0.00";
            // 
            // EditQuiz_MaxGradeTxt
            // 
            EditQuiz_MaxGradeTxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            EditQuiz_MaxGradeTxt.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            EditQuiz_MaxGradeTxt.Location = new Point(1176, 73);
            EditQuiz_MaxGradeTxt.Name = "EditQuiz_MaxGradeTxt";
            EditQuiz_MaxGradeTxt.Size = new Size(84, 30);
            EditQuiz_MaxGradeTxt.TabIndex = 22;
            EditQuiz_MaxGradeTxt.Text = "10.00";
            EditQuiz_MaxGradeTxt.TextAlign = HorizontalAlignment.Center;
            // 
            // EditQuiz_SaveBtn
            // 
            EditQuiz_SaveBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            EditQuiz_SaveBtn.BackColor = Color.FromArgb(0, 159, 229);
            EditQuiz_SaveBtn.FlatStyle = FlatStyle.Flat;
            EditQuiz_SaveBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EditQuiz_SaveBtn.ForeColor = Color.White;
            EditQuiz_SaveBtn.Location = new Point(1278, 63);
            EditQuiz_SaveBtn.Name = "EditQuiz_SaveBtn";
            EditQuiz_SaveBtn.Size = new Size(85, 48);
            EditQuiz_SaveBtn.TabIndex = 21;
            EditQuiz_SaveBtn.Text = "SAVE";
            EditQuiz_SaveBtn.UseVisualStyleBackColor = false;
            EditQuiz_SaveBtn.Click += EditQuiz_SaveBtn_Click;
            // 
            // EditQuiz_MaxGradeLbl
            // 
            EditQuiz_MaxGradeLbl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            EditQuiz_MaxGradeLbl.AutoSize = true;
            EditQuiz_MaxGradeLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            EditQuiz_MaxGradeLbl.Location = new Point(1035, 76);
            EditQuiz_MaxGradeLbl.Name = "EditQuiz_MaxGradeLbl";
            EditQuiz_MaxGradeLbl.Size = new Size(135, 23);
            EditQuiz_MaxGradeLbl.TabIndex = 20;
            EditQuiz_MaxGradeLbl.Text = "Maximum grade";
            // 
            // EditQuiz_MultipleItemsBtn
            // 
            EditQuiz_MultipleItemsBtn.BackColor = Color.FromArgb(0, 159, 229);
            EditQuiz_MultipleItemsBtn.FlatStyle = FlatStyle.Flat;
            EditQuiz_MultipleItemsBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            EditQuiz_MultipleItemsBtn.ForeColor = Color.White;
            EditQuiz_MultipleItemsBtn.Location = new Point(286, 116);
            EditQuiz_MultipleItemsBtn.Name = "EditQuiz_MultipleItemsBtn";
            EditQuiz_MultipleItemsBtn.Size = new Size(285, 54);
            EditQuiz_MultipleItemsBtn.TabIndex = 19;
            EditQuiz_MultipleItemsBtn.Text = "SELECT MULTIPLE ITEMS";
            EditQuiz_MultipleItemsBtn.UseVisualStyleBackColor = false;
            // 
            // EditQuiz_RepaginateBtn
            // 
            EditQuiz_RepaginateBtn.BackColor = Color.FromArgb(0, 159, 229);
            EditQuiz_RepaginateBtn.FlatStyle = FlatStyle.Flat;
            EditQuiz_RepaginateBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            EditQuiz_RepaginateBtn.ForeColor = Color.White;
            EditQuiz_RepaginateBtn.Location = new Point(14, 116);
            EditQuiz_RepaginateBtn.Name = "EditQuiz_RepaginateBtn";
            EditQuiz_RepaginateBtn.Size = new Size(266, 54);
            EditQuiz_RepaginateBtn.TabIndex = 18;
            EditQuiz_RepaginateBtn.Text = "REPAGINATE";
            EditQuiz_RepaginateBtn.UseVisualStyleBackColor = false;
            // 
            // EditQuiz_NumberofQuestionLbl
            // 
            EditQuiz_NumberofQuestionLbl.AutoSize = true;
            EditQuiz_NumberofQuestionLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            EditQuiz_NumberofQuestionLbl.Location = new Point(14, 76);
            EditQuiz_NumberofQuestionLbl.Name = "EditQuiz_NumberofQuestionLbl";
            EditQuiz_NumberofQuestionLbl.Size = new Size(238, 23);
            EditQuiz_NumberofQuestionLbl.TabIndex = 17;
            EditQuiz_NumberofQuestionLbl.Text = "Question: 0 | This quiz is open";
            // 
            // EditQuiz_ContestNameLbl
            // 
            EditQuiz_ContestNameLbl.AutoSize = true;
            EditQuiz_ContestNameLbl.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            EditQuiz_ContestNameLbl.ForeColor = Color.FromArgb(194, 36, 36);
            EditQuiz_ContestNameLbl.Location = new Point(3, 5);
            EditQuiz_ContestNameLbl.Name = "EditQuiz_ContestNameLbl";
            EditQuiz_ContestNameLbl.Size = new Size(859, 60);
            EditQuiz_ContestNameLbl.TabIndex = 16;
            EditQuiz_ContestNameLbl.Text = "Editing Quiz: Thi giữa kỳ 2 môn Công nghệ";
            // 
            // randomQuestion
            // 
            randomQuestion.Dock = DockStyle.Fill;
            randomQuestion.Location = new Point(0, 0);
            randomQuestion.Name = "randomQuestion";
            randomQuestion.Size = new Size(1379, 651);
            randomQuestion.TabIndex = 27;
            // 
            // fromQuestionBank
            // 
            fromQuestionBank.Dock = DockStyle.Fill;
            fromQuestionBank.Location = new Point(0, 0);
            fromQuestionBank.Name = "fromQuestionBank";
            fromQuestionBank.Size = new Size(1379, 651);
            fromQuestionBank.TabIndex = 27;
            // 
            // EditQuiz
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel_edit);
            Controls.Add(fromQuestionBank);
            Controls.Add(randomQuestion);
            Name = "EditQuiz";
            Size = new Size(1379, 651);
            panel_edit.ResumeLayout(false);
            panel_edit.PerformLayout();
            flowLayoutPanel_popup.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_edit;
        private Button EditQuiz_AddBtn;
        private CheckBox EditQuiz_ShuffleCbx;
        private Label EditQuiz_TotalofMarkLbl;
        private TextBox EditQuiz_MaxGradeTxt;
        private Button EditQuiz_SaveBtn;
        private Label EditQuiz_MaxGradeLbl;
        private Button EditQuiz_MultipleItemsBtn;
        private Button EditQuiz_RepaginateBtn;
        private Label EditQuiz_NumberofQuestionLbl;
        private Label EditQuiz_ContestNameLbl;
        private FlowLayoutPanel flowLayoutPanel_popup;
        private Button EditForm_NewQuestionBtn;
        private Button EditQuiz_BankBtn;
        private Button EditQuiz_RandomBtn;
        private RandomQuestion randomQuestion;
        private FromQuestionBank fromQuestionBank;
    }
}
