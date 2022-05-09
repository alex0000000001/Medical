using Siticone.Desktop.UI.WinForms;
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
    public partial class MyDoctor_DoctorWork : UserControl
    {
        public static bool hasAuth { get; set; }
        public static int role { get; set; }
        public MyDoctor_DoctorWork()
        {
            InitializeComponent();
            
        }
        int number;

        private void DoctorWork_Load(object sender, EventArgs e)
        {
            MainPage ma = new MainPage();
            MyDoctor myDoctor = new MyDoctor();
            MedicalEntities medicalContext = new MedicalEntities();
            int number = 1;
            int doctorID = int.Parse(myDoctor.lbDoctorID.Text);
            var qry = from q in medicalContext.ClinicDetails
                      where q.DoctorID == doctorID
                      select q.ClinicDetailID;

            if (qry.Count() > 0)
            {
                int id = qry.First();

                var qry2 = from q in medicalContext.Members
                          from c in q.Reserves
                          where c.ClinicDetailID.Equals(id)
                          select new { Patient= q.MemberName};

                gvPatinet.Columns.Add("Column", "候診順序");
                gvPatinet.Columns.Add("Column2", "");
                gvPatinet.Columns.Add("Column3", "");

                foreach (var i in qry2)
                {
                    gvPatinet.Rows.Add(number, i.Patient,"候診中");
                    number++;
                }
            }

            //gvPatinet.Rows[0].Selected = true;
          

        }

        private void gvPatinet_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex>=0)
            {
                value = (int)gvPatinet.Rows[e.RowIndex].Cells[0].Value;
                name = (string)gvPatinet.Rows[e.RowIndex].Cells[1].Value;
                index = gvPatinet.Rows[e.RowIndex].Cells[0].RowIndex;

            }
            
        }

        int value=0; string name; int index = 0;

        private void 過號候補ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gvPatinet.Rows.Add(value, name,"過號候補");
            gvPatinet.Rows[index].Cells[2].Style.ForeColor = Color.Red;
            gvPatinet.Rows.RemoveAt(index);
            gvPatinet.Refresh();
        }

        private void 已報到ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gvPatinet.Rows[index].Cells[2].Value = "候診中";        
        }

        int click = 0;

        private void BtnNext_Click(object sender, EventArgs e)
        { 
            if (click == 0)
            {
                gvPatinet.Rows[index].Cells[2].Value = "看診中";
                click++; 
            }
            else
            {
                gvPatinet.Rows[index].Cells[2].Value = "完成看診";
                gvPatinet.Rows[index].Cells[2].Style.ForeColor = Color.Purple;


                gvPatinet.Rows[index].Selected = false;

                if (index < gvPatinet.Rows.Count - 1)
                {
                    gvPatinet.Rows[index + 1].Cells[2].Value = "看診中";
                    gvPatinet.Rows[index + 1].Selected = true;
                    index++;
                }
                else
                {
                    MessageBox.Show("今日看診已完成");
                }
            }





        }

        //private void BtnStart_Click(object sender, EventArgs e)
        //{
        //    gvPatinet.Rows[index].Cells[2].Value = "看診中";
        //    BtnStart.Enabled = false;
        //    BtnStart.ForeColor = Color.Gray;
        //}

        private void gvPatinet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
