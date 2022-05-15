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
    public partial class EditVisit : Form
    {
        public EditVisit()
        {
            InitializeComponent();
        }

        private void backBt_Click(object sender, EventArgs e)
        {
            Doctor doctor = new Doctor();
            doctor.Show();
            this.Close();
        }

        private void addBt_Click(object sender, EventArgs e)
        {
            string cos = petTextBox.Text;
            string connection = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Przychodnia;Integrated Security=True;Encrypt=False"; 
            string sqlQuery = "SELECT * FROM Wizyta";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            SqlDataReader reader = cmd.ExecuteReader();
            bool exists = false;
            while (reader.Read())
            {
                string data = reader[3].ToString(); // dostaję jaz kropkami między datą w ofrmi dd.mm.yyyy i godziną z dwukropkiem
                if (dateTextBox.Text!="")
                {
                    if (doctorTextBox.Text!= "")
                    {
                        if (reader[2].ToString() == doctorTextBox.Text && reader[3].ToString() == dateTextBox.Text)
                        {
                            exists = true;
                            break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter employees' login!");
                        break;
                    }
                }
                else
                {
                    MessageBox.Show("Please enter the date of the visit!");
                    break;
                }
            }
            con.Close();
            if (!exists)
            {
                if (laboratoryTextBox.Text != "")
                {
                    if (medicineTB.Text != "")
                    {
                        if (infoTextBox.Text != "")
                        {
                            //pracownia i leki i opis jest
                            string data = "INSERT INTO Wizyta(Id_zwierzecia,Id_pracownika,Data_wizyty,Id_pracowni,Lek,Opis) VALUES(" + petTextBox.Text + "," + doctorTextBox.Text + "," + dateTextBox.Text +", "+laboratoryTextBox.Text+","+medicineTB.Text+ ", "+ infoTextBox.Text + ");";
                            con.Open();
                            SqlCommand newvisit = new SqlCommand(data, con);
                            newvisit.ExecuteNonQuery();
                            con.Close();
                        }
                        else
                        {
                            //pracownia i leki ale bez opisu
                            string data = "INSERT INTO Wizyta(Id_zwierzecia,Id_pracownika,Data_wizyty,Id_pracowni,Lek) VALUES(" + petTextBox.Text + "," + doctorTextBox.Text + "," + dateTextBox.Text +", " + laboratoryTextBox.Text + "," + medicineTB.Text + ");";
                            con.Open();
                            SqlCommand newvisit = new SqlCommand(data, con);
                            newvisit.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                    else
                    {
                        if (infoTextBox.Text != "")
                        {
                            //pracownia i bez leków z opsiem
                            string data = "INSERT INTO Wizyta(Id_zwierzecia,Id_pracownika,Data_wizyty,Id_pracowni,Opis) VALUES(" + petTextBox.Text + "," + doctorTextBox.Text + "," + dateTextBox.Text +", " + laboratoryTextBox.Text + "," + infoTextBox.Text + ");";
                            con.Open();
                            SqlCommand newvisit = new SqlCommand(data, con);
                            newvisit.ExecuteNonQuery();
                            con.Close();
                        }
                        else
                        {
                            //pracowia bez leków bez opisu
                            string data = "INSERT INTO Wizyta(Id_zwierzecia,Id_pracownika,Data_wizyty,Id_pracowni) VALUES(" + petTextBox.Text + "," + doctorTextBox.Text + "," + dateTextBox.Text +", " + laboratoryTextBox.Text+");";
                            con.Open();
                            SqlCommand newvisit = new SqlCommand(data, con);
                            newvisit.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                }
                else
                {
                    if (medicineTB.Text != "")
                    {
                        if (infoTextBox.Text != "")
                        {
                            //bez pracowni, z lekami  i z opisem
                            string data = "INSERT INTO Wizyta(Id_zwierzecia,Id_pracownika,Data_wizyty,Lek,Opis) VALUES("+petTextBox.Text+","+doctorTextBox.Text+","+dateTextBox.Text+ "," + medicineTB.Text + ", " + infoTextBox.Text + ");";
                            con.Open();
                            SqlCommand newvisit = new SqlCommand(data, con);
                            newvisit.ExecuteNonQuery();
                            con.Close();
                        }
                        else
                        {
                            //bez pracowni z lekami bez opisu
                            string data = "INSERT INTO Wizyta(Id_zwierzecia,Id_pracownika,Data_wizyty,Opis) VALUES(" + petTextBox.Text + "," + doctorTextBox.Text + "," + dateTextBox.Text + ", " + infoTextBox.Text + ");";
                            con.Open();
                            SqlCommand newvisit = new SqlCommand(data, con);
                            newvisit.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                    else
                    {
                        if (infoTextBox.Text != "")
                        {
                            //bez leków bez pracowni , z opisem
                            string data = "INSERT INTO Wizyta(Id_zwierzecia,Id_pracownika,Data_wizyty,Opis) VALUES(" + petTextBox.Text + "," + doctorTextBox.Text + "," + dateTextBox.Text + ", " + infoTextBox.Text + ");";
                            con.Open();
                            SqlCommand newvisit = new SqlCommand(data, con);
                            newvisit.ExecuteNonQuery();
                            con.Close();
                        }
                        else
                        {
                            //bez niczego
                            string data = "INSERT INTO Wizyta(Id_zwierzecia,Id_pracownika,Data_wizyty) VALUES(" + petTextBox.Text + "," + doctorTextBox.Text + "," + dateTextBox.Text + ");";
                            con.Open();
                            SqlCommand newvisit = new SqlCommand(data, con);
                            newvisit.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                }

            }
            else
            {
                MessageBox.Show("There is already a visit at that date with this employee!");
            }
        }
    }
}
