using Learning_System.ExternalClass;
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
    public partial class EditQuiz : UserControl
    {
        public DataProcessing questionsData = new();
        public DataProcessing categoriesData = new();
        public EditQuiz()
        {
            InitializeComponent();
            fromQuestionBank.questionsData = questionsData;
            fromQuestionBank.categoriesData = categoriesData;
            randomQuestion.questionsData = questionsData;
            randomQuestion.categoriesData = categoriesData;
        }

        private void EditQuiz_AddBtn_Click(object sender, EventArgs e)
        {
            if (flowLayoutPanel_popup.Visible == false)
                flowLayoutPanel_popup.Visible = true;
            else flowLayoutPanel_popup.Visible = false;
        }

        private void EditQuiz_BankBtn_Click(object sender, EventArgs e)
        {
            panel_edit.SendToBack();
            fromQuestionBank.BringToFront();
            randomQuestion.SendToBack();
        }

        private void EditQuiz_RandomBtn_Click(object sender, EventArgs e)
        {
            panel_edit.SendToBack();
            fromQuestionBank.SendToBack();
            randomQuestion.BringToFront();
        }

        private void EditQuiz_SaveBtn_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }
    }
}
