using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Siticone.Desktop.UI.WinForms;
using Medical.UserControls;

namespace Medical
{
    public partial class MainPage:Form
    {

        bool silderEXpand;
        public static int role;
        public MainPage()
        {
            InitializeComponent();
            new SiticoneShadowForm(this);
            new SiticoneDragControl(TopHeader);
            new SiticoneDragControl(DragPanel);

            // add controls
            PanelSlider.Controls.Add(new Dashboard());
            PanelSlider.Controls.Add(new Logon());
            PanelSlider.Controls.Add(new Notifications());
            PanelSlider.Controls.Add(new Sales());
            PanelSlider.Controls.Add(new Settings());
            PanelSlider.Controls.Add(new UserControls.Reserve());
            PanelSlider.Controls.Add(new Clinic());
            PanelSlider.Controls.Add(new UserControls.Treatment());
            PanelSlider.Controls.Add(new DoctorTeam());
            PanelSlider.Controls.Add(new MyDoctor());
            PanelSlider.Controls.Add(new Store());
            PanelSlider.Controls.Add(new Info());
            PanelSlider.Controls.Add(new UserControls.Article());

        }

        internal void UISwitch(string ui, bool isSideNav)
        {
            switch (ui)
            {
                case "Dashboard":
                    PanelSlider.Controls.Find("Dashboard", false)[0].BringToFront();
                    break;
                case "Logon":
                    PanelSlider.Controls.Find("Logon", false)[0].BringToFront();
                    break;
                case "Notifications":
                    PanelSlider.Controls.Find("Notifications", false)[0].BringToFront();
                    break;
                case "Sales":
                    PanelSlider.Controls.Find("Sales", false)[0].BringToFront();
                    break;
                case "Settings":
                    PanelSlider.Controls.Find("Settings", false)[0].BringToFront();
                    break;
                case "Reserve":
                    PanelSlider.Controls.Find("Reserve", false)[0].BringToFront();
                    break;
                case "Clinic":
                    PanelSlider.Controls.Find("Clinic", false)[0].BringToFront();
                    break;
                case "Treatment":
                    PanelSlider.Controls.Find("Treatment", false)[0].BringToFront();
                    break;
                case "DoctorTeam":
                    PanelSlider.Controls.Find("DoctorTeam", false)[0].BringToFront();
                    break;
                case "Store":
                    PanelSlider.Controls.Find("Store", false)[0].BringToFront();
                    break;
                case "MyDoctor":
                    PanelSlider.Controls.Find("MyDoctor", false)[0].BringToFront();
                    break;
                case "Info":
                    PanelSlider.Controls.Find("Info", false)[0].BringToFront();
                    break;
                case "Article":
                    PanelSlider.Controls.Find("Article", false)[0].BringToFront();
                    break;

            }

            switch (isSideNav)
            {
                case true:
                    foreach (SiticoneButton button in DragPanel.Controls.OfType<SiticoneButton>())
                    {
                        button.Checked = false;
                    }
                    break;
                default:
                    foreach (SiticoneButton button in SideNavButtonContainer.Controls.OfType<SiticoneButton>())
                    {
                        button.Checked = false;
                    }
                    break;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (silderEXpand)
            {
                if(SideNav.Width == SideNav.MinimumSize.Width)
                {
                    silderEXpand = false;
                    timer1.Stop();
                }
                else
                {
                    SideNav.Width -= 10;
                    PanelSlider.Width += 10;
                }
            }
            else
            {
                if (SideNav.Width == SideNav.MaximumSize.Width)
                {
                    silderEXpand = true;
                    timer1.Stop();
                }
                else
                {
                    PanelSlider.Width -= 10;
                    SideNav.Width += 10;
                }
            }
        }
        private void silder_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            //UISwitch("Dashboard", true);
            timer1.Start();
        }


        public void on_Click(object sender, EventArgs e)
        {
            if (int.Parse(lbRole.Text)==2)
            {
                UISwitch("MyDoctor", true);
            }
        }


        private void BtnLogon_Click(object sender, EventArgs e)
        {
            UISwitch("Logon", true);
        }

        private void NotificationBtn_Click(object sender, EventArgs e)
        {
            UISwitch("Notifications", true);
        }

        private void SalesBtn_Click(object sender, EventArgs e)
        {
            UISwitch("Sales", true);
        }

        private void SettingBtn_Click(object sender, EventArgs e)
        {
            UISwitch("Settings", true);
        }

        private void ReportsBtn_Click(object sender, EventArgs e)
        {
            UISwitch("Reserve", false);
        }
        private void BtnClinic_Click(object sender, EventArgs e)
        {
            UISwitch("Clinic", false);
        }

        private void BtnTreatment_Click(object sender, EventArgs e)
        {
            UISwitch("Treatment", false);
        }

        private void BtnDoctorTeam_Click(object sender, EventArgs e)
        {
            UISwitch("DoctorTeam", false);
        }

        public void BtnMyDoctor_Click(object sender, EventArgs e)
        {
            UISwitch("MyDoctor", false);
        }

        private void BtnStore_Click(object sender, EventArgs e)
        {
            UISwitch("Store", false);
        }

        private void BtnInfo_Click(object sender, EventArgs e)
        {
            UISwitch("Info", false);
        }

        private void BtnArticle_Click(object sender, EventArgs e)
        {
            UISwitch("Article", false);
        }
    }
}
