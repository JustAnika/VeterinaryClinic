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
        public void UploadDate()
        {
            string connection = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Przychodnia;Integrated Security=True;Encrypt=False";
            string sqlQuery = "SELECT Opis,Lek,Id_pracowni,CONVERT(DATETIME,Data_wizyty,120) FROM Wizyta WHERE Id_wizyty="+infoVisitLb.Text;
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string[] data = reader[3].ToString().Split('.',' ',':');
                string format = data[2] + '-' + data[1] + '-' + data[0] + ' '+data[3]+':'+data[4];
                dateTimePicker1.Text = format;
                try
                {
                    laboratoryTextBox.Text = reader[2].ToString();
                }
                catch (System.InvalidOperationException )
                {
                    laboratoryTextBox.Text = "";
                }
                try
                {
                    medicineTB.Text = reader[1].ToString();
                }
                catch (System.InvalidOperationException)
                {
                    medicineTB.Text = "";
                }
                try
                {
                    infoTextBox.Text = reader[0].ToString();    
                }
                catch (System.InvalidOperationException)
                {
                    infoTextBox.Text = "";
                }
            }
            con.Close();
        }
        private void backBt_Click(object sender, EventArgs e)
        {
            Doctor doctor = new Doctor();
            doctor.loginInfoLb.Text = doctorTextBox.Text;
            doctor.UploadDataVisits();
            doctor.Show();
            this.Close();
        }

        private void addBt_Click(object sender, EventArgs e)
        {
            string connection = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Przychodnia;Integrated Security=True;Encrypt=False"; 
            SqlConnection con = new SqlConnection(connection);
            string sqlQuery = "SELECT CONVERT(DATETIME,Data_wizyty,120) FROM Wizyta WHERE Id_pracownika LIKE '" + doctorTextBox.Text+"' AND Id_wizyty !=" + infoVisitLb.Text;
            con.Open();
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            SqlDataReader reader = cmd.ExecuteReader();
            bool exists = false;
            while (reader.Read())
            {
                string[] data = reader[0].ToString().Split('.', ' ', ':');
                int dzien = dateTimePicker1.Value.Day;
                int miesiac = dateTimePicker1.Value.Month;
                int rok = dateTimePicker1.Value.Year;
                int godzina = dateTimePicker1.Value.Hour;
                int minuta = dateTimePicker1.Value.Minute;
                if (int.Parse(data[0]) == dzien && int.Parse(data[1]) == miesiac && int.Parse(data[2]) == rok && int.Parse(data[3]) == godzina && int.Parse(data[4]) == minuta)
                {
                    exists = true;
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
                            string data = "UPDATE Wizyta SET Id_pracowni=" + laboratoryTextBox.Text + ", Lek='" + medicineTB.Text + "', Opis='" + infoTextBox.Text + "',Data_wizyty = CONVERT(DATETIME,'" + dateTimePicker1.Text + "',120) WHERE Id_wizyty=" + infoVisitLb.Text;
                            con.Open();
                            SqlCommand newvisit = new SqlCommand(data, con);
                            newvisit.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Edit succesful!");
                        }
                        else
                        {
                            //pracownia i leki ale bez opisu
                            string data = "UPDATE Wizyta SET Id_pracowni=" + laboratoryTextBox.Text + ", Lek='" + medicineTB.Text + "',Data_wizyty = CONVERT(DATETIME,'" + dateTimePicker1.Text + "',120) WHERE Id_wizyty=" + infoVisitLb.Text;
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
                            string data = "UPDATE Wizyta SET Id_pracowni=" + laboratoryTextBox.Text + ", Opis='" + infoTextBox.Text + "',Data_wizyty = CONVERT(DATETIME,'" + dateTimePicker1.Text + "',120) WHERE Id_wizyty=" + infoVisitLb.Text;
                            con.Open();
                            SqlCommand newvisit = new SqlCommand(data, con);
                            newvisit.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Edit succesful!");
                        }
                        else
                        {
                            //pracowia bez leków bez opisu
                            string data = "UPDATE Wizyta SET Id_pracowni=" + laboratoryTextBox.Text + ",Data_wizyty = CONVERT(DATETIME,'" + dateTimePicker1.Text + "',120)" + " WHERE Id_wizyty=" + infoVisitLb.Text;
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
                            string data = "UPDATE Wizyta SET Lek='" + medicineTB.Text + "', Opis='" + infoTextBox.Text + "',Data_wizyty = CONVERT(DATETIME,'" + dateTimePicker1.Text + "',120) WHERE Id_wizyty=" + infoVisitLb.Text;
                            con.Open();
                            SqlCommand newvisit = new SqlCommand(data, con);
                            newvisit.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Edit succesful!");
                        }
                        else
                        {
                            //bez pracowni z lekami bez opisu
                            string data = "UPDATE Wizyta SET Lek='" + medicineTB.Text + "',Data_wizyty = CONVERT(DATETIME,'" + dateTimePicker1.Text + "',120) WHERE Id_wizyty=" + infoVisitLb.Text;
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
                            string data = "UPDATE Wizyta SET Opis='" + infoTextBox.Text + "',Data_wizyty = CONVERT(DATETIME,'" + dateTimePicker1.Text + "',120) WHERE Id_wizyty=" + infoVisitLb.Text;
                            con.Open();
                            SqlCommand newvisit = new SqlCommand(data, con);
                            newvisit.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Edit succesful!");
                        }
                        else
                        {
                            string data = "UPDATE Wizyta SET Data_wizyty=CONVERT(DATETIME,'" + dateTimePicker1.Text + "',120) WHERE Id_wizyty=" + infoVisitLb.Text;
                            con.Open();
                            SqlCommand newvisit = new SqlCommand(data, con);
                            newvisit.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Edit succesful!");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("There already exists a visit for this doctor at given date!");
            }
           
        }
    }
}
