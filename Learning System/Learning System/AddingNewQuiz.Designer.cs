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
        System.ComponentModel.ComponentResourceManager resources =
            new System.ComponentModel.ComponentResourceManager(typeof(AddingNewQuiz));
        //
        // AddNewQuiz_HeadingLbl
        // 
<<<<<<< HEAD

=======
        
>>>>>>> origin/Bai5
        AddNewQuizForm_HeadingLbl = new Label();
        AddNewQuizForm_HeadingLbl.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
        AddNewQuizForm_HeadingLbl.ForeColor = Color.FromArgb(194, 36, 36);
        AddNewQuizForm_HeadingLbl.Location = new Point(13, 13);
        AddNewQuizForm_HeadingLbl.Name = "AddNewQuizForm_HeadingLbl";
        AddNewQuizForm_HeadingLbl.Size = new Size(533, 46);
        AddNewQuizForm_HeadingLbl.TabIndex = 0;
        AddNewQuizForm_HeadingLbl.Text = "Adding a new Quiz";
<<<<<<< HEAD

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

        AddNewQuizForm_YearopenCbo = new ComboBox();
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

        AddNewQuizForm_HouropenCbo = new ComboBox();
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

        AddNewQuizForm_MinuteopenCbo = new ComboBox();
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

        AddNewQuizForm_openTbt = new TextBox();
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

        AddNewQuizForm_MonthCloseCbo = new ComboBox();
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

        AddNewQuizForm_YearCloseCbo = new ComboBox();
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

        AddNewQuizForm_HourCloseCbo = new ComboBox();
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

        AddNewQuizForm_MinuteCloseCbo = new ComboBox();
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

        AddNewQuizForm_CloseTbt = new TextBox();
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

            AddNewQuizForm_YearopenCbo = new ComboBox();
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

            AddNewQuizForm_HouropenCbo = new ComboBox();
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

            AddNewQuizForm_MinuteopenCbo = new ComboBox();
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

            AddNewQuizForm_openTbt = new TextBox();
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

            AddNewQuizForm_MonthCloseCbo = new ComboBox();
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

            AddNewQuizForm_YearCloseCbo = new ComboBox();
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

            AddNewQuizForm_HourCloseCbo = new ComboBox();
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

            AddNewQuizForm_MinuteCloseCbo = new ComboBox();
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

            AddNewQuizForm_CloseTbt = new TextBox();
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
