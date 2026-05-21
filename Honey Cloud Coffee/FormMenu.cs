using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Honey_Cloud_Coffee
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 Inicio = new Form1();
            Inicio.Show();
            this.Hide();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            ConCafe cafe = new ConCafe();

            cafe.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SinCafe sincafe = new SinCafe();

            sincafe.Show();

            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuTes MTes = new MenuTes();

            MTes.Show();

            this.Hide();

        }
    }
}
