using Learning_System.Modals;

namespace Learning_System
{
    public partial class PageOfPreviewQuiz : UserControl
    {
        public const int HEIGHTMAX = 500;
        public double mark = 0;
        private PreviewQuizForm parentForm;
        public bool IsMultipleChoiceQuestion;
        public int numberOfChoice;
        const int MAXOFCHOICE = 100;
        public RadioButton[] radioChoice = new RadioButton[MAXOFCHOICE];
        public CheckBox[] checkboxChoice = new CheckBox[MAXOFCHOICE];
        public List<QuestionChoice> questionChoices = new List<QuestionChoice>();
        public RichTextBox[] richTextBoxes = new RichTextBox[MAXOFCHOICE];
        private string content;
        private int STT;
        public char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        public PageOfPreviewQuiz(int STT, List<QuestionChoice> questionChoices, string content, PreviewQuizForm previewQuizForm)
        {
            InitializeComponent();
            this.numberOfChoice = questionChoices.Count;
            this.questionChoices = questionChoices;
            this.content = content;
            this.parentForm = previewQuizForm;
            this.STT = STT;
            // set width
            this.Width = Screen.PrimaryScreen.WorkingArea.Width - parentForm.panel_right.Width;
            panel2.Width = this.Width - panel2.Location.X - 30;
            try
            {
                ContentRtb.Rtf = content;
                ContentRtb.Height = HEIGHTMAX;
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

            ContentRtb.ReadOnly = true;

            panel3.Dock = DockStyle.None;
            panel3.Width = panel2.Width;
            panel3.Dock = DockStyle.Fill;
            QuestionChoiceGrb.Dock = DockStyle.None;
            QuestionChoiceGrb.Width = panel3.Width;
            QuestionChoiceGrb.Dock = DockStyle.Fill;
            panel_button.Width = 50;
            panel_richTextboxes.Dock = DockStyle.None;
            panel_richTextboxes.Width = panel3.Width - panel_button.Width;
            panel_richTextboxes.Dock = DockStyle.Fill;
            // dynamic control
            for (int i = 0; i < questionChoices.Count; i++)
            {
                if (0 < questionChoices[i].mark && questionChoices[i].mark < 1)
                {
                    IsMultipleChoiceQuestion = true;
                    break;
                }
                IsMultipleChoiceQuestion = false;
            }
            for (int i = 0; i < numberOfChoice; i++)
            {
                richTextBoxes[i] = new RichTextBox();
                this.panel_richTextboxes.Controls.Add(richTextBoxes[i]);
                richTextBoxes[i].BackColor = Color.FromArgb(231, 243, 245);
                richTextBoxes[i].BorderStyle = BorderStyle.None;
                richTextBoxes[i].Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
                if (i == 0)
                    richTextBoxes[i].Location = new Point(0, 0);
                else richTextBoxes[i].Location = new Point(0, richTextBoxes[i - 1].Height + richTextBoxes[i - 1].Location.Y);
                richTextBoxes[i].Width = panel_richTextboxes.Width;
                try
                {
                    richTextBoxes[i].Rtf = questionChoices[i].choice;
                    richTextBoxes[i].Height = HEIGHTMAX;
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
                richTextBoxes[i].ReadOnly = true;
                //
                if (IsMultipleChoiceQuestion == true)
                {
                    checkboxChoice[i] = new CheckBox();
                    this.panel_button.Controls.Add(checkboxChoice[i]);
                    checkboxChoice[i].AutoSize = true;
                    checkboxChoice[i].Size = new Size(131, 27);
                    checkboxChoice[i].UseVisualStyleBackColor = true;
                    checkboxChoice[i].Text = "";
                    checkboxChoice[i].Location = new Point(5, richTextBoxes[i].Location.Y - 2);
                    checkboxChoice[i].Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
                    checkboxChoice[i].Click += checkBoxClick;
                    checkboxChoice[i].Text = alphabet[i % 26].ToString() + ".";
                }
                else
                {
                    radioChoice[i] = new RadioButton();
                    this.panel_button.Controls.Add(radioChoice[i]);
                    radioChoice[i].AutoSize = true;
                    radioChoice[i].Size = new Size(131, 27);
                    radioChoice[i].Location = new Point(5, richTextBoxes[i].Location.Y - 2);
                    radioChoice[i].Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
                    radioChoice[i].UseVisualStyleBackColor = true;
                    radioChoice[i].Text = "";
                    radioChoice[i].Click += radionButtonClick;
                    radioChoice[i].Text = alphabet[i % 26].ToString() + ".";
                }
            }
            NumberLbl.Text = (STT + 1).ToString();
        }

        public void resize()
        {
            int min_height = 117;
            QuestionChoiceGrb.Height = 0;
            QuestionChoiceGrb.Dock = DockStyle.None;
            QuestionChoiceGrb.Location = new Point(0, 0);
            panel3.Dock = DockStyle.None;
            panel3.Location = new Point(0, ContentRtb.Height);
            for (int i = 0; i < numberOfChoice; i++)
            {
                QuestionChoiceGrb.Height += richTextBoxes[i].Height;
            }
            panel3.Height = QuestionChoiceGrb.Height;
            panel2.Height = panel3.Height + ContentRtb.Height;
            if (panel2.Height < min_height)
            {
                panel1.Height = min_height;
                this.Height = panel1.Height + panel2.Location.Y + 10;
            }
            else
            {
                panel1.Height = panel2.Height;
                this.Height = panel2.Height + panel2.Location.Y + 10;
            }
        }

        public void radionButtonClick(object sender, EventArgs e)
        {
            parentForm.button[STT].BackColor = Color.DimGray;
            AnswerLbl.Text = "Answer saved";
        }

        public void checkBoxClick(object sender, EventArgs e)
        {
            bool check = false;
            for (int i = 0; i < numberOfChoice; i++)
            {
                if (checkboxChoice[i].Checked == true) check = true;
            }
            if (check == true)
            {
                parentForm.button[STT].BackColor = Color.DimGray;
                AnswerLbl.Text = "Answer saved";
            }
            else
            {
                parentForm.button[STT].BackColor = Color.FromArgb(0, 159, 229);
                AnswerLbl.Text = "Not yet answered";
            }
        }
    }
}
