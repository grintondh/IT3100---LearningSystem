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
    public partial class PopUpForm : UserControl
    {
        public PopUpForm()
        {
            InitializeComponent();
        }

        private void button_Questions_Click(object sender, EventArgs e)
        {
            if (PopUpForm_QuestionsBtn.Focused == true)
            {
                PopUpForm_QuestionsBtn.BackColor = Color.Gray;
                PopUpForm_CategoriesBtn.BackColor = panel_chuc_nang.BackColor;
                PopUpForm_ImportBtn.BackColor = panel_chuc_nang.BackColor;
                PopUpForm_ExportBtn.BackColor = panel_chuc_nang.BackColor;
            }
            CategoriesForm.Visible = false;
            ImportForm.Visible = false;
            ExportForm.Visible = false;
            QuestionsForm.Visible = true;
        }

        public void Show_Questions()
        {
            CategoriesForm.Visible = false;
            ImportForm.Visible = false;
            ExportForm.Visible = false;
            QuestionsForm.Visible = true;
            PopUpForm_QuestionsBtn.BackColor = Color.Gray;
            PopUpForm_CategoriesBtn.BackColor = panel_chuc_nang.BackColor;
            PopUpForm_ImportBtn.BackColor = panel_chuc_nang.BackColor;
            PopUpForm_ExportBtn.BackColor = panel_chuc_nang.BackColor;
        }

        public void Show_Categories()
        {
            QuestionsForm.Visible = false;
            ImportForm.Visible = false;
            ExportForm.Visible = false;
            CategoriesForm.Visible = true;
            PopUpForm_QuestionsBtn.BackColor = panel_chuc_nang.BackColor;
            PopUpForm_CategoriesBtn.BackColor = Color.Gray;
            PopUpForm_ImportBtn.BackColor = panel_chuc_nang.BackColor;
            PopUpForm_ExportBtn.BackColor = panel_chuc_nang.BackColor;
        }

        public void Show_Import()
        {
            QuestionsForm.Visible = false;
            CategoriesForm.Visible = false;
            ExportForm.Visible = false;
            ImportForm.Visible = true;
            PopUpForm_QuestionsBtn.BackColor = panel_chuc_nang.BackColor;
            PopUpForm_CategoriesBtn.BackColor = panel_chuc_nang.BackColor;
            PopUpForm_ImportBtn.BackColor = Color.Gray;
            PopUpForm_ExportBtn.BackColor = panel_chuc_nang.BackColor;
        }

        public void Show_Export()
        {
            QuestionsForm.Visible = false;
            CategoriesForm.Visible = false;
            ImportForm.Visible = false;
            ExportForm.Visible = true;
            PopUpForm_QuestionsBtn.BackColor = panel_chuc_nang.BackColor;
            PopUpForm_CategoriesBtn.BackColor = panel_chuc_nang.BackColor;
            PopUpForm_ImportBtn.BackColor = panel_chuc_nang.BackColor;
            PopUpForm_ExportBtn.BackColor = Color.Gray;
        }

        private void giao_dien_xem_danh_sach_cau_hoi_Load(object sender, EventArgs e)
        {
            if (PopUpForm_QuestionsBtn.Focused == true)
            {
                PopUpForm_QuestionsBtn.BackColor = Color.Gray;
                PopUpForm_CategoriesBtn.BackColor = panel_chuc_nang.BackColor;
                PopUpForm_ImportBtn.BackColor = panel_chuc_nang.BackColor;
                PopUpForm_ExportBtn.BackColor = panel_chuc_nang.BackColor;
            }
        }

        private void button_Categories_Click(object sender, EventArgs e)
        {
            if (PopUpForm_CategoriesBtn.Focused == true)
            {
                PopUpForm_CategoriesBtn.BackColor = Color.Gray;
                PopUpForm_QuestionsBtn.BackColor = panel_chuc_nang.BackColor;
                PopUpForm_ImportBtn.BackColor = panel_chuc_nang.BackColor;
                PopUpForm_ExportBtn.BackColor = panel_chuc_nang.BackColor;
            }
            QuestionsForm.Visible = false;
            ImportForm.Visible = false;
            ExportForm.Visible = false;
            CategoriesForm.Visible = true;
        }

        private void giao_dien_Categories_Load(object sender, EventArgs e)
        {
            if (PopUpForm_CategoriesBtn.Focused == true)
            {
                PopUpForm_CategoriesBtn.BackColor = Color.Gray;
                PopUpForm_QuestionsBtn.BackColor = panel_chuc_nang.BackColor;
                PopUpForm_ImportBtn.BackColor = panel_chuc_nang.BackColor;
                PopUpForm_ExportBtn.BackColor = panel_chuc_nang.BackColor;
            }
        }

        private void button_Import_Click(object sender, EventArgs e)
        {
            if (PopUpForm_ImportBtn.Focused == true)
            {
                PopUpForm_ImportBtn.BackColor = Color.Gray;
                PopUpForm_QuestionsBtn.BackColor = panel_chuc_nang.BackColor;
                PopUpForm_CategoriesBtn.BackColor = panel_chuc_nang.BackColor;
                PopUpForm_ExportBtn.BackColor = panel_chuc_nang.BackColor;
            }
            QuestionsForm.Visible = false;
            CategoriesForm.Visible = false;
            ExportForm.Visible = false;
            ImportForm.Visible = true;
        }

        private void giao_dien_Import_Load(object sender, EventArgs e)
        {
            if (PopUpForm_ImportBtn.Focused == true)
            {
                PopUpForm_ImportBtn.BackColor = Color.Gray;
                PopUpForm_QuestionsBtn.BackColor = panel_chuc_nang.BackColor;
                PopUpForm_CategoriesBtn.BackColor = panel_chuc_nang.BackColor;
                PopUpForm_ExportBtn.BackColor = panel_chuc_nang.BackColor;
            }
        }

        private void button_Export_Click(object sender, EventArgs e)
        {
            if (PopUpForm_ExportBtn.Focused == true)
            {
                PopUpForm_ExportBtn.BackColor = Color.Gray;
                PopUpForm_QuestionsBtn.BackColor = panel_chuc_nang.BackColor;
                PopUpForm_CategoriesBtn.BackColor = panel_chuc_nang.BackColor;
                PopUpForm_ImportBtn.BackColor = panel_chuc_nang.BackColor;
            }
            QuestionsForm.Visible = false;
            CategoriesForm.Visible = false;
            ImportForm.Visible = false;
            ExportForm.Visible = true;
        }

        private void giao_dien_Export_Load(object sender, EventArgs e)
        {
            if (PopUpForm_ExportBtn.Focused == true)
            {
                PopUpForm_ExportBtn.BackColor = Color.Gray;
                PopUpForm_QuestionsBtn.BackColor = panel_chuc_nang.BackColor;
                PopUpForm_CategoriesBtn.BackColor = panel_chuc_nang.BackColor;
                PopUpForm_ImportBtn.BackColor = panel_chuc_nang.BackColor;
            }
        }
    }
}
