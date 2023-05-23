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

        public void AddSpace(ref List<Categories> List, ref List<Categories> addList, int begin, string space)
        {
            foreach (int x in addList[begin].SubArray)
            {
                addList[x].Name = space + addList[x].Name;
                AddSpace(ref List, ref addList, x, space + "  ");
            }
            addList[begin].Name = "  " + addList[begin].Name;

            if (addList[begin].QuestionArray.Count > 0)
                addList[begin].Name = addList[begin].Name + " (" + addList[begin].QuestionArray.Count + ")";
            List.Add(addList[begin]);
        }
        public void loadCategoriesData()
        {
            List<Categories>? listCategories = new List<Categories>();
            List<Categories> newListCategories = new List<Categories>();
            try
            {
                listCategories = _categoriesDataJarray.ToObject<List<Categories>>();
                if (listCategories == null) return;
                AddSpace(ref newListCategories, ref listCategories, 0, "  ");
                newListCategories.Reverse();
            }
            catch (Exception ex)
            {
                DialogResult dialog = MessageBox.Show("Can't get categories data:\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (dialog == DialogResult.OK)
                    Application.Exit();
            }

            RandomQuestion_CategoryCbo.ValueMember = "Id";
            RandomQuestion_CategoryCbo.DisplayMember = "Name";
            RandomQuestion_CategoryCbo.DataSource = newListCategories;
        }
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

        private void RandomQuestion_CategoryCbo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RandomQuestion_CategoryCbo_Click(object sender, EventArgs e)
        {
            loadCategoriesData();
        }
    }
}
