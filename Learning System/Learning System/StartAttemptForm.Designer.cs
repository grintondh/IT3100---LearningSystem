﻿namespace Learning_System
{
    partial class StartAttemptForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartAttemptForm));
            panel_main = new Panel();
            panel1 = new Panel();
            CancelBtn = new Button();
            StartBtn = new Button();
            TimeLbl = new Label();
            HeaderLbl = new Label();
            NotiTxt = new TextBox();
            panel_main.SuspendLayout();
            SuspendLayout();
            // 
            // panel_main
            // 
            panel_main.BorderStyle = BorderStyle.FixedSingle;
            panel_main.Controls.Add(NotiTxt);
            panel_main.Controls.Add(panel1);
            panel_main.Controls.Add(CancelBtn);
            panel_main.Controls.Add(StartBtn);
            panel_main.Controls.Add(TimeLbl);
            panel_main.Controls.Add(HeaderLbl);
            panel_main.Dock = DockStyle.Fill;
            panel_main.Location = new Point(0, 0);
            panel_main.Name = "panel_main";
            panel_main.Size = new Size(742, 391);
            panel_main.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(1, 77);
            panel1.Name = "panel1";
            panel1.Size = new Size(741, 1);
            panel1.TabIndex = 14;
            // 
            // CancelBtn
            // 
            CancelBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            CancelBtn.BackColor = Color.FromArgb(0, 159, 229);
            CancelBtn.FlatStyle = FlatStyle.Flat;
            CancelBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            CancelBtn.ForeColor = Color.White;
            CancelBtn.Location = new Point(226, 316);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(169, 54);
            CancelBtn.TabIndex = 13;
            CancelBtn.Text = "CANCEL";
            CancelBtn.UseVisualStyleBackColor = false;
            CancelBtn.Click += CancelBtn_Click_1;
            // 
            // StartBtn
            // 
            StartBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            StartBtn.BackColor = Color.FromArgb(194, 36, 36);
            StartBtn.FlatStyle = FlatStyle.Flat;
            StartBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            StartBtn.ForeColor = Color.White;
            StartBtn.Location = new Point(10, 316);
            StartBtn.Name = "StartBtn";
            StartBtn.Size = new Size(210, 54);
            StartBtn.TabIndex = 12;
            StartBtn.Text = "START ATTEMPT";
            StartBtn.UseVisualStyleBackColor = false;
            StartBtn.Click += StartBtn_Click_1;
            // 
            // TimeLbl
            // 
            TimeLbl.AutoSize = true;
            TimeLbl.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            TimeLbl.ForeColor = Color.FromArgb(194, 36, 36);
            TimeLbl.Location = new Point(22, 92);
            TimeLbl.Name = "TimeLbl";
            TimeLbl.Size = new Size(140, 38);
            TimeLbl.TabIndex = 10;
            TimeLbl.Text = "Time limit";
            // 
            // HeaderLbl
            // 
            HeaderLbl.AutoSize = true;
            HeaderLbl.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            HeaderLbl.Location = new Point(3, 17);
            HeaderLbl.Name = "HeaderLbl";
            HeaderLbl.Size = new Size(219, 46);
            HeaderLbl.TabIndex = 9;
            HeaderLbl.Text = "Start attempt";
            // 
            // NotiTxt
            // 
            NotiTxt.BackColor = Color.White;
            NotiTxt.BorderStyle = BorderStyle.None;
            NotiTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NotiTxt.Location = new Point(22, 171);
            NotiTxt.Multiline = true;
            NotiTxt.Name = "NotiTxt";
            NotiTxt.ReadOnly = true;
            NotiTxt.Size = new Size(707, 108);
            NotiTxt.TabIndex = 15;
            NotiTxt.Text = resources.GetString("NotiTxt.Text");
            // 
            // StartAttemptForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(742, 391);
            Controls.Add(panel_main);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StartAttemptForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StartAttemptForm";
            panel_main.ResumeLayout(false);
            panel_main.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_main;
        private Panel panel1;
        private Button CancelBtn;
        private Button StartBtn;
        private Label TimeLbl;
        private Label HeaderLbl;
        private TextBox NotiTxt;
    }
}