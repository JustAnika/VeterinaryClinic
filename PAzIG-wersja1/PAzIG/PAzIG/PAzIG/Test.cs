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
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Now;
            LoadTech();
        }
        private void LoadTech()
        {
            string connection = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Przychodnia;Integrated Security=True;Encrypt=False";
            string sqlQuery = "SELECT Login_uzytkownika FROM Logowanie WHERE Id_logowania LIKE 'T'";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                TechComboBox.Items.Add(reader[0].ToString());
            }
            con.Close();
        }
        private void LoadTest()
        {
            if (TechComboBox.SelectedItem != null)
            {
                testListLV.Clear();
                string connection = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Przychodnia;Integrated Security=True;Encrypt=False";
                string sqlQuery = "SELECT Data_badania FROM Badanie WHERE Id_pracownika LIKE '" + TechComboBox.SelectedItem.ToString() + "'";
                SqlConnection con = new SqlConnection(connection);
                con.Open();
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string[] data = reader[0].ToString().Split('.', ' ', ':');
                    string dateTaken = data[2] + '-' + data[1] + '-' + data[0] + ' ' + data[3] + ':' + data[4];
                    if (data[0] == dateTimePicker1.Value.Day.ToString() && data[1] == dateTimePicker1.Value.Month.ToString() && data[2] == dateTimePicker1.Value.Year.ToString())
                    {
                        testListLV.Items.Add(dateTaken);
                    }
                }
                con.Close();
            }
        }

        private void backBt_Click(object sender, EventArgs e)
        {
            Doctor doctor = new Doctor();
            doctor.loginInfoLb.Text = fromLB.Text;
            doctor.UploadDataVisits();
            doctor.Show();
            this.Close();
        }

        private void orderBt_Click(object sender, EventArgs e)
        {
            if (TechComboBox.SelectedItem != null)
            {
                string connection = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Przychodnia;Integrated Security=True;Encrypt=False";
                string sqlQuery = "SELECT * FROM Badanie";
                SqlConnection con = new SqlConnection(connection);
                con.Open();
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                SqlDataReader reader = cmd.ExecuteReader();
                bool exists = false;
                while (reader.Read())
                {
                    string[] data = reader[3].ToString().Split('.', ' ', ':');
                    string dateTaken = data[2] + '-' + data[1] + '-' + data[0] + ' ' + data[3] + ':' + data[4];
                    string dateGiven = dateTimePicker1.Text;
                    if (reader[2].ToString() == TechComboBox.SelectedItem.ToString() && dateTaken == dateGiven)
                    {
                        exists = true;
                        break;
                    }

                }
                con.Close();
                if (!exists)
                {
                    if (OpisTb.Text != "")
                    {
                        string data = "INSERT INTO Badanie(Id_zwierzecia,Data_badania,Id_pracownika,Opis) VALUES(" + petTextBox.Text + ",CONVERT(DATETIME,'" + dateTimePicker1.Text + "',120),'" + TechComboBox.SelectedItem.ToString() + ", '" + OpisTb.Text + "');";
                        con.Open();
                        SqlCommand newvisit = new SqlCommand(data, con);
                        newvisit.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Test ordered succesfully!");
                    }
                    else
                    {
                        string data = "INSERT INTO Badanie(Id_zwierzecia,Data_badania,Id_pracownika) VALUES(" + petTextBox.Text + ",CONVERT(DATETIME,'" + dateTimePicker1.Text + "',120),'" + TechComboBox.SelectedItem.ToString() + "');";
                        con.Open();
                        SqlCommand newvisit = new SqlCommand(data, con);
                        newvisit.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Test ordered succesfully!");
                    }
                }
                else
                {
                    MessageBox.Show("There is already a test at that date with this employee!");
                }
            }
            else
            {
                MessageBox.Show("Please select a technician to order a test!");
            }
            LoadTest();
        }

        private void TechComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadTest();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            LoadTest();
        }
    }
}
