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
    }
}
