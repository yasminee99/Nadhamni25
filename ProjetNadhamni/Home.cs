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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        Facebook fb = new Facebook();
        GooglePlus gp = new GooglePlus();
        twitter tw = new twitter();
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pic_fb_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            fb.Left += 10;
            if (fb.Left >= 830)
            {
                timer1.Stop();
                this.TopMost = false;
                fb.TopMost = true;
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            fb.Left -= 10;
            if (fb.Left <= 525)
            {
                timer2.Stop();
            }

        }

        private void Home_Load(object sender, EventArgs e)
        {
            fb.Show();
            gp.Show();
            tw.Show();
            
        }

        private void exitHome_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pic_google_Click(object sender, EventArgs e)
        {
            timer3.Start();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            gp.Left += 10;
            if (gp.Left >= 830)
            {
                timer3.Stop();
                this.TopMost = false;
                gp.TopMost = true;
                timer4.Start();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            gp.Left -= 10;
            if (gp.Left <= 525)
            {
                timer4.Stop();
            }
        }

        private void pic_twitter_Click(object sender, EventArgs e)
        {
            timer5.Start();
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            tw.Left += 10;
            if (tw.Left >= 830)
            {
                timer5.Stop();
                this.TopMost = false;
                tw.TopMost = true;
                timer6.Start();
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            tw.Left -= 10;
            if (tw.Left <= 525)
            {
                timer6.Stop();
            }
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            
        }

       

       

        private void txt_username_click(object sender, EventArgs e)
        {
            txt_username.Clear();
        }

        private void txt_password_Click(object sender, EventArgs e)
        {
            txt_password.Clear();
        }

        private void txt_Email_Click(object sender, EventArgs e)
        {
            txt_Email.Clear();
        }
    }
}
