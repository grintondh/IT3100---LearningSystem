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

        private void FromQuestionBank_AddBtn_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }
    }
}
