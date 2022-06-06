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
            string connection = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Przychodnia;Integrated Security=True;Encrypt=False";
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
                if (firstNameTB.Text != "")
                {
                    if (lastNameTB.Text != "")
                    {
                        if (loginTB.Text != "")
                        {
                            if (passwordTB.Text != "")
                            {
                                if (typeLstBox.SelectedItem == "Doctor" || typeLstBox.SelectedItem == "Nurse" || typeLstBox.SelectedItem == "Technician")
                                {
                                    string user;
                                    con.Open();
                                    switch (typeLstBox.SelectedIndex)
                                    {
                                        case 0:
                                            user = "INSERT INTO Logowanie (Id_logowania, Login_uzytkownika, Haslo, Imie, Nazwisko) VALUES ('V', '" + loginTB.Text + "','" + passwordTB.Text + "','" + firstNameTB.Text + "','" + lastNameTB.Text + "')";
                                            SqlCommand cmdUser0 = new SqlCommand(user, con);
                                            cmdUser0.ExecuteNonQuery();
                                            MessageBox.Show("User added successfully.");
                                            firstNameTB.Text = "";
                                            lastNameTB.Text = "";
                                            loginTB.Text = "";
                                            passwordTB.Text = "";
                                            typeLstBox.ClearSelected();
                                            break;
                                        case 1:
                                            user = "INSERT INTO Logowanie (Id_logowania, Login_uzytkownika, Haslo, Imie, Nazwisko) VALUES ('T', '" + loginTB.Text + "','" + passwordTB.Text + "','" + firstNameTB.Text + "','" + lastNameTB.Text + "')";
                                            SqlCommand cmdUser1 = new SqlCommand(user, con);
                                            cmdUser1.ExecuteNonQuery();
                                            MessageBox.Show("User added successfully.");
                                            firstNameTB.Text = "";
                                            lastNameTB.Text = "";
                                            loginTB.Text = "";
                                            passwordTB.Text = "";
                                            typeLstBox.ClearSelected();
                                            break;
                                        case 2:
                                            user = "INSERT INTO Logowanie (Id_logowania, Login_uzytkownika, Haslo, Imie, Nazwisko) VALUES ('P', '" + loginTB.Text + "','" + passwordTB.Text + "','" + firstNameTB.Text + "','" + lastNameTB.Text + "')";
                                            SqlCommand cmdUser2 = new SqlCommand(user, con);
                                            cmdUser2.ExecuteNonQuery();
                                            MessageBox.Show("User added successfully.");
                                            firstNameTB.Text = "";
                                            lastNameTB.Text = "";
                                            loginTB.Text = "";
                                            passwordTB.Text = "";
                                            typeLstBox.ClearSelected();
                                            break;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Please enter all required information.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Please enter all required information.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please enter all required information.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter all required information.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter all required information.");
                }
            }
            
            con.Close();
        }

        private void backBT_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
            this.Close();
        }
    }
}
