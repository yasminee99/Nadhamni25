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
    public partial class PersonalInformation : Form
    {
        public PersonalInformation()
        {
            InitializeComponent();
        }
        public static bool kid = false;
        public static bool Worker = false;
        public static bool Student = false;
        public static bool unemployed = true;
        public static bool Mar = false;
        public static bool Div = false;
        public static bool wid = false;
        public static bool sing = false;

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void exitPersonal_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSavePersInfo_Click(object sender, EventArgs e)
        {
            if (Mar)
            {
                Spouse sp = new Spouse();
                sp.Show();
                this.Hide();
            }

            if ((wid || Div) && (kid))
            {
                Kids k = new Kids();
                k.Show();
                this.Hide();
            }
            if (sing)
            {
                Parents p = new Parents();
                p.Show();
                this.Hide();
            }
            if ((wid || Div) && (!kid))
            {
                Parents p = new Parents();
                p.Show();
                this.Hide();
            }
        }

        private void PersonalInformation_Load(object sender, EventArgs e)
        {
            txt_WorkInfo.Enabled = false;
            label5.Visible = false;
            rd_YesKidsInfo.Visible = false;
            rd_NoKidsInfo.Visible = false;
        }

        private void rd_YesWorkInfo_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_YesWorkInfo.Checked == true)
            {
                txt_WorkInfo.Enabled = true;
                Worker = true;
                unemployed = false;
                rd_yesStud.Enabled = false;
                rd_noStud.Enabled = false;
            }
        }

        private void rd_marriedInfo_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_marriedInfo.Checked)
            {
                Mar = true;
                label5.Visible = true;
                rd_YesKidsInfo.Visible = true;
                rd_NoKidsInfo.Visible = true;
            }
        }

        private void rd_DivorcedInfo_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_DivorcedInfo.Checked)
            {
                Div = true;
                label5.Visible = true;
                rd_YesKidsInfo.Visible = true;
                rd_NoKidsInfo.Visible = true;
            }
        }

        private void rd_WidInfo_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_WidInfo.Checked)
            {
                wid = true;
                label5.Visible = true;
                rd_YesKidsInfo.Visible = true;
                rd_NoKidsInfo.Visible = true;
            }
        }

        private void rd_YesKidsInfo_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_YesKidsInfo.Checked == true)
                kid = true;

        }

        private void rd_singleInfo_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_singleInfo.Checked == true)
                sing = true;
        }

        private void rd_yesStud_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_yesStud.Checked == true)
                Student = true;
            unemployed = false;
        }
    }
}
