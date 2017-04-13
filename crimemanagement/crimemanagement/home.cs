using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data.Types;

namespace crimemanagement
{
    public partial class home : Form
    {
        
        public home()
        {
            InitializeComponent();
        }

        private void proceedButton_Click(object sender, EventArgs e)
        {
            string user;
            if (comboBox1.SelectedItem == null)
                user = null;
            else
                user = comboBox1.SelectedItem.ToString();


            if (user == null || user.Equals(""))
                MessageBox.Show("please choose a user");
            else if (user.Equals("Police"))
            {
                this.Hide();
                police1 frm = new police1();
                frm.Show();
            }
            else if(user.Equals("User"))
            {
                this.Hide();
                user1 frm = new user1();
                frm.Show();
            }
            else
            {
                MessageBox.Show(user);
            }
              
        }

        private void home_Load(object sender, EventArgs e)
        {

        }
    }
}
