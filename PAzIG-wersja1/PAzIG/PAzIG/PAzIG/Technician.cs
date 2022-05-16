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
        private void UploadData()
        {
            string connection = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Przychodnia;Integrated Security=True;Encrypt=False"; // 
            string sqlQuery = "SELECT Id_zwierzecia, Id_pracownika, Data_Badania FROM Badanie";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string dane = "Animal: " + reader[0] + " Doctor: " + reader[1] + " Data: " + reader[2];
                testsLst.Items.Add(dane);
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
