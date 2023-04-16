using Learning_System.ExternalClass;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learning_System
{
    public partial class CategoriesForm : UserControl
    {
        private DataProcessing categoriesData = new DataProcessing();
        private List<string> showColumns = new List<string> { "Id", "Name", "SubArray", "QuestionArray", "Description", "IdNumber" };
        private List<Type> showType = new List<Type> { typeof(int), typeof(string), typeof(JArray), typeof(JArray), typeof(string), typeof(string) };
        private DataTable categoriesDataTable = new DataTable();
        private int currentLimit = 50;
        private int currentOffset = 0;

        public void loadCombobox()
        {
            try
            {
                JArray _categoriesData = JsonProcessing.ImportJsonContentInDefaultFolder("category.json", null, null);


                categoriesData.Import(showColumns, showType);
                categoriesData.Import(_categoriesData);
                categoriesDataTable = categoriesData.GetList(currentOffset, currentLimit);
            }
            catch (Exception ex)
            {
                DialogResult dialog = MessageBox.Show("Can't get categories data:\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (dialog == DialogResult.OK)
                    Application.Exit();
            }


            CategoriesForm_ParentCategoryCbo.ValueMember = "Id";
            CategoriesForm_ParentCategoryCbo.DisplayMember = "Name";
            CategoriesForm_ParentCategoryCbo.DataSource = categoriesDataTable;
        }

        public CategoriesForm()
        {
            InitializeComponent();
            loadCombobox();
        }

        private void CategoriesForm_AddCategoryBtn_Click(object sender, EventArgs e)
        {
            var _parentId = CategoriesForm_ParentCategoryCbo.SelectedValue;
            var _name = CategoriesForm_NameTxt.Text;
            var _description = CategoriesForm_CategoryInfoTxt.Text;
            var _id = CategoriesForm_IDNumberTxt.Text;

            string _errorNoti = "";
            if (_parentId == null || _parentId.ToString() == "")
            {
                if (_errorNoti.Length > 0)
                    _errorNoti += ", ";
                _errorNoti += "Parent Category";
            }
            if (_name == null || _name == "")
            {
                if (_errorNoti.Length > 0)
                    _errorNoti += ", ";
                _errorNoti += "Category's Name";
            }
            if (_id == null || _id == "")
            {
                if (_errorNoti.Length > 0)
                    _errorNoti += ", ";
                _errorNoti += "Category's ID";
            }

            if (_errorNoti != "")
            {
                CategoriesForm_errorTextLbl.Text = "Vui lòng nhập " + _errorNoti;
                CategoriesForm_errorTextLbl.ForeColor = Color.Red;
            }
            else
            {
                CategoriesForm_errorTextLbl.Text = "Đang thêm dữ liệu...";
                CategoriesForm_errorTextLbl.ForeColor = Color.Green;

                DataProcessing _tmpDT = new DataProcessing();
                categoriesData.CopyData(_tmpDT);
                DataRow _maxIdRow = _tmpDT.GetMaxMin(0, _tmpDT.GetLength(), DataProcessing.emptyList, "Id asc", "MAX");

                Categories _newCategory = new Categories()
                {
                    Id = _maxIdRow.Field<int>("Id") + 1,
                    Name = _name,
                    SubArray = new List<int>(),
                    QuestionArray = new List<int>(),
                    Description = _description,
                    IdNumber = _id
                };

                categoriesData.AddNewElement(JObject.FromObject(_newCategory));

                DataProcessing _p = new DataProcessing();
                categoriesData.CopyData(_p);

                List<string> _query = new List<string> { "Id", _newCategory.Id.ToString() };
                DataRow _parentRow = _p.GetMaxMin(0, 1, _query, null, "MAX");

                if (_parentRow != null)
                {
                    _parentRow.Field<JArray>("SubArray").Add(_newCategory.Id);
                    JObject x = DataProcessing.ConvertDataRowToJObject(_parentRow);

                    categoriesData.ChangeElementswithCondition(_query, JObject.FromObject(x));

                    /*
                    string _jsonData = JsonConvert.SerializeObject(categoriesData.Export());

                    // Creates a resource writer.
                    IResourceWriter writer = new ResourceWriter("Properties.Resources.Category");

                    // Adds resources to the resource writer.
                    writer.AddResource("String 1", "First String");
                    writer.AddResource("String 2", "Second String");

                    // Writes the resources to the file or stream, and closes it.
                    writer.Close();

                    */

                    JsonProcessing.ExportJsonContentInDefaultFolder("Category.json", categoriesData.Export());

                    MessageBox.Show("Đã thêm thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CategoriesForm_errorTextLbl.Text = "Đã thêm dữ liệu";
                    CategoriesForm_errorTextLbl.ForeColor = Color.Red;

                    CategoriesForm_NameTxt.Text = "";
                    CategoriesForm_CategoryInfoTxt.Text = "";
                    CategoriesForm_IDNumberTxt.Text = "";

                    loadCombobox();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại do không tìm thấy parent category thỏa mãn.", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    CategoriesForm_errorTextLbl.Text = "Thêm dữ liệu lỗi!";
                    CategoriesForm_errorTextLbl.ForeColor = Color.Red;
                }
            }
        }
    }
}
