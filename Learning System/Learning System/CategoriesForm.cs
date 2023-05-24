using Learning_System.ExternalClass;
using Newtonsoft.Json.Linq;
using System.Data;

namespace Learning_System
{
    public partial class CategoriesForm : UserControl
    {
        private DataProcessing categoriesData = new();
        private List<string> showColumns = new() { "Id", "Name", "SubArray", "QuestionArray", "Description", "IdNumber" };
        private List<Type> showType = new() { typeof(int), typeof(string), typeof(JArray), typeof(JArray), typeof(string), typeof(string) };
        private readonly List<string> showKey = new() { "PRIMARY KEY", "", "", "", "", "" };
        private DataTable? categoriesDataTable = new();
        private int currentLimit = 50;
        private int currentOffset = 0;
        public void LoadCombobox()
        {
            try
            {
                JArray? _categoriesData = JsonProcessing.ImportJsonContentInDefaultFolder("category.json", null, null);

                if (_categoriesData == null)
                    throw new Exception();

                categoriesData.Import(showColumns, showType, showKey);
                categoriesData.Import(_categoriesData);
                categoriesDataTable = categoriesData.Init().Offset(currentOffset).Limit(currentLimit).Get();
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
                try
                {
                    CategoriesForm_errorTextLbl.Text = "Đang thêm dữ liệu...";
                    CategoriesForm_errorTextLbl.ForeColor = Color.Green;

                    DataRow? _maxIdRow = categoriesData.Init()
                                                       .Offset(0)
                                                       .Limit(categoriesData.Length())
                                                       .Sort("Id desc")
                                                       .GetFirstRow();

                    Categories _newCategory = new()
                    {
                        Id = (_maxIdRow == null) ? 0 : (_maxIdRow.Field<int>("Id") + 1),
                        Name = _name,
                        SubArray = new List<int>(),
                        QuestionArray = new List<int>(),
                        Description = _description,
                        IdNumber = _id
                    };

                    if (categoriesData.Insert(JObject.FromObject(_newCategory)) == DataProcessing.StatusCode.Error)
                        throw new Exception();

                    List<string> _query = new() { "Id", _parentId.ToString() };
                    DataRow? _parentRow = categoriesData.Init().Offset(currentOffset).Limit(currentLimit).Query(_query).GetFirstRow();

                    if (_parentRow != null)
                    {
                        var _x = _parentRow.Field<JArray>("SubArray");
                        if (_x != null)
                            _x.Add(_newCategory.Id);
                        else
                        {
                            MessageBox.Show("Không tìm thấy cột SubArray trong dữ liệu!", "Error");
                            throw new Exception();
                        }

                        JObject x = DataProcessing.ConvertDataRowToJObject(_parentRow);

                        if (categoriesData.Init().Offset(0).Limit(1).Query(_query).Update(x) == DataProcessing.StatusCode.Error)
                            throw new Exception();

                        CategoriesForm_ParentCategoryCbo.ValueMember = "Id";
                        CategoriesForm_ParentCategoryCbo.DisplayMember = "Name";
                        CategoriesForm_ParentCategoryCbo.DataSource = categoriesData.Init().Offset(currentOffset).Limit(currentLimit).Query(DataProcessing.EmptyList).Sort(null).Get();

                        JsonProcessing.ExportJsonContentInDefaultFolder("Category.json", categoriesData.Export());
                        MessageBox.Show("Đã thêm thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        CategoriesForm_errorTextLbl.Text = "Đã thêm dữ liệu";
                        CategoriesForm_errorTextLbl.ForeColor = Color.Red;

                        CategoriesForm_NameTxt.Text = "";
                        CategoriesForm_CategoryInfoTxt.Text = "";
                        CategoriesForm_IDNumberTxt.Text = "";
                    }
                    else
                        throw new Exception();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm phần tử thất bại!\nChi tiết lỗi:\n" + ex, "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    CategoriesForm_errorTextLbl.Text = "Thêm dữ liệu lỗi!";
                    CategoriesForm_errorTextLbl.ForeColor = Color.Red;
                }
            }
        }
    }
}
