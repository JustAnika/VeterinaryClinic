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
            UploadDataPatients();
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
                string dane = "Animal: "+reader[1]+" Species: " + reader[2]+" Sex: " + reader[3]+ " Id: " + reader[0] ;      
                patientLst.Items.Add(dane);
            }
            con.Close();
        }
        public void UploadDataVisits()
        {
            string connection = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Przychodnia;Integrated Security=True;Encrypt=False"; // 
            string sqlQuery = "SELECT * FROM Wizyta WHERE Id_pracownika LIKE'"+loginInfoLb.Text+"';";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string pokoj = "";
                try
                {
                    pokoj = reader[4].ToString();
                }
                catch (System.InvalidOperationException)
                {
                    pokoj = " ";
                }
                string dane = "Date: " + reader[3].ToString() + " Animal: " + reader[1].ToString()+" Room: "+pokoj+" Id_visit:" +reader[0].ToString();
                visitLst.Items.Add(dane);
            }
            con.Close();
        }

        private void editBt_Click(object sender, EventArgs e)
        {
            Edit edit = new Edit();
            edit.formLB.Text = loginInfoLb.Text;
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
            if (visitLst.SelectedItems.Count==1)
            {
                //id zwierzaka
                string[] separated = visitLst.SelectedItems[0].ToString().Split(':');
                string idp = separated[5].TrimEnd(' ','\\','n','R','o','m');
                visit.petTextBox.Text = idp;
                //login
                visit.doctorTextBox.Text = loginInfoLb.Text;
                //id wizty
                string idv = separated[separated.Length - 1].TrimEnd('}').TrimStart(' ');
                visit.infoVisitLb.Text=idv;
                //data wizyty
                visit.UploadDate();

                visit.Show();
                this.Close();
            }
            else
            {
                if (patientLst.SelectedItems.Count == 0) MessageBox.Show("Please select a visit to edit!");
                else MessageBox.Show("Please select ONLY ONE visit to edit!");
            }
        }

        private void orderBt_Click(object sender, EventArgs e)
        {
            Test test = new Test();
            if (patientLst.SelectedItems.Count == 1)
            {
                //id zwierzaka
                string[] separated = patientLst.SelectedItems[0].ToString().Split(':');
                string idp = separated[separated.Length - 1].TrimEnd('}').TrimStart(' ');
                test.petTextBox.Text = idp;
                //login
                test.fromLB.Text = loginInfoLb.Text;
                test.Show();
                this.Close();
            }
            else
            {
                if (patientLst.SelectedItems.Count == 0) MessageBox.Show("Please select an animal to order a test for!");
                else MessageBox.Show("Please select ONLY ONE animal to order a test for!");
            }
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
            addPet.formLB.Text = loginInfoLb.Text;
            addPet.Show();
            this.Close();
        }
    }
}
