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
    public partial class PoliceDetails : Form
    {
        public PoliceDetails()
        {
            InitializeComponent();
            DBConnect conn = new DBConnect();
            String DetailsQuery = "Select name,address,DOB,phone,designation,place,complaintsonhand from policedetails where policeID = '" + police1.Policeid + "';";
            String details = conn.getDetails(DetailsQuery);
            DetailsBox.Text = details;
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            police1 frm = new police1();
            frm.Show();
        }

        private void ViewCompButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            complaints frm = new complaints();
            frm.Show();
        }
    }
}
