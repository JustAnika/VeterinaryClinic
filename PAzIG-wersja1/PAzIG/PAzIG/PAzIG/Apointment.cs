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
    }
}
