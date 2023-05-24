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
            //showQuestions(selectedCategoriesIdList, showQuestionsFromSubcategories);
        }
    }
}
