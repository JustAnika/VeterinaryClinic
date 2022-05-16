using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace PAzIG
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void loginBT_Click(object sender, EventArgs e)
        {
            string connection = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Przychodnia;Integrated Security=True;Encrypt=False"; // 
            string sqlQuery = "SELECT * FROM Logowanie";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            SqlDataReader reader = cmd.ExecuteReader();
            string tryb = "";
            string login = "";
            while (reader.Read())
            {
                if (loginTB.Text != "")
                {
                    if (passwordTB.Text != "")
                    {
                        if (String.Format("{0}", reader[1]) == loginTB.Text)
                        {
                            if (String.Format("{0}", reader[2]) == passwordTB.Text)
                            {
                                tryb = String.Format("{0}", reader[0]);
                                login = String.Format("{0}", reader[1]);

                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter password", "No passsword error");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter login", "No login error");
                }
            }
            con.Close();
            switch (tryb)
            {
                case "":
                    MessageBox.Show("Nie ma użytkownika o podanym loginie i haśle. Sprawdź podane dane!");
                    break;
                case "V":
                    Doctor lekarz = new Doctor();
                    lekarz.loginInfoLb.Text = login;
                    lekarz.UploadDataVisits();
                    lekarz.Show();
                    this.Hide();
                    break;
                case "T":
                    Technician technik = new Technician();
                    technik.Show();
                    this.Hide();
                    break;
                case "P":
                    Nurse piel = new Nurse();
                    piel.Show();
                    this.Hide();
                    break;
                case "A":
                    Admin admin = new Admin();
                    admin.Show();
                    this.Hide();
                    break;
            }
        }

        private void LogIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
