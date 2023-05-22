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
        public ContestForm()
        {
            InitializeComponent();
            loadQuestionData();
            loadCategoryData();
            loadContestData();
            editQuiz.questionsData = questionsData;
            editQuiz.categoriesData = categoriesData;
        }

        private void ContestForm_EditPic_Click(object sender, EventArgs e)
        {
            panel_main.SendToBack();
            editQuiz.BringToFront();
        }

        private DataProcessing questionsData = new();
        private DataProcessing categoriesData = new();
        private DataTable contestDataTable = new();

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
            JArray _categoriesData = JsonProcessing.ImportJsonContentInDefaultFolder("Category.json", null, null);
            List<string> showColumns = new() { "Id", "Name", "SubArray", "QuestionArray", "Description", "IdNumber" };
            List<Type> showType = new() { typeof(int), typeof(string), typeof(JArray), typeof(JArray), typeof(string), typeof(string) };
            List<string> showKey = new() { "PRIMARY KEY", "", "", "", "", "" };
            categoriesData.Import(showColumns, showType, showKey);
            categoriesData.Import(_categoriesData);
        }

        private void loadContestData()
        {
            contestDataTable.Clear();
        }
    }
}
