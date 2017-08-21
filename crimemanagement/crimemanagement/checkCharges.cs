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
    public partial class checkCharges : Form
    {
        int i = 0;
        List<string>[] values;
        int Comps;
        public checkCharges()
        {
            InitializeComponent();
            string numberAccusedQuery = " select exists(select * from accused where aadhaarno = '"+ user1.AdNo + "') as T;";
            DBConnect conn = new DBConnect();
            Comps = conn.NumberOfAccused(numberAccusedQuery);
            if (Comps ==0)
            {
                MessageBox.Show("not accused!");
                this.Dispose();
                userDetails frm = new userDetails();
                frm.Show();
            }
            else
            {
                string complaintsQuery = "Select * from accused where aadhaarno = '" + user1.AdNo + "';";
                string[] columns = { "aadhaarno", "date", "place", "description", "ActionTaken" };

                //  DBConnect conn = new DBConnect();
                values = conn.Select(complaintsQuery, columns);
                if (values == null)
                {
                    MessageBox.Show("Currently No complaints!");
                }
                else
                {
                    Console.WriteLine(values);
                    aadhaarVal.Text = values[0][i];
                    dateVal.Text = values[1][i];
                    placeVal.Text = values[2][i];
                    descVal.Text = values[3][i];
                    actionVal.Text = values[4][i];
                }
            }
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new userDetails().Show();
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            i--;
            if (i < 0)
            {
                i = 0;
            }
            aadhaarVal.Text = values[0][i];
            dateVal.Text = values[1][i];
            placeVal.Text = values[2][i];
            descVal.Text = values[3][i];
            actionVal.Text = values[4][i];
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            i++;
            if (i == Comps)
            {
                i = Comps - 1;
            }

            aadhaarVal.Text = values[0][i];
            dateVal.Text = values[1][i];
            placeVal.Text = values[2][i];
            descVal.Text = values[3][i];
            actionVal.Text = values[4][i];
        }

        private void checkCharges_Load(object sender, EventArgs e)
        {

        }
    }
}
