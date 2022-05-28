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
    public partial class Apointment : Form
    {
        public Apointment()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Now;
        }
        public void LoadVisit()
        {
            VisitListLv.Clear();
            string connection = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Przychodnia;Integrated Security=True;Encrypt=False";
            string sqlQuery = "SELECT Data_wizyty FROM Wizyta WHERE Id_pracownika LIKE '"+ doctorTextBox.Text+"'";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string[] data = reader[0].ToString().Split('.', ' ', ':');
                string dateTaken = data[2] + '-' + data[1] + '-' + data[0] + ' ' + data[3] + ':' + data[4];
                int dzien = dateTimePicker1.Value.Day;
                int miesiac = dateTimePicker1.Value.Month;
                int rok = dateTimePicker1.Value.Year;
                if (int.Parse(data[0]) == dzien && int.Parse(data[1]) == miesiac && int.Parse(data[2]) == rok)
                {
                    VisitListLv.Items.Add(dateTaken);
                }
            }
            con.Close();
        }
        private void backBt_Click(object sender, EventArgs e)
        {
            Nurse nurse = new Nurse();
            nurse.Show();
            this.Close();
        }

        private void createBt_Click(object sender, EventArgs e)
        {
            string connection = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Przychodnia;Integrated Security=True;Encrypt=False";
            string sqlQuery = "SELECT * FROM Wizyta";
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
                if (reader[2].ToString() == doctorTextBox.Text && dateTaken == dateGiven)
                {
                    exists = true;
                    break;
                }

            }
            con.Close();
            if (!exists)
            {
                string data = "INSERT INTO Wizyta(Id_zwierzecia,Data_wizyty,Id_pracownika) VALUES(" + petTextBox.Text + ",CONVERT(DATETIME,'" +  dateTimePicker1.Text + "',120),'" + doctorTextBox.Text + "');";
                con.Open();
                SqlCommand newvisit = new SqlCommand(data, con);
                newvisit.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Visit registration succesful!");
            }
            else
            {
                MessageBox.Show("There is already a visit at that date with this employee!");
            }
            LoadVisit();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            LoadVisit();
        }
    }
    
}
