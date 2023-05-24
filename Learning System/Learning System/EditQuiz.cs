﻿using Learning_System.ExternalClass;
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
        private List<int> questionID = new();
        public EditQuiz()
        {
            InitializeComponent();
        }
        public void addData(DataProcessing _questionData, DataProcessing _categoriesData)
        {
            questionsData = _questionData;
            categoriesData = _categoriesData;
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
            flowLayoutPanel_popup.Visible = false;
        }

        private void EditQuiz_RandomBtn_Click(object sender, EventArgs e)
        {
            panel_edit.SendToBack();
            fromQuestionBank.SendToBack();
            randomQuestion.BringToFront();
            flowLayoutPanel_popup.Visible = false;
        }

        private void EditQuiz_SaveBtn_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }

        public void loadDatagridview(List<int> selectedQuestions)
        {
            if (selectedQuestions.Count == 0) return;
            for (int i = 0; i < selectedQuestions.Count; i++)
            {
                if (!questionID.Contains(selectedQuestions[i]))
                    questionID.Add(selectedQuestions[i]);
            }
            EditQuiz_QuestionDtg.Rows.Clear();
            for (int i = 0; i < questionID.Count; i++)
            {
                List<string> query = new List<string> { "ID", questionID[i].ToString() };
                DataRow row = questionsData.Init().Offset(0).Limit(1).Query(query).GetFirstRow();
                var index = EditQuiz_QuestionDtg.Rows.Add();
                DataGridViewRow DtgRow = EditQuiz_QuestionDtg.Rows[index];
                DtgRow.Cells[0].Value = row.Field<string>("Name") + " " + row.Field<string>("Content");
            }
        }
    }
}
