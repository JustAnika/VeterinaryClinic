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
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void backBt_Click(object sender, EventArgs e)
        {
            Doctor doctor = new Doctor();
            doctor.loginInfoLb.Text = fromLB.Text;
            doctor.UploadDataVisits();
            doctor.Show();
            this.Close();
        }
    }
}
