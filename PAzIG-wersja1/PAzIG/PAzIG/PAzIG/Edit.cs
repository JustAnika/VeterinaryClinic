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
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
        }

        private void editBt_Click(object sender, EventArgs e)
        {
            string connection = "Data Source=DESKTOP-BBT1MOF\\CITADEL;Initial Catalog=Przychodnia;Integrated Security=True;Encrypt=False";
            SqlConnection con = new SqlConnection(connection);
            long phone;
            long.TryParse(phoneTB.Text, out phone);
            if (loginTB.Text != "")
            {
                if (firstNameTB.Text != "")
                {
                    if (lastNameTB.Text != "")
                    {
                        if (adressTB.Text != "")
                        {
                            if (phoneTB.Text != "")
                            {
                                if (phone > 0)
                                {
                                    if (petTB.Text != "")
                                    {
                                        if (speciesTB.Text != "")
                                        {
                                            if (sexTB.Text != "")
                                            {
                                                if (sexTB.Text == "K" || sexTB.Text == "M" || sexTB.Text == "N")
                                                {
                                                    if (ageTB.Text != "")
                                                    {
                                                        long age;
                                                        long.TryParse(ageTB.Text, out age);
                                                        if (age > 0)
                                                        {
                                                            if (infoTB.Text != "")
                                                            {
                                                                string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Adres = '" + adressTB.Text + "', Telefon = " + phoneTB.Text + " WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                                string pet = "UPTADE Pacjent SET Imie = '" + petTB.Text + "', Gatunek = '" + speciesTB.Text + "', Plec = '" + sexTB.Text + "', Wiek = '" + ageTB.Text + "', Opis = '" + infoTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "')";
                                                                con.Open();

                                                                SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                                SqlCommand cmdPet = new SqlCommand(pet, con);

                                                                cmdOwner.ExecuteNonQuery();
                                                                cmdPet.ExecuteNonQuery();
                                                            }
                                                            else
                                                            {
                                                                string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Adres = '" + adressTB.Text + "', Telefon = " + phoneTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                                string pet = "UPTADE Pacjent SET Imie = '" + petTB.Text + "', Gatunek = '" + speciesTB.Text + "', Plec = '" + sexTB.Text + "', Wiek = '" + ageTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                                con.Open();

                                                                SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                                SqlCommand cmdPet = new SqlCommand(pet, con);

                                                                cmdOwner.ExecuteNonQuery();
                                                                cmdPet.ExecuteNonQuery();
                                                            }
                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("Please enter correct form of data");
                                                        }
                                                    }
                                                    else
                                                    {
                                                        if (infoTB.Text != "")
                                                        {
                                                            string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Adres = '" + adressTB.Text + "', Telefon = " + phoneTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                            string pet = "UPTADE Pacjent SET Imie = '" + petTB.Text + "', Gatunek = '" + speciesTB.Text + "', Plec = '" + sexTB.Text + "', Opis = '" + infoTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                            con.Open();

                                                            SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                            SqlCommand cmdPet = new SqlCommand(pet, con);

                                                            cmdOwner.ExecuteNonQuery();
                                                            cmdPet.ExecuteNonQuery();
                                                        }
                                                        else
                                                        {
                                                            string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Adres = '" + adressTB.Text + "', Telefon = " + phoneTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                            string pet = "UPTADE Pacjent SET Imie = '" + petTB.Text + "', Gatunek = '" + speciesTB.Text + "', Plec = '" + sexTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                            con.Open();

                                                            SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                            SqlCommand cmdPet = new SqlCommand(pet, con);

                                                            cmdOwner.ExecuteNonQuery();
                                                            cmdPet.ExecuteNonQuery();
                                                        }
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Please enter correct form of data");
                                                }
                                            }
                                            else
                                            {
                                                if (ageTB.Text != "")
                                                {
                                                    long age;
                                                    long.TryParse(ageTB.Text, out age);
                                                    if (age > 0)
                                                    {
                                                        if (infoTB.Text != "")
                                                        {
                                                            string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Adres = '" + adressTB.Text + "', Telefon = " + phoneTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                            string pet = "UPTADE Pacjent SET Imie = '" + petTB.Text + "', Gatunek = '" + speciesTB.Text + "', Wiek = '" + ageTB.Text + "', Opis = '" + infoTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                            con.Open();

                                                            SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                            SqlCommand cmdPet = new SqlCommand(pet, con);

                                                            cmdOwner.ExecuteNonQuery();
                                                            cmdPet.ExecuteNonQuery();
                                                        }
                                                        else
                                                        {
                                                            string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Adres = '" + adressTB.Text + "', Telefon = " + phoneTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                            string pet = "UPTADE Pacjent SET Imie = '" + petTB.Text + "', Gatunek = '" + speciesTB.Text + "', Wiek = '" + ageTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                            con.Open();

                                                            SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                            SqlCommand cmdPet = new SqlCommand(pet, con);

                                                            cmdOwner.ExecuteNonQuery();
                                                            cmdPet.ExecuteNonQuery();
                                                        }
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Please enter correct form of data");
                                                    }
                                                }
                                                else
                                                {
                                                    if (infoTB.Text != "")
                                                    {
                                                        string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Adres = '" + adressTB.Text + "', Telefon = " + phoneTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                        string pet = "UPTADE Pacjent SET Imie = '" + petTB.Text + "', Gatunek = '" + speciesTB.Text + "', Opis = '" + infoTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                        con.Open();

                                                        SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                        SqlCommand cmdPet = new SqlCommand(pet, con);

                                                        cmdOwner.ExecuteNonQuery();
                                                        cmdPet.ExecuteNonQuery();
                                                    }
                                                    else
                                                    {
                                                        string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Adres = '" + adressTB.Text + "', Telefon = " + phoneTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                        string pet = "UPTADE Pacjent SET Imie = '" + petTB.Text + "', Gatunek = '" + speciesTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                        con.Open();

                                                        SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                        SqlCommand cmdPet = new SqlCommand(pet, con);

                                                        cmdOwner.ExecuteNonQuery();
                                                        cmdPet.ExecuteNonQuery();
                                                    }
                                                }
                                            }
                                        }
                                        else
                                        {
                                            if (sexTB.Text != "")
                                            {
                                                if (sexTB.Text == "K" || sexTB.Text == "M" || sexTB.Text == "N")
                                                {
                                                    if (ageTB.Text != "")
                                                    {
                                                        long age;
                                                        long.TryParse(ageTB.Text, out age);
                                                        if (age > 0)
                                                        {
                                                            if (infoTB.Text != "")
                                                            {
                                                                string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Adres = '" + adressTB.Text + "', Telefon = " + phoneTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                                string pet = "UPTADE Pacjent SET Imie = '" + petTB.Text + "', Plec = '" + sexTB.Text + "', Wiek = '" + ageTB.Text + "', Opis = '" + infoTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                                con.Open();

                                                                SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                                SqlCommand cmdPet = new SqlCommand(pet, con);

                                                                cmdOwner.ExecuteNonQuery();
                                                                cmdPet.ExecuteNonQuery();
                                                            }
                                                            else
                                                            {
                                                                string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Adres = '" + adressTB.Text + "', Telefon = " + phoneTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                                string pet = "UPTADE Pacjent SET Imie = '" + petTB.Text + "', Plec = '" + sexTB.Text + "', Wiek = '" + ageTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                                con.Open();

                                                                SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                                SqlCommand cmdPet = new SqlCommand(pet, con);

                                                                cmdOwner.ExecuteNonQuery();
                                                                cmdPet.ExecuteNonQuery();
                                                            }
                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("Please enter correct form of data");
                                                        }
                                                    }
                                                    else
                                                    {
                                                        if (infoTB.Text != "")
                                                        {
                                                            string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Adres = '" + adressTB.Text + "', Telefon = " + phoneTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                            string pet = "UPTADE Pacjent SET Imie = '" + petTB.Text + "', Plec = '" + sexTB.Text + "', Opis = '" + infoTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                            con.Open();

                                                            SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                            SqlCommand cmdPet = new SqlCommand(pet, con);

                                                            cmdOwner.ExecuteNonQuery();
                                                            cmdPet.ExecuteNonQuery();
                                                        }
                                                        else
                                                        {
                                                            string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Adres = '" + adressTB.Text + "', Telefon = " + phoneTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                            string pet = "UPTADE Pacjent SET Imie = '" + petTB.Text + "', Plec = '" + sexTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                            con.Open();

                                                            SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                            SqlCommand cmdPet = new SqlCommand(pet, con);

                                                            cmdOwner.ExecuteNonQuery();
                                                            cmdPet.ExecuteNonQuery();
                                                        }
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Please enter correct form of data");
                                                }
                                            }
                                            else
                                            {
                                                if (ageTB.Text != "")
                                                {
                                                    long age;
                                                    long.TryParse(ageTB.Text, out age);
                                                    if (age > 0)
                                                    {
                                                        if (infoTB.Text != "")
                                                        {
                                                            string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Adres = '" + adressTB.Text + "', Telefon = " + phoneTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                            string pet = "UPTADE Pacjent SET Imie = '" + petTB.Text + "', Wiek = '" + ageTB.Text + "', Opis = '" + infoTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                            con.Open();

                                                            SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                            SqlCommand cmdPet = new SqlCommand(pet, con);

                                                            cmdOwner.ExecuteNonQuery();
                                                            cmdPet.ExecuteNonQuery();
                                                        }
                                                        else
                                                        {
                                                            string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Adres = '" + adressTB.Text + "', Telefon = " + phoneTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                            string pet = "UPTADE Pacjent SET Imie = '" + petTB.Text + "', Wiek = '" + ageTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                            con.Open();

                                                            SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                            SqlCommand cmdPet = new SqlCommand(pet, con);

                                                            cmdOwner.ExecuteNonQuery();
                                                            cmdPet.ExecuteNonQuery();
                                                        }
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Please enter correct form of data");
                                                    }
                                                }
                                                else
                                                {
                                                    if (infoTB.Text != "")
                                                    {
                                                        string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Adres = '" + adressTB.Text + "', Telefon = " + phoneTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                        string pet = "UPTADE Pacjent SET Imie = '" + petTB.Text + "', Opis = '" + infoTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                        con.Open();

                                                        SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                        SqlCommand cmdPet = new SqlCommand(pet, con);

                                                        cmdOwner.ExecuteNonQuery();
                                                        cmdPet.ExecuteNonQuery();
                                                    }
                                                    else
                                                    {
                                                        string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Adres = '" + adressTB.Text + "', Telefon = " + phoneTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                        string pet = "UPTADE Pacjent SET Imie = '" + petTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                        con.Open();

                                                        SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                        SqlCommand cmdPet = new SqlCommand(pet, con);

                                                        cmdOwner.ExecuteNonQuery();
                                                        cmdPet.ExecuteNonQuery();
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (speciesTB.Text != "")
                                        {
                                            if (sexTB.Text != "")
                                            {
                                                if (sexTB.Text == "K" || sexTB.Text == "M" || sexTB.Text == "N")
                                                {
                                                    if (ageTB.Text != "")
                                                    {
                                                        long age;
                                                        long.TryParse(ageTB.Text, out age);
                                                        if (age > 0)
                                                        {
                                                            if (infoTB.Text != "")
                                                            {
                                                                string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Adres = '" + adressTB.Text + "', Telefon = " + phoneTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                                string pet = "UPTADE Pacjent SET Gatunek = '" + speciesTB.Text + "', Plec = '" + sexTB.Text + "', Wiek = '" + ageTB.Text + "', Opis = '" + infoTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                                con.Open();

                                                                SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                                SqlCommand cmdPet = new SqlCommand(pet, con);

                                                                cmdOwner.ExecuteNonQuery();
                                                                cmdPet.ExecuteNonQuery();
                                                            }
                                                            else
                                                            {
                                                                string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Adres = '" + adressTB.Text + "', Telefon = " + phoneTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                                string pet = "UPTADE Pacjent SET Gatunek = '" + speciesTB.Text + "', Plec = '" + sexTB.Text + "', Wiek = '" + ageTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                                con.Open();

                                                                SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                                SqlCommand cmdPet = new SqlCommand(pet, con);

                                                                cmdOwner.ExecuteNonQuery();
                                                                cmdPet.ExecuteNonQuery();
                                                            }
                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("Please enter correct form of data");
                                                        }
                                                    }
                                                    else
                                                    {
                                                        if (infoTB.Text != "")
                                                        {
                                                            string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Adres = '" + adressTB.Text + "', Telefon = " + phoneTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                            string pet = "UPTADE Pacjent SET Gatunek = '" + speciesTB.Text + "', Plec = '" + sexTB.Text + "', Opis = '" + infoTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                            con.Open();

                                                            SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                            SqlCommand cmdPet = new SqlCommand(pet, con);

                                                            cmdOwner.ExecuteNonQuery();
                                                            cmdPet.ExecuteNonQuery();
                                                        }
                                                        else
                                                        {
                                                            string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Adres = '" + adressTB.Text + "', Telefon = " + phoneTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                            string pet = "UPTADE Pacjent SET Gatunek = '" + speciesTB.Text + "', Plec = '" + sexTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                            con.Open();

                                                            SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                            SqlCommand cmdPet = new SqlCommand(pet, con);

                                                            cmdOwner.ExecuteNonQuery();
                                                            cmdPet.ExecuteNonQuery();
                                                        }
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Please enter correct form of data");
                                                }
                                            }
                                            else
                                            {
                                                if (ageTB.Text != "")
                                                {
                                                    long age;
                                                    long.TryParse(ageTB.Text, out age);
                                                    if (age > 0)
                                                    {
                                                        if (infoTB.Text != "")
                                                        {
                                                            string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Adres = '" + adressTB.Text + "', Telefon = " + phoneTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                            string pet = "UPTADE Pacjent SET Gatunek = '" + speciesTB.Text + "', Wiek = '" + ageTB.Text + "', Opis = '" + infoTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                            con.Open();

                                                            SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                            SqlCommand cmdPet = new SqlCommand(pet, con);

                                                            cmdOwner.ExecuteNonQuery();
                                                            cmdPet.ExecuteNonQuery();
                                                        }
                                                        else
                                                        {
                                                            string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Adres = '" + adressTB.Text + "', Telefon = " + phoneTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                            string pet = "UPTADE Pacjent SET Gatunek = '" + speciesTB.Text + "', Wiek = '" + ageTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                            con.Open();

                                                            SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                            SqlCommand cmdPet = new SqlCommand(pet, con);

                                                            cmdOwner.ExecuteNonQuery();
                                                            cmdPet.ExecuteNonQuery();
                                                        }
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Please enter correct form of data");
                                                    }
                                                }
                                                else
                                                {
                                                    if (infoTB.Text != "")
                                                    {
                                                        string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Adres = '" + adressTB.Text + "', Telefon = " + phoneTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                        string pet = "UPTADE Pacjent SET Gatunek = '" + speciesTB.Text + "', Opis = '" + infoTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                        con.Open();

                                                        SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                        SqlCommand cmdPet = new SqlCommand(pet, con);

                                                        cmdOwner.ExecuteNonQuery();
                                                        cmdPet.ExecuteNonQuery();
                                                    }
                                                    else
                                                    {
                                                        string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Adres = '" + adressTB.Text + "', Telefon = " + phoneTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                        string pet = "UPTADE Pacjent SET Gatunek = '" + speciesTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                        con.Open();

                                                        SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                        SqlCommand cmdPet = new SqlCommand(pet, con);

                                                        cmdOwner.ExecuteNonQuery();
                                                        cmdPet.ExecuteNonQuery();
                                                    }
                                                }
                                            }
                                        }
                                        else
                                        {
                                            if (sexTB.Text != "")
                                            {
                                                if (sexTB.Text == "K" || sexTB.Text == "M" || sexTB.Text == "N")
                                                {
                                                    if (ageTB.Text != "")
                                                    {
                                                        long age;
                                                        long.TryParse(ageTB.Text, out age);
                                                        if (age > 0)
                                                        {
                                                            if (infoTB.Text != "")
                                                            {
                                                                string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Adres = '" + adressTB.Text + "', Telefon = " + phoneTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                                string pet = "UPTADE Pacjent SET Plec = '" + sexTB.Text + "', Wiek = '" + ageTB.Text + "', Opis = '" + infoTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                                con.Open();

                                                                SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                                SqlCommand cmdPet = new SqlCommand(pet, con);

                                                                cmdOwner.ExecuteNonQuery();
                                                                cmdPet.ExecuteNonQuery();
                                                            }
                                                            else
                                                            {
                                                                string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Adres = '" + adressTB.Text + "', Telefon = " + phoneTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                                string pet = "UPTADE Pacjent SET Plec = '" + sexTB.Text + "', Wiek = '" + ageTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                                con.Open();

                                                                SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                                SqlCommand cmdPet = new SqlCommand(pet, con);

                                                                cmdOwner.ExecuteNonQuery();
                                                                cmdPet.ExecuteNonQuery();
                                                            }
                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("Please enter correct form of data");
                                                        }
                                                    }
                                                    else
                                                    {
                                                        if (infoTB.Text != "")
                                                        {
                                                            string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Adres = '" + adressTB.Text + "', Telefon = " + phoneTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                            string pet = "UPTADE Pacjent SET Plec = '" + sexTB.Text + "', Opis = '" + infoTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                            con.Open();

                                                            SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                            SqlCommand cmdPet = new SqlCommand(pet, con);

                                                            cmdOwner.ExecuteNonQuery();
                                                            cmdPet.ExecuteNonQuery();
                                                        }
                                                        else
                                                        {
                                                            string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Adres = '" + adressTB.Text + "', Telefon = " + phoneTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                            string pet = "UPTADE Pacjent SET Plec = '" + sexTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                            con.Open();

                                                            SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                            SqlCommand cmdPet = new SqlCommand(pet, con);

                                                            cmdOwner.ExecuteNonQuery();
                                                            cmdPet.ExecuteNonQuery();
                                                        }
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Please enter correct form of data");
                                                }
                                            }
                                            else
                                            {
                                                if (ageTB.Text != "")
                                                {
                                                    long age;
                                                    long.TryParse(ageTB.Text, out age);
                                                    if (age > 0)
                                                    {
                                                        if (infoTB.Text != "")
                                                        {
                                                            string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Adres = '" + adressTB.Text + "', Telefon = " + phoneTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                            string pet = "UPTADE Pacjent SET Wiek = '" + ageTB.Text + "', Opis = '" + infoTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                            con.Open();

                                                            SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                            SqlCommand cmdPet = new SqlCommand(pet, con);

                                                            cmdOwner.ExecuteNonQuery();
                                                            cmdPet.ExecuteNonQuery();
                                                        }
                                                        else
                                                        {
                                                            string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Adres = '" + adressTB.Text + "', Telefon = " + phoneTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                            string pet = "UPTADE Pacjent SET Wiek = '" + ageTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                            con.Open();

                                                            SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                            SqlCommand cmdPet = new SqlCommand(pet, con);

                                                            cmdOwner.ExecuteNonQuery();
                                                            cmdPet.ExecuteNonQuery();
                                                        }
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Please enter correct form of data");
                                                    }
                                                }
                                                else
                                                {
                                                    if (infoTB.Text != "")
                                                    {
                                                        string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Adres = '" + adressTB.Text + "', Telefon = " + phoneTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                        string pet = "UPTADE Pacjent SET Opis = '" + infoTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                        con.Open();

                                                        SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                        SqlCommand cmdPet = new SqlCommand(pet, con);

                                                        cmdOwner.ExecuteNonQuery();
                                                        cmdPet.ExecuteNonQuery();
                                                    }
                                                    else
                                                    {
                                                        string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Adres = '" + adressTB.Text + "', Telefon = " + phoneTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";                                                       
                                                        con.Open();

                                                        SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                        cmdOwner.ExecuteNonQuery();
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Please enter correct form of data");
                                }
                            }
                            else
                            {
                                if (petTB.Text != "")
                                {
                                    if (speciesTB.Text != "")
                                    {
                                        if (sexTB.Text != "")
                                        {
                                            if (sexTB.Text == "K" || sexTB.Text == "M" || sexTB.Text == "N")
                                            {
                                                if (ageTB.Text != "")
                                                {
                                                    long age;
                                                    long.TryParse(ageTB.Text, out age);
                                                    if (age > 0)
                                                    {
                                                        if (infoTB.Text != "")
                                                        {
                                                            string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Adres = '" + adressTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                            string pet = "UPTADE Pacjent SET Imie = '" + petTB.Text + "', Gatunek = '" + speciesTB.Text + "', Plec = '" + sexTB.Text + "', Wiek = '" + ageTB.Text + "', Opis = '" + infoTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                            con.Open();

                                                            SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                            SqlCommand cmdPet = new SqlCommand(pet, con);

                                                            cmdOwner.ExecuteNonQuery();
                                                            cmdPet.ExecuteNonQuery();
                                                        }
                                                        else
                                                        {
                                                            string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Adres = '" + adressTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                            string pet = "UPTADE Pacjent SET Imie = '" + petTB.Text + "', Gatunek = '" + speciesTB.Text + "', Plec = '" + sexTB.Text + "', Wiek = '" + ageTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                            con.Open();

                                                            SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                            SqlCommand cmdPet = new SqlCommand(pet, con);

                                                            cmdOwner.ExecuteNonQuery();
                                                            cmdPet.ExecuteNonQuery();
                                                        }
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Please enter correct form of data");
                                                    }
                                                }
                                                else
                                                {
                                                    if (infoTB.Text != "")
                                                    {
                                                        string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Adres = '" + adressTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                        string pet = "UPTADE Pacjent SET Imie = '" + petTB.Text + "', Gatunek = '" + speciesTB.Text + "', Plec = '" + sexTB.Text + "', Opis = '" + infoTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                        con.Open();

                                                        SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                        SqlCommand cmdPet = new SqlCommand(pet, con);

                                                        cmdOwner.ExecuteNonQuery();
                                                        cmdPet.ExecuteNonQuery();
                                                    }
                                                    else
                                                    {
                                                        string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Adres = '" + adressTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                        string pet = "UPTADE Pacjent SET Imie = '" + petTB.Text + "', Gatunek = '" + speciesTB.Text + "', Plec = '" + sexTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                        con.Open();

                                                        SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                        SqlCommand cmdPet = new SqlCommand(pet, con);

                                                        cmdOwner.ExecuteNonQuery();
                                                        cmdPet.ExecuteNonQuery();
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Please enter correct form of data");
                                            }
                                        }
                                        else
                                        {
                                            if (ageTB.Text != "")
                                            {
                                                long age;
                                                long.TryParse(ageTB.Text, out age);
                                                if (age > 0)
                                                {
                                                    if (infoTB.Text != "")
                                                    {
                                                        string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Adres = '" + adressTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                        string pet = "UPTADE Pacjent SET Imie = '" + petTB.Text + "', Gatunek = '" + speciesTB.Text + "', Wiek = '" + ageTB.Text + "', Opis = '" + infoTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                        con.Open();

                                                        SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                        SqlCommand cmdPet = new SqlCommand(pet, con);

                                                        cmdOwner.ExecuteNonQuery();
                                                        cmdPet.ExecuteNonQuery();
                                                    }
                                                    else
                                                    {
                                                        string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Adres = '" + adressTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                        string pet = "UPTADE Pacjent SET Imie = '" + petTB.Text + "', Gatunek = '" + speciesTB.Text + "', Wiek = '" + ageTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                        con.Open();

                                                        SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                        SqlCommand cmdPet = new SqlCommand(pet, con);

                                                        cmdOwner.ExecuteNonQuery();
                                                        cmdPet.ExecuteNonQuery();
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Please enter correct form of data");
                                                }
                                            }
                                            else
                                            {
                                                if (infoTB.Text != "")
                                                {
                                                    string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Adres = '" + adressTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                    string pet = "UPTADE Pacjent SET Imie = '" + petTB.Text + "', Gatunek = '" + speciesTB.Text + "', Opis = '" + infoTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                    con.Open();

                                                    SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                    SqlCommand cmdPet = new SqlCommand(pet, con);

                                                    cmdOwner.ExecuteNonQuery();
                                                    cmdPet.ExecuteNonQuery();
                                                }
                                                else
                                                {
                                                    string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Adres = '" + adressTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                    string pet = "UPTADE Pacjent SET Imie = '" + petTB.Text + "', Gatunek = '" + speciesTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                    con.Open();

                                                    SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                    SqlCommand cmdPet = new SqlCommand(pet, con);

                                                    cmdOwner.ExecuteNonQuery();
                                                    cmdPet.ExecuteNonQuery();
                                                }
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (sexTB.Text != "")
                                        {
                                            if (sexTB.Text == "K" || sexTB.Text == "M" || sexTB.Text == "N")
                                            {
                                                if (ageTB.Text != "")
                                                {
                                                    long age;
                                                    long.TryParse(ageTB.Text, out age);
                                                    if (age > 0)
                                                    {
                                                        if (infoTB.Text != "")
                                                        {
                                                            string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Adres = '" + adressTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                            string pet = "UPTADE Pacjent SET Imie = '" + petTB.Text + "', Plec = '" + sexTB.Text + "', Wiek = '" + ageTB.Text + "', Opis = '" + infoTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                            con.Open();

                                                            SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                            SqlCommand cmdPet = new SqlCommand(pet, con);

                                                            cmdOwner.ExecuteNonQuery();
                                                            cmdPet.ExecuteNonQuery();
                                                        }
                                                        else
                                                        {
                                                            string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Adres = '" + adressTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                            string pet = "UPTADE Pacjent SET Imie = '" + petTB.Text + "', Plec = '" + sexTB.Text + "', Wiek = '" + ageTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                            con.Open();

                                                            SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                            SqlCommand cmdPet = new SqlCommand(pet, con);

                                                            cmdOwner.ExecuteNonQuery();
                                                            cmdPet.ExecuteNonQuery();
                                                        }
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Please enter correct form of data");
                                                    }
                                                }
                                                else
                                                {
                                                    if (infoTB.Text != "")
                                                    {
                                                        string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Adres = '" + adressTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                        string pet = "UPTADE Pacjent SET Imie = '" + petTB.Text + "', Plec = '" + sexTB.Text + "', Opis = '" + infoTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                        con.Open();

                                                        SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                        SqlCommand cmdPet = new SqlCommand(pet, con);

                                                        cmdOwner.ExecuteNonQuery();
                                                        cmdPet.ExecuteNonQuery();
                                                    }
                                                    else
                                                    {
                                                        string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Adres = '" + adressTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                        string pet = "UPTADE Pacjent SET Imie = '" + petTB.Text + "', Plec = '" + sexTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                        con.Open();

                                                        SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                        SqlCommand cmdPet = new SqlCommand(pet, con);

                                                        cmdOwner.ExecuteNonQuery();
                                                        cmdPet.ExecuteNonQuery();
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Please enter correct form of data");
                                            }
                                        }
                                        else
                                        {
                                            if (ageTB.Text != "")
                                            {
                                                long age;
                                                long.TryParse(ageTB.Text, out age);
                                                if (age > 0)
                                                {
                                                    if (infoTB.Text != "")
                                                    {
                                                        string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Adres = '" + adressTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                        string pet = "UPTADE Pacjent SET Imie = '" + petTB.Text + "', Wiek = '" + ageTB.Text + "', Opis = '" + infoTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                        con.Open();

                                                        SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                        SqlCommand cmdPet = new SqlCommand(pet, con);

                                                        cmdOwner.ExecuteNonQuery();
                                                        cmdPet.ExecuteNonQuery();
                                                    }
                                                    else
                                                    {
                                                        string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Adres = '" + adressTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                        string pet = "UPTADE Pacjent SET Imie = '" + petTB.Text + "', Wiek = '" + ageTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                        con.Open();

                                                        SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                        SqlCommand cmdPet = new SqlCommand(pet, con);

                                                        cmdOwner.ExecuteNonQuery();
                                                        cmdPet.ExecuteNonQuery();
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Please enter correct form of data");
                                                }
                                            }
                                            else
                                            {
                                                if (infoTB.Text != "")
                                                {
                                                    string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Adres = '" + adressTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                    string pet = "UPTADE Pacjent SET Imie = '" + petTB.Text + "', Opis = '" + infoTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                    con.Open();

                                                    SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                    SqlCommand cmdPet = new SqlCommand(pet, con);

                                                    cmdOwner.ExecuteNonQuery();
                                                    cmdPet.ExecuteNonQuery();
                                                }
                                                else
                                                {
                                                    string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Adres = '" + adressTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                    string pet = "UPTADE Pacjent SET Imie = '" + petTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                    con.Open();

                                                    SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                    SqlCommand cmdPet = new SqlCommand(pet, con);

                                                    cmdOwner.ExecuteNonQuery();
                                                    cmdPet.ExecuteNonQuery();
                                                }
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    if (speciesTB.Text != "")
                                    {
                                        if (sexTB.Text != "")
                                        {
                                            if (sexTB.Text == "K" || sexTB.Text == "M" || sexTB.Text == "N")
                                            {
                                                if (ageTB.Text != "")
                                                {
                                                    long age;
                                                    long.TryParse(ageTB.Text, out age);
                                                    if (age > 0)
                                                    {
                                                        if (infoTB.Text != "")
                                                        {
                                                            string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Adres = '" + adressTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                            string pet = "UPTADE Pacjent SET Gatunek = '" + speciesTB.Text + "', Plec = '" + sexTB.Text + "', Wiek = '" + ageTB.Text + "', Opis = '" + infoTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                            con.Open();

                                                            SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                            SqlCommand cmdPet = new SqlCommand(pet, con);

                                                            cmdOwner.ExecuteNonQuery();
                                                            cmdPet.ExecuteNonQuery();
                                                        }
                                                        else
                                                        {
                                                            string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Adres = '" + adressTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                            string pet = "UPTADE Pacjent SET Gatunek = '" + speciesTB.Text + "', Plec = '" + sexTB.Text + "', Wiek = '" + ageTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                            con.Open();

                                                            SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                            SqlCommand cmdPet = new SqlCommand(pet, con);

                                                            cmdOwner.ExecuteNonQuery();
                                                            cmdPet.ExecuteNonQuery();
                                                        }
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Please enter correct form of data");
                                                    }
                                                }
                                                else
                                                {
                                                    if (infoTB.Text != "")
                                                    {
                                                        string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Adres = '" + adressTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                        string pet = "UPTADE Pacjent SET Gatunek = '" + speciesTB.Text + "', Plec = '" + sexTB.Text + "', Opis = '" + infoTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                        con.Open();

                                                        SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                        SqlCommand cmdPet = new SqlCommand(pet, con);

                                                        cmdOwner.ExecuteNonQuery();
                                                        cmdPet.ExecuteNonQuery();
                                                    }
                                                    else
                                                    {
                                                        string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Adres = '" + adressTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                        string pet = "UPTADE Pacjent SET Gatunek = '" + speciesTB.Text + "', Plec = '" + sexTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                        con.Open();

                                                        SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                        SqlCommand cmdPet = new SqlCommand(pet, con);

                                                        cmdOwner.ExecuteNonQuery();
                                                        cmdPet.ExecuteNonQuery();
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Please enter correct form of data");
                                            }
                                        }
                                        else
                                        {
                                            if (ageTB.Text != "")
                                            {
                                                long age;
                                                long.TryParse(ageTB.Text, out age);
                                                if (age > 0)
                                                {
                                                    if (infoTB.Text != "")
                                                    {
                                                        string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Adres = '" + adressTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                        string pet = "UPTADE Pacjent SET Gatunek = '" + speciesTB.Text + "', Wiek = '" + ageTB.Text + "', Opis = '" + infoTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                        con.Open();

                                                        SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                        SqlCommand cmdPet = new SqlCommand(pet, con);

                                                        cmdOwner.ExecuteNonQuery();
                                                        cmdPet.ExecuteNonQuery();
                                                    }
                                                    else
                                                    {
                                                        string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Adres = '" + adressTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                        string pet = "UPTADE Pacjent SET Gatunek = '" + speciesTB.Text + "', Wiek = '" + ageTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                        con.Open();

                                                        SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                        SqlCommand cmdPet = new SqlCommand(pet, con);

                                                        cmdOwner.ExecuteNonQuery();
                                                        cmdPet.ExecuteNonQuery();
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Please enter correct form of data");
                                                }
                                            }
                                            else
                                            {
                                                if (infoTB.Text != "")
                                                {
                                                    string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Adres = '" + adressTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                    string pet = "UPTADE Pacjent SET Gatunek = '" + speciesTB.Text + "', Opis = '" + infoTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                    con.Open();

                                                    SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                    SqlCommand cmdPet = new SqlCommand(pet, con);

                                                    cmdOwner.ExecuteNonQuery();
                                                    cmdPet.ExecuteNonQuery();
                                                }
                                                else
                                                {
                                                    string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Adres = '" + adressTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                    string pet = "UPTADE Pacjent SET Gatunek = '" + speciesTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                    con.Open();

                                                    SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                    SqlCommand cmdPet = new SqlCommand(pet, con);

                                                    cmdOwner.ExecuteNonQuery();
                                                    cmdPet.ExecuteNonQuery();
                                                }
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (sexTB.Text != "")
                                        {
                                            if (sexTB.Text == "K" || sexTB.Text == "M" || sexTB.Text == "N")
                                            {
                                                if (ageTB.Text != "")
                                                {
                                                    long age;
                                                    long.TryParse(ageTB.Text, out age);
                                                    if (age > 0)
                                                    {
                                                        if (infoTB.Text != "")
                                                        {
                                                            string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Adres = '" + adressTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                            string pet = "UPTADE Pacjent SET Plec = '" + sexTB.Text + "', Wiek = '" + ageTB.Text + "', Opis = '" + infoTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                            con.Open();

                                                            SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                            SqlCommand cmdPet = new SqlCommand(pet, con);

                                                            cmdOwner.ExecuteNonQuery();
                                                            cmdPet.ExecuteNonQuery();
                                                        }
                                                        else
                                                        {
                                                            string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Adres = '" + adressTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                            string pet = "UPTADE Pacjent SET Plec = '" + sexTB.Text + "', Wiek = '" + ageTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                            con.Open();

                                                            SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                            SqlCommand cmdPet = new SqlCommand(pet, con);

                                                            cmdOwner.ExecuteNonQuery();
                                                            cmdPet.ExecuteNonQuery();
                                                        }
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Please enter correct form of data");
                                                    }
                                                }
                                                else
                                                {
                                                    if (infoTB.Text != "")
                                                    {
                                                        string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Adres = '" + adressTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                        string pet = "UPTADE Pacjent SET Plec = '" + sexTB.Text + "', Opis = '" + infoTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                        con.Open();

                                                        SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                        SqlCommand cmdPet = new SqlCommand(pet, con);

                                                        cmdOwner.ExecuteNonQuery();
                                                        cmdPet.ExecuteNonQuery();
                                                    }
                                                    else
                                                    {
                                                        string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Adres = '" + adressTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                        string pet = "UPTADE Pacjent SET Plec = '" + sexTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                        con.Open();

                                                        SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                        SqlCommand cmdPet = new SqlCommand(pet, con);

                                                        cmdOwner.ExecuteNonQuery();
                                                        cmdPet.ExecuteNonQuery();
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Please enter correct form of data");
                                            }
                                        }
                                        else
                                        {
                                            if (ageTB.Text != "")
                                            {
                                                long age;
                                                long.TryParse(ageTB.Text, out age);
                                                if (age > 0)
                                                {
                                                    if (infoTB.Text != "")
                                                    {
                                                        string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Adres = '" + adressTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                        string pet = "UPTADE Pacjent SET Wiek = '" + ageTB.Text + "', Opis = '" + infoTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                        con.Open();

                                                        SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                        SqlCommand cmdPet = new SqlCommand(pet, con);

                                                        cmdOwner.ExecuteNonQuery();
                                                        cmdPet.ExecuteNonQuery();
                                                    }
                                                    else
                                                    {
                                                        string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Adres = '" + adressTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                        string pet = "UPTADE Pacjent SET Wiek = '" + ageTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                        con.Open();

                                                        SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                        SqlCommand cmdPet = new SqlCommand(pet, con);

                                                        cmdOwner.ExecuteNonQuery();
                                                        cmdPet.ExecuteNonQuery();
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Please enter correct form of data");
                                                }
                                            }
                                            else
                                            {
                                                if (infoTB.Text != "")
                                                {
                                                    string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Adres = '" + adressTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                    string pet = "UPTADE Pacjent SET Opis = '" + infoTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                    con.Open();

                                                    SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                    SqlCommand cmdPet = new SqlCommand(pet, con);

                                                    cmdOwner.ExecuteNonQuery();
                                                    cmdPet.ExecuteNonQuery();
                                                }
                                                else
                                                {
                                                    string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Adres = '" + adressTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                    con.Open();

                                                    SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                    cmdOwner.ExecuteNonQuery();
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            if (phoneTB.Text != "")
                            {
                                if (phone > 0)
                                {
                                    if (petTB.Text != "")
                                    {
                                        if (speciesTB.Text != "")
                                        {
                                            if (sexTB.Text != "")
                                            {
                                                if (sexTB.Text == "K" || sexTB.Text == "M" || sexTB.Text == "N")
                                                {
                                                    if (ageTB.Text != "")
                                                    {
                                                        long age;
                                                        long.TryParse(ageTB.Text, out age);
                                                        if (age > 0)
                                                        {
                                                            if (infoTB.Text != "")
                                                            {
                                                                string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Telefon = " + phoneTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                                string pet = "UPTADE Pacjent SET Imie = '" + petTB.Text + "', Gatunek = '" + speciesTB.Text + "', Plec = '" + sexTB.Text + "', Wiek = '" + ageTB.Text + "', Opis = '" + infoTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                                con.Open();

                                                                SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                                SqlCommand cmdPet = new SqlCommand(pet, con);

                                                                cmdOwner.ExecuteNonQuery();
                                                                cmdPet.ExecuteNonQuery();
                                                            }
                                                            else
                                                            {
                                                                string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Telefon = " + phoneTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                                string pet = "UPTADE Pacjent SET Imie = '" + petTB.Text + "', Gatunek = '" + speciesTB.Text + "', Plec = '" + sexTB.Text + "', Wiek = '" + ageTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                                con.Open();

                                                                SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                                SqlCommand cmdPet = new SqlCommand(pet, con);

                                                                cmdOwner.ExecuteNonQuery();
                                                                cmdPet.ExecuteNonQuery();
                                                            }
                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("Please enter correct form of data");
                                                        }
                                                    }
                                                    else
                                                    {
                                                        if (infoTB.Text != "")
                                                        {
                                                            string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Telefon = " + phoneTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                            string pet = "UPTADE Pacjent SET Imie = '" + petTB.Text + "', Gatunek = '" + speciesTB.Text + "', Plec = '" + sexTB.Text + "', Opis = '" + infoTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                            con.Open();

                                                            SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                            SqlCommand cmdPet = new SqlCommand(pet, con);

                                                            cmdOwner.ExecuteNonQuery();
                                                            cmdPet.ExecuteNonQuery();
                                                        }
                                                        else
                                                        {
                                                            string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Telefon = " + phoneTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                            string pet = "UPTADE Pacjent SET Imie = '" + petTB.Text + "', Gatunek = '" + speciesTB.Text + "', Plec = '" + sexTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                            con.Open();

                                                            SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                            SqlCommand cmdPet = new SqlCommand(pet, con);

                                                            cmdOwner.ExecuteNonQuery();
                                                            cmdPet.ExecuteNonQuery();
                                                        }
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Please enter correct form of data");
                                                }
                                            }
                                            else
                                            {
                                                if (ageTB.Text != "")
                                                {
                                                    long age;
                                                    long.TryParse(ageTB.Text, out age);
                                                    if (age > 0)
                                                    {
                                                        if (infoTB.Text != "")
                                                        {
                                                            string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Telefon = " + phoneTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                            string pet = "UPTADE Pacjent SET Imie = '" + petTB.Text + "', Gatunek = '" + speciesTB.Text + "', Wiek = '" + ageTB.Text + "', Opis = '" + infoTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                            con.Open();

                                                            SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                            SqlCommand cmdPet = new SqlCommand(pet, con);

                                                            cmdOwner.ExecuteNonQuery();
                                                            cmdPet.ExecuteNonQuery();
                                                        }
                                                        else
                                                        {
                                                            string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Telefon = " + phoneTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                            string pet = "UPTADE Pacjent SET Imie = '" + petTB.Text + "', Gatunek = '" + speciesTB.Text + "', Wiek = '" + ageTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                            con.Open();

                                                            SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                            SqlCommand cmdPet = new SqlCommand(pet, con);

                                                            cmdOwner.ExecuteNonQuery();
                                                            cmdPet.ExecuteNonQuery();
                                                        }
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Please enter correct form of data");
                                                    }
                                                }
                                                else
                                                {
                                                    if (infoTB.Text != "")
                                                    {
                                                        string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Telefon = " + phoneTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                        string pet = "UPTADE Pacjent SET Imie = '" + petTB.Text + "', Gatunek = '" + speciesTB.Text + "', Opis = '" + infoTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                        con.Open();

                                                        SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                        SqlCommand cmdPet = new SqlCommand(pet, con);

                                                        cmdOwner.ExecuteNonQuery();
                                                        cmdPet.ExecuteNonQuery();
                                                    }
                                                    else
                                                    {
                                                        string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Telefon = " + phoneTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                        string pet = "UPTADE Pacjent SET Imie = '" + petTB.Text + "', Gatunek = '" + speciesTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                        con.Open();

                                                        SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                        SqlCommand cmdPet = new SqlCommand(pet, con);

                                                        cmdOwner.ExecuteNonQuery();
                                                        cmdPet.ExecuteNonQuery();
                                                    }
                                                }
                                            }
                                        }
                                        else
                                        {
                                            if (sexTB.Text != "")
                                            {
                                                if (sexTB.Text == "K" || sexTB.Text == "M" || sexTB.Text == "N")
                                                {
                                                    if (ageTB.Text != "")
                                                    {
                                                        long age;
                                                        long.TryParse(ageTB.Text, out age);
                                                        if (age > 0)
                                                        {
                                                            if (infoTB.Text != "")
                                                            {
                                                                string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Telefon = " + phoneTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                                string pet = "UPTADE Pacjent SET Imie = '" + petTB.Text + "', Plec = '" + sexTB.Text + "', Wiek = '" + ageTB.Text + "', Opis = '" + infoTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                                con.Open();

                                                                SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                                SqlCommand cmdPet = new SqlCommand(pet, con);

                                                                cmdOwner.ExecuteNonQuery();
                                                                cmdPet.ExecuteNonQuery();
                                                            }
                                                            else
                                                            {
                                                                string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Telefon = " + phoneTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                                string pet = "UPTADE Pacjent SET Imie = '" + petTB.Text + "', Plec = '" + sexTB.Text + "', Wiek = '" + ageTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                                con.Open();

                                                                SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                                SqlCommand cmdPet = new SqlCommand(pet, con);

                                                                cmdOwner.ExecuteNonQuery();
                                                                cmdPet.ExecuteNonQuery();
                                                            }
                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("Please enter correct form of data");
                                                        }
                                                    }
                                                    else
                                                    {
                                                        if (infoTB.Text != "")
                                                        {
                                                            string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Telefon = " + phoneTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                            string pet = "UPTADE Pacjent SET Imie = '" + petTB.Text + "', Plec = '" + sexTB.Text + "', Opis = '" + infoTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                            con.Open();

                                                            SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                            SqlCommand cmdPet = new SqlCommand(pet, con);

                                                            cmdOwner.ExecuteNonQuery();
                                                            cmdPet.ExecuteNonQuery();
                                                        }
                                                        else
                                                        {
                                                            string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Telefon = " + phoneTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                            string pet = "UPTADE Pacjent SET Imie = '" + petTB.Text + "', Plec = '" + sexTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                            con.Open();

                                                            SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                            SqlCommand cmdPet = new SqlCommand(pet, con);

                                                            cmdOwner.ExecuteNonQuery();
                                                            cmdPet.ExecuteNonQuery();
                                                        }
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Please enter correct form of data");
                                                }
                                            }
                                            else
                                            {
                                                if (ageTB.Text != "")
                                                {
                                                    long age;
                                                    long.TryParse(ageTB.Text, out age);
                                                    if (age > 0)
                                                    {
                                                        if (infoTB.Text != "")
                                                        {
                                                            string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Telefon = " + phoneTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                            string pet = "UPTADE Pacjent SET Imie = '" + petTB.Text + "', Wiek = '" + ageTB.Text + "', Opis = '" + infoTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                            con.Open();

                                                            SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                            SqlCommand cmdPet = new SqlCommand(pet, con);

                                                            cmdOwner.ExecuteNonQuery();
                                                            cmdPet.ExecuteNonQuery();
                                                        }
                                                        else
                                                        {
                                                            string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Telefon = " + phoneTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                            string pet = "UPTADE Pacjent SET Imie = '" + petTB.Text + "', Wiek = '" + ageTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                            con.Open();

                                                            SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                            SqlCommand cmdPet = new SqlCommand(pet, con);

                                                            cmdOwner.ExecuteNonQuery();
                                                            cmdPet.ExecuteNonQuery();
                                                        }
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Please enter correct form of data");
                                                    }
                                                }
                                                else
                                                {
                                                    if (infoTB.Text != "")
                                                    {
                                                        string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Telefon = " + phoneTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                        string pet = "UPTADE Pacjent SET Imie = '" + petTB.Text + "', Opis = '" + infoTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                        con.Open();

                                                        SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                        SqlCommand cmdPet = new SqlCommand(pet, con);

                                                        cmdOwner.ExecuteNonQuery();
                                                        cmdPet.ExecuteNonQuery();
                                                    }
                                                    else
                                                    {
                                                        string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Telefon = " + phoneTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                        string pet = "UPTADE Pacjent SET Imie = '" + petTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                        con.Open();

                                                        SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                        SqlCommand cmdPet = new SqlCommand(pet, con);

                                                        cmdOwner.ExecuteNonQuery();
                                                        cmdPet.ExecuteNonQuery();
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (speciesTB.Text != "")
                                        {
                                            if (sexTB.Text != "")
                                            {
                                                if (sexTB.Text == "K" || sexTB.Text == "M" || sexTB.Text == "N")
                                                {
                                                    if (ageTB.Text != "")
                                                    {
                                                        long age;
                                                        long.TryParse(ageTB.Text, out age);
                                                        if (age > 0)
                                                        {
                                                            if (infoTB.Text != "")
                                                            {
                                                                string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Telefon = " + phoneTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                                string pet = "UPTADE Pacjent SET Gatunek = '" + speciesTB.Text + "', Plec = '" + sexTB.Text + "', Wiek = '" + ageTB.Text + "', Opis = '" + infoTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                                con.Open();

                                                                SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                                SqlCommand cmdPet = new SqlCommand(pet, con);

                                                                cmdOwner.ExecuteNonQuery();
                                                                cmdPet.ExecuteNonQuery();
                                                            }
                                                            else
                                                            {
                                                                string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Telefon = " + phoneTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                                string pet = "UPTADE Pacjent SET Gatunek = '" + speciesTB.Text + "', Plec = '" + sexTB.Text + "', Wiek = '" + ageTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                                con.Open();

                                                                SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                                SqlCommand cmdPet = new SqlCommand(pet, con);

                                                                cmdOwner.ExecuteNonQuery();
                                                                cmdPet.ExecuteNonQuery();
                                                            }
                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("Please enter correct form of data");
                                                        }
                                                    }
                                                    else
                                                    {
                                                        if (infoTB.Text != "")
                                                        {
                                                            string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Telefon = " + phoneTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                            string pet = "UPTADE Pacjent SET Gatunek = '" + speciesTB.Text + "', Plec = '" + sexTB.Text + "', Opis = '" + infoTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                            con.Open();

                                                            SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                            SqlCommand cmdPet = new SqlCommand(pet, con);

                                                            cmdOwner.ExecuteNonQuery();
                                                            cmdPet.ExecuteNonQuery();
                                                        }
                                                        else
                                                        {
                                                            string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Telefon = " + phoneTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                            string pet = "UPTADE Pacjent SET Gatunek = '" + speciesTB.Text + "', Plec = '" + sexTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                            con.Open();

                                                            SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                            SqlCommand cmdPet = new SqlCommand(pet, con);

                                                            cmdOwner.ExecuteNonQuery();
                                                            cmdPet.ExecuteNonQuery();
                                                        }
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Please enter correct form of data");
                                                }
                                            }
                                            else
                                            {
                                                if (ageTB.Text != "")
                                                {
                                                    long age;
                                                    long.TryParse(ageTB.Text, out age);
                                                    if (age > 0)
                                                    {
                                                        if (infoTB.Text != "")
                                                        {
                                                            string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Telefon = " + phoneTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                            string pet = "UPTADE Pacjent SET Gatunek = '" + speciesTB.Text + "', Wiek = '" + ageTB.Text + "', Opis = '" + infoTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                            con.Open();

                                                            SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                            SqlCommand cmdPet = new SqlCommand(pet, con);

                                                            cmdOwner.ExecuteNonQuery();
                                                            cmdPet.ExecuteNonQuery();
                                                        }
                                                        else
                                                        {
                                                            string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Telefon = " + phoneTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                            string pet = "UPTADE Pacjent SET Gatunek = '" + speciesTB.Text + "', Wiek = '" + ageTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                            con.Open();

                                                            SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                            SqlCommand cmdPet = new SqlCommand(pet, con);

                                                            cmdOwner.ExecuteNonQuery();
                                                            cmdPet.ExecuteNonQuery();
                                                        }
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Please enter correct form of data");
                                                    }
                                                }
                                                else
                                                {
                                                    if (infoTB.Text != "")
                                                    {
                                                        string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Telefon = " + phoneTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                        string pet = "UPTADE Pacjent SET Gatunek = '" + speciesTB.Text + "', Opis = '" + infoTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                        con.Open();

                                                        SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                        SqlCommand cmdPet = new SqlCommand(pet, con);

                                                        cmdOwner.ExecuteNonQuery();
                                                        cmdPet.ExecuteNonQuery();
                                                    }
                                                    else
                                                    {
                                                        string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Telefon = " + phoneTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                        string pet = "UPTADE Pacjent SET Gatunek = '" + speciesTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                        con.Open();

                                                        SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                        SqlCommand cmdPet = new SqlCommand(pet, con);

                                                        cmdOwner.ExecuteNonQuery();
                                                        cmdPet.ExecuteNonQuery();
                                                    }
                                                }
                                            }
                                        }
                                        else
                                        {
                                            if (sexTB.Text != "")
                                            {
                                                if (sexTB.Text == "K" || sexTB.Text == "M" || sexTB.Text == "N")
                                                {
                                                    if (ageTB.Text != "")
                                                    {
                                                        long age;
                                                        long.TryParse(ageTB.Text, out age);
                                                        if (age > 0)
                                                        {
                                                            if (infoTB.Text != "")
                                                            {
                                                                string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Telefon = " + phoneTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                                string pet = "UPTADE Pacjent SET Plec = '" + sexTB.Text + "', Wiek = '" + ageTB.Text + "', Opis = '" + infoTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                                con.Open();

                                                                SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                                SqlCommand cmdPet = new SqlCommand(pet, con);

                                                                cmdOwner.ExecuteNonQuery();
                                                                cmdPet.ExecuteNonQuery();
                                                            }
                                                            else
                                                            {
                                                                string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Telefon = " + phoneTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                                string pet = "UPTADE Pacjent SET Plec = '" + sexTB.Text + "', Wiek = '" + ageTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                                con.Open();

                                                                SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                                SqlCommand cmdPet = new SqlCommand(pet, con);

                                                                cmdOwner.ExecuteNonQuery();
                                                                cmdPet.ExecuteNonQuery();
                                                            }
                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("Please enter correct form of data");
                                                        }
                                                    }
                                                    else
                                                    {
                                                        if (infoTB.Text != "")
                                                        {
                                                            string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Telefon = " + phoneTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                            string pet = "UPTADE Pacjent SET Plec = '" + sexTB.Text + "', Opis = '" + infoTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                            con.Open();

                                                            SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                            SqlCommand cmdPet = new SqlCommand(pet, con);

                                                            cmdOwner.ExecuteNonQuery();
                                                            cmdPet.ExecuteNonQuery();
                                                        }
                                                        else
                                                        {
                                                            string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Telefon = " + phoneTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                            string pet = "UPTADE Pacjent SET Plec = '" + sexTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                            con.Open();

                                                            SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                            SqlCommand cmdPet = new SqlCommand(pet, con);

                                                            cmdOwner.ExecuteNonQuery();
                                                            cmdPet.ExecuteNonQuery();
                                                        }
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Please enter correct form of data");
                                                }
                                            }
                                            else
                                            {
                                                if (ageTB.Text != "")
                                                {
                                                    long age;
                                                    long.TryParse(ageTB.Text, out age);
                                                    if (age > 0)
                                                    {
                                                        if (infoTB.Text != "")
                                                        {
                                                            string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Telefon = " + phoneTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                            string pet = "UPTADE Pacjent SET Wiek = '" + ageTB.Text + "', Opis = '" + infoTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                            con.Open();

                                                            SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                            SqlCommand cmdPet = new SqlCommand(pet, con);

                                                            cmdOwner.ExecuteNonQuery();
                                                            cmdPet.ExecuteNonQuery();
                                                        }
                                                        else
                                                        {
                                                            string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Telefon = " + phoneTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                            string pet = "UPTADE Pacjent SET Wiek = '" + ageTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                            con.Open();

                                                            SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                            SqlCommand cmdPet = new SqlCommand(pet, con);

                                                            cmdOwner.ExecuteNonQuery();
                                                            cmdPet.ExecuteNonQuery();
                                                        }
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Please enter correct form of data");
                                                    }
                                                }
                                                else
                                                {
                                                    if (infoTB.Text != "")
                                                    {
                                                        string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Telefon = " + phoneTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                        string pet = "UPTADE Pacjent SET Opis = '" + infoTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                        con.Open();

                                                        SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                        SqlCommand cmdPet = new SqlCommand(pet, con);

                                                        cmdOwner.ExecuteNonQuery();
                                                        cmdPet.ExecuteNonQuery();
                                                    }
                                                    else
                                                    {
                                                        string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "', Telefon = " + phoneTB.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                        con.Open();

                                                        SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                        cmdOwner.ExecuteNonQuery();
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Please enter correct form of data");
                                }
                            }
                            else
                            {
                                if (petTB.Text != "")
                                {
                                    if (speciesTB.Text != "")
                                    {
                                        if (sexTB.Text != "")
                                        {
                                            if (sexTB.Text == "K" || sexTB.Text == "M" || sexTB.Text == "N")
                                            {
                                                if (ageTB.Text != "")
                                                {
                                                    long age;
                                                    long.TryParse(ageTB.Text, out age);
                                                    if (age > 0)
                                                    {
                                                        if (infoTB.Text != "")
                                                        {
                                                            string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                            string pet = "UPTADE Pacjent SET Imie = '" + petTB.Text + "', Gatunek = '" + speciesTB.Text + "', Plec = '" + sexTB.Text + "', Wiek = '" + ageTB.Text + "', Opis = '" + infoTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                            con.Open();

                                                            SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                            SqlCommand cmdPet = new SqlCommand(pet, con);

                                                            cmdOwner.ExecuteNonQuery();
                                                            cmdPet.ExecuteNonQuery();
                                                        }
                                                        else
                                                        {
                                                            string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                            string pet = "UPTADE Pacjent SET Imie = '" + petTB.Text + "', Gatunek = '" + speciesTB.Text + "', Plec = '" + sexTB.Text + "', Wiek = '" + ageTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                            con.Open();

                                                            SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                            SqlCommand cmdPet = new SqlCommand(pet, con);

                                                            cmdOwner.ExecuteNonQuery();
                                                            cmdPet.ExecuteNonQuery();
                                                        }
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Please enter correct form of data");
                                                    }
                                                }
                                                else
                                                {
                                                    if (infoTB.Text != "")
                                                    {
                                                        string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                        string pet = "UPTADE Pacjent SET Imie = '" + petTB.Text + "', Gatunek = '" + speciesTB.Text + "', Plec = '" + sexTB.Text + "', Opis = '" + infoTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                        con.Open();

                                                        SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                        SqlCommand cmdPet = new SqlCommand(pet, con);

                                                        cmdOwner.ExecuteNonQuery();
                                                        cmdPet.ExecuteNonQuery();
                                                    }
                                                    else
                                                    {
                                                        string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                        string pet = "UPTADE Pacjent SET Imie = '" + petTB.Text + "', Gatunek = '" + speciesTB.Text + "', Plec = '" + sexTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                        con.Open();

                                                        SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                        SqlCommand cmdPet = new SqlCommand(pet, con);

                                                        cmdOwner.ExecuteNonQuery();
                                                        cmdPet.ExecuteNonQuery();
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Please enter correct form of data");
                                            }
                                        }
                                        else
                                        {
                                            if (ageTB.Text != "")
                                            {
                                                long age;
                                                long.TryParse(ageTB.Text, out age);
                                                if (age > 0)
                                                {
                                                    if (infoTB.Text != "")
                                                    {
                                                        string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                        string pet = "UPTADE Pacjent SET Imie = '" + petTB.Text + "', Gatunek = '" + speciesTB.Text + "', Wiek = '" + ageTB.Text + "', Opis = '" + infoTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                        con.Open();

                                                        SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                        SqlCommand cmdPet = new SqlCommand(pet, con);

                                                        cmdOwner.ExecuteNonQuery();
                                                        cmdPet.ExecuteNonQuery();
                                                    }
                                                    else
                                                    {
                                                        string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                        string pet = "UPTADE Pacjent SET Imie = '" + petTB.Text + "', Gatunek = '" + speciesTB.Text + "', Wiek = '" + ageTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                        con.Open();

                                                        SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                        SqlCommand cmdPet = new SqlCommand(pet, con);

                                                        cmdOwner.ExecuteNonQuery();
                                                        cmdPet.ExecuteNonQuery();
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Please enter correct form of data");
                                                }
                                            }
                                            else
                                            {
                                                if (infoTB.Text != "")
                                                {
                                                    string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                    string pet = "UPTADE Pacjent SET Imie = '" + petTB.Text + "', Gatunek = '" + speciesTB.Text + "', Opis = '" + infoTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                    con.Open();

                                                    SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                    SqlCommand cmdPet = new SqlCommand(pet, con);

                                                    cmdOwner.ExecuteNonQuery();
                                                    cmdPet.ExecuteNonQuery();
                                                }
                                                else
                                                {
                                                    string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                    string pet = "UPTADE Pacjent SET Imie = '" + petTB.Text + "', Gatunek = '" + speciesTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                    con.Open();

                                                    SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                    SqlCommand cmdPet = new SqlCommand(pet, con);

                                                    cmdOwner.ExecuteNonQuery();
                                                    cmdPet.ExecuteNonQuery();
                                                }
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (sexTB.Text != "")
                                        {
                                            if (sexTB.Text == "K" || sexTB.Text == "M" || sexTB.Text == "N")
                                            {
                                                if (ageTB.Text != "")
                                                {
                                                    long age;
                                                    long.TryParse(ageTB.Text, out age);
                                                    if (age > 0)
                                                    {
                                                        if (infoTB.Text != "")
                                                        {
                                                            string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                            string pet = "UPTADE Pacjent SET Imie = '" + petTB.Text + "', Plec = '" + sexTB.Text + "', Wiek = '" + ageTB.Text + "', Opis = '" + infoTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                            con.Open();

                                                            SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                            SqlCommand cmdPet = new SqlCommand(pet, con);

                                                            cmdOwner.ExecuteNonQuery();
                                                            cmdPet.ExecuteNonQuery();
                                                        }
                                                        else
                                                        {
                                                            string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                            string pet = "UPTADE Pacjent SET Imie = '" + petTB.Text + "', Plec = '" + sexTB.Text + "', Wiek = '" + ageTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                            con.Open();

                                                            SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                            SqlCommand cmdPet = new SqlCommand(pet, con);

                                                            cmdOwner.ExecuteNonQuery();
                                                            cmdPet.ExecuteNonQuery();
                                                        }
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Please enter correct form of data");
                                                    }
                                                }
                                                else
                                                {
                                                    if (infoTB.Text != "")
                                                    {
                                                        string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                        string pet = "UPTADE Pacjent SET Imie = '" + petTB.Text + "', Plec = '" + sexTB.Text + "', Opis = '" + infoTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                        con.Open();

                                                        SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                        SqlCommand cmdPet = new SqlCommand(pet, con);

                                                        cmdOwner.ExecuteNonQuery();
                                                        cmdPet.ExecuteNonQuery();
                                                    }
                                                    else
                                                    {
                                                        string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                        string pet = "UPTADE Pacjent SET Imie = '" + petTB.Text + "', Plec = '" + sexTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                        con.Open();

                                                        SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                        SqlCommand cmdPet = new SqlCommand(pet, con);

                                                        cmdOwner.ExecuteNonQuery();
                                                        cmdPet.ExecuteNonQuery();
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Please enter correct form of data");
                                            }
                                        }
                                        else
                                        {
                                            if (ageTB.Text != "")
                                            {
                                                long age;
                                                long.TryParse(ageTB.Text, out age);
                                                if (age > 0)
                                                {
                                                    if (infoTB.Text != "")
                                                    {
                                                        string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                        string pet = "UPTADE Pacjent SET Imie = '" + petTB.Text + "', Wiek = '" + ageTB.Text + "', Opis = '" + infoTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                        con.Open();

                                                        SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                        SqlCommand cmdPet = new SqlCommand(pet, con);

                                                        cmdOwner.ExecuteNonQuery();
                                                        cmdPet.ExecuteNonQuery();
                                                    }
                                                    else
                                                    {
                                                        string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                        string pet = "UPTADE Pacjent SET Imie = '" + petTB.Text + "', Wiek = '" + ageTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                        con.Open();

                                                        SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                        SqlCommand cmdPet = new SqlCommand(pet, con);

                                                        cmdOwner.ExecuteNonQuery();
                                                        cmdPet.ExecuteNonQuery();
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Please enter correct form of data");
                                                }
                                            }
                                            else
                                            {
                                                if (infoTB.Text != "")
                                                {
                                                    string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                    string pet = "UPTADE Pacjent SET Imie = '" + petTB.Text + "', Opis = '" + infoTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                    con.Open();

                                                    SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                    SqlCommand cmdPet = new SqlCommand(pet, con);

                                                    cmdOwner.ExecuteNonQuery();
                                                    cmdPet.ExecuteNonQuery();
                                                }
                                                else
                                                {
                                                    string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                    string pet = "UPTADE Pacjent SET Imie = '" + petTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                    con.Open();

                                                    SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                    SqlCommand cmdPet = new SqlCommand(pet, con);

                                                    cmdOwner.ExecuteNonQuery();
                                                    cmdPet.ExecuteNonQuery();
                                                }
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    if (speciesTB.Text != "")
                                    {
                                        if (sexTB.Text != "")
                                        {
                                            if (sexTB.Text == "K" || sexTB.Text == "M" || sexTB.Text == "N")
                                            {
                                                if (ageTB.Text != "")
                                                {
                                                    long age;
                                                    long.TryParse(ageTB.Text, out age);
                                                    if (age > 0)
                                                    {
                                                        if (infoTB.Text != "")
                                                        {
                                                            string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                            string pet = "UPTADE Pacjent SET Gatunek = '" + speciesTB.Text + "', Plec = '" + sexTB.Text + "', Wiek = '" + ageTB.Text + "', Opis = '" + infoTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                            con.Open();

                                                            SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                            SqlCommand cmdPet = new SqlCommand(pet, con);

                                                            cmdOwner.ExecuteNonQuery();
                                                            cmdPet.ExecuteNonQuery();
                                                        }
                                                        else
                                                        {
                                                            string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                            string pet = "UPTADE Pacjent SET Gatunek = '" + speciesTB.Text + "', Plec = '" + sexTB.Text + "', Wiek = '" + ageTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                            con.Open();

                                                            SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                            SqlCommand cmdPet = new SqlCommand(pet, con);

                                                            cmdOwner.ExecuteNonQuery();
                                                            cmdPet.ExecuteNonQuery();
                                                        }
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Please enter correct form of data");
                                                    }
                                                }
                                                else
                                                {
                                                    if (infoTB.Text != "")
                                                    {
                                                        string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                        string pet = "UPTADE Pacjent SET Gatunek = '" + speciesTB.Text + "', Plec = '" + sexTB.Text + "', Opis = '" + infoTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                        con.Open();

                                                        SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                        SqlCommand cmdPet = new SqlCommand(pet, con);

                                                        cmdOwner.ExecuteNonQuery();
                                                        cmdPet.ExecuteNonQuery();
                                                    }
                                                    else
                                                    {
                                                        string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                        string pet = "UPTADE Pacjent SET Gatunek = '" + speciesTB.Text + "', Plec = '" + sexTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                        con.Open();

                                                        SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                        SqlCommand cmdPet = new SqlCommand(pet, con);

                                                        cmdOwner.ExecuteNonQuery();
                                                        cmdPet.ExecuteNonQuery();
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Please enter correct form of data");
                                            }
                                        }
                                        else
                                        {
                                            if (ageTB.Text != "")
                                            {
                                                long age;
                                                long.TryParse(ageTB.Text, out age);
                                                if (age > 0)
                                                {
                                                    if (infoTB.Text != "")
                                                    {
                                                        string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                        string pet = "UPTADE Pacjent SET Gatunek = '" + speciesTB.Text + "', Wiek = '" + ageTB.Text + "', Opis = '" + infoTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                        con.Open();

                                                        SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                        SqlCommand cmdPet = new SqlCommand(pet, con);

                                                        cmdOwner.ExecuteNonQuery();
                                                        cmdPet.ExecuteNonQuery();
                                                    }
                                                    else
                                                    {
                                                        string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                        string pet = "UPTADE Pacjent SET Gatunek = '" + speciesTB.Text + "', Wiek = '" + ageTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                        con.Open();

                                                        SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                        SqlCommand cmdPet = new SqlCommand(pet, con);

                                                        cmdOwner.ExecuteNonQuery();
                                                        cmdPet.ExecuteNonQuery();
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Please enter correct form of data");
                                                }
                                            }
                                            else
                                            {
                                                if (infoTB.Text != "")
                                                {
                                                    string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                    string pet = "UPTADE Pacjent SET Gatunek = '" + speciesTB.Text + "', Opis = '" + infoTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                    con.Open();

                                                    SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                    SqlCommand cmdPet = new SqlCommand(pet, con);

                                                    cmdOwner.ExecuteNonQuery();
                                                    cmdPet.ExecuteNonQuery();
                                                }
                                                else
                                                {
                                                    string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                    string pet = "UPTADE Pacjent SET Gatunek = '" + speciesTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                    con.Open();

                                                    SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                    SqlCommand cmdPet = new SqlCommand(pet, con);

                                                    cmdOwner.ExecuteNonQuery();
                                                    cmdPet.ExecuteNonQuery();
                                                }
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (sexTB.Text != "")
                                        {
                                            if (sexTB.Text == "K" || sexTB.Text == "M" || sexTB.Text == "N")
                                            {
                                                if (ageTB.Text != "")
                                                {
                                                    long age;
                                                    long.TryParse(ageTB.Text, out age);
                                                    if (age > 0)
                                                    {
                                                        if (infoTB.Text != "")
                                                        {
                                                            string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                            string pet = "UPTADE Pacjent SET Plec = '" + sexTB.Text + "', Wiek = '" + ageTB.Text + "', Opis = '" + infoTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                            con.Open();

                                                            SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                            SqlCommand cmdPet = new SqlCommand(pet, con);

                                                            cmdOwner.ExecuteNonQuery();
                                                            cmdPet.ExecuteNonQuery();
                                                        }
                                                        else
                                                        {
                                                            string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                            string pet = "UPTADE Pacjent SET Plec = '" + sexTB.Text + "', Wiek = '" + ageTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                            con.Open();

                                                            SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                            SqlCommand cmdPet = new SqlCommand(pet, con);

                                                            cmdOwner.ExecuteNonQuery();
                                                            cmdPet.ExecuteNonQuery();
                                                        }
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Please enter correct form of data");
                                                    }
                                                }
                                                else
                                                {
                                                    if (infoTB.Text != "")
                                                    {
                                                        string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                        string pet = "UPTADE Pacjent SET Plec = '" + sexTB.Text + "', Opis = '" + infoTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                        con.Open();

                                                        SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                        SqlCommand cmdPet = new SqlCommand(pet, con);

                                                        cmdOwner.ExecuteNonQuery();
                                                        cmdPet.ExecuteNonQuery();
                                                    }
                                                    else
                                                    {
                                                        string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                        string pet = "UPTADE Pacjent SET Plec = '" + sexTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                        con.Open();

                                                        SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                        SqlCommand cmdPet = new SqlCommand(pet, con);

                                                        cmdOwner.ExecuteNonQuery();
                                                        cmdPet.ExecuteNonQuery();
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Please enter correct form of data");
                                            }
                                        }
                                        else
                                        {
                                            if (ageTB.Text != "")
                                            {
                                                long age;
                                                long.TryParse(ageTB.Text, out age);
                                                if (age > 0)
                                                {
                                                    if (infoTB.Text != "")
                                                    {
                                                        string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                        string pet = "UPTADE Pacjent SET Wiek = '" + ageTB.Text + "', Opis = '" + infoTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                        con.Open();

                                                        SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                        SqlCommand cmdPet = new SqlCommand(pet, con);

                                                        cmdOwner.ExecuteNonQuery();
                                                        cmdPet.ExecuteNonQuery();
                                                    }
                                                    else
                                                    {
                                                        string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                        string pet = "UPTADE Pacjent SET Wiek = '" + ageTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                        con.Open();

                                                        SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                        SqlCommand cmdPet = new SqlCommand(pet, con);

                                                        cmdOwner.ExecuteNonQuery();
                                                        cmdPet.ExecuteNonQuery();
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Please enter correct form of data");
                                                }
                                            }
                                            else
                                            {
                                                if (infoTB.Text != "")
                                                {
                                                    string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                    string pet = "UPTADE Pacjent SET Opis = '" + infoTB.Text + "' WHERE Id_zwierzecia = (SELECT Id_zwierzecia FROM Wlasciciel WHERE Id_wlasciciela LIKE '" + loginTB.Text + "'";
                                                    con.Open();

                                                    SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                    SqlCommand cmdPet = new SqlCommand(pet, con);

                                                    cmdOwner.ExecuteNonQuery();
                                                    cmdPet.ExecuteNonQuery();
                                                }
                                                else
                                                {
                                                    string owner = "UPDATE Wlasciciel SET Imie = '" + firstNameLb.Text + "', Nazwisko = '" + lastNameLb.Text + "WHERE Login_uzytkownika LIKE '" + loginTB.Text + "'";
                                                    con.Open();

                                                    SqlCommand cmdOwner = new SqlCommand(owner, con);
                                                    cmdOwner.ExecuteNonQuery();
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter all required information");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter all required information");
                }
            }
            else
            {
                MessageBox.Show("Please enter all required information");
            }
            con.Close();
        }

        private void backBt_Click(object sender, EventArgs e)
        {
            if (formLB.Text == "doctor")
            {
                Doctor doctor = new Doctor();
                doctor.Show();
                this.Close();
            }
            else
            {
                Nurse nurse = new Nurse();
                nurse.Show();
                this.Close();
            }
        }
    }
}
