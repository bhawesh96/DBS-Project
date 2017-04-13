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
    public partial class user1 : Form
    {
        public static string AdNo;
        public user1()
        {
            InitializeComponent();
        }

        private void GoHomeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            home frm = new home();
            frm.Show();
        
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            AdNo = aadhaarBox.Text;
            if (AdNo == null || AdNo.Equals(""))
                MessageBox.Show("Enter Aadhaar No");
            else
            {
                String Query = "Select aadhaarNo from userdetails where exists(select * from userdetails where aadhaarNo = '" + AdNo + "') and aadhaarNo = '" + AdNo + "';";
                DBConnect conn = new DBConnect();
                if(!conn.AadhaarExists(Query))
                {
                    MessageBox.Show("Invaild Aadhaar Number");
                }
                else
                {
                    this.Hide();
                    userDetails frm = new userDetails();
                    frm.Show();
                    
                }

            }
        }
    }
}
