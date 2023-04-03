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
    public partial class Giao_dien_tu_pop_up : UserControl
    {
        public Giao_dien_tu_pop_up()
        {
            InitializeComponent();
        }

        private void button_Questions_Click(object sender, EventArgs e)
        {
            if (button_Questions.Focused == true)
            {
                button_Questions.BackColor = Color.Gray;
                button_Categories.BackColor = panel_chuc_nang.BackColor;
                button_Import.BackColor = panel_chuc_nang.BackColor;
                button_Export.BackColor = panel_chuc_nang.BackColor;
            }
            giao_dien_Categories.Visible = false;
            giao_dien_Import.Visible = false;
            giao_dien_Export.Visible = false;
            giao_dien_xem_danh_sach_cau_hoi.Visible = true;
        }

        public void Show_Questions()
        {
            giao_dien_Categories.Visible = false;
            giao_dien_Import.Visible = false;
            giao_dien_Export.Visible = false;
            giao_dien_xem_danh_sach_cau_hoi.Visible = true;
            button_Questions.BackColor = Color.Gray;
            button_Categories.BackColor = panel_chuc_nang.BackColor;
            button_Import.BackColor = panel_chuc_nang.BackColor;
            button_Export.BackColor = panel_chuc_nang.BackColor;
        }

        public void Show_Categories()
        {
            giao_dien_xem_danh_sach_cau_hoi.Visible = false;
            giao_dien_Import.Visible = false;
            giao_dien_Export.Visible = false;
            giao_dien_Categories.Visible = true;
            button_Questions.BackColor = panel_chuc_nang.BackColor;
            button_Categories.BackColor = Color.Gray;
            button_Import.BackColor = panel_chuc_nang.BackColor;
            button_Export.BackColor = panel_chuc_nang.BackColor;
        }

        public void Show_Import()
        {
            giao_dien_xem_danh_sach_cau_hoi.Visible = false;
            giao_dien_Categories.Visible = false;
            giao_dien_Export.Visible = false;
            giao_dien_Import.Visible = true;
            button_Questions.BackColor = panel_chuc_nang.BackColor;
            button_Categories.BackColor = panel_chuc_nang.BackColor;
            button_Import.BackColor = Color.Gray;
            button_Export.BackColor = panel_chuc_nang.BackColor;
        }

        public void Show_Export()
        {
            giao_dien_xem_danh_sach_cau_hoi.Visible = false;
            giao_dien_Categories.Visible = false;
            giao_dien_Import.Visible = false;
            giao_dien_Export.Visible = true;
            button_Questions.BackColor = panel_chuc_nang.BackColor;
            button_Categories.BackColor = panel_chuc_nang.BackColor;
            button_Import.BackColor = panel_chuc_nang.BackColor;
            button_Export.BackColor = Color.Gray;
        }

        private void giao_dien_xem_danh_sach_cau_hoi_Load(object sender, EventArgs e)
        {
            if (button_Questions.Focused == true)
            {
                button_Questions.BackColor = Color.Gray;
                button_Categories.BackColor = panel_chuc_nang.BackColor;
                button_Import.BackColor = panel_chuc_nang.BackColor;
                button_Export.BackColor = panel_chuc_nang.BackColor;
            }
        }

        private void button_Categories_Click(object sender, EventArgs e)
        {
            if (button_Categories.Focused == true)
            {
                button_Categories.BackColor = Color.Gray;
                button_Questions.BackColor = panel_chuc_nang.BackColor;
                button_Import.BackColor = panel_chuc_nang.BackColor;
                button_Export.BackColor = panel_chuc_nang.BackColor;
            }
            giao_dien_xem_danh_sach_cau_hoi.Visible = false;
            giao_dien_Import.Visible = false;
            giao_dien_Export.Visible = false;
            giao_dien_Categories.Visible = true;
        }

        private void giao_dien_Categories_Load(object sender, EventArgs e)
        {
            if (button_Categories.Focused == true)
            {
                button_Categories.BackColor = Color.Gray;
                button_Questions.BackColor = panel_chuc_nang.BackColor;
                button_Import.BackColor = panel_chuc_nang.BackColor;
                button_Export.BackColor = panel_chuc_nang.BackColor;
            }
        }

        private void button_Import_Click(object sender, EventArgs e)
        {
            if (button_Import.Focused == true)
            {
                button_Import.BackColor = Color.Gray;
                button_Questions.BackColor = panel_chuc_nang.BackColor;
                button_Categories.BackColor = panel_chuc_nang.BackColor;
                button_Export.BackColor = panel_chuc_nang.BackColor;
            }
            giao_dien_xem_danh_sach_cau_hoi.Visible = false;
            giao_dien_Categories.Visible = false;
            giao_dien_Export.Visible = false;
            giao_dien_Import.Visible = true;
        }

        private void giao_dien_Import_Load(object sender, EventArgs e)
        {
            if (button_Import.Focused == true)
            {
                button_Import.BackColor = Color.Gray;
                button_Questions.BackColor = panel_chuc_nang.BackColor;
                button_Categories.BackColor = panel_chuc_nang.BackColor;
                button_Export.BackColor = panel_chuc_nang.BackColor;
            }
        }

        private void button_Export_Click(object sender, EventArgs e)
        {
            if (button_Export.Focused == true)
            {
                button_Export.BackColor = Color.Gray;
                button_Questions.BackColor = panel_chuc_nang.BackColor;
                button_Categories.BackColor = panel_chuc_nang.BackColor;
                button_Import.BackColor = panel_chuc_nang.BackColor;
            }
            giao_dien_xem_danh_sach_cau_hoi.Visible = false;
            giao_dien_Categories.Visible = false;
            giao_dien_Import.Visible = false;
            giao_dien_Export.Visible = true;
        }

        private void giao_dien_Export_Load(object sender, EventArgs e)
        {
            if (button_Export.Focused == true)
            {
                button_Export.BackColor = Color.Gray;
                button_Questions.BackColor = panel_chuc_nang.BackColor;
                button_Categories.BackColor = panel_chuc_nang.BackColor;
                button_Import.BackColor = panel_chuc_nang.BackColor;
            }
        }
    }
}
