using Learning_System.Modals;
using Learning_System.ProcessingClasses;
using Newtonsoft.Json.Linq;
using System.Data;

namespace Learning_System
{
    public partial class FromQuestionBank : UserControl
    {
        private EditQuiz ParentEditQuiz;

        private bool isLoad = false;
        public List<int> questionSelectedList = new List<int>();

        public DataProcessing questionsData = new();
        public DataProcessing categoriesData = new();
        public JArray _categoriesDataJarray = new();
        public FromQuestionBank(EditQuiz _EditQuiz)
        {
            InitializeComponent();
            FromQuestionBank_SelectCategoryCbo.Text = "  Default";
            ParentEditQuiz = _EditQuiz;
            FromQuestionBank_ShowQuestionsDtg.BorderStyle = BorderStyle.None;
            FromQuestionBank_ShowQuestionsDtg.Width = Screen.PrimaryScreen.WorkingArea.Width - 30;
            FromQuestionBank_ShowQuestionsDtg.Columns[1].Width = FromQuestionBank_ShowQuestionsDtg.Width - 130;
            FromQuestionBank_ShowQuestionsDtg.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            FromQuestionBank_ShowQuestionsDtg.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            FromQuestionBank_ShowQuestionsDtg.RowTemplate.Height = 35;
            FromQuestionBank_AddBtn.Location = new Point(FromQuestionBank_ShowQuestionsDtg.Location.X,
                FromQuestionBank_ShowQuestionsDtg.Location.Y + FromQuestionBank_ShowQuestionsDtg.Height + 50);
        }
        public void addData(DataProcessing _questionData, DataProcessing _categoriesData, JArray __categoriesDataJarray)
        {
            questionsData = _questionData;
            categoriesData = _categoriesData;
            _categoriesDataJarray = __categoriesDataJarray;
        }

        private void FromQuestionBank_CategoryCbo_DropDown(object sender, EventArgs e)
        {

        }

        //bien dung de gui id cua category dang duoc chon sang form edit question
        //private int SendParentIdToEditForm;
        //bien luu cac category duoc hien tren datagridview
        private List<int> selectedCategoriesIdList = new List<int>();
        // bien co hien cau hoi tu category con hay khong
        private bool showQuestionsFromSubcategories = false;
        private void GetSubCategories(int _parentCategories, ref List<int> _subCategories, ref List<Categories> categories)
        {
            foreach (int x in categories[_parentCategories].SubArray)
            {
                _subCategories.Add(x);
                GetSubCategories(x, ref _subCategories, ref categories);
            }
        }

        public void showQuestions(List<int> showQuestionsFromCategoriesID, bool _showQuestionsFromSubcategories)
        {
            FromQuestionBank_ShowQuestionsDtg.Rows.Clear();

            try
            {
                if (questionsData.Length() == 0) MessageBox.Show("Không có câu hỏi nào trong Categories này!");
                else
                {
                    //var index = QuestionForm_ShowQuestionsDtg.Rows.Add();
                    //QuestionForm_ShowQuestionsDtg.Rows[index].Cells[1].Value = "Question name / ID number";
                    for (int i = 0; i < questionsData.Length(); i++)
                    {
                        DataRow? Question = questionsData.Init().Offset(i).Limit(1).Sort("ID desc").GetFirstRow();
                        if (Question == null)
                        {
                            DialogResult dialogResult = MessageBox.Show("Can't get questions data:\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            if (dialogResult == DialogResult.OK)
                                System.Windows.Forms.Application.Exit();
                            return;
                        }
                        int inCategories = Question.Field<int>("CategoryID");
                        int QuestionID = Question.Field<int>("ID");
                        if ((showQuestionsFromCategoriesID.Contains(inCategories) && _showQuestionsFromSubcategories) || (showQuestionsFromCategoriesID[0] == inCategories && !showQuestionsFromSubcategories))
                        {
                            string? _QuestionName = Question.Field<string>("Content");

                            //                            DataGridViewRow row = (DataGridViewRow)QuestionForm_ShowQuestionsDtg.Rows[0].Clone();
                            var index = FromQuestionBank_ShowQuestionsDtg.Rows.Add();
                            DataGridViewRow row = FromQuestionBank_ShowQuestionsDtg.Rows[index];
                            //
                            RichTextBox tmp = new RichTextBox();
                            tmp.Visible = false;
                            try
                            {
                                tmp.Rtf = _QuestionName;
                                row.Cells[1].Value = tmp.Text;
                            }
                            catch
                            {
                                row.Cells[1].Value = _QuestionName;
                            }
                            row.Cells[2].Value = QuestionID;
                            if (i % 2 == 0) row.DefaultCellStyle.BackColor = Color.White;
                            else row.DefaultCellStyle.BackColor = Color.AliceBlue;

                        }

                    }
                }
            }
            catch (Exception ex)
            {
                DialogResult dialogResult = MessageBox.Show("Can't get questions data:\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (dialogResult == DialogResult.OK)
                    System.Windows.Forms.Application.Exit();
            }
        }
        public void loadCategoriesData()
        {
            List<Categories>? listCategories = _categoriesDataJarray.ToObject<List<Categories>>();
            List<Categories> newListCategories = new List<Categories>();
            if (listCategories == null) return;
            AddSpace(ref newListCategories, ref listCategories, 0, "  ");
            newListCategories.Reverse();

            FromQuestionBank_SelectCategoryCbo.ValueMember = "Id";
            FromQuestionBank_SelectCategoryCbo.DisplayMember = "Name";
            FromQuestionBank_SelectCategoryCbo.DataSource = newListCategories;
        }

        //Them Space cho cac lua chon Combobox
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

        private void FromQuestionBank_SelectCategoryCbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FromQuestionBank_SelectCategoryCbo.SelectedItem == null) return;
            var a = (Categories)FromQuestionBank_SelectCategoryCbo.SelectedItem;
            selectedCategoriesIdList.Clear();
            int _parentCategories = a.Id;
            //
            //SendParentIdToEditForm = _parentCategories;
            //
            try
            {
                //JArray? _categoriesData = JsonProcessing.ImportJsonContentInDefaultFolder("Category.json", null, null);
                if (_categoriesDataJarray == null) return;
                List<Categories>? categories = _categoriesDataJarray.ToObject<List<Categories>>();
                if (categories == null || _categoriesDataJarray == null) return;
                if (_parentCategories >= 0)
                {
                    selectedCategoriesIdList.Add(_parentCategories);
                    GetSubCategories(_parentCategories, ref selectedCategoriesIdList, ref categories);
                    showQuestions(selectedCategoriesIdList, showQuestionsFromSubcategories);
                }
            }
            catch (Exception ex)
            {
                DialogResult dialog = MessageBox.Show("Can't get categories data:\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (dialog == DialogResult.OK)
                    System.Windows.Forms.Application.Exit();
            }
        }

        /*private void QuestionsForm_ShowFromSubcategoriesCb_CheckedChanged(object sender, EventArgs e)
        {
            showQuestionsFromSubcategories = QuestionsForm_ShowFromSubcategoriesCb.Checked;
            showQuestions(selectedCategoriesIdList, showQuestionsFromSubcategories);
        }*/

        private void FromQuestionBank_SubcategoriesCbx_CheckedChanged(object sender, EventArgs e)
        {
            if (FromQuestionBank_SelectCategoryCbo.SelectedIndex == -1)
            {
                FromQuestionBank_SubcategoriesCbx.Checked = false;
                return;
            }
            else
            {
                showQuestionsFromSubcategories = FromQuestionBank_SubcategoriesCbx.Checked;
                showQuestions(selectedCategoriesIdList, showQuestionsFromSubcategories);
            }
        }

        private void FromQuestionBank_SelectCategoryCbo_MouseClick(object sender, MouseEventArgs e)
        {
            if (!isLoad)
            {
                isLoad = true;
                loadCategoriesData();
            }
        }

        private void FromQuestionBank_AddBtn_Click_1(object sender, EventArgs e)
        {
            questionSelectedList.Clear();
            for (int i = 0; i < FromQuestionBank_ShowQuestionsDtg.RowCount; i++)
            {
                DataGridViewRow row = FromQuestionBank_ShowQuestionsDtg.Rows[i];
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    questionSelectedList.Add(Convert.ToInt32(row.Cells[2].Value));
                }
            }
            this.SendToBack();
            ParentEditQuiz.loadQuestionID(questionSelectedList);
            FromQuestionBank_SelectCategoryCbo.Text = "  Default";
            if (FromQuestionBank_SubcategoriesCbx.Checked == true)
            { FromQuestionBank_SubcategoriesCbx.Checked = false; }
        }

        private void RandomQuestion_ExitBtn_Click(object sender, EventArgs e)
        {
            questionSelectedList.Clear();
            this.SendToBack();
        }

        private void FromQuestionBank_ShowQuestionsDtg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Select "Select All" cell
                if (e.RowIndex == -1 && e.ColumnIndex == 0)
                {
                    if (FromQuestionBank_ShowQuestionsDtg.Rows.Count == 0)
                        return;

                    FromQuestionBank_ShowQuestionsDtg.CurrentCell = FromQuestionBank_ShowQuestionsDtg.CurrentRow.Cells[1];
                    foreach (DataGridViewRow row in FromQuestionBank_ShowQuestionsDtg.Rows)
                    {
                        DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[0];
                        if (chk.Value == null || Convert.ToBoolean(chk.Value) == false)
                            chk.Value = (object)true;
                        else
                            chk.Value = (object)false;

                        // chk.Value = !(chk.Value == null ? false : (bool)chk.Value); //because chk.Value is initialy null
                    }

                }
            }
            catch { return; }
        }

    }
}
