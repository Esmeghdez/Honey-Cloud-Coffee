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
    public partial class MokaExtras : Form
    {
        public MokaExtras()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            ConCafe conCafe = new ConCafe();

            conCafe.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMenu menu = new FormMenu();

            menu.Show();

            this.Hide();

        }

        private void mla_Click(object sender, EventArgs e)
        {

        }

        private void mld_Click(object sender, EventArgs e)
        {

        }

        private void mle_Click(object sender, EventArgs e)
        {

        }

        private void mca_Click(object sender, EventArgs e)
        {

        }

        private void ms_Click(object sender, EventArgs e)
        {

        }

        private void mazm_Click(object sender, EventArgs e)
        {

        }

        private void ma_Click(object sender, EventArgs e)
        {

        }

        private void mf_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void mlam_Click(object sender, EventArgs e)
        {

        }

        private void mldm_Click(object sender, EventArgs e)
        {

        }

        private void mlem_Click(object sender, EventArgs e)
        {

        }

        private void mcam_Click(object sender, EventArgs e)
        {

        }

        private void msm_Click(object sender, EventArgs e)
        {

        }

        private void mamm_Click(object sender, EventArgs e)
        {

        }

        private void mam_Click(object sender, EventArgs e)
        {

        }

        private void mfm_Click(object sender, EventArgs e)
        {

        }

        private void mcm_Click(object sender, EventArgs e)
        {

        }
    }
}
