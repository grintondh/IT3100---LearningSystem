//using Calculator;
using Learning_System.ExternalClass;
using Newtonsoft.Json.Linq;
using System;
using System.Buffers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Learning_System
{

    public partial class EditQuestionForm : Form
    {

        private int Count_Choices = 0;
        private int Count_Button = 1;
        private int Count_Line = 0;
        private bool IsInitial = true;
        private int CurrentParentId;
        private int QuestionID;

        // Data cho category
        private DataProcessing categoriesData = new DataProcessing();
        private List<string> showColumns = new() { "Id", "Name", "SubArray", "QuestionArray", "Description", "IdNumber" };
        private List<Type> showType = new() { typeof(int), typeof(string), typeof(JArray), typeof(JArray), typeof(string), typeof(string) };
        private readonly List<string> showKey = new() { "PRIMARY KEY", "", "", "", "", "" };
        private DataTable? categoriesDataTable = new();
        private int currentLimit = 50;
        private int currentOffset = 0;

        // Data cho question
        private DataProcessing questionsData = new DataProcessing();
        private List<string> showColumns_questions = new List<string> { "ID", "Name", "CategoryID", "Content", "DefaultMark", "Choice" };
        private List<Type> showType_questions = new List<Type> { typeof(int), typeof(string), typeof(int), typeof(string), typeof(double), typeof(JArray) };
        private readonly List<string> showKey_questions = new List<string>() { "PRIMARY KEY", "", "", "", "", "" };
        private DataTable? questionsDataTable = new();
        public EditQuestionForm(int ID, int ParentID)
        {
            CurrentParentId = ParentID;
            QuestionID = ID;
            // Doc du lieu Question
            try
            {
                JArray _questionsData = JsonProcessing.ImportJsonContentInDefaultFolder("Question.json", null, null);
                questionsData.Import(showColumns_questions, showType_questions, showKey_questions);
                questionsData.Import(_questionsData);
                questionsDataTable = questionsData.Init().Offset(currentOffset).Limit(questionsData.Length()).Get();
            }
            catch (Exception ex)
            {
                DialogResult dialog = MessageBox.Show("Can't get categories data:\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            InitializeComponent();
            //Doc du lieu Category
            try
            {
                if (IsInitial == true)
                {
                    JArray _categoriesData = JsonProcessing.ImportJsonContentInDefaultFolder("Category.json", null, null);
                    categoriesData.Import(showColumns, showType, showKey);
                    categoriesData.Import(_categoriesData);
                    categoriesDataTable = categoriesData.Init().Offset(currentOffset).Limit(categoriesData.Length()).Get();
                    IsInitial = false;
                }
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
            // Doc du lieu cau hoi vao form
            List<string> queryQuestion = new() { "ID", ID.ToString() };
            DataRow currentQuestionRow = questionsData.Init().Offset(0).Limit(1).Query(queryQuestion).GetFirstRow();
            AddNewQuestionForm_NameTxt.Text = currentQuestionRow.Field<string>("Name");
            try
            {
                AddNewQuestionForm_TextRtb.Rtf = currentQuestionRow.Field<string>("Content");
            }
            catch
            {
                AddNewQuestionForm_TextRtb.Text = currentQuestionRow.Field<string>("Content");
            }
            AddNewQuestionForm_MarkTxt.Text = currentQuestionRow.Field<double>("DefaultMark").ToString();
            List<QuestionChoice> choices = currentQuestionRow.Field<JArray>("Choice").ToObject<List<QuestionChoice>>();
            // dynamic control
            Panel[] panel = new Panel[choices.Count];
            RichTextBox[] richTextBoxes = new RichTextBox[choices.Count];
            System.Windows.Forms.ComboBox[] combobox = new System.Windows.Forms.ComboBox[choices.Count];
            Label[] labelChoice = new Label[choices.Count];
            Label[] labelGrade = new Label[choices.Count];
            for (int i = 0; i < choices.Count; i++)
            {
                richTextBoxes[i] = new RichTextBox();
                combobox[i] = new System.Windows.Forms.ComboBox();
                labelChoice[i] = new Label();
                labelGrade[i] = new Label();
                //panel
                this.Controls.Add(panel[i]);
                this.Controls.Add(richTextBoxes[i]);
                this.Controls.Add(combobox[i]);
                this.Controls.Add(labelChoice[i]);
                this.Controls.Add(labelGrade[i]);
                panel[i] = new Panel();
                panel[i].Dock = DockStyle.Top;
                panel[i].Location = new Point(0, 474 + i*258);
                panel[i].Name = "panel" + i.ToString();
                panel[i].Size = new Size(1212, 258);
                panel[i].Controls.Add(richTextBoxes[i]);
                panel[i].Controls.Add(combobox[i]);
                panel[i].Controls.Add(labelChoice[i]);
                panel[i].Controls.Add(labelGrade[i]);
                panel[i].SuspendLayout();
                // combobox
                combobox[i].Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
                combobox[i].FormattingEnabled = true;
                combobox[i].Items.AddRange(new object[] { "None", "100%", "90%", "83.33333%", "80%", "75%", "70%", "66.66667%", "60%", "50%", "40%", "33.33333%", "30%", "25%", "20%", "16.66667%", "14.28571%", "12.5%", "11.11111%", "10%", "5%", "-5%", "-10%", "-11.11111%", "-12.5%", "-14.28571%", "-16.66667%", "-20%", "-25%", "-30%", "-33.33333%", "-40%", "-50%", "-60%", "-66.66667%", "-70%", "-75%", "-80%", "-83.33333%" });
                combobox[i].Location = new Point(106, 201);
                combobox[i].Size = new Size(151, 31);
                combobox[i].SelectedIndex = ConvertDoubleToComboboxIndex(choices[i].mark);
                // richtextbox
                richTextBoxes[i].Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
                richTextBoxes[i].Location = new Point(106, 14);
                richTextBoxes[i].Size = new Size(434, 162);
                richTextBoxes[i].Text = "";
                // label choice
                labelChoice[i].AutoSize = true;
                labelChoice[i].Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
                labelChoice[i].Location = new Point(12, 14);
                labelChoice[i].Size = new Size(71, 23);
                labelChoice[i].Text = "Choice" + i.ToString();
                // label grade
                labelGrade[i].AutoSize = true;
                labelGrade[i].Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
                labelGrade[i].Location = new Point(12, 201);
                labelGrade[i].Size = new Size(56, 23);
                labelGrade[i].Text = "Grade";

                panel[i].ResumeLayout(false);
                panel[i].PerformLayout();
                this.ResumeLayout(false);
            }
        }

        public EditQuestionForm()
        {
            InitializeComponent();
        }

        private void AddNewQuestionForm_CategoryCbo_DropDown(object sender, EventArgs e)
        {
            //
        }

        private void AddNewQuestionForm_SaveBtn_Click(object sender, EventArgs e)
        {
            if (Count_Button > 0)
            {
                List<string> _query = new() { "ID", QuestionID.ToString() };
                int check = questionsData.Init().Offset(0).Limit(1).Query(_query).Delete();

                List<string> _query1 = new() { "Id", CurrentParentId.ToString() };
                DataRow _parentRow = categoriesData.Init().Offset(0).Limit(1).Query(_query1).GetFirstRow();
                var _x = _parentRow.Field<JArray>("QuestionArray");
                List<int> questionArray = _x.ToObject<List<int>>();
                _x.RemoveAt(questionArray.IndexOf(QuestionID));
                JObject x = DataProcessing.ConvertDataRowToJObject(_parentRow);
                if (categoriesData.Init().Offset(0).Limit(1).Query(_query1).Update(x) == DataProcessing.StatusCode.Error)
                    throw new Exception();
            }
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
                if (AddNewQuestionForm_CategoryCbo.SelectedValue == null)
                {
                    MessageBox.Show("Please select a category");
                    return;
                }
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
                    mark = ConvertComboboxTextToDouble(comboBox1.Text)
                };
                var _qchoice2 = new QuestionChoice()
                {
                    choice = richTextBox2.Text,
                    mark = ConvertComboboxTextToDouble(comboBox2.Text)
                };
                var _qchoice3 = new QuestionChoice()
                {
                    choice = richTextBox3.Text,
                    mark = ConvertComboboxTextToDouble(comboBox3.Text)
                };
                var _qchoice4 = new QuestionChoice()
                {
                    choice = richTextBox4.Text,
                    mark = ConvertComboboxTextToDouble(comboBox4.Text)
                };
                var _qchoice5 = new QuestionChoice()
                {
                    choice = richTextBox5.Text,
                    mark = ConvertComboboxTextToDouble(comboBox5.Text)
                };
                var _qchoice6 = new QuestionChoice()
                {
                    choice = richTextBox6.Text,
                    mark = ConvertComboboxTextToDouble(comboBox6.Text)
                };
                var _qchoice7 = new QuestionChoice()
                {
                    choice = richTextBox7.Text,
                    mark = ConvertComboboxTextToDouble(comboBox7.Text)
                };
                var _qchoice8 = new QuestionChoice()
                {
                    choice = richTextBox8.Text,
                    mark = ConvertComboboxTextToDouble(comboBox8.Text)
                };
                var _qchoice9 = new QuestionChoice()
                {
                    choice = richTextBox9.Text,
                    mark = ConvertComboboxTextToDouble(comboBox9.Text)
                };
                var _qchoice10 = new QuestionChoice()
                {
                    choice = richTextBox10.Text,
                    mark = ConvertComboboxTextToDouble(comboBox10.Text)
                };
                var _qchoice11 = new QuestionChoice()
                {
                    choice = richTextBox11.Text,
                    mark = ConvertComboboxTextToDouble(comboBox11.Text)
                };
                // them du lieu tu dap ap vao list _choice
                var _choice = new List<QuestionChoice>();
                if ((_qchoice1.choice != "") && (_qchoice1.choice != null))
                    _choice.Add(_qchoice1);
                if ((_qchoice2.choice != "") && (_qchoice2.choice != null))
                    _choice.Add(_qchoice2);
                if (Count_Choices == 1)
                {
                    if ((_qchoice3.choice != "") && (_qchoice3.choice != null))
                        _choice.Add(_qchoice3);
                    if ((_qchoice4.choice != "") && (_qchoice4.choice != null))
                        _choice.Add(_qchoice4);
                    if ((_qchoice5.choice != "") && (_qchoice5.choice != null))
                        _choice.Add(_qchoice5);
                }
                if (Count_Choices == 2)
                {
                    if ((_qchoice3.choice != "") && (_qchoice3.choice != null))
                        _choice.Add(_qchoice3);
                    if ((_qchoice4.choice != "") && (_qchoice4.choice != null))
                        _choice.Add(_qchoice4);
                    if ((_qchoice5.choice != "") && (_qchoice5.choice != null))
                        _choice.Add(_qchoice5);
                    if ((_qchoice6.choice != "") && (_qchoice6.choice != null))
                        _choice.Add(_qchoice6);
                    if ((_qchoice7.choice != "") && (_qchoice7.choice != null))
                        _choice.Add(_qchoice7);
                    if ((_qchoice8.choice != "") && (_qchoice8.choice != null))
                        _choice.Add(_qchoice8);
                }
                if (Count_Choices == 3)
                {
                    if ((_qchoice3.choice != "") && (_qchoice3.choice != null))
                        _choice.Add(_qchoice3);
                    if ((_qchoice4.choice != "") && (_qchoice4.choice != null))
                        _choice.Add(_qchoice4);
                    if ((_qchoice5.choice != "") && (_qchoice5.choice != null))
                        _choice.Add(_qchoice5);
                    if ((_qchoice6.choice != "") && (_qchoice6.choice != null))
                        _choice.Add(_qchoice6);
                    if ((_qchoice7.choice != "") && (_qchoice7.choice != null))
                        _choice.Add(_qchoice7);
                    if ((_qchoice8.choice != "") && (_qchoice8.choice != null))
                        _choice.Add(_qchoice8);
                    if ((_qchoice9.choice != "") && (_qchoice9.choice != null))
                        _choice.Add(_qchoice9);
                    if ((_qchoice10.choice != "") && (_qchoice10.choice != null))
                        _choice.Add(_qchoice10);
                    if ((_qchoice11.choice != "") && (_qchoice11.choice != null))
                        _choice.Add(_qchoice11);
                }
                try
                {
                    DataRow _maxIDRow = questionsData.Init().Offset(0).Limit(questionsData.Length()).Sort("ID desc").GetFirstRow();
                    Questions _newQuestion = new Questions()
                    {
                        ID = QuestionID,
                        CategoryID = Convert.ToInt32(_parentId.ToString()),
                        Name = _name,
                        Content = _content,
                        DefaultMark = _defaultmark,
                        Choice = _choice
                    };

                    List<string> _query = new List<string> { "Id", _parentId.ToString() };
                    DataRow? _parentRow = categoriesData.Init().Offset(currentOffset).Limit(currentLimit).Query(_query).GetFirstRow();

                    if (_parentRow != null)
                    {
                        if (true)
                        {
                            var _x = _parentRow.Field<JArray>("QuestionArray");
                            _x.Add(_newQuestion.ID);
                            JObject x = DataProcessing.ConvertDataRowToJObject(_parentRow);
                            if (categoriesData.Init().Offset(0).Limit(1).Query(_query).Update(x) == DataProcessing.StatusCode.Error)
                                throw new Exception();
                            JsonProcessing.ExportJsonContentInDefaultFolder("Category.json", categoriesData.Export());
                            CurrentParentId = Convert.ToInt32(_parentId.ToString());
                        }
                        questionsData.Insert(JObject.FromObject(_newQuestion));
                        JsonProcessing.ExportJsonContentInDefaultFolder("Question.json", questionsData.Export());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm phần tử thất bại!\nChi tiết lỗi:\n" + ex, "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                this.Close();
            }

        }

        private void AddNewQuestionForm_CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddNewQuestionForm_SaveAndContinueBtn_Click(object sender, EventArgs e)
        {
            if (Count_Button > 0)
            {
                List<string> _query = new() { "ID", QuestionID.ToString() };
                int check = questionsData.Init().Offset(0).Limit(1).Query(_query).Delete();

                List<string> _query1 = new() { "Id", CurrentParentId.ToString() };
                DataRow _parentRow = categoriesData.Init().Offset(0).Limit(1).Query(_query1).GetFirstRow();
                var _x = _parentRow.Field<JArray>("QuestionArray");
                List<int> questionArray = _x.ToObject<List<int>>();
                _x.RemoveAt(questionArray.IndexOf(QuestionID));
                JObject x = DataProcessing.ConvertDataRowToJObject(_parentRow);
                if (categoriesData.Init().Offset(0).Limit(1).Query(_query1).Update(x) == DataProcessing.StatusCode.Error)
                    throw new Exception();
            }
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
                if (AddNewQuestionForm_CategoryCbo.SelectedValue == null)
                {
                    MessageBox.Show("Please select a category");
                    return;
                }
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
                    mark = ConvertComboboxTextToDouble(comboBox1.Text)
                };
                var _qchoice2 = new QuestionChoice()
                {
                    choice = richTextBox2.Text,
                    mark = ConvertComboboxTextToDouble(comboBox2.Text)
                };
                var _qchoice3 = new QuestionChoice()
                {
                    choice = richTextBox3.Text,
                    mark = ConvertComboboxTextToDouble(comboBox3.Text)
                };
                var _qchoice4 = new QuestionChoice()
                {
                    choice = richTextBox4.Text,
                    mark = ConvertComboboxTextToDouble(comboBox4.Text)
                };
                var _qchoice5 = new QuestionChoice()
                {
                    choice = richTextBox5.Text,
                    mark = ConvertComboboxTextToDouble(comboBox5.Text)
                };
                var _qchoice6 = new QuestionChoice()
                {
                    choice = richTextBox6.Text,
                    mark = ConvertComboboxTextToDouble(comboBox6.Text)
                };
                var _qchoice7 = new QuestionChoice()
                {
                    choice = richTextBox7.Text,
                    mark = ConvertComboboxTextToDouble(comboBox7.Text)
                };
                var _qchoice8 = new QuestionChoice()
                {
                    choice = richTextBox8.Text,
                    mark = ConvertComboboxTextToDouble(comboBox8.Text)
                };
                var _qchoice9 = new QuestionChoice()
                {
                    choice = richTextBox9.Text,
                    mark = ConvertComboboxTextToDouble(comboBox9.Text)
                };
                var _qchoice10 = new QuestionChoice()
                {
                    choice = richTextBox10.Text,
                    mark = ConvertComboboxTextToDouble(comboBox10.Text)
                };
                var _qchoice11 = new QuestionChoice()
                {
                    choice = richTextBox11.Text,
                    mark = ConvertComboboxTextToDouble(comboBox11.Text)
                };
                // them du lieu tu dap ap vao list _choice
                var _choice = new List<QuestionChoice>();
                if ((_qchoice1.choice != "") && (_qchoice1.choice != null))
                    _choice.Add(_qchoice1);
                if ((_qchoice2.choice != "") && (_qchoice2.choice != null))
                    _choice.Add(_qchoice2);
                if (Count_Choices == 1)
                {
                    if ((_qchoice3.choice != "") && (_qchoice3.choice != null))
                        _choice.Add(_qchoice3);
                    if ((_qchoice4.choice != "") && (_qchoice4.choice != null))
                        _choice.Add(_qchoice4);
                    if ((_qchoice5.choice != "") && (_qchoice5.choice != null))
                        _choice.Add(_qchoice5);
                }
                if (Count_Choices == 2)
                {
                    if ((_qchoice3.choice != "") && (_qchoice3.choice != null))
                        _choice.Add(_qchoice3);
                    if ((_qchoice4.choice != "") && (_qchoice4.choice != null))
                        _choice.Add(_qchoice4);
                    if ((_qchoice5.choice != "") && (_qchoice5.choice != null))
                        _choice.Add(_qchoice5);
                    if ((_qchoice6.choice != "") && (_qchoice6.choice != null))
                        _choice.Add(_qchoice6);
                    if ((_qchoice7.choice != "") && (_qchoice7.choice != null))
                        _choice.Add(_qchoice7);
                    if ((_qchoice8.choice != "") && (_qchoice8.choice != null))
                        _choice.Add(_qchoice8);
                }
                if (Count_Choices == 3)
                {
                    if ((_qchoice3.choice != "") && (_qchoice3.choice != null))
                        _choice.Add(_qchoice3);
                    if ((_qchoice4.choice != "") && (_qchoice4.choice != null))
                        _choice.Add(_qchoice4);
                    if ((_qchoice5.choice != "") && (_qchoice5.choice != null))
                        _choice.Add(_qchoice5);
                    if ((_qchoice6.choice != "") && (_qchoice6.choice != null))
                        _choice.Add(_qchoice6);
                    if ((_qchoice7.choice != "") && (_qchoice7.choice != null))
                        _choice.Add(_qchoice7);
                    if ((_qchoice8.choice != "") && (_qchoice8.choice != null))
                        _choice.Add(_qchoice8);
                    if ((_qchoice9.choice != "") && (_qchoice9.choice != null))
                        _choice.Add(_qchoice9);
                    if ((_qchoice10.choice != "") && (_qchoice10.choice != null))
                        _choice.Add(_qchoice10);
                    if ((_qchoice11.choice != "") && (_qchoice11.choice != null))
                        _choice.Add(_qchoice11);
                }
                try
                {
                    DataRow _maxIDRow = questionsData.Init().Offset(0).Limit(questionsData.Length()).Sort("ID desc").GetFirstRow();

                    Questions _newQuestion = new Questions()
                    {
                        ID = QuestionID,
                        CategoryID = Convert.ToInt32(_parentId.ToString()),
                        Name = _name,
                        Content = _content,
                        DefaultMark = _defaultmark,
                        Choice = _choice
                    };

                    List<string> _query = new List<string> { "Id", _parentId.ToString() };
                    DataRow _parentRow = categoriesData.Init().Offset(currentOffset).Limit(currentLimit).Query(_query).GetFirstRow();

                    if (_parentRow != null)
                    {
                        var _x = _parentRow.Field<JArray>("QuestionArray");
                        if (true)
                        {
                            _x.Add(_newQuestion.ID);
                            JObject x = DataProcessing.ConvertDataRowToJObject(_parentRow);
                            if (categoriesData.Init().Offset(0).Limit(1).Query(_query).Update(x) == DataProcessing.StatusCode.Error)
                                throw new Exception();
                            JsonProcessing.ExportJsonContentInDefaultFolder("Category.json", categoriesData.Export());
                            CurrentParentId = Convert.ToInt32(_parentId.ToString());
                        }
                        questionsData.Insert(JObject.FromObject(_newQuestion));
                        JsonProcessing.ExportJsonContentInDefaultFolder("Question.json", questionsData.Export());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm phần tử thất bại!\nChi tiết lỗi:\n" + ex, "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            Count_Button++;
        }

        private void AddNewQuestionForm_MoreChoicesBtn_Click(object sender, EventArgs e)
        {
            Count_Choices++;
            if (Count_Choices == 1)
            {
                panel_choice_3.Height = 322;
                panel_choice_4.Height = 322;
                panel_choice_5.Height = 322;
            }
            //else
            if (Count_Choices == 2)
            {
                panel_choice_6.Height = 322;
                panel_choice_7.Height = 322;
                panel_choice_8.Height = 322;
            }
            //else
            if (Count_Choices == 3)
            {
                panel_choice_9.Height = 322;
                panel_choice_10.Height = 322;
                panel_choice_11.Height = 322;
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
            panel_choice_1.Height = 0;
            panel_choice_2.Height = 0;
        }

        private double ConvertComboboxTextToDouble(string _CboText)
        {
            try
            {
                return Convert.ToDouble(_CboText.Substring(0, _CboText.Length - 1)) / 100.0;
            }
            catch
            {
                return 0;
            }
        }

        private int ConvertDoubleToComboboxIndex(double mark)
        {
            List<double> list = new() { 0, 100, 90, 83.33333, 80, 75, 70, 66.66667, 60, 50, 40, 33.33333, 30, 25, 20, 16.66667, 14.28571, 12.5, 11.11111, 10, 5, -5, -10, -11.11111, -12.5, -14.28571, -16.66667, -20, -25, -30, -33.33333, -40, -50, -60, -66.66667, -70, -75, -80, -83.33333 };
            if (mark == 0) return 0;
            else return list.IndexOf(mark * 100);
        }
        
    }
}
