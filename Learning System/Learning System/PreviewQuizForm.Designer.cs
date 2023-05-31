namespace Learning_System
{
    partial class PreviewQuizForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel_top = new Panel();
            panel_heading = new Panel();
            PathLbl = new Label();
            ITLbl = new Label();
            PreviousPageBtn = new Button();
            panel_left = new Panel();
            NextPageBtn = new Button();
            panel_right = new Panel();
            label1 = new Label();
            panel_QuestionBtn = new Panel();
            QuizNavigationLbl = new Label();
            panel_time = new Panel();
            panel_changePage = new Panel();
            panel_heading.SuspendLayout();
            panel_left.SuspendLayout();
            panel_right.SuspendLayout();
            panel_changePage.SuspendLayout();
            SuspendLayout();
            // 
            // panel_top
            // 
            panel_top.BackColor = Color.FromArgb(0, 159, 229);
            panel_top.BorderStyle = BorderStyle.FixedSingle;
            panel_top.Dock = DockStyle.Top;
            panel_top.Location = new Point(0, 0);
            panel_top.Name = "panel_top";
            panel_top.Size = new Size(1366, 64);
            panel_top.TabIndex = 2;
            // 
            // panel_heading
            // 
            panel_heading.BackColor = Color.White;
            panel_heading.BorderStyle = BorderStyle.FixedSingle;
            panel_heading.Controls.Add(PathLbl);
            panel_heading.Controls.Add(ITLbl);
            panel_heading.Dock = DockStyle.Top;
            panel_heading.Location = new Point(0, 64);
            panel_heading.Name = "panel_heading";
            panel_heading.Size = new Size(1366, 146);
            panel_heading.TabIndex = 4;
            // 
            // PathLbl
            // 
            PathLbl.AutoSize = true;
            PathLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            PathLbl.Location = new Point(23, 83);
            PathLbl.Name = "PathLbl";
            PathLbl.Size = new Size(291, 23);
            PathLbl.TabIndex = 1;
            PathLbl.Text = "Home  /  My courses  /  THI CUỐI KỲ";
            // 
            // ITLbl
            // 
            ITLbl.AutoSize = true;
            ITLbl.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            ITLbl.ForeColor = Color.FromArgb(194, 36, 36);
            ITLbl.Location = new Point(23, 13);
            ITLbl.Name = "ITLbl";
            ITLbl.Size = new Size(60, 60);
            ITLbl.TabIndex = 0;
            ITLbl.Text = "IT";
            // 
            // PreviousPageBtn
            // 
            PreviousPageBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            PreviousPageBtn.BackColor = Color.FromArgb(0, 159, 229);
            PreviousPageBtn.FlatStyle = FlatStyle.Flat;
            PreviousPageBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PreviousPageBtn.ForeColor = Color.White;
            PreviousPageBtn.Location = new Point(7, 3);
            PreviousPageBtn.Name = "PreviousPageBtn";
            PreviousPageBtn.Size = new Size(169, 42);
            PreviousPageBtn.TabIndex = 14;
            PreviousPageBtn.Text = "Previous page";
            PreviousPageBtn.UseVisualStyleBackColor = false;
            PreviousPageBtn.Click += PreviousPageBtn_Click;
            // 
            // panel_left
            // 
            panel_left.BackColor = Color.White;
            panel_left.Controls.Add(panel_changePage);
            panel_left.Dock = DockStyle.Fill;
            panel_left.Location = new Point(0, 241);
            panel_left.Name = "panel_left";
            panel_left.Size = new Size(1000, 474);
            panel_left.TabIndex = 5;
            // 
            // NextPageBtn
            // 
            NextPageBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            NextPageBtn.BackColor = Color.FromArgb(0, 159, 229);
            NextPageBtn.FlatStyle = FlatStyle.Flat;
            NextPageBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NextPageBtn.ForeColor = Color.White;
            NextPageBtn.Location = new Point(824, 3);
            NextPageBtn.Name = "NextPageBtn";
            NextPageBtn.Size = new Size(169, 42);
            NextPageBtn.TabIndex = 15;
            NextPageBtn.Text = "Next page";
            NextPageBtn.UseVisualStyleBackColor = false;
            NextPageBtn.Click += NextPageBtn_Click;
            // 
            // panel_right
            // 
            panel_right.BackColor = Color.White;
            panel_right.Controls.Add(label1);
            panel_right.Controls.Add(panel_QuestionBtn);
            panel_right.Controls.Add(QuizNavigationLbl);
            panel_right.Dock = DockStyle.Right;
            panel_right.Location = new Point(1000, 210);
            panel_right.Name = "panel_right";
            panel_right.Size = new Size(366, 505);
            panel_right.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(6, 419);
            label1.Name = "label1";
            label1.Size = new Size(154, 28);
            label1.TabIndex = 4;
            label1.Text = "Finish attempt ...";
            // 
            // panel_QuestionBtn
            // 
            panel_QuestionBtn.Location = new Point(16, 44);
            panel_QuestionBtn.Name = "panel_QuestionBtn";
            panel_QuestionBtn.Size = new Size(338, 363);
            panel_QuestionBtn.TabIndex = 3;
            // 
            // QuizNavigationLbl
            // 
            QuizNavigationLbl.AutoSize = true;
            QuizNavigationLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            QuizNavigationLbl.ForeColor = Color.FromArgb(194, 36, 36);
            QuizNavigationLbl.Location = new Point(6, 3);
            QuizNavigationLbl.Name = "QuizNavigationLbl";
            QuizNavigationLbl.Size = new Size(150, 28);
            QuizNavigationLbl.TabIndex = 2;
            QuizNavigationLbl.Text = "Quiz navigation";
            // 
            // panel_time
            // 
            panel_time.BackColor = Color.White;
            panel_time.Dock = DockStyle.Top;
            panel_time.Location = new Point(0, 210);
            panel_time.Name = "panel_time";
            panel_time.Size = new Size(1000, 31);
            panel_time.TabIndex = 7;
            // 
            // panel_changePage
            // 
            panel_changePage.BackColor = Color.White;
            panel_changePage.Controls.Add(PreviousPageBtn);
            panel_changePage.Controls.Add(NextPageBtn);
            panel_changePage.Dock = DockStyle.Bottom;
            panel_changePage.Location = new Point(0, 422);
            panel_changePage.Name = "panel_changePage";
            panel_changePage.Size = new Size(1000, 52);
            panel_changePage.TabIndex = 8;
            // 
            // PreviewQuizForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1366, 715);
            Controls.Add(panel_left);
            Controls.Add(panel_time);
            Controls.Add(panel_right);
            Controls.Add(panel_heading);
            Controls.Add(panel_top);
            Name = "PreviewQuizForm";
            Text = "PreviewQuizForm";
            WindowState = FormWindowState.Maximized;
            panel_heading.ResumeLayout(false);
            panel_heading.PerformLayout();
            panel_left.ResumeLayout(false);
            panel_right.ResumeLayout(false);
            panel_right.PerformLayout();
            panel_changePage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_top;
        private Panel panel_heading;
        public Label PathLbl;
        private Label ITLbl;
        private Label QuizNavigationLbl;
        private Label label1;
        private Panel panel_QuestionBtn;
        private Button NextPageBtn;
        private Button PreviousPageBtn;
        private Panel panel_time;
        private Panel panel_changePage;
        public Panel panel_left;
        public Panel panel_right;
    }
}