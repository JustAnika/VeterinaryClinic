using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAzIG
{
    public partial class AddVisit : Form
    {
        public AddVisit()
        {
            InitializeComponent();
        }

        private void backBt_Click(object sender, EventArgs e)
        {
            Doctor doctor = new Doctor();
            doctor.Show();
            this.Close();
        }

        private void addBt_Click(object sender, EventArgs e)
        {
            string connection = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Przychodnia;Integrated Security=True;Encrypt=False"; 
            string sqlQuery = "SELECT * FROM Wizyta";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            SqlDataReader reader = cmd.ExecuteReader();
            bool exists = false;
            while (reader.Read())
            {
                if (dateTextBox.Text!="")
                {
                    if (doctorTextBox.Text!= "")
                    {
                        if (reader[2].ToString() == doctorTextBox.Text && reader[3].ToString() == dateTextBox.Text)
                        {
                            exists = true;
                            break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter employees id!");
                        break;
                    }
                }
                else
                {
                    MessageBox.Show("Please enter the date of the visit!");
                    break;
                }
            }
            con.Close();
            if (!exists)
            {

            }
            else
            {
                MessageBox.Show("There is already a visit at that date with this employee!");
            }
        }
    }
}
