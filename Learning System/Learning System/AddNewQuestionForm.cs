using Calculator;
using Learning_System.ExternalClass;
using Newtonsoft.Json.Linq;
using System;
using System.Buffers;
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

    public partial class AddNewQuestionForm : Form
    {

        private int Count_Choices = 0;

        // Data cho category
        private DataProcessing categoriesData = new DataProcessing();
        private List<string> showColumns = new List<string> { "Id", "Name", "SubArray", "QuestionArray", "Description", "IdNumber" };
        private List<Type> showType = new List<Type> { typeof(int), typeof(string), typeof(JArray), typeof(JArray), typeof(string), typeof(string) };
        private DataTable categoriesDataTable = new DataTable();
        private int currentLimit = 50;
        private int currentOffset = 0;

        // Data cho question
        private DataProcessing questionsData = new DataProcessing();
        private List<string> showColumns_questions = new List<string> { "ID", "Name", "CategoryID", "Content", "DefaultMark", "Choice" };
        private List<Type> showType_questions = new List<Type> { typeof(int), typeof(string), typeof(int), typeof(string), typeof(double), typeof(JArray) };
        private DataTable questionsDataTable = new DataTable();

        public AddNewQuestionForm()
        {
            try
            {
                JArray _questionsData = JsonProcessing.ImportJsonContentInDefaultFolder("Question.json", null, null);
                questionsData.Import(showColumns_questions, showType_questions);
                questionsData.Import(_questionsData);
                questionsDataTable = questionsData.GetList(currentOffset, currentLimit, DataProcessing.emptyList, DataProcessing.emptyList);
            }
            catch (Exception ex)
            {
                DialogResult dialog = MessageBox.Show("Can't get categories data:\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            InitializeComponent();
        }

        private void AddNewQuestionForm_CategoryCbo_DropDown(object sender, EventArgs e)
        {
            try
            {
                JArray _categoriesData = JsonProcessing.ImportJsonContentInDefaultFolder("Category.json", null, null);
                categoriesData.Import(showColumns, showType);
                categoriesData.Import(_categoriesData);
                categoriesDataTable = categoriesData.GetList(currentOffset, currentLimit);
            }
            catch (Exception ex)
            {
                DialogResult dialog = MessageBox.Show("Can't get categories data:\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (dialog == DialogResult.OK)
                    Application.Exit();
            }
            AddNewQuestionForm_CategoryCbo.ValueMember = "Id";
            AddNewQuestionForm_CategoryCbo.DisplayMember = "Name";
            AddNewQuestionForm_CategoryCbo.DataSource = categoriesDataTable;
        }

        private void AddNewQuestionForm_SaveBtn_Click(object sender, EventArgs e)
        {
            string _error = "";
            if (AddNewQuestionForm_NameTxt.Text == null || AddNewQuestionForm_NameTxt.Text == "")
            {
                if (_error.Length > 0)
                    _error += ", ";
                _error += "Question name";
            }
            if (AddNewQuestionForm_TextRtb.Text == null || AddNewQuestionForm_TextRtb.Text == "")
            {
                if (_error.Length > 0)
                    _error += ", ";
                _error += "Question text";
            }
            if (AddNewQuestionForm_MarkTxt.Text == null || AddNewQuestionForm_MarkTxt.Text == "")
            {
                if (_error.Length > 0)
                    _error += ", ";
                _error += "Default mark";
            }
            if (_error != "")
            {
                AddNewQuestionForm_ErrorLbl.Text = "Must be filled: " + _error;
            }
            else
            {
                AddNewQuestionForm_ErrorLbl.Text = "";
                var _parentId = AddNewQuestionForm_CategoryCbo.SelectedValue;
                var _name = AddNewQuestionForm_NameTxt.Text;
                var _content = AddNewQuestionForm_TextRtb.Rtf;
                try
                {
                    Convert.ToDouble(AddNewQuestionForm_MarkTxt.Text);
                }
                catch
                {
                    MessageBox.Show("Default mark must be double");
                    return;
                }
                var _defaultmark = Convert.ToDouble(AddNewQuestionForm_MarkTxt.Text);
                // doc du lieu tu dap an
                var _qchoice1 = new QuestionChoice()
                {
                    choice = richTextBox1.Text,
                    mark = (Convert.ToDouble(comboBox1.Text.Substring(0, comboBox1.Text.Length - 1))) / 100.0
                };
                var _qchoice2 = new QuestionChoice()
                {
                    choice = richTextBox2.Text,
                    mark = (Convert.ToDouble(comboBox2.Text.Substring(0, comboBox2.Text.Length - 1))) / 100.0
                };
                var _qchoice3 = new QuestionChoice()
                {
                    choice = richTextBox3.Text,
                    mark = (Convert.ToDouble(comboBox3.Text.Substring(0, comboBox3.Text.Length - 1))) / 100.0
                };
                var _qchoice4 = new QuestionChoice()
                {
                    choice = richTextBox4.Text,
                    mark = (Convert.ToDouble(comboBox4.Text.Substring(0, comboBox4.Text.Length - 1))) / 100.0
                };
                var _qchoice5 = new QuestionChoice()
                {
                    choice = richTextBox5.Text,
                    mark = (Convert.ToDouble(comboBox5.Text.Substring(0, comboBox5.Text.Length - 1))) / 100.0
                };
                var _qchoice6 = new QuestionChoice()
                {
                    choice = richTextBox6.Text,
                    mark = (Convert.ToDouble(comboBox6.Text.Substring(0, comboBox6.Text.Length - 1))) / 100.0
                };
                var _qchoice7 = new QuestionChoice()
                {
                    choice = richTextBox7.Text,
                    mark = (Convert.ToDouble(comboBox7.Text.Substring(0, comboBox7.Text.Length - 1))) / 100.0
                };
                var _qchoice8 = new QuestionChoice()
                {
                    choice = richTextBox8.Text,
                    mark = (Convert.ToDouble(comboBox8.Text.Substring(0, comboBox8.Text.Length - 1))) / 100.0
                };
                var _qchoice9 = new QuestionChoice()
                {
                    choice = richTextBox9.Text,
                    mark = (Convert.ToDouble(comboBox9.Text.Substring(0, comboBox9.Text.Length - 1))) / 100.0
                };
                var _qchoice10 = new QuestionChoice()
                {
                    choice = richTextBox10.Text,
                    mark = (Convert.ToDouble(comboBox10.Text.Substring(0, comboBox10.Text.Length - 1))) / 100.0
                };
                var _qchoice11 = new QuestionChoice()
                {
                    choice = richTextBox11.Text,
                    mark = (Convert.ToDouble(comboBox11.Text.Substring(0, comboBox11.Text.Length - 1))) / 100.0
                };
                // them du lieu tu dap ap vao list _choice
                var _choice = new List<QuestionChoice>();
                _choice.Add(_qchoice1);
                _choice.Add(_qchoice2);
                if (Count_Choices == 1)
                {
                    _choice.Add(_qchoice3);
                    _choice.Add(_qchoice4);
                    _choice.Add(_qchoice5);
                }
                if (Count_Choices == 2)
                {
                    _choice.Add(_qchoice3);
                    _choice.Add(_qchoice4);
                    _choice.Add(_qchoice5);
                    _choice.Add(_qchoice6);
                    _choice.Add(_qchoice7);
                    _choice.Add(_qchoice8);
                }
                if (Count_Choices == 3)
                {
                    _choice.Add(_qchoice3);
                    _choice.Add(_qchoice4);
                    _choice.Add(_qchoice5);
                    _choice.Add(_qchoice6);
                    _choice.Add(_qchoice7);
                    _choice.Add(_qchoice8);
                    _choice.Add(_qchoice9);
                    _choice.Add(_qchoice10);
                    _choice.Add(_qchoice11);
                }

                DataRow _maxIDRow = questionsData.GetMaxMin(0, questionsData.GetLength(), DataProcessing.emptyList, "ID asc", "MAX");

                Questions _newQuestion = new Questions()
                {
                    ID = _maxIDRow.Field<int>("ID") + 1,
                    CategoryID = Convert.ToInt32(_parentId.ToString()),
                    Name = _name,
                    Content = _content,
                    DefaultMark = _defaultmark,
                    Choice = _choice
                };

                List<string> _query = new List<string> { "OffsetOff", "1", "Id", _parentId.ToString() };
                List<string> _column = new List<string> { "QuestionArray" };
                DataTable _parentRow = categoriesData.GetList(0, 1, _query, _column);

                if (_parentRow != null)
                {
                    _parentRow.Rows[0].Field<JArray>("QuestionArray").Add(_newQuestion.ID);
                    JObject x = DataProcessing.ConvertDataRowToJObject(_parentRow.Rows[0]);

                    categoriesData.ChangeElementswithCondition(_query.GetRange(2, 2).ToList(), JObject.FromObject(x));

                    JsonProcessing.ExportJsonContentInDefaultFolder("Category.json", categoriesData.Export());
                }
                else
                {
                    MessageBox.Show("Thêm thất bại do không tìm thấy parent category thỏa mãn.", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                questionsData.AddNewElement(JObject.FromObject(_newQuestion));
                JsonProcessing.ExportJsonContentInDefaultFolder("Question.json", questionsData.Export());

                this.Close();
            }

        }

        private void AddNewQuestionForm_CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddNewQuestionForm_SaveAndContinueBtn_Click(object sender, EventArgs e)
        {

        }

        private void AddNewQuestionForm_MoreChoicesBtn_Click(object sender, EventArgs e)
        {
            Count_Choices++;
            if (Count_Choices == 1)
            {
                panel_choice_3.Height = 258;
                panel_choice_4.Height = 258;
                panel_choice_5.Height = 258;
            }
            //else
            if (Count_Choices == 2)
            {
                panel_choice_6.Height = 258;
                panel_choice_7.Height = 258;
                panel_choice_8.Height = 258;
            }
            //else
            if (Count_Choices == 3)
            {
                panel_choice_9.Height = 258;
                panel_choice_10.Height = 258;
                panel_choice_11.Height = 258;
                AddNewQuestionForm_MoreChoicesBtn.Visible = false;
            }
        }

        private void AddNewQuestionForm_Load(object sender, EventArgs e)
        {
            panel_choice_11.Visible = true;
            panel_choice_10.Visible = true;
            panel_choice_9.Visible = true;
            panel_choice_8.Visible = true;
            panel_choice_7.Visible = true;
            panel_choice_6.Visible = true;
            panel_choice_5.Visible = true;
            panel_choice_4.Visible = true;
            panel_choice_3.Visible = true;
            panel_choice_3.Height = 0;
            panel_choice_4.Height = 0;
            panel_choice_5.Height = 0;
            panel_choice_6.Height = 0;
            panel_choice_7.Height = 0;
            panel_choice_8.Height = 0;
            panel_choice_9.Height = 0;
            panel_choice_10.Height = 0;
            panel_choice_11.Height = 0;
        }
    }
}
