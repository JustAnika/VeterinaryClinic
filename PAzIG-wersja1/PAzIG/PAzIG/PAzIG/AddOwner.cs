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
    public partial class AddOwner : Form
    {
        public AddOwner()
        {
            InitializeComponent();
        }

        private void registerBt_Click(object sender, EventArgs e)
        {
            string connection = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Przychodnia;Integrated Security=True;Encrypt=False";
            SqlConnection con = new SqlConnection(connection);
            string test = "SELECT * FROM Logowanie WHERE Login_uzytkownika LIKE '" + loginTB.Text + "' AND Haslo LIKE '" + passwordTB.Text + "'";
            con.Open();
            SqlCommand cmdTest = new SqlCommand(test, con);
            SqlDataReader reader = cmdTest.ExecuteReader();
            int notExist = 0;
            while (reader.Read())
            {
                if (String.Format("{0}",reader[0]) == "W")
                {
                    if (String.Format("{0}",reader[1]) == loginTB.Text)
                    {
                        if (String.Format("{0}",reader[2]) == passwordTB.Text)
                        {
                            MessageBox.Show("The user already exist. Choose different data.");
                        }
                    }
                }
                else
                {
                    notExist = 1;
                }
            }
            if (notExist == 0)
            {

            }
            else
            {
                long phone;
                long.TryParse(phoneTB.Text, out phone);
                if (loginTB.Text != "")
                {
                    if (passwordLB.Text != "")
                    {
                        if (firstNameTB.Text != "")
                        {
                            if (lastNameTB.Text != "")
                            {
                                if (adressTB.Text != "")
                                {
                                    if (phoneTB.Text != "")
                                    {
                                        if (phone > 0)
                                        { 
                                            string login = "INSERT INTO Logowanie VALUES ('W','" + loginTB.Text + "','" + passwordTB.Text + "')";
                                            string owner = "INSERT INTO Wlasciciel (Imie, Id_wlasciciela, Nazwisko, Adres, Telefon) VALUES (" + "'" + firstNameTB.Text + "'," + "(SELECT Login_uzytkownika FROM Logowanie WHERE Haslo LIKE '" + passwordTB.Text + "'),'" + lastNameTB.Text + "','" + adressTB.Text + "'," + phoneTB.Text + ")";
                                            con.Open();
                                            SqlCommand cmdLogin = new SqlCommand(login, con);
                                            SqlCommand cmdOwner = new SqlCommand(owner, con);
                                            cmdLogin.ExecuteNonQuery();
                                            cmdOwner.ExecuteNonQuery();
                                         
                                        }
                                        else
                                        {
                                            MessageBox.Show("Please enter correct form of data");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Please enter all required information");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Please enter all required information");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Please enter all required information");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please enter all required information");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter all required information");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter all required information");
                }
            }
            con.Close();
        }

        private void backBt_Click(object sender, EventArgs e)
        {
            if (formLB.Text == "doctor")
            {
                Doctor doctor = new Doctor();
                doctor.Show();
                this.Close();
            }
            else
            {
                Nurse nurse = new Nurse();
                nurse.Show();
                this.Close();
            }         
        }
    }
}
