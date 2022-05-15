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
            string connection = "Data Source=DESKTOP-BBT1MOF\\CITADEL;Initial Catalog=Przychodnia;Integrated Security=True;Encrypt=False";
            SqlConnection con = new SqlConnection(connection);
            string test = "SELECT * FROM Logowanie WHERE Login_uzytkownika LIKE '" + loginTB.Text + "' AND Haslo LIKE '" + passwordTB.Text + "'";
            con.Open();
            SqlCommand cmdTest = new SqlCommand(test, con);
            SqlDataReader reader = cmdTest.ExecuteReader();
            int notExist = 0;
            while (reader.Read())
            {
                if (reader[0] == "W")
                {
                    if (reader[1] == loginTB.Text)
                    {
                        if (reader[2] == passwordTB.Text)
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
                                            if (petTB.Text != "")
                                            {
                                                if (speciesTB.Text != "")
                                                {
                                                    if (sexTB.Text != "")
                                                    {
                                                        if (sexTB.Text == "K" || sexTB.Text == "M" || sexTB.Text == "N")
                                                        {

                                                            string login = "INSERT INTO Logowanie VALUES ('W','" + loginTB.Text + "','" + passwordTB.Text + "')";
                                                            string owner = "INSERT INTO Wlasciciel (Imie, Id_wlasciciela, Nazwisko, Adres, Telefon) VALUES (" + "'" + firstNameTB.Text + "'," + "(SELECT Login_uzytkownika FROM Logowanie WHERE Haslo LIKE '" + passwordTB.Text + "'),'" + lastNameTB.Text + "','" + adressTB.Text + "'," + phoneTB.Text + ")";
                                                            if (ageTB.Text == "")
                                                            {
                                                                if (infoTB.Text == "")
                                                                {
                                                                    string pet = "INSERT INTO Pacjent (Id_zwierzecia, Imie, Gatunek, Plec) VALUES (" + "(SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "),'" + petTB.Text + "','" + speciesTB.Text + "','" + sexTB.Text + "')";

                                                                    con.Open();

                                                                    SqlCommand cmdLogin = new SqlCommand(login, con);
                                                                    SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                                    SqlCommand cmdPet = new SqlCommand(pet, con);

                                                                    cmdLogin.ExecuteNonQuery();
                                                                    cmdOwner.ExecuteNonQuery();
                                                                    cmdPet.ExecuteNonQuery();
                                                                }
                                                                else
                                                                {
                                                                    string pet = "INSERT INTO Pacjent VALUES (Id_zwierzecia, Imie, Gatunek, Plec, Opis) VALUES (" + "(SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "),'" + petTB.Text + "','" + speciesTB.Text + "','" + sexTB.Text + "','" + infoTB.Text + "')";

                                                                    con.Open();

                                                                    SqlCommand cmdLogin = new SqlCommand(login, con);
                                                                    SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                                    SqlCommand cmdPet = new SqlCommand(pet, con);

                                                                    cmdLogin.ExecuteNonQuery();
                                                                    cmdOwner.ExecuteNonQuery();
                                                                    cmdPet.ExecuteNonQuery();
                                                                }
                                                            }
                                                            else
                                                            {
                                                                long age;
                                                                long.TryParse(ageTB.Text, out age);
                                                                if (age > 0)
                                                                {
                                                                    if (infoTB.Text == "")
                                                                    {
                                                                        string pet = "INSERT INTO Pacjent VALUES (Id_zwierzecia, Imie, Gatunek, Plec, Wiek) VALUES (" + "(SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "),'" + petTB.Text + "','" + speciesTB.Text + "','" + sexTB.Text + "'," + ageTB.Text + ")";

                                                                        con.Open();

                                                                        SqlCommand cmdLogin = new SqlCommand(login, con);
                                                                        SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                                        SqlCommand cmdPet = new SqlCommand(pet, con);

                                                                        cmdLogin.ExecuteNonQuery();
                                                                        cmdOwner.ExecuteNonQuery();
                                                                        cmdPet.ExecuteNonQuery();
                                                                    }
                                                                    else
                                                                    {
                                                                        string pet = "INSERT INTO Pacjent VALUES (Id_zwierzecia, Imie, Gatunek, Plec, Wiek, Opis) VALUES (" + "(SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "),'" + petTB.Text + "','" + speciesTB.Text + "','" + sexTB.Text + "'," + ageTB.Text + ",'" + infoTB.Text + "')";

                                                                        con.Open();

                                                                        SqlCommand cmdLogin = new SqlCommand(login, con);
                                                                        SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                                        SqlCommand cmdPet = new SqlCommand(pet, con);

                                                                        cmdLogin.ExecuteNonQuery();
                                                                        cmdOwner.ExecuteNonQuery();
                                                                        cmdPet.ExecuteNonQuery();
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    MessageBox.Show("Please enter correct form of data");
                                                                }
                                                            }
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
