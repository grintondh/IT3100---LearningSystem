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
using System.Transactions;
using System.Windows.Forms;

namespace Learning_System
{
    public partial class QuestionsForm : UserControl
    {
         private List<Categories> listCategories = new List<Categories>();
         private List<Categories> newListCategories = new List<Categories>();
        public void loadCategoriesData()
        {
            try
            {
                JArray _categoriesData = JsonProcessing.ImportJsonContentInDefaultFolder("category.json", null, null);
                listCategories = _categoriesData.ToObject<List<Categories>>();
                AddSpace(ref newListCategories, listCategories, 0, "  ");
                newListCategories.Reverse();
            }
            catch (Exception ex)
            {
                DialogResult dialog = MessageBox.Show("Can't get categories data:\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (dialog == DialogResult.OK)
                    Application.Exit();
            }


            QuestionsForm_SelectCategoryCbo.ValueMember = "Id";
            QuestionsForm_SelectCategoryCbo.DisplayMember = "Name";
            QuestionsForm_SelectCategoryCbo.DataSource = listCategories;
        }

        //Them Space cho cac lua chon Combobox
        public void AddSpace(ref List<Categories> List, List<Categories> addList, int begin, string space)
        {
            foreach (int x in addList[begin].SubArray)
            {
                addList[x].Name = space + addList[x].Name;
                AddSpace(ref List, addList, x, space + "  ");
            }
            addList[begin].Name = "  " + addList[begin].Name;

            if (addList[begin].QuestionArray.Count > 0)
                addList[begin].Name = addList[begin].Name + " (" + addList[begin].QuestionArray.Count + ")";
            List.Add(addList[begin]);
        }
        public QuestionsForm()
        {
            InitializeComponent();
            loadCategoriesData();
            QuestionsForm_SelectCategoryCbo.SelectedIndex = -1;
            QuestionsForm_SelectCategoryCbo.SelectedText = "  Default";


            //JArray jarrayCategories = JsonProcessing.ImportJsonContentInDefaultFolder("Category.json", null, null);
            //List<Categories> listCategories = jarrayCategories.ToObject<List<Categories>>();
            //List<Categories> newListCategories = new List<Categories>();
            //AddSpace(ref newListCategories, listCategories, 0, "  ");
            //newListCategories.Reverse();

            //QuestionsForm_SelectCategoryCbo.DataSource = newListCategories;
            //QuestionsForm_SelectCategoryCbo.DisplayMember = "Name";

            ////Set gia tri ban dau la Default 

            //QuestionsForm_SelectCategoryCbo.SelectedIndex = -1;
            //QuestionsForm_SelectCategoryCbo.SelectedText = "  Default";

            //Categories ct = new Categories();
            //ct = (Categories)QuestionsForm_SelectCategoryCbo.Items[0];
            ////DrawItemEventArgs newItem = (DrawItemEventArgs)ct;
            //Font font = ct.Font;
            //font = new System.Drawing.Font(font, FontStyle.Bold);

        }

        private void QuestionsForm_SelectCategoryCbo_Click(object sender, EventArgs e)
        {
            loadCategoriesData();
        }

        private void QuestionsForm_SelectCategoryCbo_DropDown(object sender, EventArgs e)
        {
            loadCategoriesData();
        }
    }
}
