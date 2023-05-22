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
    public partial class FromQuestionBank : UserControl
    {
        public DataProcessing questionsData = new();
        public DataProcessing categoriesData = new();
        public FromQuestionBank()
        {
            InitializeComponent();
        }
        public void addData(DataProcessing _questionData, DataProcessing _categoriesData)
        {
            questionsData = _questionData;
            categoriesData = _categoriesData;
        }

        private void FromQuestionBank_AddBtn_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }

        private void FromQuestionBank_CategoryCbo_DropDown(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = categoriesData.Init().Offset(0).Limit(categoriesData.Length()).Get();
            FromQuestionBank_CategoryCbo.DataSource = dt;
            FromQuestionBank_CategoryCbo.ValueMember = "Id";
            FromQuestionBank_CategoryCbo.DisplayMember = "Name";
        }
    }
}
