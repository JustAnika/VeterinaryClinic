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
            visitLst.Items.Clear();
            string connection = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Przychodnia;Integrated Security=True;Encrypt=False"; // 
            string sqlQuery = "SELECT * FROM Wizyta WHERE Id_pracownika LIKE'"+loginInfoLb.Text+"' ORDER BY Data_wizyty;";
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
                string[] data = reader[3].ToString().Split('.', ' ', ':');
                string dateTaken = data[2] + '-' + data[1] + '-' + data[0] + ' ' + data[3] + ':' + data[4];
                int dzien = dateTimePicker1.Value.Day;
                int miesiac = dateTimePicker1.Value.Month;
                int rok = dateTimePicker1.Value.Year;
                if (int.Parse(data[0]) == dzien && int.Parse(data[1]) == miesiac && int.Parse(data[2]) == rok)
                {
                    string dane = "Date: " + dateTaken + " Animal: " + reader[1].ToString() + " Room: " + pokoj + " Id_visit:" + reader[0].ToString();
                    visitLst.Items.Add(dane);
                }
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
                string idp = separated[4].TrimEnd(' ','\\','n','R','o','m');
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

        private void patientLst_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (patientLst.SelectedItems.Count == 1)
            {
                historyLV.Items.Clear();
                string[] separated = patientLst.SelectedItems[0].ToString().Split(':');
                string idpet = separated[separated.Length - 1].TrimEnd('}').TrimStart(' ');
                historyLV.Items.Add("VISITS:");
                string connection = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Przychodnia;Integrated Security=True;Encrypt=False"; // 
                string sqlQuery = "SELECT Id_pracownika, Data_wizyty, Id_pracowni, Lek, Opis FROM Wizyta WHERE Id_zwierzecia = "+idpet+" ORDER BY Data_wizyty";
                SqlConnection con = new SqlConnection(connection);
                con.Open();
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string dane = "Date: " + reader[1];
                    string dane1 = "Doctor: "+ reader[0];
                    string dane2 = "Workroom: " + reader[2] + " Medicine: " + reader[3];
                    string dane3 = "Additional: " + reader[4] ;
                    historyLV.Items.Add(dane);
                    historyLV.Items.Add(dane1);
                    historyLV.Items.Add(dane2);
                    historyLV.Items.Add(dane3);
                    historyLV.Items.Add("-----");
                }
                con.Close();
                historyLV.Items.Add("TESTS:");
                string sqlQuery1 = "SELECT Id_pracownika, Data_badania, Opis FROM Badanie WHERE Id_zwierzecia = " + idpet + " ORDER BY Data_badania";
                SqlConnection con1 = new SqlConnection(connection);
                con.Open();
                SqlCommand cmd1 = new SqlCommand(sqlQuery1, con);
                SqlDataReader reader1 = cmd1.ExecuteReader();
                while (reader1.Read())
                {
                    string dane = "Date: " + reader1[1];
                    string dane1 = "Tech: " + reader1[0];
                    string dane2 = "Description: ";
                    string dane3 = reader1[2].ToString();
                    historyLV.Items.Add(dane);
                    historyLV.Items.Add(dane1);
                    historyLV.Items.Add(dane2);
                    historyLV.Items.Add(dane3);
                    historyLV.Items.Add("-----");
                }
                con.Close();
            }
            else
            {
                if (patientLst.SelectedItems.Count > 1)
                {
                    historyLV.Items.Clear();
                    historyLV.Items.Add("Need ONLY ONE animal to see it's history!");
                }
                else
                {
                    historyLV.Items.Clear();
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            UploadDataVisits();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (allDateCecb.Checked)
            {
                visitLst.Items.Clear();
                string connection = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Przychodnia;Integrated Security=True;Encrypt=False"; // 
                string sqlQuery = "SELECT * FROM Wizyta WHERE Id_pracownika LIKE'" + loginInfoLb.Text + "' ORDER BY Data_wizyty;";
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
                    string[] data = reader[3].ToString().Split('.', ' ', ':');
                    string dateTaken = data[2] + '-' + data[1] + '-' + data[0] + ' ' + data[3] + ':' + data[4];
                    string dane = "Date: " + dateTaken + " Animal: " + reader[1].ToString() + " Room: " + pokoj + " Id_visit:" + reader[0].ToString();
                    visitLst.Items.Add(dane);
                }
                con.Close();
            }
            else
            {
                UploadDataVisits();
            }
        }
    }
}
