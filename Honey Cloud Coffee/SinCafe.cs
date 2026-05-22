using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Honey_Cloud_Coffee
{
    public partial class SinCafe : Form
    {
        public SinCafe()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FormMenu menu = new FormMenu();

            menu.Show();

            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ChaiExtras chaiExtras = new ChaiExtras();

            chaiExtras.Show();

            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MatchaExtras matchaExtras = new MatchaExtras();

            matchaExtras.Show();

            this.Hide();
        }
    }
}
