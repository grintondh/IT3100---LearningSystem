using Learning_System.Class;
using Learning_System.ExternalClass;
using Newtonsoft.Json.Linq;
using System.Data;

namespace Learning_System
{
    public partial class AddNewQuestionForm : Form
    {
        const int MAXOFCHOICE = 20;
        private int Count_Choices = 2;
        private int Count_Button = 0;
        private int Count_Line = 0;
        private bool IsInitial = true;
        private int CurrentParentId;
        // dynamic control
        Panel[] panelParent = new Panel[MAXOFCHOICE];
        Panel[] panel = new Panel[MAXOFCHOICE];
        RichTextBox[] richTextBoxes = new RichTextBox[MAXOFCHOICE];
        ComboBox[] combobox = new ComboBox[MAXOFCHOICE];
        Label[] labelChoice = new Label[MAXOFCHOICE];
        Label[] labelGrade = new Label[MAXOFCHOICE];

        // Data cho category
        private DataProcessing categoriesData = new();
        private List<string> showColumns = new() { "Id", "Name", "SubArray", "QuestionArray", "Description", "IdNumber" };
        private List<Type> showType = new() { typeof(int), typeof(string), typeof(JArray), typeof(JArray), typeof(string), typeof(string) };
        private readonly List<string> showKey = new() { "PRIMARY KEY", "NOT NULL", "", "", "", "" };
        private DataTable? categoriesDataTable = new();
        private int currentLimit = 50;
        private int currentOffset = 0;

        // Data cho question
        private DataProcessing questionsData = new();
        private List<string> showColumns_questions = new() { "ID", "Name", "CategoryID", "Content", "DefaultMark", "Choice" };
        private List<Type> showType_questions = new() { typeof(int), typeof(string), typeof(int), typeof(string), typeof(double), typeof(JArray) };
        private readonly List<string> showKey_questions = new() { "PRIMARY KEY", "NOT NULL", "", "NOT NULL", "NOT NULL", "" };
        private DataTable? questionsDataTable = new();

        public AddNewQuestionForm()
        {
            try
            {
                JArray? _questionsData = JsonProcessing.ImportJsonContentInDefaultFolder("Question.json", null, null);

                if (_questionsData == null)
                    throw new E01CantFindFile();

                questionsData.Import(showColumns_questions, showType_questions, showKey_questions);
                questionsData.Import(_questionsData);
                questionsDataTable = questionsData.Init().Offset(currentOffset).Limit(currentLimit).Get();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't get categories data!\nDescription: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            InitializeComponent();

            for (int i = 0; i < 2; i++)
            {
                richTextBoxes[i] = new RichTextBox();
                combobox[i] = new ComboBox();
                labelChoice[i] = new Label();
                labelGrade[i] = new Label();
                //panel Parent
                panelParent[i] = new Panel
                {
                    Location = new Point(0, panel_.Height + i * 258),
                    Size = new Size(1212, 258)
                };
                //panel
                panel[i] = new Panel
                {
                    Location = new Point(354, 6),
                    Size = new Size(800, 243)
                };
                panel[i].Controls.Add(richTextBoxes[i]);
                panel[i].Controls.Add(combobox[i]);
                panel[i].Controls.Add(labelChoice[i]);
                panel[i].Controls.Add(labelGrade[i]);
                panel[i].BackColor = SystemColors.Control;
                // combobox
                combobox[i].Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
                combobox[i].FormattingEnabled = true;
                combobox[i].Items.AddRange(new object[] { "None", "100%", "90%", "83.33333%", "80%", "75%", "70%", "66.66667%", "60%", "50%", "40%", "33.33333%", "30%", "25%", "20%", "16.66667%", "14.28571%", "12.5%", "11.11111%", "10%", "5%", "-5%", "-10%", "-11.11111%", "-12.5%", "-14.28571%", "-16.66667%", "-20%", "-25%", "-30%", "-33.33333%", "-40%", "-50%", "-60%", "-66.66667%", "-70%", "-75%", "-80%", "-83.33333%" });
                combobox[i].Location = new Point(106, 201);
                combobox[i].Size = new Size(151, 31);
                combobox[i].Text = "None";
                combobox[i].TabIndex = i + 13;
                // richtextbox
                richTextBoxes[i].Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
                richTextBoxes[i].Location = new Point(106, 14);
                richTextBoxes[i].Size = new Size(568, 162);
                richTextBoxes[i].Text = "";
                combobox[i].TabIndex = i + 12;
                // label choice
                labelChoice[i].AutoSize = true;
                labelChoice[i].Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
                labelChoice[i].Location = new Point(12, 14);
                labelChoice[i].Size = new Size(71, 23);
                labelChoice[i].Text = "Choice" + (i + 1).ToString();
                // label grade
                labelGrade[i].AutoSize = true;
                labelGrade[i].Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
                labelGrade[i].Location = new Point(12, 201);
                labelGrade[i].Size = new Size(56, 23);
                labelGrade[i].Text = "Grade";

                panel_body.Controls.Add(panelParent[i]);
                panelParent[i].Controls.Add(panel[i]);
            }
            panel_button.Location = new Point(0, panelParent[Count_Choices - 1].Location.Y + 258);
        }

        private void AddNewQuestionForm_CategoryCbo_DropDown(object sender, EventArgs e)
        {
            try
            {
                if (IsInitial == true)
                {
                    JArray? _categoriesData = JsonProcessing.ImportJsonContentInDefaultFolder("Category.json", null, null);

                    if (_categoriesData == null)
                        throw new E01CantFindFile();

                    categoriesData.Import(showColumns, showType, showKey);
                    categoriesData.Import(_categoriesData);
                    categoriesDataTable = categoriesData.Init().Offset(currentOffset).Limit(currentLimit).Get();
                    IsInitial = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't get categories data!\nDescription: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
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
                if (Count_Button > 0)
                {
                    DataRow? _maxIDRow = questionsData.Init().Offset(0).Limit(questionsData.Length()).Sort("ID desc").GetFirstRow();
                    if (_maxIDRow == null)
                        throw new E02CantProcessQuery();

                    int a = _maxIDRow.Field<int>("ID");
                    List<string> _query = new() { "ID", a.ToString() };
                    _ = questionsData.Init().Offset(0).Limit(1).Query(_query).Delete();

                    List<string> _query1 = new() { "Id", CurrentParentId.ToString() };

                    DataRow? _parentRow = categoriesData.Init().Offset(0).Limit(1).Query(_query1).GetFirstRow();
                    if (_parentRow == null)
                        throw new E02CantProcessQuery();

                    JArray? _x = _parentRow.Field<JArray>("QuestionArray");
                    if (_x == null)
                        throw new E03NotExistColumn("QuestionArray");

                    _x.RemoveAt(_x.Count - 1);
                    JObject x = DataProcessing.ConvertDataRowToJObject(_parentRow);

                    if (categoriesData.Init().Offset(0).Limit(1).Query(_query1).Update(x) == DataProcessing.StatusCode.Error)
                        throw new E02CantProcessQuery();
                }

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
                var _choice = new List<QuestionChoice>();
                bool isExistFullMark = false;
                for (int i = 0; i < Count_Choices; i++)
                {
                    if (richTextBoxes[i].TextLength != 0)
                    {
                        _choice.Add(new QuestionChoice()
                        {
                            choice = richTextBoxes[i].Rtf,
                            mark = ConvertComboboxTextToDouble(combobox[i].Text)
                        });
                        if (_choice[i].mark == 1)
                            isExistFullMark = true;
                    }
                }

                if (isExistFullMark == false)
                {
                    DialogResult dgr = MessageBox.Show("You haven't given any choice 100% score!", "Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                    if (dgr == DialogResult.Retry)
                    {
                        return;
                    }
                }

                try
                {
                    DataRow? _maxIDRow = questionsData.Init().Offset(0).Limit(questionsData.Length()).Sort("ID desc").GetFirstRow();
                    if (_maxIDRow == null)
                        throw new E02CantProcessQuery();

                    Questions _newQuestion = new()
                    {
                        ID = (_maxIDRow == null) ? 0 : (_maxIDRow.Field<int>("ID") + 1),
                        CategoryID = Convert.ToInt32(_parentId.ToString()),
                        Name = _name,
                        Content = _content,
                        DefaultMark = _defaultmark,
                        Choice = _choice
                    };

                    List<string> _query = new() { "Id", _parentId.ToString() };
                    DataRow? _parentRow = categoriesData.Init().Offset(currentOffset).Limit(currentLimit).Query(_query).GetFirstRow();

                    if (_parentRow == null)
                        throw new E02CantProcessQuery();
                    else
                    {
                        JArray? _x = _parentRow.Field<JArray>("QuestionArray");
                        if (_x == null)
                            throw new E03NotExistColumn("QuestionArray");

                        _x.Add(_newQuestion.ID);

                        JObject x = DataProcessing.ConvertDataRowToJObject(_parentRow);

                        if (categoriesData.Init().Offset(0).Limit(1).Query(_query).Update(x) == DataProcessing.StatusCode.Error)
                            throw new E02CantProcessQuery();

                        if (JsonProcessing.ExportJsonContentInDefaultFolder("Category.json", categoriesData.Export()) == null)
                            throw new E04CantExportProperly("Category.json");

                        CurrentParentId = Convert.ToInt32(_parentId.ToString());

                        if (questionsData.Insert(JObject.FromObject(_newQuestion)) == DataProcessing.StatusCode.Error)
                            throw new E05CantInsertProperly();

                        if (JsonProcessing.ExportJsonContentInDefaultFolder("Question.json", questionsData.Export()) == null)
                            throw new E04CantExportProperly();
                    }

                    MessageBox.Show("Add question successfully!", "Success");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Add question failed!\nDescription: " + ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Close();
            }
        }

        private void AddNewQuestionForm_CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddNewQuestionForm_SaveAndContinueBtn_Click(object sender, EventArgs e)
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
                if (Count_Button > 0)
                {
                    DataRow? _maxIDRow = questionsData.Init().Offset(0).Limit(questionsData.Length()).Sort("ID desc").GetFirstRow();
                    if (_maxIDRow == null)
                        throw new E02CantProcessQuery();

                    var a = _maxIDRow.Field<int>("ID");
                    List<string> _query = new() { "ID", a.ToString() };
                    _ = questionsData.Init().Offset(0).Limit(1).Query(_query).Delete();

                    List<string> _query1 = new() { "Id", CurrentParentId.ToString() };
                    DataRow? _parentRow = categoriesData.Init().Offset(0).Limit(1).Query(_query1).GetFirstRow();

                    if (_parentRow == null)
                        throw new E02CantProcessQuery();

                    JArray? _x = _parentRow.Field<JArray>("QuestionArray");
                    if (_x == null)
                        throw new E03NotExistColumn("QuestionArray");
                    else
                        _x.RemoveAt(_x.Count - 1);

                    JObject x = DataProcessing.ConvertDataRowToJObject(_parentRow);
                    if (categoriesData.Init().Offset(0).Limit(1).Query(_query1).Update(x) == DataProcessing.StatusCode.Error)
                        throw new E02CantProcessQuery();
                }

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
                bool isExistFullMark = false;

                var _choice = new List<QuestionChoice>();
                for (int i = 0; i < Count_Choices; i++)
                {
                    if (richTextBoxes[i].TextLength != 0)
                    {
                        _choice.Add(new QuestionChoice()
                        {
                            choice = richTextBoxes[i].Rtf,
                            mark = ConvertComboboxTextToDouble(combobox[i].Text)
                        });

                        if (_choice[i].mark == 1)
                            isExistFullMark = true;
                    }
                }

                if (isExistFullMark == false)
                {
                    DialogResult dgr = MessageBox.Show("You haven't given any choice 100% score!", "Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                    if (dgr == DialogResult.Retry)
                    {
                        return;
                    }
                }

                try
                {
                    DataRow? _maxIDRow = questionsData.Init().Offset(0).Limit(questionsData.Length()).Sort("ID desc").GetFirstRow();
                    if (_maxIDRow == null)
                        throw new E02CantProcessQuery();

                    Questions _newQuestion = new()
                    {
                        ID = _maxIDRow.Field<int>("ID") + 1,
                        CategoryID = Convert.ToInt32(_parentId.ToString()),
                        Name = _name,
                        Content = _content,
                        DefaultMark = _defaultmark,
                        Choice = _choice
                    };

                    List<string> _query = new() { "Id", _parentId.ToString() };
                    DataRow? _parentRow = categoriesData.Init().Offset(currentOffset).Limit(currentLimit).Query(_query).GetFirstRow();

                    if (_parentRow == null)
                        throw new E02CantProcessQuery();
                    else
                    {
                        JArray? _x = _parentRow.Field<JArray>("QuestionArray");
                        if (_x == null)
                            throw new E03NotExistColumn("QuestionArray");
                        else
                        {
                            _x.Add(_newQuestion.ID);
                            JObject x = DataProcessing.ConvertDataRowToJObject(_parentRow);
                            if (categoriesData.Init().Offset(0).Limit(1).Query(_query).Update(x) == DataProcessing.StatusCode.Error)
                                throw new E02CantProcessQuery();

                            if (JsonProcessing.ExportJsonContentInDefaultFolder("Category.json", categoriesData.Export()) == null)
                                throw new E04CantExportProperly();

                            CurrentParentId = Convert.ToInt32(_parentId.ToString());
                        }
                        questionsData.Insert(JObject.FromObject(_newQuestion));
                        JsonProcessing.ExportJsonContentInDefaultFolder("Question.json", questionsData.Export());
                    }

                    MessageBox.Show("Add question successfully!", "Success");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Add new question failed!\nDescription: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            Count_Button++;
        }

        private void AddNewQuestionForm_MoreChoicesBtn_Click(object sender, EventArgs e)
        {
            for (int i = Count_Choices; i < Count_Choices + 3; i++)
            {
                richTextBoxes[i] = new RichTextBox();
                combobox[i] = new ComboBox();
                labelChoice[i] = new Label();
                labelGrade[i] = new Label();
                //panel Parent
                panelParent[i] = new Panel
                {
                    Location = new Point(0, panelParent[i - 1].Location.Y + 258),
                    Size = new Size(1212, 258)
                };
                //panel
                panel[i] = new Panel
                {
                    Location = new Point(354, 6),
                    Size = new Size(800, 243)
                };
                panel[i].Controls.Add(richTextBoxes[i]);
                panel[i].Controls.Add(combobox[i]);
                panel[i].Controls.Add(labelChoice[i]);
                panel[i].Controls.Add(labelGrade[i]);
                panel[i].BackColor = SystemColors.Control;
                // combobox
                combobox[i].Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
                combobox[i].FormattingEnabled = true;
                combobox[i].Items.AddRange(new object[] { "None", "100%", "90%", "83.33333%", "80%", "75%", "70%", "66.66667%", "60%", "50%", "40%", "33.33333%", "30%", "25%", "20%", "16.66667%", "14.28571%", "12.5%", "11.11111%", "10%", "5%", "-5%", "-10%", "-11.11111%", "-12.5%", "-14.28571%", "-16.66667%", "-20%", "-25%", "-30%", "-33.33333%", "-40%", "-50%", "-60%", "-66.66667%", "-70%", "-75%", "-80%", "-83.33333%" });
                combobox[i].Location = new Point(106, 201);
                combobox[i].Size = new Size(151, 31);
                combobox[i].TabIndex = i + 13;
                combobox[i].Text = "None";
                // richtextbox
                richTextBoxes[i].Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
                richTextBoxes[i].Location = new Point(106, 14);
                richTextBoxes[i].Size = new Size(568, 162);
                richTextBoxes[i].Text = "";
                combobox[i].TabIndex = i + 12;
                // label choice
                labelChoice[i].AutoSize = true;
                labelChoice[i].Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
                labelChoice[i].Location = new Point(12, 14);
                labelChoice[i].Size = new Size(71, 23);
                labelChoice[i].Text = "Choice" + (i + 1).ToString();
                // label grade
                labelGrade[i].AutoSize = true;
                labelGrade[i].Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
                labelGrade[i].Location = new Point(12, 201);
                labelGrade[i].Size = new Size(56, 23);
                labelGrade[i].Text = "Grade";

                panel_body.Controls.Add(panelParent[i]);
                panelParent[i].Controls.Add(panel[i]);
            }
            panel_button.Location = new Point(0, panelParent[Count_Choices + 2].Location.Y + 258);
            if (Count_Choices + 3 >= MAXOFCHOICE)
                AddNewQuestionForm_MoreChoicesBtn.Visible = false;
            else Count_Choices += 3;
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

    }
}
