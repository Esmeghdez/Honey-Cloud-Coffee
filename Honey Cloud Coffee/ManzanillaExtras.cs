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
    public partial class ManzanillaExtras : Form
    {
        public ManzanillaExtras()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuTes MTes = new MenuTes();

            MTes.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMenu menu = new FormMenu();

            menu.Show();

            this.Hide();
        }
    }
}
