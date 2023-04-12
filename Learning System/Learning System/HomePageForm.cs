using Calculator;

namespace Learning_System
{
    public partial class HomePageForm : Form
    {
        public HomePageForm()
        {
            InitializeComponent();
        }

        private void picture_setting_Click(object sender, EventArgs e)
        {
            if (panel_popup.Height == panel_popup.MinimumSize.Height)
            {
                panel_popup.Height = panel_popup.MaximumSize.Height;
                flowLayoutPanel_popup.Visible = true;
                HomePageForm_QuestionsBankLbl.Visible = true;
            }
            else
            {
                panel_popup.Height = panel_popup.MinimumSize.Height;
                flowLayoutPanel_popup.Visible = false;
                HomePageForm_QuestionsBankLbl.Visible = false;
            }
        }

        private void button_Import_Click(object sender, EventArgs e)
        {
            if (panel_popup.Height == panel_popup.MaximumSize.Height)
            {
                panel_popup.Height = panel_popup.MinimumSize.Height;
                flowLayoutPanel_popup.Visible = false;
                HomePageForm_QuestionsBankLbl.Visible = false;
            }
            PopUpForm.Visible = true;
            PopUpForm.Show_Import();
            panel3.Visible = false;
        }

        private void button_Categories_Click(object sender, EventArgs e)
        {
            if (panel_popup.Height == panel_popup.MaximumSize.Height)
            {
                panel_popup.Height = panel_popup.MinimumSize.Height;
                flowLayoutPanel_popup.Visible = false;
                HomePageForm_QuestionsBankLbl.Visible = false;
            }
            PopUpForm.Visible = true;
            PopUpForm.Show_Categories();
            panel3.Visible = false;
        }

        private void button_Questions_Click(object sender, EventArgs e)
        {
            if (panel_popup.Height == panel_popup.MaximumSize.Height)
            {
                panel_popup.Height = panel_popup.MinimumSize.Height;
                flowLayoutPanel_popup.Visible = false;
                HomePageForm_QuestionsBankLbl.Visible = false;
            }
            PopUpForm.Visible = true;
            PopUpForm.Show_Questions();
            panel3.Visible = false;
        }

        private void button_Export_Click(object sender, EventArgs e)
        {
            if (panel_popup.Height == panel_popup.MaximumSize.Height)
            {
                panel_popup.Height = panel_popup.MinimumSize.Height;
                flowLayoutPanel_popup.Visible = false;
                HomePageForm_QuestionsBankLbl.Visible = false;
            }
            PopUpForm.Visible = true;
            PopUpForm.Show_Export();
            panel3.Visible = false;
        }
    }
}