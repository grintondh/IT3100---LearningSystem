namespace Learning_System
{
    public partial class QuestionsForm : UserControl
    {
        public QuestionsForm()
        {
            InitializeComponent();
        }

        private void QuestionsForm_CreateNewQuestionBtn_Click(object sender, EventArgs e)
        {
            AddNewQuestionForm addNewQuestionForm = new AddNewQuestionForm();
            addNewQuestionForm.ShowDialog();
            // Hàm ngay bên dưới này dùng để load lại datagridview, khi nào merge code vào thì ông bỏ // đi hộ tôi nhá
            // showQuestions(selectedCategoriesIdList, showQuestionsFromSubcategories);
        }
    }
}
