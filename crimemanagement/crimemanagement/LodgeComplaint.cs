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
    public partial class LodgeComplaint : Form
    {
        public LodgeComplaint()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            DBConnect conn = new DBConnect();
            String InsertQuery = "call insertComplaint3('" + titleText.Text +"', '" + typeCombo.SelectedItem.ToString() + "', '" + placeCombo.SelectedItem.ToString() + "', '"  + descText.Text+ "', '" + user1.AdNo + "');";
            int response = conn.ExecuteQuery(InsertQuery);
            if (response > 0)
            {
                MessageBox.Show("Your complaint has been lodged");

                this.Hide();
                new userDetails().Show();
            }
            else
            {
                MessageBox.Show("complaint could not be lodged");

            }
        }

        private void goBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            userDetails frm = new userDetails();
            frm.Show();
        }
    }

}
