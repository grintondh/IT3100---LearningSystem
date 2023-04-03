namespace Learning_System
{
    partial class Giao_dien_Categories
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
            label_Add_Category = new Label();
            label_Parent_Category = new Label();
            comboBox_Parent_Category = new ComboBox();
            label_Name = new Label();
            textBox_Name = new TextBox();
            textBox_Category_info = new TextBox();
            textBox_ID_number = new TextBox();
            label_Category_info = new Label();
            label_ID_number = new Label();
            button_Add = new Button();
            SuspendLayout();
            // 
            // label_Add_Category
            // 
            label_Add_Category.AutoSize = true;
            label_Add_Category.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label_Add_Category.Location = new Point(13, 13);
            label_Add_Category.Name = "label_Add_Category";
            label_Add_Category.Size = new Size(227, 46);
            label_Add_Category.TabIndex = 0;
            label_Add_Category.Text = "Add Category";
            // 
            // label_Parent_Category
            // 
            label_Parent_Category.AutoSize = true;
            label_Parent_Category.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label_Parent_Category.Location = new Point(13, 83);
            label_Parent_Category.Name = "label_Parent_Category";
            label_Parent_Category.Size = new Size(133, 23);
            label_Parent_Category.TabIndex = 1;
            label_Parent_Category.Text = "Parent Category";
            // 
            // comboBox_Parent_Category
            // 
            comboBox_Parent_Category.FormattingEnabled = true;
            comboBox_Parent_Category.Location = new Point(205, 83);
            comboBox_Parent_Category.Name = "comboBox_Parent_Category";
            comboBox_Parent_Category.Size = new Size(276, 28);
            comboBox_Parent_Category.TabIndex = 2;
            // 
            // label_Name
            // 
            label_Name.AutoSize = true;
            label_Name.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label_Name.Location = new Point(13, 141);
            label_Name.Name = "label_Name";
            label_Name.Size = new Size(56, 23);
            label_Name.TabIndex = 3;
            label_Name.Text = "Name";
            // 
            // textBox_Name
            // 
            textBox_Name.Location = new Point(205, 141);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(276, 27);
            textBox_Name.TabIndex = 4;
            // 
            // textBox_Category_info
            // 
            textBox_Category_info.Location = new Point(205, 211);
            textBox_Category_info.Multiline = true;
            textBox_Category_info.Name = "textBox_Category_info";
            textBox_Category_info.Size = new Size(721, 194);
            textBox_Category_info.TabIndex = 5;
            // 
            // textBox_ID_number
            // 
            textBox_ID_number.Location = new Point(205, 439);
            textBox_ID_number.Name = "textBox_ID_number";
            textBox_ID_number.Size = new Size(276, 27);
            textBox_ID_number.TabIndex = 6;
            // 
            // label_Category_info
            // 
            label_Category_info.AutoSize = true;
            label_Category_info.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label_Category_info.Location = new Point(13, 211);
            label_Category_info.Name = "label_Category_info";
            label_Category_info.Size = new Size(113, 23);
            label_Category_info.TabIndex = 7;
            label_Category_info.Text = "Category info";
            // 
            // label_ID_number
            // 
            label_ID_number.AutoSize = true;
            label_ID_number.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label_ID_number.Location = new Point(13, 439);
            label_ID_number.Name = "label_ID_number";
            label_ID_number.Size = new Size(92, 23);
            label_ID_number.TabIndex = 8;
            label_ID_number.Text = "ID number";
            // 
            // button_Add
            // 
            button_Add.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_Add.Location = new Point(511, 482);
            button_Add.Name = "button_Add";
            button_Add.Size = new Size(185, 51);
            button_Add.TabIndex = 9;
            button_Add.Text = "ADD CATEGORY";
            button_Add.UseVisualStyleBackColor = true;
            // 
            // Giao_dien_Categories
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button_Add);
            Controls.Add(label_ID_number);
            Controls.Add(label_Category_info);
            Controls.Add(textBox_ID_number);
            Controls.Add(textBox_Category_info);
            Controls.Add(textBox_Name);
            Controls.Add(label_Name);
            Controls.Add(comboBox_Parent_Category);
            Controls.Add(label_Parent_Category);
            Controls.Add(label_Add_Category);
            Name = "Giao_dien_Categories";
            Size = new Size(1178, 565);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_Add_Category;
        private Label label_Parent_Category;
        private ComboBox comboBox_Parent_Category;
        private Label label_Name;
        private TextBox textBox_Name;
        private TextBox textBox_Category_info;
        private TextBox textBox_ID_number;
        private Label label_Category_info;
        private Label label_ID_number;
        private Button button_Add;
    }
}
