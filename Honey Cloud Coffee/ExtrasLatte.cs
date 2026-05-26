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
    public partial class ExtrasLatte : Form
    {
        private Bebida miBebidaSeleccionada;
        public ExtrasLatte()
        {
            InitializeComponent();
            this.miBebidaSeleccionada = new Latte();

            ActualizarPedido();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            ConCafe conCafe = new ConCafe();

            conCafe.Show();

            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMenu menu = new FormMenu();

            menu.Show();

            this.Hide();
        }

        //----------------------------------------------------------------------
        //caliente -
        private void Calientel_Click(object sender, EventArgs e)
        {
            int cantidadCaliente = int.Parse(lbll1.Text);
            if (cantidadCaliente > 0)
            {
                cantidadCaliente--;
                lbll1.Text = cantidadCaliente.ToString();
                ActualizarPedido();
            }
        }

        private void Calientelmas_Click(object sender, EventArgs e)
        {
            int cantidadCaliente = int.Parse(lbll1.Text);

            cantidadCaliente++;
            lbll1.Text = cantidadCaliente.ToString();
            ActualizarPedido();
        }
        //---------------------------------------------------------------------------
        //frio -
        private void friol_Click(object sender, EventArgs e)
        {
            int cantidadFrio = int.Parse(lbll2.Text);
            if (cantidadFrio > 0)
            {
                cantidadFrio--;
                lbll2.Text = cantidadFrio.ToString();
                ActualizarPedido();
            }
        }

        private void friom_Click(object sender, EventArgs e)
        {
            int cantidadFrio = int.Parse(lbll2.Text);
            cantidadFrio++;
            lbll2.Text = cantidadFrio.ToString();
            ActualizarPedido();
        }

        //---------------------------------------------------------------------------
        //Azucar
        private void azul_Click(object sender, EventArgs e)
        {
            int cantidadAzucar = int.Parse(lbll3.Text);
            if (cantidadAzucar > 0)

            {
                cantidadAzucar--;
                lbll3.Text = cantidadAzucar.ToString();
                ActualizarPedido();
            }
        }

        private void azucarmas_Click(object sender, EventArgs e)
        {
            int cantidadAzucar = int.Parse(lbll3.Text);

            cantidadAzucar++;
            lbll3.Text = cantidadAzucar.ToString();
            ActualizarPedido();
        }

        //---------------------------------------------------------------------------
        //Azucar M
        private void azucarml_Click(object sender, EventArgs e)
        {
            int cantidadAzucarM = int.Parse(lbll4.Text);

            if (cantidadAzucarM > 0)
            {
                cantidadAzucarM--;
                lbll4.Text = cantidadAzucarM.ToString();
                ActualizarPedido();
            }
        }

        private void lecheazum_Click(object sender, EventArgs e)
        {
            int cantidadAzucarM = int.Parse(lbll4.Text);
            cantidadAzucarM++;
            lbll4.Text = cantidadAzucarM.ToString();
            ActualizarPedido();
        }

        //----------------------------------------------------------------------------------
        //splenda -
        private void splendal_Click(object sender, EventArgs e)
        {
            int cantidadSplenda = int.Parse(lbll5.Text);

            if (cantidadSplenda > 0)
            {
                cantidadSplenda--;
                lbll5.Text = cantidadSplenda.ToString();
                ActualizarPedido();
            }
        }

        private void splendamas_Click(object sender, EventArgs e)
        {
            int cantidadSplenda = int.Parse(lbll5.Text);
            cantidadSplenda++;
            lbll5.Text = cantidadSplenda.ToString();

            ActualizarPedido();
        }

        //----------------------------------------------------------------------------------
        //Canela
        private void canelal_Click(object sender, EventArgs e)
        {
            int cantidadCanela = int.Parse(lbll6.Text);

            if (cantidadCanela > 0)
            {
                cantidadCanela--;
                lbll6.Text = cantidadCanela.ToString();
                ActualizarPedido();
            }
        }

        private void canelamas_Click(object sender, EventArgs e)
        {
            int cantidadCanela = int.Parse(lbll6.Text);
            cantidadCanela++;
            lbll6.Text = cantidadCanela.ToString();

            ActualizarPedido();
        }

        //----------------------------------------------------------------------------------
        //Leche Entera -
        private void lecheentl_Click(object sender, EventArgs e)
        {
            int cantidadLechee = int.Parse(lbll7.Text);

            if (cantidadLechee > 0)
            {
                cantidadLechee--;
                lbll7.Text = cantidadLechee.ToString();

                ActualizarPedido();
            }
        }

        private void lecheentem_Click(object sender, EventArgs e)
        {
            int cantidadLechee = int.Parse(lbll7.Text);

            cantidadLechee++;
            lbll7.Text = cantidadLechee.ToString();

            ActualizarPedido();
        }

        //----------------------------------------------------------------------------------
        //Leche deslactosada -
        private void lechedesl_Click(object sender, EventArgs e)
        {
            int cantidadLeched = int.Parse(lbll8.Text);

            if (cantidadLeched > 0)
            {
                cantidadLeched--;
                lbll8.Text = cantidadLeched.ToString();
                ActualizarPedido();
            }
        }

        private void lechedesm_Click(object sender, EventArgs e)
        {
            int cantidadLeched = int.Parse(lbll8.Text);

            cantidadLeched++;
            lbll8.Text = cantidadLeched.ToString();

            ActualizarPedido();
        }
        //----------------------------------------------------------------------------------
        //Leche de Almendras -
        private void lechedealm_Click(object sender, EventArgs e)
        {
            int cantidadLechea = int.Parse(lbll9.Text);

            if (cantidadLechea > 0)
            {
                cantidadLechea--;
                lbll9.Text = cantidadLechea.ToString();

                ActualizarPedido();
            }
        }

        private void lechedealmas_Click(object sender, EventArgs e)
        {
            int cantidadLechea = int.Parse(lbll9.Text);

            cantidadLechea++;
            lbll9.Text = cantidadLechea.ToString();
            ActualizarPedido();
        }


        //---------------------------------------------------------------------------------------
        private void ActualizarPedido()
        {
            if (miBebidaSeleccionada == null) return;

            // Iniciamos con la bebida base
            Bebida pedidoFinal = miBebidaSeleccionada;

            // caliente
            int cantCaliente = int.Parse(lbll1.Text);
            for (int i = 0; i < cantCaliente; i++)
            {
                pedidoFinal = new Caliente(pedidoFinal);
            }

            // frío
            int cantFrio = int.Parse(lbll2.Text);
            for (int i = 0; i < cantFrio; i++)
            {
                pedidoFinal = new Fria(pedidoFinal);
            }

            // azúcar
            int cantAzucar = int.Parse(lbll3.Text);
            for (int i = 0; i < cantAzucar; i++)
            {
                pedidoFinal = new Azucar(pedidoFinal);
            }

            // azucar mascabado
            int cantAzucarM = int.Parse(lbll4.Text);
            for (int i = 0; i < cantAzucarM; i++)
            {
                pedidoFinal = new AzucarMascabado(pedidoFinal);
            }

            // splenda
            int cantSplenda = int.Parse(lbll5.Text);
            for (int i = 0; i < cantSplenda; i++)
            {
                pedidoFinal = new Splenda(pedidoFinal);
            }

            // canela
            int cantCanela = int.Parse(lbll6.Text);
            for (int i = 0; i < cantCanela; i++)
            {
                pedidoFinal = new Canela(pedidoFinal);
            }

            //Leche Entera
            int cantLechee = int.Parse(lbll7.Text);
            for (int i = 0; i < cantLechee; i++)
            {
                pedidoFinal = new LecheEntera(pedidoFinal);
            }

            // Leche Deslactosada
            int cantLeched = int.Parse(lbll8.Text);
            for (int i = 0; i < cantLeched; i++)
            {
                pedidoFinal = new LecheDeslactosada(pedidoFinal);
            }

            // Leche de Almendras
            int cantLechea = int.Parse(lbll9.Text);
            for (int i = 0; i < cantLechea; i++)
            {
                pedidoFinal = new LecheAlmendras(pedidoFinal);
            }
        }
        private void btnPedidolatte_Click(object sender, EventArgs e)
        {
            if (miBebidaSeleccionada == null) return;



            // Leer las cantitades directamente de los label

            int cantCaliente = int.Parse(lbll1.Text);
            int cantFrio = int.Parse(lbll2.Text);
            int cantAzucar = int.Parse(lbll3.Text);
            int cantAzucarM = int.Parse(lbll4.Text);
            int cantSplenda = int.Parse(lbll5.Text);
            int cantCanela = int.Parse(lbll6.Text);
            int cantLechee = int.Parse(lbll7.Text);
            int cantLeched = int.Parse(lbll8.Text);
            int cantLechea = int.Parse(lbll9.Text);


            Bebida pedidoFinal = miBebidaSeleccionada;

            //-----------------------------------------------------------------------------------

            for (int i = 0; i < cantCaliente; i++)
            {
                pedidoFinal = new Caliente(pedidoFinal);
            }

            for (int i = 0; i < cantFrio; i++)
            {
                pedidoFinal = new Fria(pedidoFinal);
            }

            for (int i = 0; i < cantAzucar; i++)
            {
                pedidoFinal = new Azucar(pedidoFinal);
            }

            for (int i = 0; i < cantAzucarM; i++)
            {
                pedidoFinal = new AzucarMascabado(pedidoFinal);
            }

            for (int i = 0; i < cantSplenda; i++)

            {
                pedidoFinal = new Splenda(pedidoFinal);
            }

            for (int i = 0; i < cantCanela; i++)
            {
                pedidoFinal = new Canela(pedidoFinal);
            }

            for (int i = 0; i < cantLechee; i++)
            {
                pedidoFinal = new LecheEntera(pedidoFinal);
            }

            for (int i = 0; i < cantLeched; i++)
            {
                pedidoFinal = new LecheDeslactosada(pedidoFinal);
            }

            for (int i = 0; i < cantLechea; i++)
            {
                pedidoFinal = new LecheAlmendras(pedidoFinal);
            }

            double precioFinal = pedidoFinal.Costo();

            //  ticket
            string nombreBebidaBase = miBebidaSeleccionada.Descripcion();
            string especificacionesLimpias = "";

            //-------------------------------------------------------------------------------

            // Si el usuario eligio, agregamos cuantos quiere 

            if (cantCaliente > 0)
            {
                especificacionesLimpias += $"\n   , Caliente (x{cantCaliente})";
            }
            //Frio
            if (cantFrio > 0)
            {
                especificacionesLimpias += $"\n   , Frío (x{cantFrio})";
            }
            //Azucar
            if (cantAzucar > 0)
            {
                especificacionesLimpias += $"\n   , Azucar (x{cantAzucar})";
            }
            //Azucar Mascabado
            if (cantAzucarM > 0)
            {
                especificacionesLimpias += $"\n   , Azucar Mascabado (x{cantAzucarM})";
            }

            //Splenda

            if (cantSplenda > 0)
            {
                especificacionesLimpias += $"\n   , Splenda (x{cantSplenda})";
            }

            //Canela
            if (cantCanela > 0)
            {
                especificacionesLimpias += $"\n   , Canela (x{cantCanela})";
            }


            //Leche Entera 
            if (cantLechee > 0)
            {
                especificacionesLimpias += $"\n   , Leche Entera (x{cantLechee})";
            }

            //Leche Entera 

            if (cantLeched > 0)
            {
                especificacionesLimpias += $"\n  , Leche deslactosada (x{cantLeched})";
            }

            //Leche Entera 

            if (cantLechea > 0)
            {
                especificacionesLimpias += $"\n   , Leche de Almendras (x{cantLechea})";
            }

            // -------------------------------------------------------------------------

            // Mostrar mensaje final

            // -------------------------------------------------------------------------

            MessageBox.Show($"¡Pedido Completado Exitosamente!\n\n" +
                            $"Bebida: {nombreBebidaBase}\n" +
                            $"Especificaciones:{especificacionesLimpias}\n\n" +
                            $"Total a Pagar: ${precioFinal.ToString("N2", System.Globalization.CultureInfo.InvariantCulture)}",
                            "Honey Cloud Coffee",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            // Regresamos el texto labels a "0"

            lbll1.Text = "0";  //caliente   
            lbll2.Text = "0";  //frio
            lbll3.Text = "0";  //azucar
            lbll4.Text = "0"; //azucarm
            lbll5.Text = "0";  //splenda
            lbll6.Text = "0"; //canela
            lbll7.Text = "0";  //Leche Entera
            lbll8.Text = "0";  //Leche Deslactosada
            lbll9.Text = "0";   //Leche de Almendras

            ActualizarPedido();
        }
    }
}
