using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crimemanagement
{
    public partial class police1 : Form
    {
        public static string Policeid;
        //public string getID()
        //{
//            /return Policeid;
  //      }

        public police1()
        {
            InitializeComponent();
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            Policeid = pID.Text;
            string PolicePass = ppass.Text;
            if (Policeid == null || Policeid == "" || PolicePass == null || PolicePass == "")
            {
                MessageBox.Show("enter details");
            }
            else
            {
                DBConnect conn = new DBConnect();
                string SelectQuery = "Select password from policedetails where PoliceID='" + Policeid + "';";
                String pas = conn.checkPass(SelectQuery);

                //MessageBox.Show(pas);

                if (PolicePass.Equals(pas))
                {
                    this.Hide();
                    PoliceDetails frm = new PoliceDetails();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("wrong username/password");

                }
            }
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            home frm = new home();
            frm.Show();
        }
    }
}
