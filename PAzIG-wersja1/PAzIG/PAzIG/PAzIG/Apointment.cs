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
                string data = reader[3].ToString(); // dostaję jaz kropkami między datą w ofrmi dd.mm.yyyy i godziną z dwukropkiem - między nimi spacja
                if (reader[2].ToString() == doctorTextBox.Text && reader[3].ToString() == dateTimePicker1.Text)
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
        }
    }
    
}
