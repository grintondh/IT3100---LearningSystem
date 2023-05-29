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
    public partial class PageOfPreviewQuiz : UserControl
    {
        private bool IsMultipleChoiceQuestion;
        private int numberOfChoice;
        const int MAXOFCHOICE = 10;
        private RadioButton[] radioChoice = new RadioButton[MAXOFCHOICE];
        private CheckBox[] checkboxChoice = new CheckBox[MAXOFCHOICE];
        private List<QuestionChoice> questionChoices = new List<QuestionChoice>();
        private string content;
        public PageOfPreviewQuiz(int STT, int numberOfChocie, List<QuestionChoice> questionChoices, string content)
        {
            InitializeComponent();
            this.numberOfChoice = numberOfChocie;
            this.questionChoices = questionChoices;
            this.content = content;
            for (int i = 0; i < questionChoices.Count; i++)
            {
                if (0 < questionChoices[i].mark && questionChoices[i].mark < 1)
                {
                    IsMultipleChoiceQuestion = true;
                    break;
                }
                IsMultipleChoiceQuestion = false;
            }
            if (IsMultipleChoiceQuestion == false)
            {
                for (int i = 0; i < numberOfChoice; i++)
                {
                    radioChoice[i] = new RadioButton();
                    this.QuestionChoiceGrb.Controls.Add(radioChoice[i]);
                    radioChoice[i].AutoSize = true;
                    radioChoice[i].Size = new Size(131, 27);
                    radioChoice[i].Location = new Point(10, 20 + i * 27);
                    radioChoice[i].Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
                    radioChoice[i].UseVisualStyleBackColor = true;
                    radioChoice[i].Text = questionChoices[i].choice;
                }
            }
            else
            {
                for (int i = 0; i < numberOfChoice; i++)
                {
                    checkboxChoice[i] = new CheckBox();
                    this.QuestionChoiceGrb.Controls.Add(checkboxChoice[i]);
                    checkboxChoice[i].AutoSize = true;
                    checkboxChoice[i].Size = new Size(131, 27);
                    checkboxChoice[i].Location = new Point(10, 30 + i * 27);
                    checkboxChoice[i].Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
                    checkboxChoice[i].UseVisualStyleBackColor = true;
                    checkboxChoice[i].Text = questionChoices[i].choice;
                }
            }
            NumberLbl.Text = (STT + 1).ToString();
            try
            {
                ContentRtb.Rtf = content;
            }
            catch
            {
                ContentRtb.Text = content;
            }
        }

    }
}
