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
            Wgraj();
        }
        private void Wgraj()
        {
            string connection = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Przychodnia;Integrated Security=True;Encrypt=False";
            string login = "annnowak";
            //string sqlQuery = "SELECT * FROM Wlasciciel WHERE id_wlasciciela LIKE '"+login+"'"; 
            string sqlQuery = "SELECT * FROM Wlasciciel ";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            SqlDataReader reader = cmd.ExecuteReader();
            List<string> dane = new List<string>();
            while (reader.Read())
            {
                string dana = String.Format("{0}", reader[0]) + " \n " + String.Format("{0}", reader[1]) + " \n " + String.Format("{0}", reader[2]) + " \n " + String.Format("{0}", reader[3]) + " \n " + String.Format("{0}", reader[4]) + " \n " + String.Format("{0}", reader[5]);
                patientLst.Items.Add(dana);
                dane.Add(dana);
            }
            con.Close();
            
        }
        private void registrationBt_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            registration.formLB.Text = "doctor";
            registration.Show();
            this.Close();
        }

        private void editBt_Click(object sender, EventArgs e)
        {
            Edit edit = new Edit();
            edit.formLB.Text = "doctor";
            edit.Show();
            this.Close();
        }

        private void addBt_Click(object sender, EventArgs e)
        {
            AddVisit visit = new AddVisit();
            visit.Show();
            this.Close();
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

        private void Doctor_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
