namespace Learning_System
{
    partial class Home_Page
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home_Page));
            panel1 = new Panel();
            label_User_Name = new Label();
            picture_user_avatar = new PictureBox();
            picture_menu = new PictureBox();
            panel_popup = new Panel();
            flowLayoutPanel_popup = new FlowLayoutPanel();
            button_Questions = new Button();
            button_Categories = new Button();
            button_Import = new Button();
            button_Export = new Button();
            picture_setting = new PictureBox();
            label_Question_Bank = new Label();
            button_turn_editing_on = new Button();
            label1 = new Label();
            label_IT = new Label();
            panel3 = new Panel();
            panel2 = new Panel();
            panel4 = new Panel();
            giao_dien_tu_pop_up = new Giao_dien_tu_pop_up();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picture_user_avatar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picture_menu).BeginInit();
            panel_popup.SuspendLayout();
            flowLayoutPanel_popup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picture_setting).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label_User_Name);
            panel1.Controls.Add(picture_user_avatar);
            panel1.Controls.Add(picture_menu);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1385, 64);
            panel1.TabIndex = 0;
            // 
            // label_User_Name
            // 
            label_User_Name.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label_User_Name.AutoSize = true;
            label_User_Name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_User_Name.Location = new Point(1215, 15);
            label_User_Name.Name = "label_User_Name";
            label_User_Name.Size = new Size(108, 28);
            label_User_Name.TabIndex = 2;
            label_User_Name.Text = "User Name";
            // 
            // picture_user_avatar
            // 
            picture_user_avatar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picture_user_avatar.Image = (Image)resources.GetObject("picture_user_avatar.Image");
            picture_user_avatar.Location = new Point(1321, 8);
            picture_user_avatar.Name = "picture_user_avatar";
            picture_user_avatar.Size = new Size(59, 45);
            picture_user_avatar.SizeMode = PictureBoxSizeMode.Zoom;
            picture_user_avatar.TabIndex = 1;
            picture_user_avatar.TabStop = false;
            // 
            // picture_menu
            // 
            picture_menu.Image = (Image)resources.GetObject("picture_menu.Image");
            picture_menu.Location = new Point(22, 12);
            picture_menu.Name = "picture_menu";
            picture_menu.Size = new Size(49, 33);
            picture_menu.SizeMode = PictureBoxSizeMode.Zoom;
            picture_menu.TabIndex = 0;
            picture_menu.TabStop = false;
            // 
            // panel_popup
            // 
            panel_popup.Controls.Add(flowLayoutPanel_popup);
            panel_popup.Controls.Add(picture_setting);
            panel_popup.Controls.Add(label_Question_Bank);
            panel_popup.Dock = DockStyle.Top;
            panel_popup.Location = new Point(0, 64);
            panel_popup.MaximumSize = new Size(0, 189);
            panel_popup.MinimumSize = new Size(0, 45);
            panel_popup.Name = "panel_popup";
            panel_popup.Size = new Size(1385, 45);
            panel_popup.TabIndex = 1;
            // 
            // flowLayoutPanel_popup
            // 
            flowLayoutPanel_popup.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            flowLayoutPanel_popup.Controls.Add(button_Questions);
            flowLayoutPanel_popup.Controls.Add(button_Categories);
            flowLayoutPanel_popup.Controls.Add(button_Import);
            flowLayoutPanel_popup.Controls.Add(button_Export);
            flowLayoutPanel_popup.Location = new Point(1144, 6);
            flowLayoutPanel_popup.Name = "flowLayoutPanel_popup";
            flowLayoutPanel_popup.Size = new Size(175, 36);
            flowLayoutPanel_popup.TabIndex = 9;
            flowLayoutPanel_popup.Visible = false;
            // 
            // button_Questions
            // 
            button_Questions.FlatAppearance.BorderSize = 0;
            button_Questions.FlatAppearance.MouseOverBackColor = Color.Gray;
            button_Questions.FlatStyle = FlatStyle.Flat;
            button_Questions.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_Questions.Location = new Point(3, 3);
            button_Questions.Name = "button_Questions";
            button_Questions.Size = new Size(162, 39);
            button_Questions.TabIndex = 5;
            button_Questions.Text = "Questions";
            button_Questions.UseVisualStyleBackColor = true;
            button_Questions.Click += button_Questions_Click;
            // 
            // button_Categories
            // 
            button_Categories.FlatAppearance.BorderSize = 0;
            button_Categories.FlatAppearance.MouseOverBackColor = Color.Gray;
            button_Categories.FlatStyle = FlatStyle.Flat;
            button_Categories.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_Categories.Location = new Point(3, 48);
            button_Categories.Name = "button_Categories";
            button_Categories.Size = new Size(162, 39);
            button_Categories.TabIndex = 6;
            button_Categories.Text = "Categories";
            button_Categories.UseVisualStyleBackColor = true;
            button_Categories.Click += button_Categories_Click;
            // 
            // button_Import
            // 
            button_Import.FlatAppearance.BorderSize = 0;
            button_Import.FlatAppearance.MouseOverBackColor = Color.Gray;
            button_Import.FlatStyle = FlatStyle.Flat;
            button_Import.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_Import.Location = new Point(3, 93);
            button_Import.Name = "button_Import";
            button_Import.Size = new Size(162, 39);
            button_Import.TabIndex = 7;
            button_Import.Text = "Import";
            button_Import.UseVisualStyleBackColor = true;
            button_Import.Click += button_Import_Click;
            // 
            // button_Export
            // 
            button_Export.FlatAppearance.BorderSize = 0;
            button_Export.FlatAppearance.MouseOverBackColor = Color.Gray;
            button_Export.FlatStyle = FlatStyle.Flat;
            button_Export.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_Export.Location = new Point(3, 138);
            button_Export.Name = "button_Export";
            button_Export.Size = new Size(162, 39);
            button_Export.TabIndex = 8;
            button_Export.Text = "Export";
            button_Export.UseVisualStyleBackColor = true;
            button_Export.Click += button_Export_Click;
            // 
            // picture_setting
            // 
            picture_setting.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picture_setting.Image = (Image)resources.GetObject("picture_setting.Image");
            picture_setting.Location = new Point(1325, 6);
            picture_setting.Name = "picture_setting";
            picture_setting.Size = new Size(48, 37);
            picture_setting.SizeMode = PictureBoxSizeMode.Zoom;
            picture_setting.TabIndex = 2;
            picture_setting.TabStop = false;
            picture_setting.Click += picture_setting_Click;
            // 
            // label_Question_Bank
            // 
            label_Question_Bank.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label_Question_Bank.AutoSize = true;
            label_Question_Bank.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label_Question_Bank.Location = new Point(925, 10);
            label_Question_Bank.Name = "label_Question_Bank";
            label_Question_Bank.Size = new Size(197, 38);
            label_Question_Bank.TabIndex = 0;
            label_Question_Bank.Text = "Question Bank";
            label_Question_Bank.Visible = false;
            // 
            // button_turn_editing_on
            // 
            button_turn_editing_on.Anchor = AnchorStyles.Right;
            button_turn_editing_on.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_turn_editing_on.Location = new Point(1164, 63);
            button_turn_editing_on.Name = "button_turn_editing_on";
            button_turn_editing_on.Size = new Size(211, 46);
            button_turn_editing_on.TabIndex = 6;
            button_turn_editing_on.Text = "TURN EDITING ON";
            button_turn_editing_on.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(22, 77);
            label1.Name = "label1";
            label1.Size = new Size(290, 23);
            label1.TabIndex = 1;
            label1.Text = "Home  /  My courses  /  THI GIỮA KỲ";
            // 
            // label_IT
            // 
            label_IT.AutoSize = true;
            label_IT.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label_IT.Location = new Point(22, 3);
            label_IT.Name = "label_IT";
            label_IT.Size = new Size(60, 60);
            label_IT.TabIndex = 0;
            label_IT.Text = "IT";
            // 
            // panel3
            // 
            panel3.Controls.Add(label_IT);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(button_turn_editing_on);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 109);
            panel3.Name = "panel3";
            panel3.Size = new Size(1385, 115);
            panel3.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel4);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 224);
            panel2.Name = "panel2";
            panel2.Size = new Size(1385, 500);
            panel2.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.Controls.Add(giao_dien_tu_pop_up);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1385, 500);
            panel4.TabIndex = 0;
            // 
            // giao_dien_tu_pop_up
            // 
            giao_dien_tu_pop_up.BorderStyle = BorderStyle.FixedSingle;
            giao_dien_tu_pop_up.Dock = DockStyle.Fill;
            giao_dien_tu_pop_up.Location = new Point(0, 0);
            giao_dien_tu_pop_up.Name = "giao_dien_tu_pop_up";
            giao_dien_tu_pop_up.Size = new Size(1385, 500);
            giao_dien_tu_pop_up.TabIndex = 0;
            giao_dien_tu_pop_up.Visible = false;
            // 
            // Home_Page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1385, 724);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel_popup);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Home_Page";
            Text = "Home Page";
            WindowState = FormWindowState.Maximized;
            Load += Home_Page_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picture_user_avatar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picture_menu).EndInit();
            panel_popup.ResumeLayout(false);
            panel_popup.PerformLayout();
            flowLayoutPanel_popup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picture_setting).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label_User_Name;
        private PictureBox picture_user_avatar;
        private PictureBox picture_menu;
        private Panel panel3;
        private PictureBox picture_setting;
        private Label label1;
        private Label label_IT;
        private Label label_Question_Bank;
        private Button button_turn_editing_on;
        private Panel panel_popup;
        private Button button_Questions;
        private Button button_Export;
        private Button button_Import;
        private Button button_Categories;
        private FlowLayoutPanel flowLayoutPanel_popup;
        private Panel panel2;
        private Panel panel4;
        private Giao_dien_tu_pop_up giao_dien_tu_pop_up;
    }
}