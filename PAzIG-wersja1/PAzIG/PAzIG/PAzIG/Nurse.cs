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
    public partial class Nurse : Form
    {
        public Nurse()
        {
            InitializeComponent();
        }

        private void registrationBt_Click(object sender, EventArgs e)
        {
            AddOwner addOwner = new AddOwner();
            addOwner.Show();
            this.Close();
        }

        private void editBt_Click(object sender, EventArgs e)
        {
            Edit edit = new Edit();
            edit.Show();
            this.Close();
        }

        private void createBt_Click(object sender, EventArgs e)
        {
            Apointment apointment = new Apointment();
            apointment.Show();
            this.Close();
        }

        private void logOutBt_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddPet addPet = new AddPet();
            addPet.Show();
            this.Close();
        }
    }
}
