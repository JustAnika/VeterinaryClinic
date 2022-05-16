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
    public partial class Doctor : Form
    {
        public Doctor()
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
                string dane = "Animal: "+reader[1]+"\n Species: " + reader[2]+"\n Sex: " + reader[3]+ "\n Id: " + reader[0] ;      
                patientLst.Items.Add(dane);
            }
            con.Close();
        }

        private void editBt_Click(object sender, EventArgs e)
        {
            Edit edit = new Edit();
            edit.formLB.Text = "doctor";
            if (patientLst.SelectedItems.Count == 1)
            {
                string[] separated = patientLst.SelectedItems[0].ToString().Split(':');
                string identyfikator = separated[separated.Length - 1].TrimEnd('}').TrimStart(' ');
                edit.idTB.Text = identyfikator;
                edit.ShowData();
                edit.Show();
                this.Close();
            }
            else
            {
                if (patientLst.SelectedItems.Count == 0) MessageBox.Show("Please select an animal to edit!");
                else MessageBox.Show("Please select ONLY ONE animal to edit!");
            }
        }

        private void addBt_Click(object sender, EventArgs e)
        {
            EditVisit visit = new EditVisit();
            if (patientLst.SelectedItems.Count == 1)
            {
                string[] separated = patientLst.SelectedItems[0].ToString().Split(':');
                string identyfikator = separated[separated.Length - 1].TrimEnd('}').TrimStart(' ');
                visit.petTextBox.Text = identyfikator;
                visit.Show();
                this.Close();
            }
            else
            {
                if (patientLst.SelectedItems.Count == 0) MessageBox.Show("Please select an animal to edit a visit!");
                else MessageBox.Show("Please select ONLY ONE animal to edit a visit!");
            }
        }

        private void orderBt_Click(object sender, EventArgs e)
        {
            Test test = new Test();
            test.Show();
            this.Close();
        }

        private void logOutBt_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
            this.Close();
        }

        private void petBT_Click(object sender, EventArgs e)
        {
            Register addPet = new Register();
            addPet.formLB.Text = "doctor";
            addPet.Show();
            this.Close();
        }
    }
}
