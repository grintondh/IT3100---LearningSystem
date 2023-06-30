using Learning_System.ProcessingClasses;
using Learning_System.Modals;
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
        public DateTime timeStart;
        public EditQuiz editQuiz;
        public string nameContest;
        public int timeLimit;
        public ContestForm(int contestID)
        {
            InitializeComponent();
            timeStart = DateTime.Now;
            this.ContestID = contestID;
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
            ContestForm_PathLbl.Text = "Home  /  My courses  /  THI CUỐI KỲ  /  General  /  " + nameContest + "  /  Edit quiz";
        }

        public DataProcessing questionsData = new();
        private DataProcessing categoriesData = new();
        private JArray _categoriesDataJarray = new();
        private System.Data.DataTable contestDataTable = new();
        private DataProcessing contestData = new();
        public int ContestID;

        private void loadQuestionData()
        {
            JArray _questionsData = JsonProcessing.ImportJsonContentInDefaultFolder("Question.json", null, null);
            if (_questionsData == null)
                throw new E01CantFindFile();
            List<string> showColumns_questions = new List<string> { "ID", "Name", "CategoryID", "Content", "DefaultMark", "Choice" };
            List<Type> showType_questions = new List<Type> { typeof(int), typeof(string), typeof(int), typeof(string), typeof(double), typeof(JArray) };
            List<string> showKey_questions = new List<string>() { "PRIMARY KEY", "NOT NULL", "", "NOT NULL", "NOT NULL", "" };
            questionsData.Import(showColumns_questions, showType_questions, showKey_questions);
            questionsData.Import(_questionsData);
        }

        private void loadCategoryData()
        {
            _categoriesDataJarray = JsonProcessing.ImportJsonContentInDefaultFolder("Category.json", null, null);
            if (_categoriesDataJarray == null)
                throw new E01CantFindFile();
            List<string> showColumns = new() { "Id", "Name", "SubArray", "QuestionArray", "Description", "IdNumber" };
            List<Type> showType = new() { typeof(int), typeof(string), typeof(JArray), typeof(JArray), typeof(string), typeof(string) };
            List<string> showKey = new() { "PRIMARY KEY", "NOT NULL", "", "", "", "" };
            categoriesData.Import(showColumns, showType, showKey);
            categoriesData.Import(_categoriesDataJarray);
        }

        private void loadContestData()
        {
            JArray _contestData = JsonProcessing.ImportJsonContentInDefaultFolder("Contest.json", null, null);
            if (_contestData == null)
                throw new E01CantFindFile();
            List<string> showColumns = new List<string>() { "Id", "Name", "Description", "DescriptionShow", "QuestionArray", "ShuffleAnswer",
                                               "TimeStart", "StartEnable", "TimeEnd", "EndEnable", "TimeLimit", "TimeLimitEnable", "MaximumGrade"};
            List<Type> showType = new() { typeof(int), typeof(string), typeof(string), typeof(bool), typeof(JArray), typeof(bool),
                                 typeof(DateTime), typeof(bool), typeof(DateTime), typeof(bool), typeof(int), typeof(bool), typeof(double) };
            List<string> showKey = new() { "PRIMARY KEY", "", "", "", "", "", "", "", "", "", "", "", "" };
            contestData.Import(showColumns, showType, showKey);
            contestData.Import(_contestData);
            List<string> query = new() { "Id", ContestID.ToString() };
            DataRow row = contestData.Init().Offset(0).Limit(1).Query(query).GetFirstRow();
            nameContest = row.Field<string>("Name");
            ContestForm_ContestNameLbl.Text = nameContest;
            ContestForm_TimeLbl.Text = "Time limit: " + row.Field<int>("TimeLimit") + " minutes";
            timeLimit = row.Field<int>("TimeLimit");
            editQuiz.EditQuiz_ContestNameLbl.Text = "Editing quiz: " + nameContest;
            editQuiz.EditQuiz_ShuffleCbx.Checked = row.Field<bool>("ShuffleAnswer");
            if (row.Field<double>("MaximumGrade").ToString() == null || row.Field<double>("MaximumGrade").ToString() == "")
                editQuiz.EditQuiz_MaxGradeTxt.Text = "10.00";
            else editQuiz.EditQuiz_MaxGradeTxt.Text = row.Field<double>("MaximumGrade").ToString();
            ContestForm_PathLbl.Text = "Home  /  My courses  /  THI CUỐI KỲ  /  General  /  " + nameContest;
            var x = row.Field<JArray>("QuestionArray").ToObject<List<int>>();
            editQuiz.loadQuestionID(x);
        }

        public void saveContestData(DataProcessing contestData, List<int> questionID)
        {
            if (JsonProcessing.ExportJsonContentInDefaultFolder("Contest.json", contestData.Export()) == null)
                throw new E04CantExportProperly();
            this.contestData = contestData;
            editQuiz.loadQuestionID(questionID);
        }

        public void updateContestData(DataProcessing contestData)
        {
            this.contestData = contestData;
        }

        private void ContestForm_PreviewQuizBtn_Click(object sender, EventArgs e)
        {
            if (editQuiz.questionID.Count == 0)
            {
                MessageBox.Show("Before previewing the quiz, you must add some questions");
            }
            else
            {
                this.Hide();
                StartAttemptForm startAttemptForm = new StartAttemptForm(this, editQuiz.questionID);
                startAttemptForm.ShowDialog();
                this.Show();
            }
        }

        private void ContestForm_MenuPic_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
