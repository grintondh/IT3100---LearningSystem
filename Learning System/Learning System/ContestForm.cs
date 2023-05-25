using Learning_System.ExternalClass;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learning_System
{
    public partial class ContestForm : Form
    {
        public EditQuiz editQuiz;
        public ContestForm()
        {
            InitializeComponent();
            loadQuestionData();
            loadCategoryData();
            editQuiz = new EditQuiz(this);
            panel_body.Controls.Add(editQuiz);
            editQuiz.Dock = DockStyle.Fill;
            editQuiz.addData(questionsData, categoriesData);
            loadContestData();
            editQuiz.addContestData(contestData);
            editQuiz.fromQuestionBank.addData(questionsData, categoriesData, _categoriesDataJarray);
            editQuiz.randomQuestion.addData(questionsData, categoriesData, _categoriesDataJarray);
        }

        private void ContestForm_EditPic_Click(object sender, EventArgs e)
        {
            panel_main.SendToBack();
            editQuiz.BringToFront();
        }

        private DataProcessing questionsData = new();
        private DataProcessing categoriesData = new();
        private JArray _categoriesDataJarray = new();
        private DataTable contestDataTable = new();
        private DataProcessing contestData = new();
        public int ContestID = 0;

        private void loadQuestionData()
        {
            JArray _questionsData = JsonProcessing.ImportJsonContentInDefaultFolder("Question.json", null, null);
            List<string> showColumns_questions = new List<string> { "ID", "Name", "CategoryID", "Content", "DefaultMark", "Choice" };
            List<Type> showType_questions = new List<Type> { typeof(int), typeof(string), typeof(int), typeof(string), typeof(double), typeof(JArray) };
            List<string> showKey_questions = new List<string>() { "PRIMARY KEY", "", "", "", "", "" };
            questionsData.Import(showColumns_questions, showType_questions, showKey_questions);
            questionsData.Import(_questionsData);
        }

        private void loadCategoryData()
        {
            _categoriesDataJarray = JsonProcessing.ImportJsonContentInDefaultFolder("Category.json", null, null);
            List<string> showColumns = new() { "Id", "Name", "SubArray", "QuestionArray", "Description", "IdNumber" };
            List<Type> showType = new() { typeof(int), typeof(string), typeof(JArray), typeof(JArray), typeof(string), typeof(string) };
            List<string> showKey = new() { "PRIMARY KEY", "", "", "", "", "" };
            categoriesData.Import(showColumns, showType, showKey);
            categoriesData.Import(_categoriesDataJarray);
        }

        private void loadContestData()
        {
            JArray _contestData = JsonProcessing.ImportJsonContentInDefaultFolder("Contests.json", null, null);
            List<string> showColumns = new List<string>() { "Id", "Name", "Description", "DescriptionShow", "QuestionArray",
                "ShuffleAnswer", "DayStart", "MonthStart", "YearStart", "HourStart", "MinuteStart", "StartEnable", "DayEnd",
                "MonthEnd", "YearEnd", "HourEnd", "MinuteEnd", "EndEnable", "TimeLimit", "TimeLimitEnable" };
            List<Type> showType = new() { typeof(int), typeof(string), typeof(string), typeof(bool), typeof(JArray),
                typeof(bool), typeof(int), typeof(string), typeof(int), typeof(int), typeof(int), typeof(bool), typeof(int),
                typeof(string), typeof(int), typeof(int), typeof(int), typeof(bool), typeof(int), typeof(bool) };
            List<string> showKey = new() { "PRIMARY KEY", "", "", "" , "" , "" , "" , "" , "" , "" , "" , "" , "" , "" , "" , "" , "",
                "","","" };
            contestData.Import(showColumns, showType, showKey);
            contestData.Import(_contestData);
            List<string> query = new() { "Id", ContestID.ToString() };
            DataRow row = contestData.Init().Offset(0).Limit(1).Query(query).GetFirstRow();
            ContestForm_ContestNameLbl.Text = row.Field<string>("Name");
            ContestForm_TimeLbl.Text = "Time limit: " + row.Field<int>("TimeLimit") + " minutes";
            editQuiz.EditQuiz_ContestNameLbl.Text = "Editing quiz: " + row.Field<string>("Name");
            editQuiz.EditQuiz_ShuffleCbx.Checked = row.Field<bool>("ShuffleAnswer");
            var x = row.Field<JArray>("QuestionArray").ToObject<List<int>>();
            editQuiz.loadQuestionID(x);
        }

        public void saveContestData(DataProcessing contestData, List<int> questionID)
        {
            JsonProcessing.ExportJsonContentInDefaultFolder("Contests.json", contestData.Export());
            this.contestData = contestData;
            editQuiz.loadQuestionID(questionID);
        }
        
        public void updateContestData(DataProcessing contestData)
        {
            this.contestData = contestData;
        }
    }
}
