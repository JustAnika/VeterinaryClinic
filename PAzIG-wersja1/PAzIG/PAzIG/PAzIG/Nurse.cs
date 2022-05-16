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
    public partial class Nurse : Form
    {
        public Nurse()
        {
            InitializeComponent();
            UploadDataPatients();
            UploadDataDoctors();
        }
        private void UploadDataPatients()
        {
            string connection = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Przychodnia;Integrated Security=True;Encrypt=False"; // 
            string sqlQuery = "SELECT * FROM Pacjent";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string dane = "Animal: " + reader[1] + " Species: " + reader[2] + " Sex: " + reader[3] + " Id: " + reader[0];
                patientLst.Items.Add(dane);
            }
            con.Close();
        }
        private void UploadDataDoctors()
        {
            string connection = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Przychodnia;Integrated Security=True;Encrypt=False"; // 
            string sqlQuery = "SELECT * FROM Logowanie WHERE Id_logowania LIKE 'V'";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string dane = "First name: " + reader[3] + " Surname: " + reader[4] + " Login: " + reader[1] ;
                doctorLst.Items.Add(dane);
            }
            con.Close();
        }
        private void editBt_Click(object sender, EventArgs e)
        {
            Edit edit = new Edit();
            if (patientLst.SelectedItems.Count == 1)
            {
                string[] separated = patientLst.SelectedItems[0].ToString().Split(':');
                string id = separated[separated.Length - 1].TrimEnd('}').TrimStart(' ');
                edit.idTB.Text = id;
                edit.ShowData();
                edit.Show();
                this.Close();
            }
            else
            {
                if (patientLst.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Please select a patient to edit.");
                }
                else
                {
                    MessageBox.Show("Please select only one patient to edit.");
                }
            }
        }

        private void createBt_Click(object sender, EventArgs e)
        {
            Apointment apointment = new Apointment();
            if (patientLst.SelectedItems.Count == 1)
            {
                if (doctorLst.SelectedItems.Count == 1)
                {
                    string[] separated = patientLst.SelectedItems[0].ToString().Split(':');
                    string identyfikatorP = separated[separated.Length - 1].TrimEnd('}').TrimStart(' ');
                    apointment.petTextBox.Text = identyfikatorP;

                    string[] separatedD = doctorLst.SelectedItems[0].ToString().Split(':');
                    string identyfikatorD = separatedD[separatedD.Length - 1].TrimEnd('}').TrimStart(' ');
                    apointment.doctorTextBox.Text = identyfikatorD;
                    apointment.Show();
                    this.Close();
                }
                else
                {
                    if (doctorLst.SelectedItems.Count == 0) MessageBox.Show("Please select a docotr to schedule a visit!");
                    else MessageBox.Show("Please select ONLY ONE doctor to schedule a visit!");
                }
            }
            else
            {
                if (patientLst.SelectedItems.Count == 0) MessageBox.Show("Please select an animal to schedule a visit!");
                else MessageBox.Show("Please select ONLY ONE animal to schedule a visit!");
            }
        }

        private void logOutBt_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Register addPet = new Register();
            addPet.Show();
            this.Close();
        }
    }
}
