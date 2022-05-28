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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void registerBt_Click(object sender, EventArgs e)
        {
            string connection = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Przychodnia;Integrated Security=True;Encrypt=False";
            SqlConnection con = new SqlConnection(connection);
            string test = "SELECT * FROM Pacjent";
            con.Open();
            SqlCommand cmdTest = new SqlCommand(test, con);
            SqlDataReader reader = cmdTest.ExecuteReader();
            int notExist = 0;
            while (reader.Read())
            {
                if (String.Format("{0}", reader[1]) == nameTB.Text)
                {
                    if (String.Format("{0}", reader[6]) == firstNameTB.Text)
                    {
                        if (String.Format("{0}", reader[7]) == lastNameTB.Text)
                        {
                            MessageBox.Show("This patient already exist.");
                            notExist = 1;
                            nameTB.Text = "";
                            speciesTB.Text = "";
                            sexLstBox.SelectedIndex = 0;
                            ageTB.Text = "";
                            infoTB.Text = "";
                            firstNameTB.Text = "";
                            lastNameTB.Text = "";
                            phoneTB.Text = "";
                        }
                    }
                }
            }
            if (notExist == 1)
            {

            }
            else
            {
                con.Close();
                con.Open();
                long phone;
                long.TryParse(phoneTB.Text, out phone);
                double age;
                double.TryParse(ageTB.Text, out age);
                if (nameTB.Text != "")
                {
                    if (speciesTB.Text != "")
                    {
                        if (sexLstBox.SelectedItem == "K" || sexLstBox.SelectedItem == "M" || sexLstBox.SelectedItem == "N")
                        {
                            if (firstNameTB.Text != "")
                            {
                                if (lastNameLb.Text != "")
                                {
                                    if (phoneTB.Text != "")
                                    {
                                        if (phone > 0)
                                        {
                                            if (phoneTB.Text.Length == 9)
                                            {
                                                if (ageTB.Text != "")
                                                {
                                                    if (age > 0)
                                                    {
                                                        if (infoTB.Text != "")
                                                        {
                                                            string patient = "INSERT INTO Pacjent (Imie_zwierzecia, Gatunek, Plec, Wiek, Opis, Imie, Nazwisko, Telefon) VALUES ('" + nameTB.Text + "','" + speciesTB.Text + "','" + sexLstBox.SelectedItem + "'," + ageTB.Text + ",'" + infoTB.Text + "','" + firstNameTB.Text + "','" + lastNameTB.Text + "'," + phoneTB.Text + ")";
                                                            SqlCommand cmdPatient = new SqlCommand(patient, con);
                                                            cmdPatient.ExecuteNonQuery();

                                                            MessageBox.Show("Registered successfully.");
                                                            nameTB.Text = "";
                                                            speciesTB.Text = "";
                                                            sexLstBox.SelectedIndex = 0;
                                                            ageTB.Text = "";
                                                            infoTB.Text = "";
                                                            firstNameTB.Text = "";
                                                            lastNameTB.Text = "";
                                                            phoneTB.Text = "";
                                                        }
                                                        else
                                                        {
                                                            string patient = "INSERT INTO Pacjent (Imie_zwierzecia, Gatunek, Plec, Wiek, Imie, Nazwisko, Telefon) VALUES ('" + nameTB.Text + "','" + speciesTB.Text + "','" + sexLstBox.SelectedItem + "'," + ageTB.Text + ",'" + firstNameTB.Text + "','" + lastNameTB.Text + "'," + phoneTB.Text + ")";
                                                            SqlCommand cmdPatient = new SqlCommand(patient, con);
                                                            cmdPatient.ExecuteNonQuery();

                                                            MessageBox.Show("Registered successfully.");
                                                            nameTB.Text = "";
                                                            speciesTB.Text = "";
                                                            sexLstBox.SelectedIndex = 0;
                                                            ageTB.Text = "";
                                                            infoTB.Text = "";
                                                            firstNameTB.Text = "";
                                                            lastNameTB.Text = "";
                                                            phoneTB.Text = "";
                                                        }
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Please enter correct form of data.");
                                                    }
                                                }
                                                else
                                                {
                                                    if (infoTB.Text != "")
                                                    {
                                                        string patient = "INSERT INTO Pacjent (Imie_zwierzecia, Gatunek, Plec, Opis, Imie, Nazwisko, Telefon) VALUES ('" + nameTB.Text + "','" + speciesTB.Text + "','" + sexLstBox.SelectedItem + "','" + infoTB.Text + "','" + firstNameTB.Text + "','" + lastNameTB.Text + "'," + phoneTB.Text + ")";
                                                        SqlCommand cmdPatient = new SqlCommand(patient, con);
                                                        cmdPatient.ExecuteNonQuery();

                                                        MessageBox.Show("Registered successfully.");
                                                        nameTB.Text = "";
                                                        speciesTB.Text = "";
                                                        sexLstBox.SelectedIndex = 0;
                                                        ageTB.Text = "";
                                                        infoTB.Text = "";
                                                        firstNameTB.Text = "";
                                                        lastNameTB.Text = "";
                                                        phoneTB.Text = "";
                                                    }
                                                    else
                                                    {
                                                        string patient = "INSERT INTO Pacjent (Imie_zwierzecia, Gatunek, Plec, Imie, Nazwisko, Telefon) VALUES ('" + nameTB.Text + "','" + speciesTB.Text + "','" + sexLstBox.SelectedItem + "','" + firstNameTB.Text + "','" + lastNameTB.Text + "'," + phoneTB.Text + ")";
                                                        SqlCommand cmdPatient = new SqlCommand(patient, con);
                                                        cmdPatient.ExecuteNonQuery();

                                                        MessageBox.Show("Registered successfully.");
                                                        nameTB.Text = "";
                                                        speciesTB.Text = "";
                                                        sexLstBox.SelectedIndex = 0;
                                                        ageTB.Text = "";
                                                        infoTB.Text = "";
                                                        firstNameTB.Text = "";
                                                        lastNameTB.Text = "";
                                                        phoneTB.Text = "";
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Please enter correct form of data.");
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Please enter correct form of data.");
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
                else
                {
                    MessageBox.Show("Please enter all required information.");
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
