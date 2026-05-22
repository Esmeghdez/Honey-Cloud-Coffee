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
    public partial class ConCafe : Form
    {
        public ConCafe()
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
            ExtrasLatte ELatte = new ExtrasLatte();

            ELatte.Show();

            this.Hide();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            CapuccinoExtras capuccinoextras = new CapuccinoExtras();

            capuccinoextras.Show();

            this.Hide();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MokaExtras mokaextras = new MokaExtras();

            mokaextras.Show();

            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            DirtyChaiExtras dirtyChaiExtras = new DirtyChaiExtras();

            dirtyChaiExtras.Show();

            this.Hide();
        }
    }
}
