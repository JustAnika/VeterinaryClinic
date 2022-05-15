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
            UploadData();
        }
        private void UploadData()
        {
            string connection = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Przychodnia;Integrated Security=True;Encrypt=False"; // 
            string sqlQuery = "SELECT * FROM Pacjent";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string dane = "Animal: " + reader[1] + "\n Species: " + reader[2] + "\n Sex: " + reader[3] + "\n Id: " + reader[0];
                patientLst.Items.Add(dane);
            }
            con.Close();
        }
        private void editBt_Click(object sender, EventArgs e)
        {
            Edit edit = new Edit();
            edit.Show();
            this.Close();
        }

        private void createBt_Click(object sender, EventArgs e)
        {
            Apointment apointment = new Apointment();
            if (patientLst.SelectedItems.Count == 1)
            {
                string[] separated = patientLst.SelectedItems[0].ToString().Split(':');
                string identyfikator = separated[separated.Length - 1].TrimEnd('}');
                apointment.petTextBox.Text = identyfikator;
                apointment.Show();
                this.Close();
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
