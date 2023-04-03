namespace Learning_System
{
    partial class Giao_dien_xem_danh_sach_cau_hoi
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
            button_create = new Button();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            label1 = new Label();
            comboBox_select_a_category = new ComboBox();
            label_select = new Label();
            label_Questions_Bank = new Label();
            SuspendLayout();
            // 
            // button_create
            // 
            button_create.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button_create.ForeColor = Color.Black;
            button_create.Location = new Point(8, 164);
            button_create.Name = "button_create";
            button_create.Size = new Size(243, 49);
            button_create.TabIndex = 13;
            button_create.Text = "CREATE A NEW QUESTION ...";
            button_create.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox2.ForeColor = Color.Black;
            checkBox2.Location = new Point(11, 140);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(172, 21);
            checkBox2.TabIndex = 12;
            checkBox2.Text = "Also show old questions";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.ForeColor = Color.Black;
            checkBox1.Location = new Point(11, 120);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(262, 21);
            checkBox1.TabIndex = 11;
            checkBox1.Text = "Also show questions from subcategoies";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(11, 97);
            label1.Name = "label1";
            label1.Size = new Size(408, 23);
            label1.TabIndex = 10;
            label1.Text = "The default category for questions shared in context";
            // 
            // comboBox_select_a_category
            // 
            comboBox_select_a_category.FormattingEnabled = true;
            comboBox_select_a_category.Location = new Point(144, 60);
            comboBox_select_a_category.Name = "comboBox_select_a_category";
            comboBox_select_a_category.Size = new Size(164, 28);
            comboBox_select_a_category.TabIndex = 9;
            // 
            // label_select
            // 
            label_select.AutoSize = true;
            label_select.ForeColor = Color.Black;
            label_select.Location = new Point(11, 64);
            label_select.Name = "label_select";
            label_select.Size = new Size(130, 20);
            label_select.TabIndex = 8;
            label_select.Text = "Select a category :";
            // 
            // label_Questions_Bank
            // 
            label_Questions_Bank.AutoSize = true;
            label_Questions_Bank.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label_Questions_Bank.ForeColor = Color.Black;
            label_Questions_Bank.Location = new Point(3, 11);
            label_Questions_Bank.Name = "label_Questions_Bank";
            label_Questions_Bank.Size = new Size(251, 46);
            label_Questions_Bank.TabIndex = 7;
            label_Questions_Bank.Text = "Questions Bank";
            // 
            // Giao_dien_xem_danh_sach_cau_hoi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button_create);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label1);
            Controls.Add(comboBox_select_a_category);
            Controls.Add(label_select);
            Controls.Add(label_Questions_Bank);
            Name = "Giao_dien_xem_danh_sach_cau_hoi";
            Size = new Size(1084, 466);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_create;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Label label1;
        private ComboBox comboBox_select_a_category;
        private Label label_select;
        private Label label_Questions_Bank;
    }
}
