using Learning_System.ExternalClass;
using Newtonsoft.Json.Linq;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Learning_System;

public partial class AddingNewQuiz : Form
{
    private DataProcessing quizData = new DataProcessing();
    private List<string> showColumns = new() { "Id", "Name", "Description", "DescriptionShow", "QuestionArray", "ShuffleAnswer", 
                                               "DayStart", "MonthStart", "YearStart", "HourStart", "MinuteStart", "StartEnable",
                                               "DayEnd", "MonthEnd", "YearEnd", "HourEnd", "MinuteEnd", "EndEnable",
                                               "TimeLimit", "TimeLimitEnable"};
    private List<Type> showType = new() { typeof(int), typeof(string), typeof(string), typeof(bool), typeof(JArray), typeof(bool),
                                          typeof(int), typeof(string), typeof(int), typeof(int), typeof(int), typeof(bool),
                                          typeof(int), typeof(string), typeof(int), typeof(int), typeof(int), typeof(bool),
                                          typeof(int), typeof(bool)};
    private readonly List<string> showKey = new() { "PRIMARY KEY", "", "", "", "", "",
                                                    "", "", "", "", "", "",
                                                    "", "", "", "", "", "",
                                                    "", ""};
    private DataTable? quizDataTable = new();
    private int currentLimit = 50;
    private int currentOffset = 0;
    public AddingNewQuiz()
    {
        InitializeComponent();
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
        Controls.Add(AddingNewQuizForm_closeMonthCbo);
        Controls.Add(AddNewQuizForm_TimelimiMinuteCbo);
        Controls.Add(AddNewQuizForm_TimeexpiresCloseCbo);

        AddingNewQuizForm_closeMonthCbo.SelectedIndex = 0;
        AddingNewQuizForm_openMonthCbo.SelectedIndex = 0;
        AddNewQuizForm_TimelimiMinuteCbo.SelectedIndex = 0;
        AddNewQuizForm_TimeexpiresCloseCbo.SelectedIndex = 0;
        AddingNewQuizForm_openDayNud.Maximum = 31;
        AddingNewQuizForm_closeDayNud.Maximum = 31;

        AddNewQuizForm_Load();
    }

    public void AddNewQuizForm_Load()
    {
        JArray _quizData = JsonProcessing.ImportJsonContentInDefaultFolder("Contests.json", null, null);

        quizData.Import(showColumns, showType, showKey);
        quizData.Import(_quizData);
        quizDataTable = quizData.Init().Offset(currentOffset).Limit(currentLimit).Get();
    }

    private void btn_Create_Click(object sender, EventArgs e)
    {
        var _name = AddNewQuizForm_NameTxt.Text;
        var _description = AddNewQuizFormTxt_Description.Text;
        var _displayEnable = AddingNewQuizForm_DisplayCb.Checked;
        var _openDay = (int)AddingNewQuizForm_openDayNud.Value;
        var _closeDay = (int)AddingNewQuizForm_closeDayNud.Value;
        var _openMonth = AddingNewQuizForm_openMonthCbo.Text;
        var _closeMonth = AddingNewQuizForm_closeMonthCbo.Text;
        var _openYear = (int)AddingNewQuizForm_openYearNud.Value;
        var _closeYear = (int)AddingNewQuizForm_closeYearNud.Value;
        var _openHour = (int)AddingNewQuizForm_openHourNud.Value;
        var _closeHour = (int)AddingNewQuizForm_closeHourNud.Value;
        var _openMinute = (int)AddingNewQuizForm_openMinuteNud.Value; 
        var _closeMinute = (int)AddingNewQuizForm_closeMinuteNud.Value;
        var _openEnable = AddingNewQuizForm_openEnableCb.Checked;
        var _closeEnable = AddingNewQuizForm_closeEnableCB.Checked;
        var _timeLimitEnable = AddingNewQuizForm_timeLimitEnableCB.Checked;
        var _timeLimitString = AddingNewQuizForm_timeLimitTxt.Text;
        int _timeLimit = 0;
        Int32.TryParse(AddingNewQuizForm_timeLimitTxt.Text, out _timeLimit);


        string _errorNoti = "";
        if (_name == null || _name == "")
        {
            if (_errorNoti.Length > 0)
                _errorNoti += ", ";
            _errorNoti += "Quiz's Name";
        }
        if (_description == null || _description == "")
        {
            if (_errorNoti.Length > 0)
                _errorNoti += ", ";
            _errorNoti += "Quiz's Description";
        }
        if (_timeLimitString == null || _timeLimitString == "")
        {
            if (_errorNoti.Length > 0)
                _errorNoti += ", ";
            _errorNoti += "Time Limit";
        }

        if (_errorNoti != "")
        {
            AddingNewQuizForm_errorTextLbl.Text = "Vui lòng nhập " + _errorNoti;
            AddingNewQuizForm_errorTextLbl.ForeColor = Color.Red;
        }
        else
        {
            try
            {
                AddingNewQuizForm_errorTextLbl.Text = "Đang thêm dữ liệu...";
                AddingNewQuizForm_errorTextLbl.ForeColor = Color.Green;

                DataRow? _maxIdRow = quizData.Init()
                                                   .Offset(0)
                                                   .Limit(quizData.Length())
                                                   .Sort("Id desc")
                                                   .GetFirstRow();

                Contests _newQuiz = new()
                {
                    Id = (_maxIdRow == null) ? 0 : (_maxIdRow.Field<int>("Id") + 1),
                    Name = _name,
                    Description = _description,
                    DescriptionShow = _displayEnable,
                    QuestionArray = new List<int>(),
                    ShuffleAnswer = false,
                    DayStart = _openDay,
                    MonthStart = _openMonth,
                    YearStart = _openYear,
                    HourStart = _openHour,
                    MinuteStart = _openMinute,
                    StartEnable = _openEnable,
                    DayEnd = _closeDay,
                    MonthEnd = _closeMonth,
                    YearEnd = _closeYear,
                    HourEnd = _closeHour,
                    MinuteEnd = _closeMinute,
                    EndEnable = _closeEnable,
                    TimeLimit = _timeLimit,
                    TimeLimitEnable = _timeLimitEnable,
                };

                if (quizData.Insert(JObject.FromObject(_newQuiz)) == DataProcessing.StatusCode.Error)
                    throw new Exception();

                JsonProcessing.ExportJsonContentInDefaultFolder("Contests.json", quizData.Export());
                MessageBox.Show("Đã thêm thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                AddingNewQuizForm_errorTextLbl.Text = "Đã thêm dữ liệu";
                AddingNewQuizForm_errorTextLbl.ForeColor = Color.Red;

                AddNewQuizForm_NameTxt.Text = "";
                AddNewQuizFormTxt_Description.Text = "";
                AddNewQuizForm_Timelimit.Text = "";  
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm phần tử thất bại!\nChi tiết lỗi:\n" + ex, "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);

                AddingNewQuizForm_errorTextLbl.Text = "Thêm dữ liệu lỗi!";
                AddingNewQuizForm_errorTextLbl.ForeColor = Color.Red;
            }
        }
    }

    private void timeLimit_KeyPress(object sender, KeyPressEventArgs e)
    {
        char ch = e.KeyChar;

        if (Char.IsDigit(ch))
        { e.Handled = false; }
        else if (ch == 8) { e.Handled = false; }
        else { e.Handled = true; }
    }

    private void AddingNewQuizForm_openMonthCbo_SelectedIndexChanged(object sender, EventArgs e)
    {
        string a;
        a = AddingNewQuizForm_openMonthCbo.SelectedItem.ToString();
        if ((a == "January")||(a == "March")||(a == "May") || (a == "July") || (a == "August") || (a == "October") || (a == "December"))
        {
            AddingNewQuizForm_openDayNud.Maximum = 31;
        }
        if ((a == "April")||(a == "June")||(a == "September")||(a == "November"))
        {
            AddingNewQuizForm_openDayNud.Maximum = 31;
        }
        if (a == "February")
        {
            int b = (int)AddingNewQuizForm_openYearNud.Value;
            if ((b % 4) ==0) { AddingNewQuizForm_openDayNud.Maximum = 29; }
            else AddingNewQuizForm_openDayNud.Maximum = 28;
        }
    }


    private void AddingNewQuizForm_closeMonthCbo_SelectedIndexChanged(object sender, EventArgs e)
    {
        string a;
        a = AddingNewQuizForm_closeMonthCbo.SelectedItem.ToString();
        if ((a == "January") || (a == "March") || (a == "May") || (a == "July") || (a == "August") || (a == "October") || (a == "December"))
        {
            AddingNewQuizForm_closeDayNud.Maximum = 31;
        }
        if ((a == "April") || (a == "June") || (a == "September") || (a == "November"))
        {
            AddingNewQuizForm_closeDayNud.Maximum = 30;
        }
        if (a == "February")
        {
            int b = (int)AddingNewQuizForm_closeYearNud.Value;
            if ((b % 4) == 0) { AddingNewQuizForm_closeDayNud.Maximum = 29; }
            else AddingNewQuizForm_closeDayNud.Maximum = 28;
        }
    }

    private void btn_Cancel_Click(object sender, EventArgs e)
    {
        this.Close();
    }

   
}