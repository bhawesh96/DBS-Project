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
    public partial class complaints : Form
    {
        int i = 0;
        List<string>[] values;
        int Comps;
        public complaints()
        {
            InitializeComponent();
            string numberCompQuery = "select complaintsonhand from policedetails where policeID='" + police1.Policeid + "';";
            DBConnect conn = new DBConnect();
            Comps = conn.NumberOfComplaints(numberCompQuery);
            if (Comps > 0 == false)
            {
                MessageBox.Show("no complaints currently!");
                this.Hide();
                PoliceDetails frm = new PoliceDetails();
                frm.Show();
            }
            else
            {
                string complaintsQuery = "Select comp_id,title,type,place,description,victim from reg_complaints where policeID = '" + police1.Policeid + "';";
                string[] columns = { "comp_id", "title", "type", "place", "description", "victim" };

                //  DBConnect conn = new DBConnect();
                values = conn.Select(complaintsQuery, columns);
                if (values == null)
                {
                    MessageBox.Show("Currently No complaints!");
                }
                else
                {
                    Console.WriteLine(values);
                    CompIdVal.Text = values[0][i];
                    TitleVal.Text = values[1][i];
                    TypeVal.Text = values[2][i];
                    PlaceVal.Text = values[3][i];
                    DescVal.Text = values[4][i];
                    VictimVal.Text = values[5][i];
                }
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            i++;
            if(i==Comps)
            {
                i = Comps-1;
            }

            CompIdVal.Text = values[0][i];
            TitleVal.Text = values[1][i];
            TypeVal.Text = values[2][i];
            PlaceVal.Text = values[3][i];
            DescVal.Text = values[4][i];
            VictimVal.Text = values[5][i];
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            i--;
            if(i<0)
            {
                i = 0;
            }
            CompIdVal.Text = values[0][i];
            TitleVal.Text = values[1][i];
            TypeVal.Text = values[2][i];
            PlaceVal.Text = values[3][i];
            DescVal.Text = values[4][i];
            VictimVal.Text = values[5][i];
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            //string delQuery = "delete from reg_complaints where comp_id='" + compIdLabel.Text + "';";
            string delQuery = "call deleteComplaint('" + CompIdVal.Text + "');";
            DBConnect conn = new DBConnect();
            conn.Delete(delQuery);
            this.Dispose();
            PoliceDetails frm = new PoliceDetails();
            frm.Show();
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PoliceDetails frm = new PoliceDetails();
            frm.Show();
        }

        private void complaints_Load(object sender, EventArgs e)
        {

        }
    }
}
