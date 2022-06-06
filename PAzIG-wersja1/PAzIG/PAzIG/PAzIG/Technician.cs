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
    public partial class Technician : Form
    {
        public Technician()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Now;
        }
        public void UploadData()
        {
            testsLst.Items.Clear();
            string connection = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Przychodnia;Integrated Security=True;Encrypt=False"; 
            string sqlQuery = "SELECT Id_badania, Data_Badania, Opis FROM Badanie WHERE Id_pracownika LIKE '"+ loginLb.Text +"' ORDER BY Data_badania";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string[] data = reader[1].ToString().Split('.', ' ', ':');
                string dateTaken = data[2] + '-' + data[1] + '-' + data[0] + ' ' + data[3] + ':' + data[4];
                int dzien = dateTimePicker1.Value.Day;
                int miesiac = dateTimePicker1.Value.Month;
                int rok = dateTimePicker1.Value.Year;
                if (int.Parse(data[0]) == dzien && int.Parse(data[1]) == miesiac && int.Parse(data[2]) == rok)
                {
                    string dane = "Id: " + reader[0].ToString() + " Data: " + dateTaken + " Opis: " + reader[2].ToString();
                    testsLst.Items.Add(dane);
                }

            }
            con.Close();
        }
        private void logOutBt_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            UploadData();
        }
    }
}
