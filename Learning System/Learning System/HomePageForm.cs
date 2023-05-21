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
            if (panel_popup.Visible == false)
            {
                panel_popup.Visible = true;
            }
            else
            {
                panel_popup.Visible = false;
            }
        }

        private void button_Import_Click(object sender, EventArgs e)
        {
            if (panel_popup.Visible == false)
            {
                panel_popup.Visible = true;
            }
            else
            {
                panel_popup.Visible = false;
            }
            PopUpForm.Visible = true;
            PopUpForm.Show_Import();
        }

        private void button_Categories_Click(object sender, EventArgs e)
        {
            if (panel_popup.Visible == false)
            {
                panel_popup.Visible = true;
            }
            else
            {
                panel_popup.Visible = false;
            }
            PopUpForm.Visible = true;
            PopUpForm.Show_Categories();
        }

        private void button_Questions_Click(object sender, EventArgs e)
        {
            if (panel_popup.Visible == false)
            {
                panel_popup.Visible = true;
            }
            else
            {
                panel_popup.Visible = false;
            }
            PopUpForm.Visible = true;
            PopUpForm.Show_Questions();
        }

        private void button_Export_Click(object sender, EventArgs e)
        {
            if (panel_popup.Visible == false)
            {
                panel_popup.Visible = true;
            }
            else
            {
                panel_popup.Visible = false;
            }
            PopUpForm.Visible = true;
            PopUpForm.Show_Export();
        }

        private void HomePageForm_EditingBtn_Click(object sender, EventArgs e)
        {
            AddingNewQuiz aDN = new AddingNewQuiz();
            aDN.ShowDialog();
        }

    }
}