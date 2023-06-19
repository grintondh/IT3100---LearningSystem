using Learning_System.ProcessingClasses;
using Learning_System.Modals;
using Newtonsoft.Json.Linq;
using System.Data;

namespace Learning_System
{
    public partial class CategoriesForm : UserControl
    {
        public void LoadCombobox()
        {
            DataTable? dt;
            try
            {
                JArray? _categoriesData = JsonProcessing.ImportJsonContentInDefaultFolder("category.json", null, null);

                if (_categoriesData == null)
                    throw new E01CantFindFile();
                
                CategoriesTable.table.Import(_categoriesData);
                dt = CategoriesTable.table.Init().Offset(0).Limit(CategoriesTable.table.Length()).Get();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CategoriesForm_ParentCategoryCbo.ValueMember = "Id";
            CategoriesForm_ParentCategoryCbo.DisplayMember = "Name";
            CategoriesForm_ParentCategoryCbo.DataSource = dt;
        }

        public CategoriesForm()
        {
            InitializeComponent();
            LoadCombobox();
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

            if (_errorNoti != "")
            {
                MessageBox.Show("Please don't leave these blank: " + _errorNoti, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    DataRow? _maxIdRow = CategoriesTable.table.Init().Offset(0).Limit(CategoriesTable.table.Length()).Sort("Id desc").GetFirstRow();

                    Categories _newCategory = new()
                    {
                        Id = (_maxIdRow == null) ? 0 : (_maxIdRow.Field<int>("Id") + 1),
                        Name = _name,
                        SubArray = new List<int>(),
                        QuestionArray = new List<int>(),
                        Description = _description,
                        IdNumber = _id
                    };

                    if (CategoriesTable.table.Insert(JObject.FromObject(_newCategory)) == DataProcessing.StatusCode.Error)
                        throw new E05CantInsertProperly();

                    List<string> _query = new() { "Id", _parentId.ToString() };
                    DataRow? _parentRow = CategoriesTable.table.Init().Offset(0).Limit(CategoriesTable.table.Length()).Query(_query).GetFirstRow();

                    if (_parentRow == null)
                        throw new E02CantProcessQuery();
                    else
                    {
                        var _x = _parentRow.Field<JArray>("SubArray");
                        if (_x != null)
                            _x.Add(_newCategory.Id);
                        else
                            throw new E03NotExistColumn("SubArray");

                        JObject x = DataProcessing.ConvertDataRowToJObject(_parentRow);

                        if (CategoriesTable.table.Init().Offset(0).Limit(1).Query(_query).Update(x) == DataProcessing.StatusCode.Error)
                            throw new E02CantProcessQuery();

                        CategoriesForm_ParentCategoryCbo.ValueMember = "Id";
                        CategoriesForm_ParentCategoryCbo.DisplayMember = "Name";
                        CategoriesForm_ParentCategoryCbo.DataSource = CategoriesTable.table.Init().Offset(0).Limit(CategoriesTable.table.Length()).Get();

                        if (JsonProcessing.ExportJsonContentInDefaultFolder("Category.json", CategoriesTable.table.Export()) == null)
                            throw new E04CantExportProperly();

                        MessageBox.Show("Add new category successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        CategoriesForm_NameTxt.Text = "";
                        CategoriesForm_CategoryInfoTxt.Text = "";
                        CategoriesForm_IDNumberTxt.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Add failed!\nDescription: " + ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
