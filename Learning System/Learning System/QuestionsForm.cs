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
            //addNewQuestionForm.ShowDialog();
            addNewQuestionForm.Show();
        }
    }
}
