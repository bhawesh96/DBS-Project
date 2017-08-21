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
    public partial class userDetails : Form
    {
        public userDetails()
        {
            InitializeComponent();
            DBConnect conn = new DBConnect();
            String DetailsQuery = "Select name,sex,address,DOB,phone from userdetails where aadhaarno = '" + user1.AdNo + "';";
            String details = conn.getUserDetails(DetailsQuery);
            detailsBox.Text = details;
        }

        private void LodgeComplaintButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LodgeComplaint frm = new LodgeComplaint();
            frm.Show();
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            user1 frm = new user1();
            frm.Show();
        }

        private void CheckChargesButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            checkCharges frm = new checkCharges();
            frm.Show();
           
        }
    }
}
