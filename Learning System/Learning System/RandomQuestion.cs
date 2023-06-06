using Learning_System.ExternalClass;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learning_System
{
    public partial class RandomQuestion : UserControl
    {
        private EditQuiz ParentEditQuiz;

        public DataProcessing questionsData = new();
        public DataProcessing categoriesData = new();
        public JArray _categoriesDataJarray = new();

        //Categories data
        private List<Categories> categories = new List<Categories>();
        private List<int> selectedCategoriesIdList = new List<int>();
        private bool selectQuestionsFromSubcategories = false;

        //Page button data
        private const int NUMBER_OF_PAGES_PER_GROUP = 5;
        private const int NUMBER_OF_QUESTIONS_PER_PAGE = 10;
        private Button[] PageButton = new Button[NUMBER_OF_PAGES_PER_GROUP + 4];
        private int numberOfPage;
        private int numberOfGroup;
        private int pageSelectedIndex;
        private int groupSelectedIndex;

        //DataGridView data
        private List<int> selectedQuestions = new List<int>();
        private List<string> selectedQuestionsContent = new List<string>();

        //RandomQuestionData
        public List<int> randomSelectedQuestions = new List<int>();
        public void AddSpace(ref List<Categories> List, ref List<Categories> addList, int begin, string space)
        {
            foreach (int x in addList[begin].SubArray)
            {
                addList[x].Name = space + addList[x].Name;
                AddSpace(ref List, ref addList, x, space + "  ");
            }
            addList[begin].Name = "  " + addList[begin].Name;

            if (addList[begin].QuestionArray.Count > 0)
                addList[begin].Name = addList[begin].Name + " (" + addList[begin].QuestionArray.Count + ")";
            List.Add(addList[begin]);
        }
        public void loadCategoriesData()
        {
            List<Categories>? listCategories = new List<Categories>();
            List<Categories> newListCategories = new List<Categories>();
            try
            {
                listCategories = _categoriesDataJarray.ToObject<List<Categories>>();
                if (listCategories == null) return;
                categories = listCategories;
                AddSpace(ref newListCategories, ref listCategories, 0, "  ");
                newListCategories.Reverse();
            }
            catch (Exception ex)
            {
                DialogResult dialog = MessageBox.Show("Can't get categories data:\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (dialog == DialogResult.OK)
                    System.Windows.Forms.Application.Exit();
            }

            RandomQuestion_CategoryCbo.ValueMember = "Id";
            RandomQuestion_CategoryCbo.DisplayMember = "Name";
            RandomQuestion_CategoryCbo.DataSource = newListCategories;
        }
        private void RandomQuestion_CategoryCbo_Click(object sender, EventArgs e)
        {
            loadCategoriesData();
        }
        private void GetSubCategories(int _parentCategories, ref List<int> _subCategories, ref List<Categories> categories)
        {
            foreach (int x in categories[_parentCategories].SubArray)
            {
                _subCategories.Add(x);
                GetSubCategories(x, ref _subCategories, ref categories);
            }
        }
        public RandomQuestion(EditQuiz _EditQuiz)
        {
            InitializeComponent();
            ParentEditQuiz = _EditQuiz;
            RandomQuestion_CategoryCbo.SelectedIndex = -1;
            RandomQuestion_CategoryCbo.SelectedText = "  Default";
            RandomQuestion_ShowQuestionDgv.BorderStyle = BorderStyle.None;
            RandomQuestion_ShowQuestionDgv.Width = Screen.PrimaryScreen.WorkingArea.Width - 30;
            RandomQuestion_ShowQuestionDgv.Columns[1].Width = RandomQuestion_ShowQuestionDgv.Width - 170;
            RandomQuestion_ShowQuestionDgv.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            RandomQuestion_ShowQuestionDgv.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            RandomQuestion_AddBtn.Location = new Point(RandomQuestion_ShowQuestionDgv.Location.X,
                RandomQuestion_ShowQuestionDgv.Location.Y + RandomQuestion_ShowQuestionDgv.Height + 50);

            for (int i = 0; i < NUMBER_OF_PAGES_PER_GROUP + 4; i++)
            {
                PageButton[i] = new Button();
                PageButton[i].Location = new System.Drawing.Point(RandomQuestion_ButtonPanelPnl.Left + i * 50, 0);
                PageButton[i].Size = new Size(50, 50);
                if (i == 0 || i == NUMBER_OF_PAGES_PER_GROUP + 3)
                {
                    if (i == 0) PageButton[i].Text = "<";
                    else PageButton[i].Text = ">";
                    PageButton[i].Font = new System.Drawing.Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
                }
                else
                {
                    if ((i == 1) || (i == NUMBER_OF_PAGES_PER_GROUP + 2)) PageButton[i].Text = "...";
                    PageButton[i].Font = new System.Drawing.Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
                }
                PageButton[i].ForeColor = Color.LightSkyBlue;
                PageButton[i].Visible = true;
                PageButton[i].AutoSize = true;
                PageButton[i].Click += new EventHandler(PageButtonHandler);
                RandomQuestion_ButtonPanelPnl.Controls.Add(PageButton[i]);
            }
        }
        public void addData(DataProcessing _questionData, DataProcessing _categoriesData, JArray _categoriesDataJarray)
        {
            questionsData = _questionData;
            categoriesData = _categoriesData;
            this._categoriesDataJarray = _categoriesDataJarray;
        }

        private void RandomQuestion_AddBtn_Click(object sender, EventArgs e)
        {
            if (RandomQuestions_NumberOfRdQuestionsCbo.SelectedItem == null || RandomQuestions_NumberOfRdQuestionsCbo.SelectedIndex < 0)
            {
                MessageBox.Show("Chưa chọn số câu hỏi cần được thêm", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (selectedQuestions.Count == 0 || selectedQuestionsContent.Count == 0)
            {
                MessageBox.Show("Không tồn tại các câu hỏi cần được thêm trong Category đã chọn", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string text = "Đã thêm thành công những câu hỏi có ID sau vào contest: ";
            for (int i = 0; i <= RandomQuestions_NumberOfRdQuestionsCbo.SelectedIndex; i++)
            {
                Random rd = new Random();
                int index = rd.Next(0, selectedQuestions.Count - 1);
                randomSelectedQuestions.Add(selectedQuestions[index]);
                text += selectedQuestions[index].ToString();
                if (i == RandomQuestions_NumberOfRdQuestionsCbo.SelectedIndex - 1) text += ".";
                else text += ", ";
                selectedQuestions.RemoveAt(index);
                selectedQuestionsContent.RemoveAt(index);
            }
            MessageBox.Show(text, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ParentEditQuiz.loadQuestionID(randomSelectedQuestions);
            this.SendToBack();
        }

        private void RandomQuestion_CategoryCbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RandomQuestion_CategoryCbo.SelectedItem == null) return;
            var a = (Categories)RandomQuestion_CategoryCbo.SelectedItem;
            selectedCategoriesIdList.Clear();
            int _parentCategories = a.Id;
            try
            {
                if (categories == null || _categoriesDataJarray == null) return;
                if (_parentCategories >= 0)
                {
                    selectedCategoriesIdList.Add(_parentCategories);
                    GetSubCategories(_parentCategories, ref selectedCategoriesIdList, ref categories);
                    SelectQuestionsFromCategories(selectedCategoriesIdList, selectQuestionsFromSubcategories);
                    //                    showQuestions(selectedCategoriesIdList, showQuestionsFromSubcategories);
                }
            }
            catch (Exception ex)
            {
                DialogResult dialog = MessageBox.Show("Can't get categories data:\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (dialog == DialogResult.OK)
                    System.Windows.Forms.Application.Exit();
            }
        }

        private void RandomQuestion_SubcategoriesCbx_CheckedChanged(object sender, EventArgs e)
        {
            selectQuestionsFromSubcategories = RandomQuestion_SubcategoriesCbx.Checked;
            if (selectedCategoriesIdList.Count == 0) return;
            SelectQuestionsFromCategories(selectedCategoriesIdList, selectQuestionsFromSubcategories);
            //            showQuestions(selectedCategoriesIdList, showQuestionsFromSubcategories);
        }

        private void SelectQuestionsFromCategories(List<int> _selectedCategoriesIdList, bool _selectQuestionsFromSubcategories)
        {
            if (selectedQuestions == null) return;
            selectedQuestions.Clear();
            selectedQuestionsContent.Clear();

            try
            {
                for (int i = 0; i < questionsData.Length(); i++)
                {
                    DataRow? question = questionsData.Init().Offset(i).Limit(1).GetFirstRow();
                    if (question != null)
                    {
                        int containedInCategories = question.Field<int>("CategoryID");
                        if (_selectQuestionsFromSubcategories && _selectedCategoriesIdList.Contains(containedInCategories) || (!_selectQuestionsFromSubcategories && _selectedCategoriesIdList[0] == containedInCategories))
                        {
                            selectedQuestions.Add(question.Field<int>("ID"));
                            string? s = question.Field<string>("Content");
                            if (s == null) s = "";
                            string _content;
                            RichTextBox tmp = new RichTextBox();
                            tmp.Visible = false;
                            try
                            {
                                tmp.Rtf = s;
                                _content = tmp.Text;
                            }
                            catch
                            {
                                _content = s;
                            }
                            if (question.Field<string>("Name") != "") _content = question.Field<string>("Name") + ": " + _content;
                            selectedQuestionsContent.Add(_content);
                        }
                    }
                }
                if (selectedQuestions.Count % NUMBER_OF_QUESTIONS_PER_PAGE == 0) numberOfPage = selectedQuestions.Count / NUMBER_OF_QUESTIONS_PER_PAGE;
                else numberOfPage = selectedQuestions.Count / NUMBER_OF_QUESTIONS_PER_PAGE + 1;
                if (numberOfPage < 0) return;
                if (numberOfPage % (NUMBER_OF_PAGES_PER_GROUP) == 0) numberOfGroup = numberOfPage / (NUMBER_OF_PAGES_PER_GROUP);
                else numberOfGroup = (numberOfPage / (NUMBER_OF_PAGES_PER_GROUP)) + 1;
                groupSelectedIndex = 1;
                pageSelectedIndex = 1;
                ShowButtons(pageSelectedIndex, groupSelectedIndex);
                ShowQuestion(pageSelectedIndex, selectedQuestions);

                RandomQuestions_NumberOfRdQuestionsCbo.Items.Clear();
                RandomQuestions_NumberOfRdQuestionsCbo.SelectedIndex = -1;
                RandomQuestions_NumberOfRdQuestionsCbo.Text = " ";
                for (int i = 1; i <= selectedQuestions.Count; i++)
                {
                    RandomQuestions_NumberOfRdQuestionsCbo.Items.Add(i);
                }
            }
            catch (Exception ex)
            {
                DialogResult dialog = MessageBox.Show("Can't get questions data:\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (dialog == DialogResult.OK)
                    System.Windows.Forms.Application.Exit();
            }
        }

        private void ShowButtons(int pageSelectedIndex, int groupSelectedIndex)
        {
            for (int i = 2; i < NUMBER_OF_PAGES_PER_GROUP + 2; i++)
            {
                int currentPage = (groupSelectedIndex - 1) * (NUMBER_OF_PAGES_PER_GROUP) + (i - 1);
                if (pageSelectedIndex == currentPage)
                {
                    PageButton[i].BackColor = Color.LightSkyBlue;
                    PageButton[i].ForeColor = Color.White;
                }
                else
                {
                    PageButton[i].ForeColor = Color.LightSkyBlue;
                    PageButton[i].BackColor = Color.White;
                }
                if (currentPage > numberOfPage) PageButton[i].Text = " ";
                else PageButton[i].Text = (currentPage).ToString();
            }
            if ((groupSelectedIndex) == 1) PageButton[1].Text = " ";
            else PageButton[1].Text = "...";
            if (groupSelectedIndex == numberOfGroup) PageButton[NUMBER_OF_PAGES_PER_GROUP + 2].Text = " ";
            else PageButton[NUMBER_OF_PAGES_PER_GROUP + 2].Text = "...";
            for (int i = 0; i < NUMBER_OF_PAGES_PER_GROUP + 3; i++)
            {
                if (PageButton[i].Text == " ") PageButton[i].Hide();
                else PageButton[i].Show();
            }
        }
        private void ShowQuestion(int pageSelectedIndex, List<int> selectedQuestions)
        {
            RandomQuestion_ShowQuestionDgv.Rows.Clear();
            if (pageSelectedIndex <= 0 || pageSelectedIndex > numberOfPage) return;
            for (int i = (pageSelectedIndex - 1) * (NUMBER_OF_QUESTIONS_PER_PAGE); i < pageSelectedIndex * NUMBER_OF_QUESTIONS_PER_PAGE; i++)
            {
                if (i >= selectedQuestions.Count) break;
                var index = RandomQuestion_ShowQuestionDgv.Rows.Add();
                DataGridViewRow row = RandomQuestion_ShowQuestionDgv.Rows[index];
                row.Cells[1].Value = selectedQuestionsContent[i];
                if (i % 2 == 0) row.DefaultCellStyle.BackColor = Color.White;
                else row.DefaultCellStyle.BackColor = Color.AliceBlue;
            }
            RandomQuestion_ShowQuestionDgv.AutoResizeRows(DataGridViewAutoSizeRowsMode.DisplayedCells);
        }
        private void PageButtonHandler(object? sender, EventArgs e)
        {
            if (sender == null) return;
            var b = sender as Button;
            if (b == null || b.Text == " " || pageSelectedIndex < 1 || pageSelectedIndex > numberOfPage) return;
            if (b.Text == "<")
            {
                if (pageSelectedIndex <= 1) return;
                pageSelectedIndex--;
                if (pageSelectedIndex % NUMBER_OF_PAGES_PER_GROUP == 0)
                {
                    groupSelectedIndex--;
                }
                ShowButtons(pageSelectedIndex, groupSelectedIndex);
                ShowQuestion(pageSelectedIndex, selectedQuestions);
                return;
            }
            if (b.Text == ">")
            {
                if (pageSelectedIndex >= numberOfPage) return;
                pageSelectedIndex++;
                if (pageSelectedIndex % NUMBER_OF_PAGES_PER_GROUP == 1 || NUMBER_OF_PAGES_PER_GROUP == 1)
                {
                    groupSelectedIndex++;
                }
                ShowButtons(pageSelectedIndex, groupSelectedIndex);
                ShowQuestion(pageSelectedIndex, selectedQuestions);
                return;
            }
            if (b.Text == "...")
            {
                if (PageButton[1] == b)
                {
                    if (groupSelectedIndex <= 1) return;
                    groupSelectedIndex--;
                    pageSelectedIndex--;
                    ShowButtons(pageSelectedIndex, groupSelectedIndex);
                    PageButton[NUMBER_OF_PAGES_PER_GROUP + 1].PerformClick();
                    return;
                }
                if (PageButton[NUMBER_OF_PAGES_PER_GROUP + 2] == b)
                {
                    if (groupSelectedIndex >= numberOfGroup) return;
                    groupSelectedIndex++;
                    pageSelectedIndex++;
                    ShowButtons(pageSelectedIndex, groupSelectedIndex);
                    PageButton[2].PerformClick();
                    return;
                }
            }
            int _pageSelectedIndex;
            bool isConvertable = int.TryParse(b.Text, out _pageSelectedIndex);
            if (isConvertable)
            {
                pageSelectedIndex = _pageSelectedIndex;
                ShowButtons(pageSelectedIndex, groupSelectedIndex);
                ShowQuestion(pageSelectedIndex, selectedQuestions);
            }
            return;
        }

        private void RandomQuestion_ExitBtn_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }
    }
}
