using Learning_System.ExternalClass;
using Newtonsoft.Json.Linq;
using System.Data;

namespace Learning_System
{
    public partial class HomePageForm : Form
    {
        public HomePageForm()
        {
            InitializeComponent();
            loadContestList();
        }

	    private void loadContestList() 
        {
            JArray? contestJson = JsonProcessing.ImportJsonContentInDefaultFolder("contest.json", null, null);

            try
            {
                if (contestJson != null)
                {
                    DataProcessing contestData = new();
                    List<string> contestColumns = new() { "Name", "TimeStart" };
                    List<Type> contestType = new() { typeof(string), typeof(DateTime) };
                    List<string> contestKey = new() { "PRIMARY KEY", "" };

                    contestData.Import(contestColumns, contestType, contestKey);
                    contestData.Import(contestJson);

                    DataTable? _DT = contestData.Init().Sort("TimeStart asc").Get();

                    if(_DT != null)
                    {
                        for (int i = 0; i < _DT.Rows.Count; i++)
                        {
                            LinkLabel linklbl = new LinkLabel {
                                Name = "ExportForm_Linklbl" + i.ToString(),
                                Location = new Point(90, 150 + i * 45),
                                Font = new System.Drawing.Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
                                FlatStyle = FlatStyle.Flat,
                                TabIndex = 10,
                                Text = _DT.Rows[i].Field<string>("Name"),
                                Size = new Size(919, 30),
                            };

                            linklbl.Click += new EventHandler((sender, args) =>
                            {
                                Properties.Settings.Default["ChoosingContest"] = linklbl.Text;
                                Properties.Settings.Default.Save();

                                MessageBox.Show(Properties.Settings.Default.ChoosingContest, "Success", MessageBoxButtons.OK);
                            });

                            panel2.Controls.Add(linklbl);
                        }
                    }
                }
                else
                    throw new Exception();
            } catch (Exception ex) {
                MessageBox.Show("Can't load your contest file!\n" + ex, "Error", MessageBoxButtons.OK);
            }
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

        private void HomePageForm_Load(object sender, EventArgs e)
        {

        }
    }
}