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
        private RichTextBox[] richTextBoxes = new RichTextBox[MAXOFCHOICE];
        private string content;
        public PageOfPreviewQuiz(int STT, List<QuestionChoice> questionChoices, string content)
        {
            InitializeComponent();
            this.numberOfChoice = questionChoices.Count;
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
                for (int i = numberOfChoice - 1; i >= 0; i--)
                {
                    richTextBoxes[i] = new RichTextBox();
                    this.panel_richTextboxes.Controls.Add(richTextBoxes[i]);
                    richTextBoxes[i].BackColor = Color.White;
                    richTextBoxes[i].BorderStyle = BorderStyle.None;
                    richTextBoxes[i].Dock = DockStyle.Top;
                    richTextBoxes[i].Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
                    if (i == numberOfChoice - 1)
                        richTextBoxes[i].Location = new Point(50, 0);
                    else richTextBoxes[i].Location = new Point(50, richTextBoxes[i + 1].Height + 10);
                    richTextBoxes[i].ReadOnly = true;
                    richTextBoxes[i].Size = new Size(1000, 217);
                    try
                    {
                        richTextBoxes[i].Rtf = questionChoices[i].choice;
                        using (Graphics g = CreateGraphics())
                        {
                            richTextBoxes[i].Height = (int)g.MeasureString(richTextBoxes[i].Rtf,
                                richTextBoxes[i].Font, richTextBoxes[i].Width).Height;
                        }
                    }
                    catch
                    {
                        richTextBoxes[i].Text = questionChoices[i].choice;
                        using (Graphics g = CreateGraphics())
                        {
                            richTextBoxes[i].Height = (int)g.MeasureString(richTextBoxes[i].Text,
                                richTextBoxes[i].Font, richTextBoxes[i].Width).Height;
                        }
                    }
                    //
                    radioChoice[i] = new RadioButton();
                    this.panel_button.Controls.Add(radioChoice[i]);
                    radioChoice[i].AutoSize = true;
                    radioChoice[i].Size = new Size(131, 27);
                    if (i == numberOfChoice - 1)
                        radioChoice[i].Location = new Point(10, 0);
                    else radioChoice[i].Location = new Point(10, richTextBoxes[i + 1].Height * (numberOfChoice - 1 - i));
                    radioChoice[i].Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
                    radioChoice[i].UseVisualStyleBackColor = true;
                    radioChoice[i].Text = "";
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
                using (Graphics g = CreateGraphics())
                {
                    ContentRtb.Height = (int)g.MeasureString(ContentRtb.Rtf,
                        ContentRtb.Font, ContentRtb.Width).Height;
                }
            }
            catch
            {
                ContentRtb.Text = content;
                using (Graphics g = CreateGraphics())
                {
                    ContentRtb.Height = (int)g.MeasureString(ContentRtb.Text,
                        ContentRtb.Font, ContentRtb.Width).Height;
                }
            }

        }

    }
}
