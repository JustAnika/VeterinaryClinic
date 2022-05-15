using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace PAzIG
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void addBT_Click(object sender, EventArgs e)
        {
            string connection = "Data Source=DESKTOP-BBT1MOF\\CITADEL;Initial Catalog=Przychodnia;Integrated Security=True;Encrypt=False";
            string sqlQuery = "SELECT * FROM Logowanie";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            cmd.ExecuteNonQuery();
            SqlDataReader reader = cmd.ExecuteReader();
            int notExist = 0;
            while (reader.Read())
            {
                if(String.Format("{0}", reader[1]) == loginTB.Text)
                {
                    if (String.Format("{0}", reader[2]) == passwordTB.Text)
                    {
                        MessageBox.Show("This user already exist.");
                        notExist = 1;
                    }
                }
            }
            con.Close();
            if (notExist == 1)
            {

            }
            else
            {
                if (loginTB.Text != "")
                {
                    if (passwordTB.Text != "")
                    {
                        string user;
                        con.Open();
                        switch (typeLstBox.SelectedIndex)
                        {
                            case 0:
                                user = "INSERT INTO Logowanie VALUES ('V', '" + loginTB.Text + "','" + passwordTB.Text + "')";
                                SqlCommand cmdUser0 = new SqlCommand(user, con);
                                cmdUser0.ExecuteNonQuery();
                                MessageBox.Show("User added successfully.");
                                break;
                            case 1:
                                user = "INSERT INTO Logowanie VALUES ('T', '" + loginTB.Text + "','" + passwordTB.Text + "')";
                                SqlCommand cmdUser1 = new SqlCommand(user, con);
                                cmdUser1.ExecuteNonQuery();
                                MessageBox.Show("User added successfully.");
                                break;
                            case 2:
                                user = "INSERT INTO Logowanie VALUES ('P', '" + loginTB.Text + "','" + passwordTB.Text + "')";
                                SqlCommand cmdUser2 = new SqlCommand(user, con);
                                cmdUser2.ExecuteNonQuery();
                                MessageBox.Show("User added successfully.");
                                break;
                        }   
                    }
                    else
                    {
                        MessageBox.Show("Please enter password", "No passsword error");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter login", "No login error");
                }
            }
            
            con.Close();
        }
    }
}
