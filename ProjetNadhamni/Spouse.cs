using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetNadhamni
{
    public partial class Spouse : Form
    {
        public Spouse()
        {
            InitializeComponent();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnSaveSpouse_Click(object sender, EventArgs e)
        {
            if (PersonalInformation.kid)
            {
                Kids k = new Kids();
                k.Show();
                this.Hide();
            }
            if (!PersonalInformation.kid && (PersonalInformation.Worker || PersonalInformation.Student || PersonalInformation.unemployed))
            {
                Parents p = new Parents();
                p.Show();
                this.Hide();

            }
        }
    }
}
