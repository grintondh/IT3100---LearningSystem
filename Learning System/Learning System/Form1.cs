namespace Learning_System
{
    public partial class Home_Page : Form
    {
        public Home_Page()
        {
            InitializeComponent();
        }

        private void picture_setting_Click(object sender, EventArgs e)
        {
            if (panel_popup.Height == panel_popup.MinimumSize.Height)
            {
                panel_popup.Height = panel_popup.MaximumSize.Height;
                flowLayoutPanel_popup.Visible = true;
                label_Question_Bank.Visible = true;
            }
            else
            {
                panel_popup.Height = panel_popup.MinimumSize.Height;
                flowLayoutPanel_popup.Visible = false;
                label_Question_Bank.Visible = false;
            }
        }

        private void Home_Page_Load(object sender, EventArgs e)
        {

        }

        private void button_Import_Click(object sender, EventArgs e)
        {
            if (panel_popup.Height == panel_popup.MaximumSize.Height)
            {
                panel_popup.Height = panel_popup.MinimumSize.Height;
                flowLayoutPanel_popup.Visible = false;
                label_Question_Bank.Visible = false;
            }
            giao_dien_tu_pop_up.Visible = true;
            giao_dien_tu_pop_up.Show_Import();
        }

        private void button_Categories_Click(object sender, EventArgs e)
        {
            if (panel_popup.Height == panel_popup.MaximumSize.Height)
            {
                panel_popup.Height = panel_popup.MinimumSize.Height;
                flowLayoutPanel_popup.Visible = false;
                label_Question_Bank.Visible = false;
            }
            giao_dien_tu_pop_up.Visible = true;
            giao_dien_tu_pop_up.Show_Categories();
        }

        private void button_Questions_Click(object sender, EventArgs e)
        {
            if (panel_popup.Height == panel_popup.MaximumSize.Height)
            {
                panel_popup.Height = panel_popup.MinimumSize.Height;
                flowLayoutPanel_popup.Visible = false;
                label_Question_Bank.Visible = false;
            }
            giao_dien_tu_pop_up.Visible = true;
            giao_dien_tu_pop_up.Show_Questions();
        }

        private void button_Export_Click(object sender, EventArgs e)
        {
            if (panel_popup.Height == panel_popup.MaximumSize.Height)
            {
                panel_popup.Height = panel_popup.MinimumSize.Height;
                flowLayoutPanel_popup.Visible = false;
                label_Question_Bank.Visible = false;
            }
            giao_dien_tu_pop_up.Visible = true;
            giao_dien_tu_pop_up.Show_Export();
        }
    }
}