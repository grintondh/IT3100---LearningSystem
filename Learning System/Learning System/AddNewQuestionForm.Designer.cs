namespace Learning_System
{
    partial class AddNewQuestionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewQuestionForm));
            AddNewQuestionForm_HeadingLbl = new Label();
            panel_heading = new Panel();
            panel_body = new Panel();
            panel_choice = new Panel();
            panel_choice1 = new Panel();
            AddNewQuestionForm_Grade1Cbo = new ComboBox();
            AddNewQuestionForm_Grade1Lbl = new Label();
            AddNewQuestionForm_Choice1Rtb = new RichTextBox();
            AddNewQuestionForm_Choice1Lbl = new Label();
            AddNewQuestionForm_MoreChoicesBtn = new Button();
            AddNewQuestionForm_SaveBtn = new Button();
            panel_ = new Panel();
            AddNewQuestionForm_CategoryLbl = new Label();
            AddNewQuestionForm_TextRtb = new RichTextBox();
            AddNewQuestionForm_NameLbl = new Label();
            AddNewQuestionForm_TextLbl = new Label();
            AddNewQuestionForm_MarkLbl = new Label();
            AddNewQuestionForm_CategoryCbo = new ComboBox();
            AddNewQuestionForm_NameTxt = new TextBox();
            AddNewQuestionForm_MarkTxt = new TextBox();
            AddNewQuestionForm_SaveAndContinueBtn = new Button();
            AddNewQuestionForm_ExpandPic = new PictureBox();
            AddNewQuestionForm_CancelBtn = new Button();
            AddNewQuestionForm_GeneralBtn = new Button();
            AddNewQuestionForm_ErrorLbl = new Label();
            panel_heading.SuspendLayout();
            panel_body.SuspendLayout();
            panel_choice.SuspendLayout();
            panel_choice1.SuspendLayout();
            panel_.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AddNewQuestionForm_ExpandPic).BeginInit();
            SuspendLayout();
            // 
            // AddNewQuestionForm_HeadingLbl
            // 
            AddNewQuestionForm_HeadingLbl.AutoSize = true;
            AddNewQuestionForm_HeadingLbl.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            AddNewQuestionForm_HeadingLbl.ForeColor = Color.FromArgb(194, 36, 36);
            AddNewQuestionForm_HeadingLbl.Location = new Point(4, 7);
            AddNewQuestionForm_HeadingLbl.Name = "AddNewQuestionForm_HeadingLbl";
            AddNewQuestionForm_HeadingLbl.Size = new Size(533, 46);
            AddNewQuestionForm_HeadingLbl.TabIndex = 8;
            AddNewQuestionForm_HeadingLbl.Text = "Adding a Multiple choice question";
            // 
            // panel_heading
            // 
            panel_heading.BorderStyle = BorderStyle.FixedSingle;
            panel_heading.Controls.Add(AddNewQuestionForm_HeadingLbl);
            panel_heading.Dock = DockStyle.Top;
            panel_heading.Location = new Point(0, 0);
            panel_heading.Name = "panel_heading";
            panel_heading.Size = new Size(1233, 60);
            panel_heading.TabIndex = 9;
            // 
            // panel_body
            // 
            panel_body.AutoScroll = true;
            panel_body.Controls.Add(AddNewQuestionForm_ErrorLbl);
            panel_body.Controls.Add(panel_choice);
            panel_body.Controls.Add(AddNewQuestionForm_MoreChoicesBtn);
            panel_body.Controls.Add(AddNewQuestionForm_SaveBtn);
            panel_body.Controls.Add(panel_);
            panel_body.Controls.Add(AddNewQuestionForm_SaveAndContinueBtn);
            panel_body.Controls.Add(AddNewQuestionForm_ExpandPic);
            panel_body.Controls.Add(AddNewQuestionForm_CancelBtn);
            panel_body.Controls.Add(AddNewQuestionForm_GeneralBtn);
            panel_body.Dock = DockStyle.Fill;
            panel_body.Location = new Point(0, 60);
            panel_body.Name = "panel_body";
            panel_body.Size = new Size(1233, 995);
            panel_body.TabIndex = 10;
            // 
            // panel_choice
            // 
            panel_choice.Controls.Add(panel_choice1);
            panel_choice.Dock = DockStyle.Top;
            panel_choice.Location = new Point(0, 474);
            panel_choice.Name = "panel_choice";
            panel_choice.Size = new Size(1233, 258);
            panel_choice.TabIndex = 21;
            // 
            // panel_choice1
            // 
            panel_choice1.Controls.Add(AddNewQuestionForm_Grade1Cbo);
            panel_choice1.Controls.Add(AddNewQuestionForm_Grade1Lbl);
            panel_choice1.Controls.Add(AddNewQuestionForm_Choice1Rtb);
            panel_choice1.Controls.Add(AddNewQuestionForm_Choice1Lbl);
            panel_choice1.Location = new Point(354, 6);
            panel_choice1.Name = "panel_choice1";
            panel_choice1.Size = new Size(565, 243);
            panel_choice1.TabIndex = 18;
            // 
            // AddNewQuestionForm_Grade1Cbo
            // 
            AddNewQuestionForm_Grade1Cbo.FormattingEnabled = true;
            AddNewQuestionForm_Grade1Cbo.Items.AddRange(new object[] { "1", "0,5", "0" });
            AddNewQuestionForm_Grade1Cbo.Location = new Point(106, 201);
            AddNewQuestionForm_Grade1Cbo.Name = "AddNewQuestionForm_Grade1Cbo";
            AddNewQuestionForm_Grade1Cbo.Size = new Size(151, 28);
            AddNewQuestionForm_Grade1Cbo.TabIndex = 3;
            // 
            // AddNewQuestionForm_Grade1Lbl
            // 
            AddNewQuestionForm_Grade1Lbl.AutoSize = true;
            AddNewQuestionForm_Grade1Lbl.Location = new Point(12, 201);
            AddNewQuestionForm_Grade1Lbl.Name = "AddNewQuestionForm_Grade1Lbl";
            AddNewQuestionForm_Grade1Lbl.Size = new Size(49, 20);
            AddNewQuestionForm_Grade1Lbl.TabIndex = 2;
            AddNewQuestionForm_Grade1Lbl.Text = "Grade";
            // 
            // AddNewQuestionForm_Choice1Rtb
            // 
            AddNewQuestionForm_Choice1Rtb.Location = new Point(106, 14);
            AddNewQuestionForm_Choice1Rtb.Name = "AddNewQuestionForm_Choice1Rtb";
            AddNewQuestionForm_Choice1Rtb.Size = new Size(434, 162);
            AddNewQuestionForm_Choice1Rtb.TabIndex = 1;
            AddNewQuestionForm_Choice1Rtb.Text = "";
            // 
            // AddNewQuestionForm_Choice1Lbl
            // 
            AddNewQuestionForm_Choice1Lbl.AutoSize = true;
            AddNewQuestionForm_Choice1Lbl.Location = new Point(12, 14);
            AddNewQuestionForm_Choice1Lbl.Name = "AddNewQuestionForm_Choice1Lbl";
            AddNewQuestionForm_Choice1Lbl.Size = new Size(62, 20);
            AddNewQuestionForm_Choice1Lbl.TabIndex = 0;
            AddNewQuestionForm_Choice1Lbl.Text = "Choice1";
            // 
            // AddNewQuestionForm_MoreChoicesBtn
            // 
            AddNewQuestionForm_MoreChoicesBtn.BackColor = Color.FromArgb(0, 159, 229);
            AddNewQuestionForm_MoreChoicesBtn.FlatStyle = FlatStyle.Flat;
            AddNewQuestionForm_MoreChoicesBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddNewQuestionForm_MoreChoicesBtn.ForeColor = Color.White;
            AddNewQuestionForm_MoreChoicesBtn.Location = new Point(460, 822);
            AddNewQuestionForm_MoreChoicesBtn.Name = "AddNewQuestionForm_MoreChoicesBtn";
            AddNewQuestionForm_MoreChoicesBtn.Size = new Size(340, 51);
            AddNewQuestionForm_MoreChoicesBtn.TabIndex = 12;
            AddNewQuestionForm_MoreChoicesBtn.Text = "BLANKS FOR 3 MORE CHOICES ";
            AddNewQuestionForm_MoreChoicesBtn.UseVisualStyleBackColor = false;
            AddNewQuestionForm_MoreChoicesBtn.Click += AddNewQuestionForm_MoreChoicesBtn_Click;
            // 
            // AddNewQuestionForm_SaveBtn
            // 
            AddNewQuestionForm_SaveBtn.BackColor = Color.FromArgb(194, 36, 36);
            AddNewQuestionForm_SaveBtn.FlatStyle = FlatStyle.Flat;
            AddNewQuestionForm_SaveBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddNewQuestionForm_SaveBtn.ForeColor = Color.White;
            AddNewQuestionForm_SaveBtn.Location = new Point(460, 936);
            AddNewQuestionForm_SaveBtn.Name = "AddNewQuestionForm_SaveBtn";
            AddNewQuestionForm_SaveBtn.Size = new Size(181, 53);
            AddNewQuestionForm_SaveBtn.TabIndex = 13;
            AddNewQuestionForm_SaveBtn.Text = "SAVE CHANGES";
            AddNewQuestionForm_SaveBtn.UseVisualStyleBackColor = false;
            AddNewQuestionForm_SaveBtn.Click += AddNewQuestionForm_SaveBtn_Click;
            // 
            // panel_
            // 
            panel_.Controls.Add(AddNewQuestionForm_CategoryLbl);
            panel_.Controls.Add(AddNewQuestionForm_TextRtb);
            panel_.Controls.Add(AddNewQuestionForm_NameLbl);
            panel_.Controls.Add(AddNewQuestionForm_TextLbl);
            panel_.Controls.Add(AddNewQuestionForm_MarkLbl);
            panel_.Controls.Add(AddNewQuestionForm_CategoryCbo);
            panel_.Controls.Add(AddNewQuestionForm_NameTxt);
            panel_.Controls.Add(AddNewQuestionForm_MarkTxt);
            panel_.Dock = DockStyle.Top;
            panel_.Location = new Point(0, 0);
            panel_.Name = "panel_";
            panel_.Size = new Size(1233, 474);
            panel_.TabIndex = 20;
            // 
            // AddNewQuestionForm_CategoryLbl
            // 
            AddNewQuestionForm_CategoryLbl.AutoSize = true;
            AddNewQuestionForm_CategoryLbl.Location = new Point(33, 56);
            AddNewQuestionForm_CategoryLbl.Name = "AddNewQuestionForm_CategoryLbl";
            AddNewQuestionForm_CategoryLbl.Size = new Size(69, 20);
            AddNewQuestionForm_CategoryLbl.TabIndex = 4;
            AddNewQuestionForm_CategoryLbl.Text = "Category";
            // 
            // AddNewQuestionForm_TextRtb
            // 
            AddNewQuestionForm_TextRtb.Location = new Point(460, 180);
            AddNewQuestionForm_TextRtb.Name = "AddNewQuestionForm_TextRtb";
            AddNewQuestionForm_TextRtb.Size = new Size(568, 235);
            AddNewQuestionForm_TextRtb.TabIndex = 17;
            AddNewQuestionForm_TextRtb.Text = "";
            // 
            // AddNewQuestionForm_NameLbl
            // 
            AddNewQuestionForm_NameLbl.AutoSize = true;
            AddNewQuestionForm_NameLbl.Location = new Point(33, 104);
            AddNewQuestionForm_NameLbl.Name = "AddNewQuestionForm_NameLbl";
            AddNewQuestionForm_NameLbl.Size = new Size(129, 20);
            AddNewQuestionForm_NameLbl.TabIndex = 5;
            AddNewQuestionForm_NameLbl.Text = "Question name (*)";
            // 
            // AddNewQuestionForm_TextLbl
            // 
            AddNewQuestionForm_TextLbl.AutoSize = true;
            AddNewQuestionForm_TextLbl.Location = new Point(33, 180);
            AddNewQuestionForm_TextLbl.Name = "AddNewQuestionForm_TextLbl";
            AddNewQuestionForm_TextLbl.Size = new Size(117, 20);
            AddNewQuestionForm_TextLbl.TabIndex = 6;
            AddNewQuestionForm_TextLbl.Text = "Question text (*)";
            // 
            // AddNewQuestionForm_MarkLbl
            // 
            AddNewQuestionForm_MarkLbl.AutoSize = true;
            AddNewQuestionForm_MarkLbl.Location = new Point(33, 439);
            AddNewQuestionForm_MarkLbl.Name = "AddNewQuestionForm_MarkLbl";
            AddNewQuestionForm_MarkLbl.Size = new Size(115, 20);
            AddNewQuestionForm_MarkLbl.TabIndex = 7;
            AddNewQuestionForm_MarkLbl.Text = "Default mark (*)";
            // 
            // AddNewQuestionForm_CategoryCbo
            // 
            AddNewQuestionForm_CategoryCbo.FormattingEnabled = true;
            AddNewQuestionForm_CategoryCbo.Location = new Point(460, 53);
            AddNewQuestionForm_CategoryCbo.Name = "AddNewQuestionForm_CategoryCbo";
            AddNewQuestionForm_CategoryCbo.Size = new Size(281, 28);
            AddNewQuestionForm_CategoryCbo.TabIndex = 8;
            AddNewQuestionForm_CategoryCbo.DropDown += AddNewQuestionForm_CategoryCbo_DropDown;
            // 
            // AddNewQuestionForm_NameTxt
            // 
            AddNewQuestionForm_NameTxt.Location = new Point(460, 101);
            AddNewQuestionForm_NameTxt.Name = "AddNewQuestionForm_NameTxt";
            AddNewQuestionForm_NameTxt.Size = new Size(281, 27);
            AddNewQuestionForm_NameTxt.TabIndex = 9;
            // 
            // AddNewQuestionForm_MarkTxt
            // 
            AddNewQuestionForm_MarkTxt.Location = new Point(460, 436);
            AddNewQuestionForm_MarkTxt.Name = "AddNewQuestionForm_MarkTxt";
            AddNewQuestionForm_MarkTxt.Size = new Size(281, 27);
            AddNewQuestionForm_MarkTxt.TabIndex = 11;
            // 
            // AddNewQuestionForm_SaveAndContinueBtn
            // 
            AddNewQuestionForm_SaveAndContinueBtn.BackColor = Color.FromArgb(0, 159, 229);
            AddNewQuestionForm_SaveAndContinueBtn.FlatStyle = FlatStyle.Flat;
            AddNewQuestionForm_SaveAndContinueBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddNewQuestionForm_SaveAndContinueBtn.ForeColor = Color.White;
            AddNewQuestionForm_SaveAndContinueBtn.Location = new Point(460, 879);
            AddNewQuestionForm_SaveAndContinueBtn.Name = "AddNewQuestionForm_SaveAndContinueBtn";
            AddNewQuestionForm_SaveAndContinueBtn.Size = new Size(386, 51);
            AddNewQuestionForm_SaveAndContinueBtn.TabIndex = 14;
            AddNewQuestionForm_SaveAndContinueBtn.Text = "SAVE CHANGES AND CONTINUE EDITING";
            AddNewQuestionForm_SaveAndContinueBtn.UseVisualStyleBackColor = false;
            AddNewQuestionForm_SaveAndContinueBtn.Click += AddNewQuestionForm_SaveAndContinueBtn_Click;
            // 
            // AddNewQuestionForm_ExpandPic
            // 
            AddNewQuestionForm_ExpandPic.Image = (Image)resources.GetObject("AddNewQuestionForm_ExpandPic.Image");
            AddNewQuestionForm_ExpandPic.Location = new Point(32, 17);
            AddNewQuestionForm_ExpandPic.Name = "AddNewQuestionForm_ExpandPic";
            AddNewQuestionForm_ExpandPic.Size = new Size(15, 10);
            AddNewQuestionForm_ExpandPic.SizeMode = PictureBoxSizeMode.Zoom;
            AddNewQuestionForm_ExpandPic.TabIndex = 16;
            AddNewQuestionForm_ExpandPic.TabStop = false;
            // 
            // AddNewQuestionForm_CancelBtn
            // 
            AddNewQuestionForm_CancelBtn.BackColor = Color.FromArgb(0, 159, 229);
            AddNewQuestionForm_CancelBtn.FlatStyle = FlatStyle.Flat;
            AddNewQuestionForm_CancelBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddNewQuestionForm_CancelBtn.ForeColor = Color.White;
            AddNewQuestionForm_CancelBtn.Location = new Point(647, 936);
            AddNewQuestionForm_CancelBtn.Name = "AddNewQuestionForm_CancelBtn";
            AddNewQuestionForm_CancelBtn.Size = new Size(135, 53);
            AddNewQuestionForm_CancelBtn.TabIndex = 15;
            AddNewQuestionForm_CancelBtn.Text = "CANCEL";
            AddNewQuestionForm_CancelBtn.UseVisualStyleBackColor = false;
            AddNewQuestionForm_CancelBtn.Click += AddNewQuestionForm_CancelBtn_Click;
            // 
            // AddNewQuestionForm_GeneralBtn
            // 
            AddNewQuestionForm_GeneralBtn.FlatAppearance.BorderSize = 0;
            AddNewQuestionForm_GeneralBtn.FlatStyle = FlatStyle.Flat;
            AddNewQuestionForm_GeneralBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            AddNewQuestionForm_GeneralBtn.ForeColor = Color.FromArgb(194, 36, 36);
            AddNewQuestionForm_GeneralBtn.Location = new Point(33, 6);
            AddNewQuestionForm_GeneralBtn.Name = "AddNewQuestionForm_GeneralBtn";
            AddNewQuestionForm_GeneralBtn.Size = new Size(96, 28);
            AddNewQuestionForm_GeneralBtn.TabIndex = 3;
            AddNewQuestionForm_GeneralBtn.Text = "General";
            AddNewQuestionForm_GeneralBtn.UseVisualStyleBackColor = true;
            // 
            // AddNewQuestionForm_ErrorLbl
            // 
            AddNewQuestionForm_ErrorLbl.AutoSize = true;
            AddNewQuestionForm_ErrorLbl.Location = new Point(12, 955);
            AddNewQuestionForm_ErrorLbl.Name = "AddNewQuestionForm_ErrorLbl";
            AddNewQuestionForm_ErrorLbl.Size = new Size(0, 20);
            AddNewQuestionForm_ErrorLbl.TabIndex = 19;
            // 
            // AddNewQuestionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1233, 1055);
            Controls.Add(panel_body);
            Controls.Add(panel_heading);
            Name = "AddNewQuestionForm";
            WindowState = FormWindowState.Maximized;
            panel_heading.ResumeLayout(false);
            panel_heading.PerformLayout();
            panel_body.ResumeLayout(false);
            panel_body.PerformLayout();
            panel_choice.ResumeLayout(false);
            panel_choice1.ResumeLayout(false);
            panel_choice1.PerformLayout();
            panel_.ResumeLayout(false);
            panel_.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AddNewQuestionForm_ExpandPic).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label AddNewQuestionForm_HeadingLbl;
        private Panel panel_heading;
        private Panel panel_body;
        private Label AddNewQuestionForm_CategoryLbl;
        private Button AddNewQuestionForm_GeneralBtn;
        private ComboBox AddNewQuestionForm_CategoryCbo;
        private Label AddNewQuestionForm_MarkLbl;
        private Label AddNewQuestionForm_TextLbl;
        private Label AddNewQuestionForm_NameLbl;
        private TextBox AddNewQuestionForm_MarkTxt;
        private TextBox AddNewQuestionForm_NameTxt;
        private Button AddNewQuestionForm_MoreChoicesBtn;
        private Button AddNewQuestionForm_SaveBtn;
        private Button AddNewQuestionForm_CancelBtn;
        private Button AddNewQuestionForm_SaveAndContinueBtn;
        private PictureBox AddNewQuestionForm_ExpandPic;
        private Panel panel_choice1;
        private ComboBox AddNewQuestionForm_Grade1Cbo;
        private Label AddNewQuestionForm_Grade1Lbl;
        private RichTextBox AddNewQuestionForm_Choice1Rtb;
        private Label AddNewQuestionForm_Choice1Lbl;
        private RichTextBox AddNewQuestionForm_TextRtb;
        private Label AddNewQuestionForm_ErrorLbl;
        private Panel panel_choice;
        private Panel panel_;
    }
}
