namespace Learning_System
{
    partial class ExportForm
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
            ExportForm_ExportBtn = new Button();
            ExportForm_PasswordTxt = new TextBox();
            ExportForm_EnablePWCbx = new CheckBox();
            statusStrip1 = new StatusStrip();
            ExportForm_progressBar = new ToolStripProgressBar();
            ExportForm_progressLabel = new ToolStripStatusLabel();
            ExportForm_ShowPwdCbx = new CheckBox();
            ExportForm_OpenAfterExportCbx = new CheckBox();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // ExportForm_ExportBtn
            // 
            ExportForm_ExportBtn.BackColor = Color.FromArgb(194, 36, 36);
            ExportForm_ExportBtn.FlatStyle = FlatStyle.Flat;
            ExportForm_ExportBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ExportForm_ExportBtn.ForeColor = Color.White;
            ExportForm_ExportBtn.Location = new Point(509, 66);
            ExportForm_ExportBtn.Name = "ExportForm_ExportBtn";
            ExportForm_ExportBtn.Size = new Size(185, 57);
            ExportForm_ExportBtn.TabIndex = 10;
            ExportForm_ExportBtn.Text = "EXPORT";
            ExportForm_ExportBtn.UseVisualStyleBackColor = false;
            ExportForm_ExportBtn.Click += ExportForm_ExportBtn_Click;
            // 
            // ExportForm_PasswordTxt
            // 
            ExportForm_PasswordTxt.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            ExportForm_PasswordTxt.Location = new Point(90, 66);
            ExportForm_PasswordTxt.Name = "ExportForm_PasswordTxt";
            ExportForm_PasswordTxt.PasswordChar = '*';
            ExportForm_PasswordTxt.PlaceholderText = "Set your password here...";
            ExportForm_PasswordTxt.ReadOnly = true;
            ExportForm_PasswordTxt.Size = new Size(275, 32);
            ExportForm_PasswordTxt.TabIndex = 11;
            // 
            // ExportForm_EnablePWCbx
            // 
            ExportForm_EnablePWCbx.AutoSize = true;
            ExportForm_EnablePWCbx.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            ExportForm_EnablePWCbx.Location = new Point(90, 104);
            ExportForm_EnablePWCbx.Name = "ExportForm_EnablePWCbx";
            ExportForm_EnablePWCbx.Size = new Size(176, 29);
            ExportForm_EnablePWCbx.TabIndex = 12;
            ExportForm_EnablePWCbx.Text = "Enable password";
            ExportForm_EnablePWCbx.UseVisualStyleBackColor = true;
            ExportForm_EnablePWCbx.CheckedChanged += ExportForm_EnablePWCbx_CheckedChanged;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { ExportForm_progressBar, ExportForm_progressLabel });
            statusStrip1.Location = new Point(0, 529);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(919, 26);
            statusStrip1.TabIndex = 13;
            statusStrip1.Text = "statusStrip1";
            // 
            // ExportForm_progressBar
            // 
            ExportForm_progressBar.Name = "ExportForm_progressBar";
            ExportForm_progressBar.Size = new Size(100, 18);
            // 
            // ExportForm_progressLabel
            // 
            ExportForm_progressLabel.BackgroundImageLayout = ImageLayout.None;
            ExportForm_progressLabel.DisplayStyle = ToolStripItemDisplayStyle.Text;
            ExportForm_progressLabel.ImageTransparentColor = SystemColors.Control;
            ExportForm_progressLabel.Name = "ExportForm_progressLabel";
            ExportForm_progressLabel.Size = new Size(50, 20);
            ExportForm_progressLabel.Text = "Ready";
            // 
            // ExportForm_ShowPwdCbx
            // 
            ExportForm_ShowPwdCbx.AutoSize = true;
            ExportForm_ShowPwdCbx.Enabled = false;
            ExportForm_ShowPwdCbx.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            ExportForm_ShowPwdCbx.Location = new Point(90, 139);
            ExportForm_ShowPwdCbx.Name = "ExportForm_ShowPwdCbx";
            ExportForm_ShowPwdCbx.Size = new Size(165, 29);
            ExportForm_ShowPwdCbx.TabIndex = 14;
            ExportForm_ShowPwdCbx.Text = "Show password";
            ExportForm_ShowPwdCbx.UseVisualStyleBackColor = true;
            ExportForm_ShowPwdCbx.CheckedChanged += ExportForm_ShowPwdCbx_CheckedChanged;
            // 
            // ExportForm_OpenAfterExportCbx
            // 
            ExportForm_OpenAfterExportCbx.AutoSize = true;
            ExportForm_OpenAfterExportCbx.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            ExportForm_OpenAfterExportCbx.Location = new Point(90, 174);
            ExportForm_OpenAfterExportCbx.Name = "ExportForm_OpenAfterExportCbx";
            ExportForm_OpenAfterExportCbx.Size = new Size(241, 29);
            ExportForm_OpenAfterExportCbx.TabIndex = 15;
            ExportForm_OpenAfterExportCbx.Text = "Open file after exporting";
            ExportForm_OpenAfterExportCbx.UseVisualStyleBackColor = true;
            // 
            // ExportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ExportForm_OpenAfterExportCbx);
            Controls.Add(ExportForm_ShowPwdCbx);
            Controls.Add(statusStrip1);
            Controls.Add(ExportForm_EnablePWCbx);
            Controls.Add(ExportForm_PasswordTxt);
            Controls.Add(ExportForm_ExportBtn);
            Name = "ExportForm";
            Size = new Size(919, 555);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ExportForm_ExportBtn;
        private TextBox ExportForm_PasswordTxt;
        private CheckBox ExportForm_EnablePWCbx;
        private StatusStrip statusStrip1;
        private ToolStripProgressBar ExportForm_progressBar;
        private ToolStripStatusLabel ExportForm_progressLabel;
        private CheckBox ExportForm_ShowPwdCbx;
        private CheckBox ExportForm_OpenAfterExportCbx;
    }
}
