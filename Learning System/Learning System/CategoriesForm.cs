using Learning_System.ExternalClass;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
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

        public CategoriesForm()
        {
            try
            {
                JArray _categoriesData = JsonProcessing.ImportJsonContentInDefaultFolder("Category.json", null, null);
                categoriesData.Import(showColumns, showType);
                categoriesData.Import(_categoriesData);
                categoriesDataTable = categoriesData.GetList(currentOffset, currentLimit, DataProcessing.emptyList, DataProcessing.emptyList);
            }
            catch (Exception ex)
            {
                DialogResult dialog = MessageBox.Show("Can't get categories data:\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            InitializeComponent();

            CategoriesForm_ParentCategoryCbo.ValueMember = "Id";
            CategoriesForm_ParentCategoryCbo.DisplayMember = "Name";
            CategoriesForm_ParentCategoryCbo.DataSource = categoriesDataTable;
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

                Categories _newCategory = new Categories()
                {
                    Id = categoriesData.GetLength(),
                    Name = _name,
                    SubArray = new List<int>(),
                    QuestionArray = new List<int>(),
                    Description = _description,
                    IdNumber = _id
                };

                categoriesData.AddNewElement(JObject.FromObject(_newCategory));

                List<string> _query = new List<string> { "OffsetOff", "1", "Id", _parentId.ToString()};
                List<string> _column = new List<string> { "SubArray" };
                DataTable _parentRow = categoriesData.GetList(0, 1, _query, _column);

                if(_parentRow != null)
                {
                    _parentRow.Rows[0].Field<JArray>("SubArray").Add(_newCategory.Id);
                    JObject x = DataProcessing.ConvertDataRowToJObject(_parentRow.Rows[0]);

                    categoriesData.ChangeElementswithCondition(_query.GetRange(2, 2).ToList(), JObject.FromObject(x));

                    JsonProcessing.ExportJsonContentInDefaultFolder("Category.json", categoriesData.Export());

                    MessageBox.Show("Đã thêm thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm thất bại do không tìm thấy parent category thỏa mãn.", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
