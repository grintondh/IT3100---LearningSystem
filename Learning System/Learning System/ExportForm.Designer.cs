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
            SuspendLayout();
            // 
            // ExportForm_ExportBtn
            // 
            ExportForm_ExportBtn.BackColor = Color.FromArgb(194, 36, 36);
            ExportForm_ExportBtn.FlatStyle = FlatStyle.Flat;
            ExportForm_ExportBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ExportForm_ExportBtn.ForeColor = Color.White;
            ExportForm_ExportBtn.Location = new Point(173, 124);
            ExportForm_ExportBtn.Name = "ExportForm_ExportBtn";
            ExportForm_ExportBtn.Size = new Size(185, 51);
            ExportForm_ExportBtn.TabIndex = 10;
            ExportForm_ExportBtn.Text = "EXPORT";
            ExportForm_ExportBtn.UseVisualStyleBackColor = false;
            ExportForm_ExportBtn.Click += ExportForm_ExportBtn_Click;
            // 
            // ExportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ExportForm_ExportBtn);
            Name = "ExportForm";
            Size = new Size(919, 555);
            ResumeLayout(false);
        }

        #endregion

        private Button ExportForm_ExportBtn;
    }
}
