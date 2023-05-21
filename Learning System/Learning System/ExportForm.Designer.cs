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
            SuspendLayout();
            // 
            // ExportForm_ExportBtn
            // 
            ExportForm_ExportBtn.BackColor = Color.FromArgb(194, 36, 36);
            ExportForm_ExportBtn.FlatStyle = FlatStyle.Flat;
            ExportForm_ExportBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ExportForm_ExportBtn.ForeColor = Color.White;
            ExportForm_ExportBtn.Location = new Point(427, 66);
            ExportForm_ExportBtn.Name = "ExportForm_ExportBtn";
            ExportForm_ExportBtn.Size = new Size(185, 57);
            ExportForm_ExportBtn.TabIndex = 10;
            ExportForm_ExportBtn.Text = "EXPORT";
            ExportForm_ExportBtn.UseVisualStyleBackColor = false;
            ExportForm_ExportBtn.Click += ExportForm_ExportBtn_Click;
            // 
            // ExportForm_PasswordTxt
            // 
            ExportForm_PasswordTxt.Location = new Point(90, 66);
            ExportForm_PasswordTxt.Name = "ExportForm_PasswordTxt";
            ExportForm_PasswordTxt.Size = new Size(275, 27);
            ExportForm_PasswordTxt.TabIndex = 11;
            // 
            // ExportForm_EnablePWCbx
            // 
            ExportForm_EnablePWCbx.AutoSize = true;
            ExportForm_EnablePWCbx.Checked = true;
            ExportForm_EnablePWCbx.CheckState = CheckState.Checked;
            ExportForm_EnablePWCbx.Location = new Point(90, 99);
            ExportForm_EnablePWCbx.Name = "ExportForm_EnablePWCbx";
            ExportForm_EnablePWCbx.Size = new Size(143, 24);
            ExportForm_EnablePWCbx.TabIndex = 12;
            ExportForm_EnablePWCbx.Text = "Enable password";
            ExportForm_EnablePWCbx.UseVisualStyleBackColor = true;
            ExportForm_EnablePWCbx.CheckedChanged += ExportForm_EnablePWCbx_CheckedChanged;
            // 
            // ExportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ExportForm_EnablePWCbx);
            Controls.Add(ExportForm_PasswordTxt);
            Controls.Add(ExportForm_ExportBtn);
            Name = "ExportForm";
            Size = new Size(919, 555);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ExportForm_ExportBtn;
        private TextBox ExportForm_PasswordTxt;
        private CheckBox ExportForm_EnablePWCbx;
    }
}
