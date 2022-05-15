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
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
        }
        public void ShowData()
        {
            string connection = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Przychodnia;Integrated Security=True;Encrypt=False";
            SqlConnection con = new SqlConnection(connection);
            string test = "SELECT * FROM Pacjent WHERE Id_zwierzecia = " + idTB.Text;
            con.Open();
            SqlCommand cmdTest = new SqlCommand(test, con);
            SqlDataReader reader = cmdTest.ExecuteReader();
            while (reader.Read())
            {
                petTB.Text = String.Format("{0}", reader[1]);
                speciesTB.Text = String.Format("{0}", reader[2]);
                sexTB.Text = String.Format("{0}", reader[3]);
                ageLb.Text = String.Format("{0}", reader[4]);
                infoTB.Text = String.Format("{0}", reader[5]);
                firstNameTB.Text = String.Format("{0}", reader[6]);
                lastNameTB.Text = String.Format("{0}", reader[7]);
                phoneTB.Text = String.Format("{0}", reader[8]);
            }
            con.Close();
        }

        private void editBt_Click(object sender, EventArgs e)
        {
            string connection = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Przychodnia;Integrated Security=True;Encrypt=False";
            SqlConnection con = new SqlConnection(connection);
            string test = "SELECT * FROM Pacjent WHERE Id_zwierzecia = " + idTB.Text;
            con.Open();
            SqlCommand cmdTest = new SqlCommand(test, con);
            SqlDataReader reader = cmdTest.ExecuteReader();
            if (petTB.Text == "")
            {
                petTB.Text = String.Format("{0}", reader[1]);
            }
            if (speciesTB.Text == "")
            {
                speciesTB.Text = String.Format("{0}", reader[2]);
            }
            if (sexTB.Text == "")
            {
                sexTB.Text = String.Format("{0}", reader[3]);
            }
            if (ageTB.Text == "")
            {
                ageTB.Text = String.Format("{0}", reader[4]);
            }
            if (infoTB.Text == "")
            {
                infoTB.Text = String.Format("{0}", reader[5]);
            }
            if (firstNameTB.Text == "")
            {
                firstNameTB.Text = String.Format("{0}", reader[6]);
            }
            if (lastNameTB.Text == "")
            {
                lastNameLb.Text = String.Format("{0}", reader[7]);
            }
            if (phoneTB.Text == "")
            {
                phoneTB.Text = String.Format("{0}", reader[8]);
            }

            if (sexTB.Text != "")
            {
                if (sexTB.Text == "K" || sexTB.Text == "M" || sexTB.Text == "N")
                {

                }
                else
                {
                    MessageBox.Show("Please enter correct form of data.");
                }
            }

            if (ageTB.Text != "")
            {
                double age;
                double.TryParse(ageTB.Text, out age);
                if (age > 0)
                {

                }
                else
                {
                    MessageBox.Show("Please enter correct form of data.");
                }
            }


            if (phoneTB.Text != "")
            {
                long phone;
                long.TryParse(phoneTB.Text, out phone);
                if (phone > 0)
                {
                    if (phoneTB.Text.Length == 9)
                    {

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

            con.Close();
            con.Open();

            string edit = "ALTER TABLE Pacjent SET VALUES Imie_zwierzecia = '" + petTB.Text + "', Gatunek = '" + speciesTB.Text + "', Plec = '" + sexTB.Text + "', Wiek = " + ageTB.Text + ", Opis = '" + infoTB.Text + "', Imie = '" + firstNameTB.Text + "', Nazwisko = '" + lastNameTB.Text + "', Telefon = " + phoneTB.Text + " WHERE Id_zwierzecia = " + idTB.Text;
            SqlCommand cmdEdit = new SqlCommand(edit, con);
            cmdEdit.ExecuteNonQuery();

            MessageBox.Show("Edited successfully.");

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
