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
    public partial class RandomQuestion : UserControl
    {
        public DataProcessing questionsData = new();
        public DataProcessing categoriesData = new();
        public JArray _categoriesDataJarray = new();
        public RandomQuestion()
        {
            InitializeComponent();
        }
        public void addData(DataProcessing _questionData, DataProcessing _categoriesData, JArray _categoriesDataJarray)
        {
            questionsData = _questionData;
            categoriesData = _categoriesData;
            this._categoriesDataJarray = _categoriesDataJarray;
        }

        private void RandomQuestion_AddBtn_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }
    }
}
