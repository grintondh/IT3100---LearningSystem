namespace Learning_System
{
    partial class PageOfPreviewQuiz
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
            panel1 = new Panel();
            MarkLbl = new Label();
            AnswerLbl = new Label();
            QuestionLbl = new Label();
            NumberLbl = new Label();
            panel2 = new Panel();
            QuestionChoiceGrb = new GroupBox();
            ContentRtb = new RichTextBox();
            panel_button = new Panel();
            panel_richTextboxes = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            QuestionChoiceGrb.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(MarkLbl);
            panel1.Controls.Add(AnswerLbl);
            panel1.Controls.Add(QuestionLbl);
            panel1.Controls.Add(NumberLbl);
            panel1.Location = new Point(18, 18);
            panel1.Name = "panel1";
            panel1.Size = new Size(193, 406);
            panel1.TabIndex = 0;
            // 
            // MarkLbl
            // 
            MarkLbl.AutoSize = true;
            MarkLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            MarkLbl.ForeColor = Color.Black;
            MarkLbl.Location = new Point(4, 78);
            MarkLbl.Name = "MarkLbl";
            MarkLbl.Size = new Size(135, 23);
            MarkLbl.TabIndex = 6;
            MarkLbl.Text = "Mark out of 1.00\r\n";
            // 
            // AnswerLbl
            // 
            AnswerLbl.AutoSize = true;
            AnswerLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            AnswerLbl.ForeColor = Color.Black;
            AnswerLbl.Location = new Point(4, 49);
            AnswerLbl.Name = "AnswerLbl";
            AnswerLbl.Size = new Size(144, 23);
            AnswerLbl.TabIndex = 5;
            AnswerLbl.Text = "Not yet answered";
            // 
            // QuestionLbl
            // 
            QuestionLbl.AutoSize = true;
            QuestionLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            QuestionLbl.ForeColor = Color.FromArgb(194, 36, 36);
            QuestionLbl.Location = new Point(4, 11);
            QuestionLbl.Name = "QuestionLbl";
            QuestionLbl.Size = new Size(79, 23);
            QuestionLbl.TabIndex = 3;
            QuestionLbl.Text = "Question";
            // 
            // NumberLbl
            // 
            NumberLbl.AutoSize = true;
            NumberLbl.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            NumberLbl.ForeColor = Color.FromArgb(194, 36, 36);
            NumberLbl.Location = new Point(82, -4);
            NumberLbl.Name = "NumberLbl";
            NumberLbl.Size = new Size(35, 41);
            NumberLbl.TabIndex = 4;
            NumberLbl.Text = "1";
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.BackColor = Color.Gainsboro;
            panel2.Controls.Add(QuestionChoiceGrb);
            panel2.Controls.Add(ContentRtb);
            panel2.Location = new Point(226, 18);
            panel2.Name = "panel2";
            panel2.Size = new Size(1104, 406);
            panel2.TabIndex = 1;
            // 
            // QuestionChoiceGrb
            // 
            QuestionChoiceGrb.Controls.Add(panel_richTextboxes);
            QuestionChoiceGrb.Controls.Add(panel_button);
            QuestionChoiceGrb.Dock = DockStyle.Fill;
            QuestionChoiceGrb.Location = new Point(0, 217);
            QuestionChoiceGrb.Name = "QuestionChoiceGrb";
            QuestionChoiceGrb.Size = new Size(1104, 189);
            QuestionChoiceGrb.TabIndex = 1;
            QuestionChoiceGrb.TabStop = false;
            QuestionChoiceGrb.Text = "Choice";
            // 
            // ContentRtb
            // 
            ContentRtb.BackColor = Color.White;
            ContentRtb.BorderStyle = BorderStyle.None;
            ContentRtb.Dock = DockStyle.Top;
            ContentRtb.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            ContentRtb.Location = new Point(0, 0);
            ContentRtb.Name = "ContentRtb";
            ContentRtb.ReadOnly = true;
            ContentRtb.Size = new Size(1104, 217);
            ContentRtb.TabIndex = 0;
            ContentRtb.Text = "";
            // 
            // panel_button
            // 
            panel_button.Dock = DockStyle.Left;
            panel_button.Location = new Point(3, 23);
            panel_button.Name = "panel_button";
            panel_button.Size = new Size(38, 163);
            panel_button.TabIndex = 0;
            // 
            // panel_richTextboxes
            // 
            panel_richTextboxes.Dock = DockStyle.Fill;
            panel_richTextboxes.Location = new Point(41, 23);
            panel_richTextboxes.Name = "panel_richTextboxes";
            panel_richTextboxes.Size = new Size(1060, 163);
            panel_richTextboxes.TabIndex = 1;
            // 
            // PageOfPreviewQuiz
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "PageOfPreviewQuiz";
            Size = new Size(1340, 441);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            QuestionChoiceGrb.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label MarkLbl;
        private Label AnswerLbl;
        private Label QuestionLbl;
        private Label NumberLbl;
        private Panel panel2;
        private RichTextBox ContentRtb;
        private GroupBox QuestionChoiceGrb;
        private Panel panel_richTextboxes;
        private Panel panel_button;
    }
}
