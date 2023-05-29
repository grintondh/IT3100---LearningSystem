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
    public partial class StartAttemptForm : Form
    {
        private int timeLimit;
        private DataProcessing questionsData;
        private List<int> questionID;
        public StartAttemptForm(int timeLimit, DataProcessing questionsData, List<int> questionID)
        {
            InitializeComponent();
            this.timeLimit = timeLimit;
            this.questionsData = questionsData;
            this.questionID = questionID;
            NotiLbl.Text = $"Your attempt will have a time limit of {timeLimit} minutes. When you start, the timer will begin \r\nto count down and cannot be paused. You must finish your attempt before it \r\nexpires. Are you sure you wish to start now?";
        }

        private void StartAttemptForm_Load(object sender, EventArgs e)
        {

        }

        private void CancelBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StartBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
            PreviewQuizForm previewQuizForm = new PreviewQuizForm(timeLimit, questionsData, questionID);
            previewQuizForm.ShowDialog();
        }
    }
}
