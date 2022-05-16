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
            string sqlQuery = "SELECT Id_zwierzecia,Id_pracownika,CONVERT(DATETIME,Data_wizyty,120) FROM Wizyta";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            SqlDataReader reader = cmd.ExecuteReader();
            bool exists = false;
            string dzien = "";
            string miesiac = "";
            string godzina = "";
            string minuta = "";
            if (dateTimePicker1.Value.Day<10)
            {
                dzien = '0'+dateTimePicker1.Value.Day.ToString();
            }
            else
            {
                dzien = dateTimePicker1.Value.Day.ToString();    
            }
            if (dateTimePicker1.Value.Month < 10)
            {
                miesiac = '0' + dateTimePicker1.Value.Month.ToString();
            }
            else
            {
                miesiac = dateTimePicker1.Value.Month.ToString();
            }
            if (dateTimePicker1.Value.Hour < 10)
            {
                godzina = '0' + dateTimePicker1.Value.Hour.ToString();
            }
            else
            {
                godzina = dateTimePicker1.Value.Hour.ToString();
            }
            if (dateTimePicker1.Value.Minute < 10)
            {
                minuta = '0' + dateTimePicker1.Value.Minute.ToString();
            }
            else
            {
                minuta = dateTimePicker1.Value.Minute.ToString();
            }
            string formatdaty = dzien +'.'+ miesiac+'.'+ dateTimePicker1.Value.Year+' '+ godzina+':'+ minuta;
            while (reader.Read())
            {
                
                if (doctorTextBox.Text!= "")
                {
                    if (reader[0].ToString()==petTextBox.Text && reader[1].ToString() == doctorTextBox.Text && reader[2].ToString() == dateTimePicker1.Text)
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
            con.Close();
            if (exists)
            {
                if (laboratoryTextBox.Text != "")
                {
                    if (medicineTB.Text != "")
                    {
                        if (infoTextBox.Text != "")
                        {
                            //pracownia i leki i opis jest
                            string data = "UPDATE Wizyta SET Id_pracowni='"+ laboratoryTextBox.Text+"', Lek='"+medicineTB.Text+"', Opis='"+infoTextBox.Text+"' WHERE Id_zwierzecia="+petTextBox.Text+"AND Id_pracownika LIKE '" + doctorTextBox.Text+ "' AND Data_wizyty = CONVERT(DATETIME,'"+dateTimePicker1.Text+"',120)";
                            con.Open();
                            SqlCommand newvisit = new SqlCommand(data, con);
                            newvisit.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Edit succesful!");
                        }
                        else
                        {
                            //pracownia i leki ale bez opisu
                            string data = "UPDATE Wizyta SET Id_pracowni='" + laboratoryTextBox.Text + "', Lek='" + medicineTB.Text+ "' WHERE Id_zwierzecia=" + petTextBox.Text + "AND Id_pracownika LIKE '" + doctorTextBox.Text + "' AND Data_wizyty = CONVERT(DATETIME,'" + dateTimePicker1.Text + "',120)";
                            con.Open();
                            SqlCommand newvisit = new SqlCommand(data, con);
                            newvisit.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Edit succesful!");
                        }
                    }
                    else
                    {
                        if (infoTextBox.Text != "")
                        {
                            //pracownia bez leków z opsiem
                            string data = "UPDATE Wizyta SET Id_pracowni='" + laboratoryTextBox.Text + "', Opis='" + infoTextBox.Text + "' WHERE Id_zwierzecia=" + petTextBox.Text + "AND Id_pracownika LIKE '" + doctorTextBox.Text + "' AND Data_wizyty = CONVERT(DATETIME,'" + dateTimePicker1.Text + "',120)";
                            con.Open();
                            SqlCommand newvisit = new SqlCommand(data, con);
                            newvisit.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Edit succesful!");
                        }
                        else
                        {
                            //pracowia bez leków bez opisu
                            string data = "UPDATE Wizyta SET Id_pracowni='" + laboratoryTextBox.Text + "' WHERE Id_zwierzecia=" + petTextBox.Text + "AND Id_pracownika LIKE '" + doctorTextBox.Text + "' AND Data_wizyty = CONVERT(DATETIME,'" + dateTimePicker1.Text + "',120)";
                            con.Open();
                            SqlCommand newvisit = new SqlCommand(data, con);
                            newvisit.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Edit succesful!");
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
                            string data = "UPDATE Wizyta SET Lek='" + medicineTB.Text + "', Opis='" + infoTextBox.Text + "' WHERE Id_zwierzecia=" + petTextBox.Text + "AND Id_pracownika LIKE '" + doctorTextBox.Text + "' AND Data_wizyty = CONVERT(DATETIME,'" + dateTimePicker1.Text + "',120)";
                            con.Open();
                            SqlCommand newvisit = new SqlCommand(data, con);
                            newvisit.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Edit succesful!");
                        }
                        else
                        {
                            //bez pracowni z lekami bez opisu
                            string data = "UPDATE Wizyta SET Lek='" + medicineTB.Text + "' WHERE Id_zwierzecia=" + petTextBox.Text + "AND Id_pracownika LIKE '" + doctorTextBox.Text + "' AND Data_wizyty = CONVERT(DATETIME,'" + dateTimePicker1.Text + "',120)";
                            con.Open();
                            SqlCommand newvisit = new SqlCommand(data, con);
                            newvisit.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Edit succesful!");
                        }
                    }
                    else
                    {
                        if (infoTextBox.Text != "")
                        {
                            //bez leków bez pracowni , z opisem
                            string data = "UPDATE Wizyta SET Opis='" + infoTextBox.Text + "' WHERE Id_zwierzecia=" + petTextBox.Text + "AND Id_pracownika LIKE '" + doctorTextBox.Text + "' AND Data_wizyty = CONVERT(DATETIME,'" + dateTimePicker1.Text + "',120)";
                            con.Open();
                            SqlCommand newvisit = new SqlCommand(data, con);
                            newvisit.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Edit succesful!");
                        }
                        else
                        {
                            //bez niczego
                            MessageBox.Show("No data to change!");
                        }
                    }
                }

            }
            else
            {
                MessageBox.Show("There isn't a visit at that date with this employee!");
            }
        }
    }
}
