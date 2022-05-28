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
        }
        public void UploadData()
        {
            string connection = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Przychodnia;Integrated Security=True;Encrypt=False"; 
            string sqlQuery = "SELECT Id_zwierzecia, Data_Badania, Opis FROM Badanie WHERE Id_pracownika LIKE '"+ loginLb.Text +"'";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string[] data = reader[1].ToString().Split('.', ' ', ':');
                string dateTaken = data[2] + '-' + data[1] + '-' + data[0] + ' ' + data[3] + ':' + data[4];
                if (data[0] == DateTime.Now.Day.ToString() && data[1] == DateTime.Now.Month.ToString() && data[2] == DateTime.Now.Year.ToString())
                {
                    string dane = "Animal: " + reader[0].ToString() + " Data: " + dateTaken + " Opis: " + reader[2].ToString();
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
    }
}
