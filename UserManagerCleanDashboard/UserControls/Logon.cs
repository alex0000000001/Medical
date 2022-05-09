using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medical.UserControls
{
    public delegate void MyEventHanlder(string str);
    public partial class Logon : UserControl
    {
        //public delegate void MyEventHanlder(string str);
        public event MyEventHanlder goBackHandler;

        //public static int role { get; set; }
        public Logon()
        {
            InitializeComponent();
        }

        

        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            MedicalEntities medicalContext = new MedicalEntities();
            var qry = medicalContext.Members.Where(x => x.IdentityID.Equals(txtName.Text.Trim()) && x.Password.Equals(txtPw.Text.Trim()));

            if (qry.Count() > 0)
            {
                MainPage.role = (int)qry.First().Auth_;
                MainPage ma = new MainPage();
                ma.lbMemberID.Text = qry.First().MemberID.ToString();
                ma.lbRole.Text = qry.First().Auth_.ToString();
                ma.on_Click(sender,e);

                if (qry.First().Auth_ == 2)
                {
                    var qry2 = medicalContext.Doctors.Where(x => x.MemberID.Equals( qry.First().MemberID ) );
                    MyDoctor myDoctor = new MyDoctor();
                    myDoctor.lbDoctorID.Text = qry2.First().DoctorID.ToString();
                }
            }
        }



    }
}
