using System.ComponentModel;

namespace Learning_System;

partial class AddingNewQuiz
{
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        components = new Container();
        Button btn_Cancel;
        ComponentResourceManager resources = new ComponentResourceManager(typeof(AddingNewQuiz));
        AddNewQuizForm_HeadingLbl = new Label();
        AddNewQuizForm_GeneralLbl = new Label();
        AddNewQuizForm_NameLbl = new Label();
        AddNewQuizForm_NameTxt = new TextBox();
        AddNewQuizFormLbl_Description = new Label();
        AddNewQuizFormTxt_Description = new TextBox();
        AddNewQuizForm_LineLbl = new Label();
        AddNewQuizForm_TiminglLbl = new Label();
        AddNewQuizForm_OpenthequizLbl = new Label();
        AddNewQuizForm_ClosethequizLbl = new Label();
        AddNewQuizForm_Timelimit = new Label();
        AddNewQuizForm_Timeexpires = new Label();
        AddingNewQuizForm_openMonthCbo = new ComboBox();
        timeLimitLabel = new Label();
        AddNewQuizForm_TimelimiMinuteCbo = new ComboBox();
        AddNewQuizForm_TimeexpiresCloseCbo = new ComboBox();
        btn_Create = new Button();
        AddingNewQuizForm_DisplayCb = new CheckBox();
        AddingNewQuizForm_openEnableCb = new CheckBox();
        AddingNewQuizForm_closeEnableCB = new CheckBox();
        AddingNewQuizForm_timeLimitEnableCB = new CheckBox();
        AddingNewQuizForm_openDayNud = new NumericUpDown();
        AddingNewQuizForm_closeDayNud = new NumericUpDown();
        AddingNewQuizForm_closeMonthCbo = new ComboBox();
        AddingNewQuizForm_openYearNud = new NumericUpDown();
        AddingNewQuizForm_closeYearNud = new NumericUpDown();
        AddingNewQuizForm_openHourNud = new NumericUpDown();
        AddingNewQuizForm_openMinuteNud = new NumericUpDown();
        AddingNewQuizForm_closeHourNud = new NumericUpDown();
        AddingNewQuizForm_closeMinuteNud = new NumericUpDown();
        AddingNewQuizForm_timeLimitTxt = new TextBox();
        ImportForm_ExpandPic1 = new PictureBox();
        pictureBox1 = new PictureBox();
        pictureBox4 = new PictureBox();
        pictureBox5 = new PictureBox();
        pictureBox8 = new PictureBox();
        pictureBox9 = new PictureBox();
        pictureBox10 = new PictureBox();
        pictureBox2 = new PictureBox();
        pictureBox3 = new PictureBox();
        AddingNewQuiz_Tooltip = new ToolTip(components);
        btn_Cancel = new Button();
        ((ISupportInitialize)AddingNewQuizForm_openDayNud).BeginInit();
        ((ISupportInitialize)AddingNewQuizForm_closeDayNud).BeginInit();
        ((ISupportInitialize)AddingNewQuizForm_openYearNud).BeginInit();
        ((ISupportInitialize)AddingNewQuizForm_closeYearNud).BeginInit();
        ((ISupportInitialize)AddingNewQuizForm_openHourNud).BeginInit();
        ((ISupportInitialize)AddingNewQuizForm_openMinuteNud).BeginInit();
        ((ISupportInitialize)AddingNewQuizForm_closeHourNud).BeginInit();
        ((ISupportInitialize)AddingNewQuizForm_closeMinuteNud).BeginInit();
        ((ISupportInitialize)ImportForm_ExpandPic1).BeginInit();
        ((ISupportInitialize)pictureBox1).BeginInit();
        ((ISupportInitialize)pictureBox4).BeginInit();
        ((ISupportInitialize)pictureBox5).BeginInit();
        ((ISupportInitialize)pictureBox8).BeginInit();
        ((ISupportInitialize)pictureBox9).BeginInit();
        ((ISupportInitialize)pictureBox10).BeginInit();
        ((ISupportInitialize)pictureBox2).BeginInit();
        ((ISupportInitialize)pictureBox3).BeginInit();
        SuspendLayout();
        // 
        // btn_Cancel
        // 
        btn_Cancel.BackColor = Color.FromArgb(0, 159, 229);
        btn_Cancel.FlatStyle = FlatStyle.Flat;
        btn_Cancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        btn_Cancel.ForeColor = Color.White;
        btn_Cancel.Location = new Point(495, 629);
        btn_Cancel.Name = "btn_Cancel";
        btn_Cancel.Size = new Size(160, 53);
        btn_Cancel.TabIndex = 36;
        btn_Cancel.Text = "CANCEL";
        btn_Cancel.UseVisualStyleBackColor = false;
        btn_Cancel.Click += Btn_Cancel_Click;
        // 
        // AddNewQuizForm_HeadingLbl
        // 
        AddNewQuizForm_HeadingLbl.Font = new Font("Segoe UI", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
        AddNewQuizForm_HeadingLbl.ForeColor = Color.FromArgb(194, 36, 36);
        AddNewQuizForm_HeadingLbl.Location = new Point(4, 7);
        AddNewQuizForm_HeadingLbl.Name = "AddNewQuizForm_HeadingLbl";
        AddNewQuizForm_HeadingLbl.Size = new Size(533, 46);
        AddNewQuizForm_HeadingLbl.TabIndex = 0;
        AddNewQuizForm_HeadingLbl.Text = "Adding a new Quiz";
        // 
        // AddNewQuizForm_GeneralLbl
        // 
        AddNewQuizForm_GeneralLbl.AutoSize = true;
        AddNewQuizForm_GeneralLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
        AddNewQuizForm_GeneralLbl.ForeColor = Color.FromArgb(194, 36, 36);
        AddNewQuizForm_GeneralLbl.Location = new Point(39, 66);
        AddNewQuizForm_GeneralLbl.Name = "AddNewQuizForm_GeneralLbl";
        AddNewQuizForm_GeneralLbl.Size = new Size(71, 23);
        AddNewQuizForm_GeneralLbl.TabIndex = 1;
        AddNewQuizForm_GeneralLbl.Text = "General";
        // 
        // AddNewQuizForm_NameLbl
        // 
        AddNewQuizForm_NameLbl.AutoSize = true;
        AddNewQuizForm_NameLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
        AddNewQuizForm_NameLbl.Location = new Point(25, 100);
        AddNewQuizForm_NameLbl.Name = "AddNewQuizForm_NameLbl";
        AddNewQuizForm_NameLbl.Size = new Size(56, 23);
        AddNewQuizForm_NameLbl.TabIndex = 3;
        AddNewQuizForm_NameLbl.Text = "Name";
        // 
        // AddNewQuizForm_NameTxt
        // 
        AddNewQuizForm_NameTxt.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
        AddNewQuizForm_NameTxt.Location = new Point(237, 100);
        AddNewQuizForm_NameTxt.Multiline = true;
        AddNewQuizForm_NameTxt.Name = "AddNewQuizForm_NameTxt";
        AddNewQuizForm_NameTxt.Size = new Size(400, 27);
        AddNewQuizForm_NameTxt.TabIndex = 4;
        // 
        // AddNewQuizFormLbl_Description
        // 
        AddNewQuizFormLbl_Description.AutoSize = true;
        AddNewQuizFormLbl_Description.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
        AddNewQuizFormLbl_Description.Location = new Point(25, 140);
        AddNewQuizFormLbl_Description.Name = "AddNewQuizFormLbl_Description";
        AddNewQuizFormLbl_Description.Size = new Size(96, 23);
        AddNewQuizFormLbl_Description.TabIndex = 5;
        AddNewQuizFormLbl_Description.Text = "Description";
        AddNewQuizFormLbl_Description.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // AddNewQuizFormTxt_Description
        // 
        AddNewQuizFormTxt_Description.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
        AddNewQuizFormTxt_Description.Location = new Point(237, 140);
        AddNewQuizFormTxt_Description.Multiline = true;
        AddNewQuizFormTxt_Description.Name = "AddNewQuizFormTxt_Description";
        AddNewQuizFormTxt_Description.Size = new Size(627, 200);
        AddNewQuizFormTxt_Description.TabIndex = 6;
        // 
        // AddNewQuizForm_LineLbl
        // 
        AddNewQuizForm_LineLbl.BorderStyle = BorderStyle.FixedSingle;
        AddNewQuizForm_LineLbl.Location = new Point(24, 387);
        AddNewQuizForm_LineLbl.Name = "AddNewQuizForm_LineLbl";
        AddNewQuizForm_LineLbl.Size = new Size(840, 1);
        AddNewQuizForm_LineLbl.TabIndex = 9;
        // 
        // AddNewQuizForm_TiminglLbl
        // 
        AddNewQuizForm_TiminglLbl.AutoSize = true;
        AddNewQuizForm_TiminglLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
        AddNewQuizForm_TiminglLbl.ForeColor = Color.FromArgb(194, 36, 36);
        AddNewQuizForm_TiminglLbl.Location = new Point(39, 399);
        AddNewQuizForm_TiminglLbl.Name = "AddNewQuizForm_TiminglLbl";
        AddNewQuizForm_TiminglLbl.Size = new Size(67, 23);
        AddNewQuizForm_TiminglLbl.TabIndex = 10;
        AddNewQuizForm_TiminglLbl.Text = "Timing";
        // 
        // AddNewQuizForm_OpenthequizLbl
        // 
        AddNewQuizForm_OpenthequizLbl.AutoSize = true;
        AddNewQuizForm_OpenthequizLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
        AddNewQuizForm_OpenthequizLbl.Location = new Point(25, 444);
        AddNewQuizForm_OpenthequizLbl.Name = "AddNewQuizForm_OpenthequizLbl";
        AddNewQuizForm_OpenthequizLbl.Size = new Size(119, 23);
        AddNewQuizForm_OpenthequizLbl.TabIndex = 11;
        AddNewQuizForm_OpenthequizLbl.Text = "Open the quiz";
        // 
        // AddNewQuizForm_ClosethequizLbl
        // 
        AddNewQuizForm_ClosethequizLbl.AutoSize = true;
        AddNewQuizForm_ClosethequizLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
        AddNewQuizForm_ClosethequizLbl.Location = new Point(24, 486);
        AddNewQuizForm_ClosethequizLbl.Name = "AddNewQuizForm_ClosethequizLbl";
        AddNewQuizForm_ClosethequizLbl.Size = new Size(118, 23);
        AddNewQuizForm_ClosethequizLbl.TabIndex = 12;
        AddNewQuizForm_ClosethequizLbl.Text = "Close the quiz";
        // 
        // AddNewQuizForm_Timelimit
        // 
        AddNewQuizForm_Timelimit.AutoSize = true;
        AddNewQuizForm_Timelimit.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
        AddNewQuizForm_Timelimit.Location = new Point(25, 529);
        AddNewQuizForm_Timelimit.Name = "AddNewQuizForm_Timelimit";
        AddNewQuizForm_Timelimit.Size = new Size(85, 23);
        AddNewQuizForm_Timelimit.TabIndex = 13;
        AddNewQuizForm_Timelimit.Text = "Time limit";
        // 
        // AddNewQuizForm_Timeexpires
        // 
        AddNewQuizForm_Timeexpires.AutoSize = true;
        AddNewQuizForm_Timeexpires.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
        AddNewQuizForm_Timeexpires.Location = new Point(25, 573);
        AddNewQuizForm_Timeexpires.Name = "AddNewQuizForm_Timeexpires";
        AddNewQuizForm_Timeexpires.Size = new Size(152, 23);
        AddNewQuizForm_Timeexpires.TabIndex = 14;
        AddNewQuizForm_Timeexpires.Text = "When time expires";
        // 
        // AddingNewQuizForm_openMonthCbo
        // 
        AddingNewQuizForm_openMonthCbo.Enabled = false;
        AddingNewQuizForm_openMonthCbo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        AddingNewQuizForm_openMonthCbo.ItemHeight = 23;
        AddingNewQuizForm_openMonthCbo.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
        AddingNewQuizForm_openMonthCbo.Location = new Point(307, 440);
        AddingNewQuizForm_openMonthCbo.Name = "AddingNewQuizForm_openMonthCbo";
        AddingNewQuizForm_openMonthCbo.Size = new Size(90, 31);
        AddingNewQuizForm_openMonthCbo.TabIndex = 16;
        AddingNewQuizForm_openMonthCbo.SelectedIndexChanged += AddingNewQuizForm_openMonthCbo_SelectedIndexChanged;
        // 
        // timeLimitLabel
        // 
        timeLimitLabel.Font = new Font("Segoe UI", 12.5F, FontStyle.Regular, GraphicsUnit.Point);
        timeLimitLabel.Location = new Point(295, 765);
        timeLimitLabel.Name = "timeLimitLabel";
        timeLimitLabel.Size = new Size(25, 30);
        timeLimitLabel.TabIndex = 34;
        timeLimitLabel.Text = "0";
        // 
        // AddNewQuizForm_TimelimiMinuteCbo
        // 
        AddNewQuizForm_TimelimiMinuteCbo.Enabled = false;
        AddNewQuizForm_TimelimiMinuteCbo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
        AddNewQuizForm_TimelimiMinuteCbo.Items.AddRange(new object[] { "minutes", "hours" });
        AddNewQuizForm_TimelimiMinuteCbo.Location = new Point(307, 525);
        AddNewQuizForm_TimelimiMinuteCbo.Name = "AddNewQuizForm_TimelimiMinuteCbo";
        AddNewQuizForm_TimelimiMinuteCbo.Size = new Size(90, 31);
        AddNewQuizForm_TimelimiMinuteCbo.TabIndex = 30;
        // 
        // AddNewQuizForm_TimeexpiresCloseCbo
        // 
        AddNewQuizForm_TimeexpiresCloseCbo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
        AddNewQuizForm_TimeexpiresCloseCbo.Items.AddRange(new object[] { " Open attempts are submitted automatically" });
        AddNewQuizForm_TimeexpiresCloseCbo.Location = new Point(237, 570);
        AddNewQuizForm_TimeexpiresCloseCbo.Name = "AddNewQuizForm_TimeexpiresCloseCbo";
        AddNewQuizForm_TimeexpiresCloseCbo.Size = new Size(389, 31);
        AddNewQuizForm_TimeexpiresCloseCbo.TabIndex = 33;
        // 
        // btn_Create
        // 
        btn_Create.BackColor = Color.FromArgb(194, 36, 36);
        btn_Create.FlatStyle = FlatStyle.Flat;
        btn_Create.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        btn_Create.ForeColor = Color.White;
        btn_Create.Location = new Point(315, 629);
        btn_Create.Name = "btn_Create";
        btn_Create.Size = new Size(160, 53);
        btn_Create.TabIndex = 35;
        btn_Create.Text = "CREATE";
        btn_Create.UseVisualStyleBackColor = false;
        btn_Create.Click += Btn_Create_Click;
        // 
        // AddingNewQuizForm_DisplayCb
        // 
        AddingNewQuizForm_DisplayCb.AutoSize = true;
        AddingNewQuizForm_DisplayCb.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
        AddingNewQuizForm_DisplayCb.Location = new Point(237, 353);
        AddingNewQuizForm_DisplayCb.Margin = new Padding(2);
        AddingNewQuizForm_DisplayCb.Name = "AddingNewQuizForm_DisplayCb";
        AddingNewQuizForm_DisplayCb.Size = new Size(293, 27);
        AddingNewQuizForm_DisplayCb.TabIndex = 37;
        AddingNewQuizForm_DisplayCb.Text = "Display discription on course page";
        AddingNewQuizForm_DisplayCb.UseVisualStyleBackColor = true;
        // 
        // AddingNewQuizForm_openEnableCb
        // 
        AddingNewQuizForm_openEnableCb.AutoSize = true;
        AddingNewQuizForm_openEnableCb.Enabled = false;
        AddingNewQuizForm_openEnableCb.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
        AddingNewQuizForm_openEnableCb.Location = new Point(672, 440);
        AddingNewQuizForm_openEnableCb.Margin = new Padding(2);
        AddingNewQuizForm_openEnableCb.Name = "AddingNewQuizForm_openEnableCb";
        AddingNewQuizForm_openEnableCb.Size = new Size(83, 27);
        AddingNewQuizForm_openEnableCb.TabIndex = 38;
        AddingNewQuizForm_openEnableCb.Text = "Enable";
        AddingNewQuizForm_openEnableCb.UseVisualStyleBackColor = true;
        // 
        // AddingNewQuizForm_closeEnableCB
        // 
        AddingNewQuizForm_closeEnableCB.AutoSize = true;
        AddingNewQuizForm_closeEnableCB.Enabled = false;
        AddingNewQuizForm_closeEnableCB.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
        AddingNewQuizForm_closeEnableCB.Location = new Point(672, 480);
        AddingNewQuizForm_closeEnableCB.Margin = new Padding(2);
        AddingNewQuizForm_closeEnableCB.Name = "AddingNewQuizForm_closeEnableCB";
        AddingNewQuizForm_closeEnableCB.Size = new Size(83, 27);
        AddingNewQuizForm_closeEnableCB.TabIndex = 39;
        AddingNewQuizForm_closeEnableCB.Text = "Enable";
        AddingNewQuizForm_closeEnableCB.UseVisualStyleBackColor = true;
        // 
        // AddingNewQuizForm_timeLimitEnableCB
        // 
        AddingNewQuizForm_timeLimitEnableCB.AutoSize = true;
        AddingNewQuizForm_timeLimitEnableCB.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
        AddingNewQuizForm_timeLimitEnableCB.Location = new Point(407, 525);
        AddingNewQuizForm_timeLimitEnableCB.Margin = new Padding(2);
        AddingNewQuizForm_timeLimitEnableCB.Name = "AddingNewQuizForm_timeLimitEnableCB";
        AddingNewQuizForm_timeLimitEnableCB.Size = new Size(83, 27);
        AddingNewQuizForm_timeLimitEnableCB.TabIndex = 40;
        AddingNewQuizForm_timeLimitEnableCB.Text = "Enable";
        AddingNewQuizForm_timeLimitEnableCB.UseVisualStyleBackColor = true;
        AddingNewQuizForm_timeLimitEnableCB.CheckedChanged += AddingNewQuizForm_timeLimitEnableCB_CheckedChanged;
        // 
        // AddingNewQuizForm_openDayNud
        // 
        AddingNewQuizForm_openDayNud.Enabled = false;
        AddingNewQuizForm_openDayNud.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
        AddingNewQuizForm_openDayNud.Location = new Point(237, 440);
        AddingNewQuizForm_openDayNud.Margin = new Padding(2);
        AddingNewQuizForm_openDayNud.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
        AddingNewQuizForm_openDayNud.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        AddingNewQuizForm_openDayNud.Name = "AddingNewQuizForm_openDayNud";
        AddingNewQuizForm_openDayNud.Size = new Size(59, 30);
        AddingNewQuizForm_openDayNud.TabIndex = 41;
        AddingNewQuizForm_openDayNud.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // AddingNewQuizForm_closeDayNud
        // 
        AddingNewQuizForm_closeDayNud.Enabled = false;
        AddingNewQuizForm_closeDayNud.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
        AddingNewQuizForm_closeDayNud.Location = new Point(237, 480);
        AddingNewQuizForm_closeDayNud.Margin = new Padding(2);
        AddingNewQuizForm_closeDayNud.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
        AddingNewQuizForm_closeDayNud.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        AddingNewQuizForm_closeDayNud.Name = "AddingNewQuizForm_closeDayNud";
        AddingNewQuizForm_closeDayNud.Size = new Size(59, 30);
        AddingNewQuizForm_closeDayNud.TabIndex = 42;
        AddingNewQuizForm_closeDayNud.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // AddingNewQuizForm_closeMonthCbo
        // 
        AddingNewQuizForm_closeMonthCbo.Enabled = false;
        AddingNewQuizForm_closeMonthCbo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
        AddingNewQuizForm_closeMonthCbo.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
        AddingNewQuizForm_closeMonthCbo.Location = new Point(307, 480);
        AddingNewQuizForm_closeMonthCbo.Name = "AddingNewQuizForm_closeMonthCbo";
        AddingNewQuizForm_closeMonthCbo.Size = new Size(90, 31);
        AddingNewQuizForm_closeMonthCbo.TabIndex = 43;
        AddingNewQuizForm_closeMonthCbo.SelectedIndexChanged += AddingNewQuizForm_closeMonthCbo_SelectedIndexChanged;
        // 
        // AddingNewQuizForm_openYearNud
        // 
        AddingNewQuizForm_openYearNud.Enabled = false;
        AddingNewQuizForm_openYearNud.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
        AddingNewQuizForm_openYearNud.Location = new Point(407, 440);
        AddingNewQuizForm_openYearNud.Margin = new Padding(2);
        AddingNewQuizForm_openYearNud.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
        AddingNewQuizForm_openYearNud.Minimum = new decimal(new int[] { 2023, 0, 0, 0 });
        AddingNewQuizForm_openYearNud.Name = "AddingNewQuizForm_openYearNud";
        AddingNewQuizForm_openYearNud.Size = new Size(69, 30);
        AddingNewQuizForm_openYearNud.TabIndex = 44;
        AddingNewQuizForm_openYearNud.Value = new decimal(new int[] { 2023, 0, 0, 0 });
        // 
        // AddingNewQuizForm_closeYearNud
        // 
        AddingNewQuizForm_closeYearNud.Enabled = false;
        AddingNewQuizForm_closeYearNud.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
        AddingNewQuizForm_closeYearNud.Location = new Point(407, 480);
        AddingNewQuizForm_closeYearNud.Margin = new Padding(2);
        AddingNewQuizForm_closeYearNud.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
        AddingNewQuizForm_closeYearNud.Minimum = new decimal(new int[] { 2023, 0, 0, 0 });
        AddingNewQuizForm_closeYearNud.Name = "AddingNewQuizForm_closeYearNud";
        AddingNewQuizForm_closeYearNud.Size = new Size(69, 30);
        AddingNewQuizForm_closeYearNud.TabIndex = 45;
        AddingNewQuizForm_closeYearNud.Value = new decimal(new int[] { 2023, 0, 0, 0 });
        // 
        // AddingNewQuizForm_openHourNud
        // 
        AddingNewQuizForm_openHourNud.Enabled = false;
        AddingNewQuizForm_openHourNud.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
        AddingNewQuizForm_openHourNud.Location = new Point(492, 440);
        AddingNewQuizForm_openHourNud.Margin = new Padding(2);
        AddingNewQuizForm_openHourNud.Maximum = new decimal(new int[] { 23, 0, 0, 0 });
        AddingNewQuizForm_openHourNud.Name = "AddingNewQuizForm_openHourNud";
        AddingNewQuizForm_openHourNud.Size = new Size(59, 30);
        AddingNewQuizForm_openHourNud.TabIndex = 46;
        AddingNewQuizForm_openHourNud.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // AddingNewQuizForm_openMinuteNud
        // 
        AddingNewQuizForm_openMinuteNud.Enabled = false;
        AddingNewQuizForm_openMinuteNud.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
        AddingNewQuizForm_openMinuteNud.Location = new Point(567, 440);
        AddingNewQuizForm_openMinuteNud.Margin = new Padding(2);
        AddingNewQuizForm_openMinuteNud.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
        AddingNewQuizForm_openMinuteNud.Name = "AddingNewQuizForm_openMinuteNud";
        AddingNewQuizForm_openMinuteNud.Size = new Size(59, 30);
        AddingNewQuizForm_openMinuteNud.TabIndex = 47;
        AddingNewQuizForm_openMinuteNud.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // AddingNewQuizForm_closeHourNud
        // 
        AddingNewQuizForm_closeHourNud.Enabled = false;
        AddingNewQuizForm_closeHourNud.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
        AddingNewQuizForm_closeHourNud.Location = new Point(492, 480);
        AddingNewQuizForm_closeHourNud.Margin = new Padding(2);
        AddingNewQuizForm_closeHourNud.Maximum = new decimal(new int[] { 23, 0, 0, 0 });
        AddingNewQuizForm_closeHourNud.Name = "AddingNewQuizForm_closeHourNud";
        AddingNewQuizForm_closeHourNud.Size = new Size(59, 30);
        AddingNewQuizForm_closeHourNud.TabIndex = 48;
        AddingNewQuizForm_closeHourNud.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // AddingNewQuizForm_closeMinuteNud
        // 
        AddingNewQuizForm_closeMinuteNud.Enabled = false;
        AddingNewQuizForm_closeMinuteNud.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
        AddingNewQuizForm_closeMinuteNud.Location = new Point(567, 480);
        AddingNewQuizForm_closeMinuteNud.Margin = new Padding(2);
        AddingNewQuizForm_closeMinuteNud.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
        AddingNewQuizForm_closeMinuteNud.Name = "AddingNewQuizForm_closeMinuteNud";
        AddingNewQuizForm_closeMinuteNud.Size = new Size(59, 30);
        AddingNewQuizForm_closeMinuteNud.TabIndex = 49;
        AddingNewQuizForm_closeMinuteNud.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // AddingNewQuizForm_timeLimitTxt
        // 
        AddingNewQuizForm_timeLimitTxt.Enabled = false;
        AddingNewQuizForm_timeLimitTxt.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
        AddingNewQuizForm_timeLimitTxt.Location = new Point(237, 525);
        AddingNewQuizForm_timeLimitTxt.Margin = new Padding(2);
        AddingNewQuizForm_timeLimitTxt.Name = "AddingNewQuizForm_timeLimitTxt";
        AddingNewQuizForm_timeLimitTxt.Size = new Size(59, 30);
        AddingNewQuizForm_timeLimitTxt.TabIndex = 50;
        AddingNewQuizForm_timeLimitTxt.KeyPress += TimeLimit_KeyPress;
        // 
        // ImportForm_ExpandPic1
        // 
        ImportForm_ExpandPic1.Image = (Image)resources.GetObject("ImportForm_ExpandPic1.Image");
        ImportForm_ExpandPic1.Location = new Point(25, 73);
        ImportForm_ExpandPic1.Name = "ImportForm_ExpandPic1";
        ImportForm_ExpandPic1.Size = new Size(15, 10);
        ImportForm_ExpandPic1.SizeMode = PictureBoxSizeMode.Zoom;
        ImportForm_ExpandPic1.TabIndex = 52;
        ImportForm_ExpandPic1.TabStop = false;
        // 
        // pictureBox1
        // 
        pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
        pictureBox1.Location = new Point(25, 407);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(15, 10);
        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox1.TabIndex = 53;
        pictureBox1.TabStop = false;
        // 
        // pictureBox4
        // 
        pictureBox4.Image = Properties.Resources.exclaimation_removebg_preview;
        pictureBox4.Location = new Point(205, 103);
        pictureBox4.Name = "pictureBox4";
        pictureBox4.Size = new Size(20, 20);
        pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox4.TabIndex = 56;
        pictureBox4.TabStop = false;
        AddingNewQuiz_Tooltip.SetToolTip(pictureBox4, "Required");
        // 
        // pictureBox5
        // 
        pictureBox5.Image = Properties.Resources.question_removebg_preview;
        pictureBox5.Location = new Point(205, 444);
        pictureBox5.Name = "pictureBox5";
        pictureBox5.Size = new Size(20, 20);
        pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox5.TabIndex = 57;
        pictureBox5.TabStop = false;
        AddingNewQuiz_Tooltip.SetToolTip(pictureBox5, "Time when quiz start. If Enable isn't checked, quiz will always open. Same as close.");
        // 
        // pictureBox8
        // 
        pictureBox8.Image = Properties.Resources.question_removebg_preview;
        pictureBox8.Location = new Point(535, 357);
        pictureBox8.Name = "pictureBox8";
        pictureBox8.Size = new Size(20, 20);
        pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox8.TabIndex = 60;
        pictureBox8.TabStop = false;
        // 
        // pictureBox9
        // 
        pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
        pictureBox9.Location = new Point(630, 446);
        pictureBox9.Name = "pictureBox9";
        pictureBox9.Size = new Size(25, 25);
        pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox9.TabIndex = 61;
        pictureBox9.TabStop = false;
        // 
        // pictureBox10
        // 
        pictureBox10.Image = (Image)resources.GetObject("pictureBox10.Image");
        pictureBox10.Location = new Point(630, 486);
        pictureBox10.Name = "pictureBox10";
        pictureBox10.Size = new Size(25, 25);
        pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox10.TabIndex = 62;
        pictureBox10.TabStop = false;
        // 
        // pictureBox2
        // 
        pictureBox2.Image = Properties.Resources.question_removebg_preview;
        pictureBox2.Location = new Point(205, 529);
        pictureBox2.Name = "pictureBox2";
        pictureBox2.Size = new Size(20, 20);
        pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox2.TabIndex = 63;
        pictureBox2.TabStop = false;
        AddingNewQuiz_Tooltip.SetToolTip(pictureBox2, "If Enable isn't checked, users will be able to submit anytime.");
        // 
        // pictureBox3
        // 
        pictureBox3.Image = Properties.Resources.question_removebg_preview;
        pictureBox3.Location = new Point(205, 573);
        pictureBox3.Name = "pictureBox3";
        pictureBox3.Size = new Size(20, 20);
        pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox3.TabIndex = 64;
        pictureBox3.TabStop = false;
        AddingNewQuiz_Tooltip.SetToolTip(pictureBox3, "What to do with this contest when time expires.");
        // 
        // AddingNewQuiz
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        AutoSizeMode = AutoSizeMode.GrowAndShrink;
        BackColor = SystemColors.ControlLightLight;
        ClientSize = new Size(904, 706);
        Controls.Add(pictureBox3);
        Controls.Add(pictureBox2);
        Controls.Add(pictureBox1);
        Controls.Add(pictureBox4);
        Controls.Add(pictureBox5);
        Controls.Add(pictureBox8);
        Controls.Add(pictureBox9);
        Controls.Add(pictureBox10);
        Controls.Add(ImportForm_ExpandPic1);
        Controls.Add(AddingNewQuizForm_timeLimitTxt);
        Controls.Add(AddingNewQuizForm_closeMinuteNud);
        Controls.Add(AddingNewQuizForm_closeHourNud);
        Controls.Add(AddingNewQuizForm_openMinuteNud);
        Controls.Add(AddingNewQuizForm_openHourNud);
        Controls.Add(AddingNewQuizForm_closeYearNud);
        Controls.Add(AddingNewQuizForm_openYearNud);
        Controls.Add(AddingNewQuizForm_closeMonthCbo);
        Controls.Add(AddingNewQuizForm_closeDayNud);
        Controls.Add(AddingNewQuizForm_openDayNud);
        Controls.Add(AddingNewQuizForm_timeLimitEnableCB);
        Controls.Add(AddingNewQuizForm_closeEnableCB);
        Controls.Add(AddingNewQuizForm_openEnableCb);
        Controls.Add(AddingNewQuizForm_DisplayCb);
        Controls.Add(btn_Cancel);
        Controls.Add(btn_Create);
        Controls.Add(timeLimitLabel);
        Controls.Add(AddNewQuizForm_HeadingLbl);
        Controls.Add(AddNewQuizForm_GeneralLbl);
        Controls.Add(AddNewQuizForm_NameTxt);
        Controls.Add(AddNewQuizFormTxt_Description);
        Controls.Add(AddNewQuizForm_NameLbl);
        Controls.Add(AddNewQuizFormLbl_Description);
        Controls.Add(AddNewQuizForm_LineLbl);
        Controls.Add(AddNewQuizForm_TiminglLbl);
        Controls.Add(AddNewQuizForm_OpenthequizLbl);
        Controls.Add(AddNewQuizForm_ClosethequizLbl);
        Controls.Add(AddNewQuizForm_Timelimit);
        Controls.Add(AddNewQuizForm_Timeexpires);
        Controls.Add(AddingNewQuizForm_openMonthCbo);
        Controls.Add(AddNewQuizForm_TimelimiMinuteCbo);
        Controls.Add(AddNewQuizForm_TimeexpiresCloseCbo);
        MaximizeBox = false;
        Name = "AddingNewQuiz";
        ((ISupportInitialize)AddingNewQuizForm_openDayNud).EndInit();
        ((ISupportInitialize)AddingNewQuizForm_closeDayNud).EndInit();
        ((ISupportInitialize)AddingNewQuizForm_openYearNud).EndInit();
        ((ISupportInitialize)AddingNewQuizForm_closeYearNud).EndInit();
        ((ISupportInitialize)AddingNewQuizForm_openHourNud).EndInit();
        ((ISupportInitialize)AddingNewQuizForm_openMinuteNud).EndInit();
        ((ISupportInitialize)AddingNewQuizForm_closeHourNud).EndInit();
        ((ISupportInitialize)AddingNewQuizForm_closeMinuteNud).EndInit();
        ((ISupportInitialize)ImportForm_ExpandPic1).EndInit();
        ((ISupportInitialize)pictureBox1).EndInit();
        ((ISupportInitialize)pictureBox4).EndInit();
        ((ISupportInitialize)pictureBox5).EndInit();
        ((ISupportInitialize)pictureBox8).EndInit();
        ((ISupportInitialize)pictureBox9).EndInit();
        ((ISupportInitialize)pictureBox10).EndInit();
        ((ISupportInitialize)pictureBox2).EndInit();
        ((ISupportInitialize)pictureBox3).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }
    #endregion

    private Label AddNewQuizForm_HeadingLbl;
    private Label AddNewQuizForm_GeneralLbl;
    private TextBox AddNewQuizForm_NameTxt;
    private Label AddNewQuizForm_NameLbl;
    private TextBox AddNewQuizFormTxt_Description;
    private Label AddNewQuizFormLbl_Description;
    private Label AddNewQuizForm_LineLbl;
    private Label AddNewQuizForm_TiminglLbl;
    private Label AddNewQuizForm_OpenthequizLbl;
    private Label AddNewQuizForm_ClosethequizLbl;
    private Label AddNewQuizForm_Timelimit;
    private Label AddNewQuizForm_Timeexpires;
    private ComboBox AddingNewQuizForm_openMonthCbo;
    private ComboBox AddNewQuizForm_TimelimiMinuteCbo;
    private ComboBox AddNewQuizForm_TimeexpiresCloseCbo;
    private Label timeLimitLabel;
    private Button btn_Create;
    private Button btn_Cancel;
    private CheckBox AddingNewQuizForm_DisplayCb;
    private CheckBox AddingNewQuizForm_openEnableCb;
    private CheckBox AddingNewQuizForm_closeEnableCB;
    private CheckBox AddingNewQuizForm_timeLimitEnableCB;
    private NumericUpDown AddingNewQuizForm_openDayNud;
    private NumericUpDown AddingNewQuizForm_closeDayNud;
    private ComboBox AddingNewQuizForm_closeMonthCbo;
    private NumericUpDown AddingNewQuizForm_openYearNud;
    private NumericUpDown AddingNewQuizForm_closeYearNud;
    private NumericUpDown AddingNewQuizForm_openHourNud;
    private NumericUpDown AddingNewQuizForm_openMinuteNud;
    private NumericUpDown AddingNewQuizForm_closeHourNud;
    private NumericUpDown AddingNewQuizForm_closeMinuteNud;
    private TextBox AddingNewQuizForm_timeLimitTxt;
    private PictureBox ImportForm_ExpandPic1;
    private PictureBox pictureBox1;
    private PictureBox pictureBox4;
    private PictureBox pictureBox5;
    private PictureBox pictureBox8;
    private PictureBox pictureBox9;
    private PictureBox pictureBox10;
    private PictureBox pictureBox2;
    private PictureBox pictureBox3;
    private ToolTip AddingNewQuiz_Tooltip;
}
/*
=======
        
         //
            //AddNewQuizForm_GeneralLbl
            //

            AddNewQuizForm_GeneralLbl = new Label();
            AddNewQuizForm_GeneralLbl.AutoSize = true;
            AddNewQuizForm_GeneralLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            AddNewQuizForm_GeneralLbl.ForeColor = Color.FromArgb(194, 36, 36);
            AddNewQuizForm_GeneralLbl.Location = new Point(46, 59);
            AddNewQuizForm_GeneralLbl.Name = "AddNewQuizForm_GeneralLbl";
            AddNewQuizForm_GeneralLbl.Size = new Size(96, 28);
            AddNewQuizForm_GeneralLbl.TabIndex = 1;
            AddNewQuizForm_GeneralLbl.Text = "General";

            //
            //AddNewQuizForm_NameLbl
            //

            AddNewQuizForm_NameLbl = new Label();
            AddNewQuizForm_NameLbl.AutoSize = true;
            AddNewQuizForm_NameLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            AddNewQuizForm_NameLbl.Location = new Point(13, 100);
            AddNewQuizForm_NameLbl.Name = "AddNewQuizForm_NameLbl";
            AddNewQuizForm_NameLbl.Size = new Size(56, 23);
            AddNewQuizForm_NameLbl.TabIndex = 3;
            AddNewQuizForm_NameLbl.Text = "Name";

            //
            // AddNewQuizForm_NameTxt
            //

            AddNewQuizForm_NameTxt = new TextBox();
            AddNewQuizForm_NameTxt.Location = new Point(205, 100);
            AddNewQuizForm_NameTxt.Multiline = true;
            AddNewQuizForm_NameTxt.Size = new Size(400, 27);
            AddNewQuizForm_NameTxt.Name = "AddNewQuizForm_NameTxt";
            AddNewQuizForm_NameTxt.TabIndex = 4;

            //
            //AddNewQuizFormLbl_DecriptionLbl
            //

            AddNewQuizFormLbl_Description = new Label();
            AddNewQuizFormLbl_Description.AutoSize = true;
            AddNewQuizFormLbl_Description.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            AddNewQuizFormLbl_Description.Location = new Point(13, 140);
            AddNewQuizFormLbl_Description.Name = "AddNewQuizFormLbl";
            AddNewQuizFormLbl_Description.Size = new Size(113, 23);
            AddNewQuizFormLbl_Description.TabIndex = 5;
            AddNewQuizFormLbl_Description.Text = "Description";

            //
            // AddNewQuizFormTxt_Description
            //

            AddNewQuizFormTxt_Description = new TextBox();
            AddNewQuizFormTxt_Description.Location = new Point(205, 140);
            AddNewQuizFormTxt_Description.Multiline = true;
            AddNewQuizFormTxt_Description.Name = "AddNewQuizForm_Description";
            AddNewQuizFormTxt_Description.Size = new Size(600, 200);
            AddNewQuizFormTxt_Description.TabIndex = 6;

            //
            // AddNewQuizForm_DisplayTbt
            //

            AddNewQuizForm_DisplayTbt = new TextBox();
            AddNewQuizForm_DisplayTbt.Location = new Point(205, 350);
            AddNewQuizForm_DisplayTbt.Multiline = true;
            AddNewQuizForm_DisplayTbt.Name = "AddNewQuizForm_DisplayTbt";
            AddNewQuizForm_DisplayTbt.Size = new Size(15, 15);
            AddNewQuizForm_DisplayTbt.TabIndex = 7;

            //
            //   AddNewQuizForm_DisplayLbl
            //

            AddNewQuizForm_DisplayLbl = new Label();
            AddNewQuizForm_DisplayLbl.AutoSize = true;
            AddNewQuizForm_DisplayLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            AddNewQuizForm_DisplayLbl.Location = new Point(220, 350);
            AddNewQuizForm_DisplayLbl.Size = new Size(500, 46);
            AddNewQuizForm_DisplayLbl.Name = "AddNewQuizForm_DisplayLbl";
            AddNewQuizForm_DisplayLbl.TabIndex = 8;
            AddNewQuizForm_DisplayLbl.Text = "Display description on course page";

            //
            // AddNewQuizForm_LineLbl
            //

            AddNewQuizForm_LineLbl = new Label();
            AddNewQuizForm_LineLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            AddNewQuizForm_LineLbl.AutoSize = false;
            AddNewQuizForm_LineLbl.Name = "AddNewQuizForm_LineLbl";
            AddNewQuizForm_LineLbl.TabIndex = 9;
            AddNewQuizForm_LineLbl.Location = new Point(13, 375);
            AddNewQuizForm_LineLbl.Size = new Size(800, 2);

            //
            // AddNewQuizForm_TiminglLbl
            //

            AddNewQuizForm_TiminglLbl = new Label();
            AddNewQuizForm_TiminglLbl.AutoSize = true;
            AddNewQuizForm_TiminglLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            AddNewQuizForm_TiminglLbl.ForeColor = Color.FromArgb(194, 36, 36);
            AddNewQuizForm_TiminglLbl.Location = new Point(46, 380);
            AddNewQuizForm_TiminglLbl.Name = "AddNewQuizForm_GeneralLbl";
            AddNewQuizForm_TiminglLbl.Size = new Size(96, 28);
            AddNewQuizForm_TiminglLbl.TabIndex = 10;
            AddNewQuizForm_TiminglLbl.Text = "Timing";

            //
            //  AddNewQuizForm_OpenthequizLbl
            //

            AddNewQuizForm_OpenthequizLbl = new Label();
            AddNewQuizForm_OpenthequizLbl.AutoSize = true;
            AddNewQuizForm_OpenthequizLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            AddNewQuizForm_OpenthequizLbl.Location = new Point(13, 415);
            AddNewQuizForm_OpenthequizLbl.Name = "AddNewQuizForm_OpenthequizLbl";
            AddNewQuizForm_OpenthequizLbl.Size = new Size(113, 23);
            AddNewQuizForm_OpenthequizLbl.TabIndex = 11;
            AddNewQuizForm_OpenthequizLbl.Text = "Open the quiz";

            //
            //AddNewQuizForm_ClosethequizLbl
            //

            AddNewQuizForm_ClosethequizLbl = new Label();
            AddNewQuizForm_ClosethequizLbl.AutoSize = true;
            AddNewQuizForm_ClosethequizLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            AddNewQuizForm_ClosethequizLbl.Location = new Point(13, 455);
            AddNewQuizForm_ClosethequizLbl.Name = "AddNewQuizForm_ClosethequizLbl";
            AddNewQuizForm_ClosethequizLbl.Size = new Size(113, 23);
            AddNewQuizForm_ClosethequizLbl.TabIndex = 12;
            AddNewQuizForm_ClosethequizLbl.Text = "Close the quiz";

            //
            // AddNewQuizForm_Timelimit
            // 

            AddNewQuizForm_Timelimit = new Label();
            AddNewQuizForm_Timelimit.AutoSize = true;
            AddNewQuizForm_Timelimit.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            AddNewQuizForm_Timelimit.Location = new Point(13, 500);
            AddNewQuizForm_Timelimit.Name = "AddNewQuizForm_Timelimit";
            AddNewQuizForm_Timelimit.Size = new Size(113, 23);
            AddNewQuizForm_Timelimit.TabIndex = 13;
            AddNewQuizForm_Timelimit.Text = "Time limit";

            //
            //AddNewQuizForm_Timeexpires
            //

            AddNewQuizForm_Timeexpires = new Label();
            AddNewQuizForm_Timeexpires.AutoSize = true;
            AddNewQuizForm_Timeexpires.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            AddNewQuizForm_Timeexpires.Location = new Point(13, 545);
            AddNewQuizForm_Timeexpires.Name = "AddNewQuizForm_Timeexpires";
            AddNewQuizForm_Timeexpires.Size = new Size(113, 23);
            AddNewQuizForm_Timeexpires.TabIndex = 14;
            AddNewQuizForm_Timeexpires.Text = "When time expires";

            //
            // AddNewQuizForm_dateopenCbo
            //

            AddNewQuizForm_dateopenCbo = new ComboBox();
            AddNewQuizForm_dateopenCbo.AutoSize = true;
            AddNewQuizForm_dateopenCbo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            AddNewQuizForm_dateopenCbo.Name = "AddNewQuizForm_dateopenCbo";
            AddNewQuizForm_dateopenCbo.TabIndex = 15;
            AddNewQuizForm_dateopenCbo.Location = new Point(215, 410);
            AddNewQuizForm_dateopenCbo.Size = new Size(60, 60);
            
            // To add "21" to the AddNewQuizForm_dateopenCbo

            AddNewQuizForm_dateopenCbo.Items.AddRange(new object[]
            {
                "21"
            });
            AddNewQuizForm_dateopenCbo.SelectedIndex = 0;

            /*Add day numbers (1-31) to the AddNewQuizForm_dateopenCbo
            for (int i = 1; i <= 31; i++)
            {
                AddNewQuizForm_dateopenCbo.Items.Add(i.ToString("D2"));
            } */

//
// AddNewQuizForm_MonthopenCbo
//

/*
            AddNewQuizForm_MonthopenCbo = new ComboBox();
            AddNewQuizForm_MonthopenCbo.AutoSize = true;
            AddNewQuizForm_MonthopenCbo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            AddNewQuizForm_MonthopenCbo.Name = "AddNewQuizForm_MonthopenCbo";
            AddNewQuizForm_MonthopenCbo.TabIndex = 16;
            AddNewQuizForm_MonthopenCbo.Location = new Point(285, 410);
            AddNewQuizForm_MonthopenCbo.Size = new Size(90, 100);
            
            // To add the strings "March" to the AddNewQuizForm_MothopenCbo

            AddNewQuizForm_MonthopenCbo.Items.Add("March");
            AddNewQuizForm_MonthopenCbo.SelectedIndex = 0;

            /* Add the months to the AddNewQuizForm_MonthopenCbo
            for (int i = 1; i <= 12; i++)
            {
                AddNewQuizForm_MonthopenCbo.Items.Add(CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(i));
            } */

//
// AddNewQuizForm_YearopenCbo
//

/*            AddNewQuizForm_YearopenCbo = new ComboBox();
            AddNewQuizForm_YearopenCbo.AutoSize = true;
            AddNewQuizForm_YearopenCbo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            AddNewQuizForm_YearopenCbo.Name = "AddNewQuizForm_YearopenCbo";
            AddNewQuizForm_YearopenCbo.TabIndex = 17;
            AddNewQuizForm_YearopenCbo.Location = new Point(385, 410);
            AddNewQuizForm_YearopenCbo.Size = new Size(70, 80);
            
            // To add "2023" to the AddNewQuizForm_YearopenCbo

            AddNewQuizForm_YearopenCbo.Items.AddRange(new object[]
            {
                "2023"
            });
            AddNewQuizForm_YearopenCbo.SelectedIndex = 0;

            /* Add years (current year to 10 years later) to the AddNewQuizForm_YearopenCbo
            int currentYear = DateTime.Now.Year;
            for (int i = currentYear; i <= currentYear + 10; i++)
            {
                AddNewQuizForm_YearopenCbo.Items.Add(i.ToString());
            }*/

//
// AddNewQuizForm_HouropenCbo
//

/*            AddNewQuizForm_HouropenCbo = new ComboBox();
            AddNewQuizForm_HouropenCbo.AutoSize = true;
            AddNewQuizForm_HouropenCbo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            AddNewQuizForm_HouropenCbo.Name = "AddNewQuizForm_HouropenCbo";
            AddNewQuizForm_HouropenCbo.TabIndex = 18;
            AddNewQuizForm_HouropenCbo.Location = new Point(465, 410);
            AddNewQuizForm_HouropenCbo.Size = new Size(65, 75);
            
            // To add "15" to the AddNewQuizForm_HouropenCbo

            AddNewQuizForm_HouropenCbo.Items.AddRange(new object[]
            {
                "15"
            });
            AddNewQuizForm_HouropenCbo.SelectedIndex = 0;

            /* Add hours from 0 to 23 to the AddNewQuizForm_HouropenCbo
            for (int i = 0; i < 24; i++)
            {
                AddNewQuizForm_HouropenCbo.Items.Add(i.ToString("00"));
            } */

//
// AddNewQuizForm_MinuteopenCbo
//

/*           AddNewQuizForm_MinuteopenCbo = new ComboBox();
           AddNewQuizForm_MinuteopenCbo.AutoSize = true;
           AddNewQuizForm_MinuteopenCbo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
           AddNewQuizForm_MinuteopenCbo.Name = " AddNewQuizForm_MinuteopenCbo";
           AddNewQuizForm_MinuteopenCbo.TabIndex = 19;
           AddNewQuizForm_MinuteopenCbo.Location = new Point(540, 410);
           AddNewQuizForm_MinuteopenCbo.Size = new Size(65, 75);

           // To add "57" to the AddNewQuizForm_MinuteopenCbo

           AddNewQuizForm_MinuteopenCbo.Items.AddRange(new object[]
           {
               "57"
           });
           AddNewQuizForm_MinuteopenCbo.SelectedIndex = 0;

           /* Add minutes to the AddNewQuizForm_MinuteopenCbo
           for (int i = 0; i < 60; i++)
           {
               AddNewQuizForm_MinuteopenCbo.Items.Add(i.ToString("D2"));
           } */

//
// AddNewQuizForm_openTbt
// 

/*         AddNewQuizForm_openTbt = new TextBox();
         AddNewQuizForm_openTbt.Multiline = true;
         AddNewQuizForm_openTbt.Name = " AddNewQuizForm_openTbt";
         AddNewQuizForm_openTbt.TabIndex = 20;
         AddNewQuizForm_openTbt.Location = new Point(640, 410);
         AddNewQuizForm_openTbt.Size = new Size(15, 15);

         //
         //AddNewQuizForm_openLbl
         //

         AddNewQuizForm_openLbl = new Label();
         AddNewQuizForm_openLbl.AutoSize = true;
         AddNewQuizForm_openLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
         AddNewQuizForm_openLbl.Name = "AddNewQuizForm_openLbl";
         AddNewQuizForm_openLbl.TabIndex = 21;
         AddNewQuizForm_openLbl.Location = new Point(655, 410);
         AddNewQuizForm_openLbl.Size = new Size(300, 30);
         AddNewQuizForm_openLbl.Text = "Enable";

         //
         //  AddNewQuizForm_dateCloseCbo
         //

         AddNewQuizForm_dateCloseCbo = new ComboBox();
         AddNewQuizForm_dateCloseCbo.AutoSize = true;
         AddNewQuizForm_dateCloseCbo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
         AddNewQuizForm_dateCloseCbo.Name = " AddNewQuizForm_dateCloseCbo";
         AddNewQuizForm_dateCloseCbo.TabIndex = 22;
         AddNewQuizForm_dateCloseCbo.Location = new Point(215, 450);
         AddNewQuizForm_dateCloseCbo.Size = new Size(60, 60);
         // To add "21" to the  AddNewQuizForm_dateCloseCbo

         AddNewQuizForm_dateCloseCbo.Items.AddRange(new object[]
         {
             "21"
         });
         AddNewQuizForm_dateCloseCbo.SelectedIndex = 0;

         /*Add day options to AddNewQuizForm_dateCloseCbo
         for (int i = 1; i <= 31; i++)
         {
             AddNewQuizForm_dateCloseCbo.Items.Add(i.ToString("00"));
         } */

//
// AddNewQuizForm_MonthCloseCbo
//

/*        AddNewQuizForm_MonthCloseCbo = new ComboBox();
        AddNewQuizForm_MonthCloseCbo.AutoSize = true;
        AddNewQuizForm_MonthCloseCbo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
        AddNewQuizForm_MonthCloseCbo.Name = "MonthCloseCbo";
        AddNewQuizForm_MonthCloseCbo.TabIndex = 23;
        AddNewQuizForm_MonthCloseCbo.Location = new Point(285, 450);
        AddNewQuizForm_MonthCloseCbo.Size = new Size(90, 100);

        // To add the strings "March" to the AddNewQuizForm_MonthCloseCbo

        AddNewQuizForm_MonthCloseCbo.Items.Add("March");
        AddNewQuizForm_MonthCloseCbo.SelectedIndex = 0;

        /* Add the months to the AddNewQuizForm_MonthCloseCbo
        for (int i = 1; i <= 12; i++)
        {
            AddNewQuizForm_MonthCloseCbo.Items.Add(CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(i));
        } */

//
// AddNewQuizForm_YearCloseCbo
//

/*      AddNewQuizForm_YearCloseCbo = new ComboBox();
      AddNewQuizForm_YearCloseCbo.AutoSize = true;
      AddNewQuizForm_YearCloseCbo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
      AddNewQuizForm_YearCloseCbo.Name = "YearCloseCbo";
      AddNewQuizForm_YearCloseCbo.TabIndex = 24;
      AddNewQuizForm_YearCloseCbo.Location = new Point(385, 450);
      AddNewQuizForm_YearCloseCbo.Size = new Size(70, 80);

      // To add "2023" to the AddNewQuizForm_YearCloseCbo

      AddNewQuizForm_YearCloseCbo.Items.AddRange(new object[]
      {
          "2023"
      });
      AddNewQuizForm_YearCloseCbo.SelectedIndex = 0;

      /* Add years (current year to 10 years later) to the AddNewQuizForm_YearCloseCbo
      int currentYearClose = DateTime.Now.Year;
      for (int i = currentYearClose; i <= currentYearClose + 10; i++)
      {
          AddNewQuizForm_YearCloseCbo.Items.Add(i.ToString());
      } */

//
// AddNewQuizForm_HourCloseCbo
//

/*     AddNewQuizForm_HourCloseCbo = new ComboBox();
     AddNewQuizForm_HourCloseCbo.AutoSize = true;
     AddNewQuizForm_HourCloseCbo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
     AddNewQuizForm_HourCloseCbo.Name = "AddNewQuizForm_HourCloseCbo";
     AddNewQuizForm_HourCloseCbo.TabIndex = 25;
     AddNewQuizForm_HourCloseCbo.Location = new Point(465, 450);
     AddNewQuizForm_HourCloseCbo.Size = new Size(65, 75);

     // To add "15" to the AddNewQuizForm_HourCloseCbo

     AddNewQuizForm_HourCloseCbo.Items.AddRange(new object[]
     {
         "15"
     });
     AddNewQuizForm_HourCloseCbo.SelectedIndex = 0;

     /* Add hours from 0 to 23 to the AddNewQuizForm_HourCloseCbo
     for (int i = 0; i < 24; i++)
     {
         AddNewQuizForm_HourCloseCbo.Items.Add(i.ToString("15"));
     } */

//
// AddNewQuizForm_MinuteCloseCbo
//

/*      AddNewQuizForm_MinuteCloseCbo = new ComboBox();
      AddNewQuizForm_MinuteCloseCbo.AutoSize = true;
      AddNewQuizForm_MinuteCloseCbo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
      AddNewQuizForm_MinuteCloseCbo.Name = "AddNewQuizForm_MinuteCloseCbo";
      AddNewQuizForm_MinuteCloseCbo.TabIndex = 26;
      AddNewQuizForm_MinuteCloseCbo.Location = new Point(540, 450);
      AddNewQuizForm_MinuteCloseCbo.Size = new Size(65, 75);

      // To add "57" to the AddNewQuizForm_MinuteCloseCbo

      AddNewQuizForm_MinuteCloseCbo.Items.AddRange(new object[]
      {
          "57"
      });
      AddNewQuizForm_MinuteCloseCbo.SelectedIndex = 0;
      /* Add minutes to the AddNewQuizForm_MinuteCloseCbo
      for (int i = 0; i < 60; i++)
       {
           AddNewQuizForm_MinuteCloseCbo.Items.Add(i.ToString("D2"));
       } */

//
// AddNewQuizForm_CloseTbt
// 

/*      AddNewQuizForm_CloseTbt = new TextBox();
        AddNewQuizForm_CloseTbt.Multiline = true;
        AddNewQuizForm_CloseTbt.Name = "AddNewQuizForm_CloseTbt";
        AddNewQuizForm_CloseTbt.TabIndex = 27;
        AddNewQuizForm_CloseTbt.Location = new Point(640, 450);
        AddNewQuizForm_CloseTbt.Size = new Size(15, 15);

        //
        //AddNewQuizForm_CloseLbl
        //

        AddNewQuizForm_CloseLbl = new Label();
        AddNewQuizForm_CloseLbl.AutoSize = true;
        AddNewQuizForm_CloseLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
        AddNewQuizForm_CloseLbl.Name = "AddNewQuizForm_CloseLbl";
        AddNewQuizForm_CloseLbl.TabIndex = 28;
        AddNewQuizForm_CloseLbl.Location = new Point(655, 450);
        AddNewQuizForm_CloseLbl.Size = new Size(300, 30);
        AddNewQuizForm_CloseLbl.Text = "Enable";

        //
        // AddNewQuizForm_TimelimitPb
        //

        AddNewQuizForm_TimelimitPb = new ProgressBar();
        AddNewQuizForm_TimelimitPb.Name = "AddNewQuizForm_TimelimitPb";
        AddNewQuizForm_TimelimitPb.TabIndex = 29;
        AddNewQuizForm_TimelimitPb.Location = new Point(215, 490);
        AddNewQuizForm_TimelimitPb.Size = new Size(65, 35);
        AddNewQuizForm_TimelimitPb.Minimum = 0; // set the minimum value of the progress bar
        AddNewQuizForm_TimelimitPb.Maximum = 100; // set the maximum value of the progress bar
        AddNewQuizForm_TimelimitPb.Step = 1; // set the amount by which the progress bar is incremented

        //
        // Add number zero to ProgressBar with Label
        //

        Label timeLimitLabel = new Label();
        timeLimitLabel.Name = "timeLimitLabel";
        timeLimitLabel.Font = new Font("Segoe UI", 12.5F, FontStyle.Regular, GraphicsUnit.Point);
        timeLimitLabel.TabIndex = 34;
        timeLimitLabel.Location = new Point(295, 765);
        timeLimitLabel.Size = new Size(25, 30);
        timeLimitLabel.Text = "0";
        Controls.Add(timeLimitLabel);

        //
        // AddNewQuizForm_TimelimiMinuteCbo
        //

        AddNewQuizForm_TimelimiMinuteCbo = new ComboBox();
        AddNewQuizForm_TimelimiMinuteCbo.AutoSize = true;
        AddNewQuizForm_TimelimiMinuteCbo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        AddNewQuizForm_TimelimiMinuteCbo.Name = "AddNewQuizForm_TimelimiMinuteCbo";
        AddNewQuizForm_TimelimiMinuteCbo.TabIndex = 30;
        AddNewQuizForm_TimelimiMinuteCbo.Location = new Point(285, 495);
        AddNewQuizForm_TimelimiMinuteCbo.Size = new Size(80, 80);

        // To add the strings "minutes" to the AddNewQuizForm_TimelimiMinuteCbo

        AddNewQuizForm_TimelimiMinuteCbo.Items.AddRange(new object[]
        {
            "minutes"
        });
        AddNewQuizForm_TimelimiMinuteCbo.SelectedIndex = 0;

        //
        // AddNewQuizForm_TimelimitTbt
        // 

        AddNewQuizForm_TimelimitTbt = new TextBox();
        AddNewQuizForm_TimelimitTbt.Multiline = true;
        AddNewQuizForm_TimelimitTbt.Name = "AddNewQuizForm_TimelimitTbt";
        AddNewQuizForm_TimelimitTbt.TabIndex = 31;
        AddNewQuizForm_TimelimitTbt.Location = new Point(373, 495);
        AddNewQuizForm_TimelimitTbt.Size = new Size(15, 15);

        //
        //AddNewQuizForm_TimelimitLbl
        //

        AddNewQuizForm_TimelimitLbl = new Label();
        AddNewQuizForm_TimelimitLbl.AutoSize = true;
        AddNewQuizForm_TimelimitLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
        AddNewQuizForm_TimelimitLbl.Name = "AddNewQuizForm_TimelimitLbl";
        AddNewQuizForm_TimelimitLbl.TabIndex = 32;
        AddNewQuizForm_TimelimitLbl.Location = new Point(390, 495);
        AddNewQuizForm_TimelimitLbl.Size = new Size(300, 30);
        AddNewQuizForm_TimelimitLbl.Text = "Enable";

        //
        //  AddNewQuizForm_TimeexpiresCloseCbo
        //

        AddNewQuizForm_TimeexpiresCloseCbo = new ComboBox();
        AddNewQuizForm_TimeexpiresCloseCbo.AutoSize = true;
        AddNewQuizForm_TimeexpiresCloseCbo.Font = new Font("Segoe UI", 11.5F, FontStyle.Regular, GraphicsUnit.Point);
        AddNewQuizForm_TimeexpiresCloseCbo.Name = "AddNewQuizForm_TimeexpiresCloseCbo";
        AddNewQuizForm_TimeexpiresCloseCbo.TabIndex = 33;
        AddNewQuizForm_TimeexpiresCloseCbo.Location = new Point(215, 540);
        AddNewQuizForm_TimeexpiresCloseCbo.Size = new Size(286, 200);

        // Add " Open attempts are submitted automatically " to AddNewQuizForm_TimeexpiresCloseCbo

        AddNewQuizForm_TimeexpiresCloseCbo.Items.Add(" Open attempts are submitted automatically");
        AddNewQuizForm_TimeexpiresCloseCbo.SelectedIndex = 0;

         //
        // AddNewQuizForm
        // 

        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(AddNewQuizForm_HeadingLbl);
        Controls.Add(AddNewQuizForm_GeneralLbl);
        Controls.Add(AddNewQuizForm_NameTxt);
        Controls.Add(AddNewQuizFormTxt_Description);
        Controls.Add(AddNewQuizForm_NameLbl);
        Controls.Add(AddNewQuizFormLbl_Description);
        Controls.Add(AddNewQuizForm_DisplayTbt);
        Controls.Add(AddNewQuizForm_DisplayLbl);
        Controls.Add(AddNewQuizForm_LineLbl);
        Controls.Add(AddNewQuizForm_TiminglLbl);
        Controls.Add(AddNewQuizForm_OpenthequizLbl);
        Controls.Add(AddNewQuizForm_ClosethequizLbl);
        Controls.Add(AddNewQuizForm_Timelimit);
        Controls.Add(AddNewQuizForm_Timeexpires);
        Controls.Add(AddNewQuizForm_dateopenCbo);
        Controls.Add(AddNewQuizForm_MonthopenCbo);
        Controls.Add(AddNewQuizForm_YearopenCbo);
        Controls.Add(AddNewQuizForm_HouropenCbo);
        Controls.Add(AddNewQuizForm_MinuteopenCbo);
        Controls.Add(AddNewQuizForm_openTbt);
        Controls.Add(AddNewQuizForm_openLbl);
        Controls.Add(AddNewQuizForm_dateCloseCbo);
        Controls.Add(AddNewQuizForm_MonthCloseCbo);
        Controls.Add(AddNewQuizForm_YearCloseCbo);
        Controls.Add(AddNewQuizForm_HourCloseCbo);
        Controls.Add(AddNewQuizForm_MinuteCloseCbo);
        Controls.Add(AddNewQuizForm_CloseTbt);
        Controls.Add(AddNewQuizForm_CloseLbl);
        Controls.Add(AddNewQuizForm_TimelimitPb);
        Controls.Add(AddNewQuizForm_TimelimiMinuteCbo);
        Controls.Add(AddNewQuizForm_TimelimitTbt);
        Controls.Add(AddNewQuizForm_TimelimitLbl);
        Controls.Add(AddNewQuizForm_TimeexpiresCloseCbo);

        Name = "Form1";
        Size = new Size(850, 750);
        PerformLayout();
    }

    #endregion

    private Label AddNewQuizForm_HeadingLbl;
    private Label AddNewQuizForm_GeneralLbl;
    private TextBox AddNewQuizForm_NameTxt;
    private Label AddNewQuizForm_NameLbl;
    private TextBox AddNewQuizFormTxt_Description;
    private Label AddNewQuizFormLbl_Description;
    private TextBox AddNewQuizForm_DisplayTbt;
    private Label AddNewQuizForm_DisplayLbl;
    private Label AddNewQuizForm_LineLbl;
    private Label AddNewQuizForm_TiminglLbl;
    private Label AddNewQuizForm_OpenthequizLbl;
    private Label AddNewQuizForm_ClosethequizLbl;
    private Label AddNewQuizForm_Timelimit;
    private Label AddNewQuizForm_Timeexpires;
    private ComboBox AddNewQuizForm_dateopenCbo;
    private ComboBox AddNewQuizForm_MonthopenCbo;
    private ComboBox AddNewQuizForm_YearopenCbo;
    private ComboBox AddNewQuizForm_HouropenCbo;
    private ComboBox AddNewQuizForm_MinuteopenCbo;
    private TextBox AddNewQuizForm_openTbt;
    private Label AddNewQuizForm_openLbl;
    private ComboBox AddNewQuizForm_dateCloseCbo;
    private ComboBox AddNewQuizForm_MonthCloseCbo;
    private ComboBox AddNewQuizForm_YearCloseCbo;
    private ComboBox AddNewQuizForm_HourCloseCbo;
    private ComboBox AddNewQuizForm_MinuteCloseCbo;
    private TextBox AddNewQuizForm_CloseTbt;
    private Label AddNewQuizForm_CloseLbl;
    private ProgressBar AddNewQuizForm_TimelimitPb;
    private ComboBox AddNewQuizForm_TimelimiMinuteCbo;
    private TextBox AddNewQuizForm_TimelimitTbt;
    private Label AddNewQuizForm_TimelimitLbl;
    private ComboBox AddNewQuizForm_TimeexpiresCloseCbo;
}
>>>>>>> origin/Bai5

*/