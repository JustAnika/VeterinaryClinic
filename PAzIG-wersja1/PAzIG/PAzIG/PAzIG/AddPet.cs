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
    public partial class AddPet : Form
    {
        public AddPet()
        {
            InitializeComponent();
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

        private void registerBt_Click(object sender, EventArgs e)
        {

        }
    }
}
