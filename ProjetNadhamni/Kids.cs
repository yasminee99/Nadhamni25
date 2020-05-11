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
    public partial class Kids : Form
    {
        public Kids()
        {
            InitializeComponent();
        }

        private void btnAddKids_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveKids_Click(object sender, EventArgs e)
        {
            Parents p = new Parents();
            p.Show();
            this.Hide();
        }
    }
}
