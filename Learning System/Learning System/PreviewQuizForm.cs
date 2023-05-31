using Learning_System.ExternalClass;
using Newtonsoft.Json.Linq;
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
    public partial class PreviewQuizForm : Form
    {
        private int currentPage = 0;
        private int numberOfPage;
        private int numberOfQuestion;
        const int questionPerPage = 3;
        private int timeLimit;
        private List<int> questionID;
        private DataProcessing questionsData;
        private Panel[] panel_Page = new Panel[100];

        public PreviewQuizForm(int timeLimit, DataProcessing questionsData, List<int> questionID, string nameContest)
        {
            InitializeComponent();
            panel_right.Width = 300;
            panel_left.Width = Screen.PrimaryScreen.WorkingArea.Width - panel_right.Width;
            panel_QuestionBtn.AutoScroll = true;
            this.timeLimit = timeLimit;
            this.questionsData = questionsData;
            this.questionID = questionID;
            PathLbl.Text += "  /  " + nameContest + "  /  Preview";
            numberOfQuestion = questionID.Count;
            //
            DataRow[] dataRow = new DataRow[numberOfQuestion];
            for (int i = 0; i < numberOfQuestion; i++)
            {
                List<string> query = new() { "ID", questionID[i].ToString() };
                dataRow[i] = questionsData.Init().Offset(0).Limit(1).Query(query).GetFirstRow();
            }
            numberOfPage = Convert.ToInt32(Math.Ceiling((decimal)numberOfQuestion / questionPerPage));
            var x = numberOfQuestion / questionPerPage;
            PageOfPreviewQuiz[] quiz = new PageOfPreviewQuiz[numberOfQuestion];
            for (int i = 0; i < x; i++)
            {
                panel_Page[i] = new Panel();
                panel_left.Controls.Add(panel_Page[i]);
                panel_Page[i].Dock = DockStyle.Fill;
                for (int j = 0; j < questionPerPage; j++)
                {
                    var questionsChoices = dataRow[questionPerPage * i + j].Field<JArray>("Choice").ToObject<List<QuestionChoice>>();
                    var content = dataRow[questionPerPage * i + j].Field<string>("Content");
                    quiz[questionPerPage * i + j] = new PageOfPreviewQuiz(questionPerPage * i + j, questionsChoices, content, this);
                    quiz[questionPerPage * i + j].resize();
                    if (j == 0)
                    {
                        quiz[questionPerPage * i + j].Location = new Point(0, 0);
                    }
                    else
                    {
                        quiz[questionPerPage * i + j].Location = new Point(0, quiz[questionPerPage * i + j - 1].Height + quiz[questionPerPage * i + j - 1].Location.Y);
                    }
                    panel_Page[i].Controls.Add(quiz[questionPerPage * i + j]);
                }
                panel_Page[i].AutoScroll = true;
                panel_Page[i].AutoSize = true;
            }
            if (x < numberOfPage)
            {
                panel_Page[numberOfPage - 1] = new Panel();
                panel_left.Controls.Add(panel_Page[numberOfPage - 1]);
                panel_Page[numberOfPage - 1].Dock = DockStyle.Fill;
                panel_Page[numberOfPage - 1].AutoScroll = true;
                for (int j = questionPerPage * x; j < numberOfQuestion; j++)
                {
                    var questionsChoices = dataRow[j].Field<JArray>("Choice").ToObject<List<QuestionChoice>>();
                    var content = dataRow[j].Field<string>("Content");
                    quiz[j] = new PageOfPreviewQuiz(j, questionsChoices, content, this);
                    quiz[j].resize();
                    if (j == questionPerPage * x)
                    {
                        quiz[j].Location = new Point(0, 0);
                    }
                    else
                    {
                        quiz[j].Location = new Point(0, quiz[j - 1].Height + quiz[j - 1].Location.Y);
                    }
                    panel_Page[numberOfPage - 1].Controls.Add(quiz[j]);
                }
            }
            panel_Page[0].BringToFront();
            PreviousPageBtn.Visible = false;
            //
            Button[] button = new Button[numberOfQuestion];
            for (int i = 0; i < numberOfQuestion; i++)
            {
                button[i] = new Button();
                button[i].Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
                button[i].BackColor = Color.FromArgb(0, 159, 229);
                button[i].FlatStyle = FlatStyle.Flat;
                button[i].Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
                button[i].ForeColor = Color.White;
                button[i].Location = new Point(5 + (i % 5) * 50, 5 + (i / 5) * 50);
                button[i].Size = new Size(45, 45);
                button[i].Text = (i + 1).ToString();
                button[i].UseVisualStyleBackColor = false;
                button[i].Click += pageButtonClick;
                panel_QuestionBtn.Controls.Add(button[i]);
            }
        }

        private void PreviousPageBtn_Click(object sender, EventArgs e)
        {
            currentPage -= 1;
            if (currentPage == 0)
            {
                PreviousPageBtn.Visible = false;
            }
            NextPageBtn.Visible = true;
            panel_Page[currentPage].BringToFront();
        }

        private void NextPageBtn_Click(object sender, EventArgs e)
        {
            currentPage += 1;
            if (currentPage == numberOfPage - 1)
            {
                NextPageBtn.Visible = false;
            }
            PreviousPageBtn.Visible = true;
            panel_Page[currentPage].BringToFront();
        }

        private void pageButtonClick(object sender, EventArgs e)
        {
            var text = ((Button)sender).Text;
            int x = (Convert.ToInt32(text) - 1) / 3;
            currentPage = x;
            panel_Page[x].BringToFront();
            if (currentPage == numberOfPage - 1)
            {
                NextPageBtn.Visible = false;
            }
            else NextPageBtn.Visible = true;
            if (currentPage == 0)
            {
                PreviousPageBtn.Visible = false;
            }
            else PreviousPageBtn.Visible = true;
        }
    }
}
