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
    public partial class CapuccinoExtras : Form
    {
        private Bebida miBebidaSeleccionada;
        public CapuccinoExtras()
        {
            InitializeComponent();
            this.miBebidaSeleccionada = new Capuccino();

            ActualizarPedido();
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

        //-----------------------------------------------------------------------------------
        //caliente -
        private void calientecap_Click(object sender, EventArgs e)
        {
            int cantidadCaliente = int.Parse(lblp1.Text);
            if (cantidadCaliente > 0)
            {
                cantidadCaliente--;
                lblp1.Text = cantidadCaliente.ToString();
                ActualizarPedido();
            }
        }

        private void capcaliente_Click(object sender, EventArgs e)
        {
            int cantidadCaliente = int.Parse(lblp1.Text);

            cantidadCaliente++;
            lblp1.Text = cantidadCaliente.ToString();
            ActualizarPedido();
        }

        //-----------------------------------------------------------------------------------
        //frio -
        private void friocap_Click(object sender, EventArgs e)
        {
            int cantidadFrio = int.Parse(lblp2.Text);
            if (cantidadFrio > 0)
            {
                cantidadFrio--;
                lblp2.Text = cantidadFrio.ToString();
                ActualizarPedido();
            }
        }

        private void capfrio_Click(object sender, EventArgs e)
        {
            int cantidadFrio = int.Parse(lblp2.Text);
            cantidadFrio++;
            lblp2.Text = cantidadFrio.ToString();
            ActualizarPedido();
        }

        //-----------------------------------------------------------------------------------
        //azucar -
        private void azucarcap_Click(object sender, EventArgs e)
        {
            int cantidadAzucar = int.Parse(lblp3.Text);
            if (cantidadAzucar > 0)

            {
                cantidadAzucar--;
                lblp3.Text = cantidadAzucar.ToString();
                ActualizarPedido();
            }
        }

        private void capazucar_Click(object sender, EventArgs e)
        {
            int cantidadAzucar = int.Parse(lblp3.Text);

            cantidadAzucar++;
            lblp3.Text = cantidadAzucar.ToString();
            ActualizarPedido();
        }

        //-----------------------------------------------------------------------------------
        //Azucar mascabado
        private void azucarmcap_Click(object sender, EventArgs e)
        {
            int cantidadAzucarM = int.Parse(lblp4.Text);

            if (cantidadAzucarM > 0)
            {
                cantidadAzucarM--;
                lblp4.Text = cantidadAzucarM.ToString();
                ActualizarPedido();
            }
        }

        private void azucarcapm_Click(object sender, EventArgs e)
        {
            int cantidadAzucarM = int.Parse(lblp4.Text);
            cantidadAzucarM++;
            lblp4.Text = cantidadAzucarM.ToString();
            ActualizarPedido();
        }

        //-----------------------------------------------------------------------------------
        //splenda
        private void splendacap_Click(object sender, EventArgs e)
        {
            int cantidadSplenda = int.Parse(lblp5.Text);

            if (cantidadSplenda > 0)
            {
                cantidadSplenda--;
                lblp5.Text = cantidadSplenda.ToString();
                ActualizarPedido();
            }
        }

        private void capsplenda_Click(object sender, EventArgs e)
        {
            int cantidadSplenda = int.Parse(lblp5.Text);
            cantidadSplenda++;
            lblp5.Text = cantidadSplenda.ToString();

            ActualizarPedido();
        }

        //-----------------------------------------------------------------------------------
        //canela
        private void canelacap_Click(object sender, EventArgs e)
        {
            int cantidadCanela = int.Parse(lblp6.Text);

            if (cantidadCanela > 0)
            {
                cantidadCanela--;
                lblp6.Text = cantidadCanela.ToString();
                ActualizarPedido();
            }
        }

        private void capcanela_Click(object sender, EventArgs e)
        {
            int cantidadCanela = int.Parse(lblp6.Text);
            cantidadCanela++;
            lblp6.Text = cantidadCanela.ToString();

            ActualizarPedido();
        }


        //-----------------------------------------------------------------------------------
        //leche entera -
        private void enteracap_Click(object sender, EventArgs e)
        {
            int cantidadLechee = int.Parse(lblp7.Text);

            if (cantidadLechee > 0)
            {
                cantidadLechee--;
                lblp7.Text = cantidadLechee.ToString();

                ActualizarPedido();
            }
        }

        private void capentera_Click(object sender, EventArgs e)
        {
            int cantidadLechee = int.Parse(lblp7.Text);

            cantidadLechee++;
            lblp7.Text = cantidadLechee.ToString();

            ActualizarPedido();
        }

        //-----------------------------------------------------------------------------------
        //Leche deslactosada -
        private void deslcap_Click(object sender, EventArgs e)
        {
            int cantidadLeched = int.Parse(lblp8.Text);

            if (cantidadLeched > 0)
            {
                cantidadLeched--;
                lblp8.Text = cantidadLeched.ToString();
                ActualizarPedido();
            }
        }

        private void capdes_Click(object sender, EventArgs e)
        {
            int cantidadLeched = int.Parse(lblp8.Text);

            cantidadLeched++;
            lblp8.Text = cantidadLeched.ToString();

            ActualizarPedido();
        }

        //-----------------------------------------------------------------------------------
        //Leche de Almendras -
        private void almcap_Click(object sender, EventArgs e)
        {
            int cantidadLechea = int.Parse(lblp9.Text);

            if (cantidadLechea > 0)
            {
                cantidadLechea--;
                lblp9.Text = cantidadLechea.ToString();

                ActualizarPedido();
            }
        }

        private void capalm_Click(object sender, EventArgs e)
        {
            int cantidadLechea = int.Parse(lblp9.Text);

            cantidadLechea++;
            lblp9.Text = cantidadLechea.ToString();
            ActualizarPedido();
        }


        private void ActualizarPedido()
        {
            if (miBebidaSeleccionada == null) return;

            // Iniciamos con la bebida base
            Bebida pedidoFinal = miBebidaSeleccionada;

            // caliente
            int cantCaliente = int.Parse(lblp1.Text);
            for (int i = 0; i < cantCaliente; i++)
            {
                pedidoFinal = new Caliente(pedidoFinal);
            }

            // frío
            int cantFrio = int.Parse(lblp2.Text);
            for (int i = 0; i < cantFrio; i++)
            {
                pedidoFinal = new Fria(pedidoFinal);
            }

            // azúcar
            int cantAzucar = int.Parse(lblp3.Text);
            for (int i = 0; i < cantAzucar; i++)
            {
                pedidoFinal = new Azucar(pedidoFinal);
            }

            // azucar mascabado
            int cantAzucarM = int.Parse(lblp4.Text);
            for (int i = 0; i < cantAzucarM; i++)
            {
                pedidoFinal = new AzucarMascabado(pedidoFinal);
            }

            // splenda
            int cantSplenda = int.Parse(lblp5.Text);
            for (int i = 0; i < cantSplenda; i++)
            {
                pedidoFinal = new Splenda(pedidoFinal);
            }

            // canela
            int cantCanela = int.Parse(lblp6.Text);
            for (int i = 0; i < cantCanela; i++)
            {
                pedidoFinal = new Canela(pedidoFinal);
            }

            //Leche Entera
            int cantLechee = int.Parse(lblp7.Text);
            for (int i = 0; i < cantLechee; i++)
            {
                pedidoFinal = new LecheEntera(pedidoFinal);
            }

            // Leche Deslactosada
            int cantLeched = int.Parse(lblp8.Text);
            for (int i = 0; i < cantLeched; i++)
            {
                pedidoFinal = new LecheDeslactosada(pedidoFinal);
            }

            // Leche de Almendras
            int cantLechea = int.Parse(lblp9.Text);
            for (int i = 0; i < cantLechea; i++)
            {
                pedidoFinal = new LecheAlmendras(pedidoFinal);
            }
        }


        //-----------------------------------------------------------------------------------
        //Pedido terminado
        private void button2_Click(object sender, EventArgs e)
        {
            if (miBebidaSeleccionada == null) return;



            // Leer las cantitades directamente de los label

            int cantCaliente = int.Parse(lblp1.Text);
            int cantFrio = int.Parse(lblp2.Text);
            int cantAzucar = int.Parse(lblp3.Text);
            int cantAzucarM = int.Parse(lblp4.Text);
            int cantSplenda = int.Parse(lblp5.Text);
            int cantCanela = int.Parse(lblp6.Text);
            int cantLechee = int.Parse(lblp7.Text);
            int cantLeched = int.Parse(lblp8.Text);
            int cantLechea = int.Parse(lblp9.Text);


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

            lblp1.Text = "0";  //caliente   
            lblp2.Text = "0";  //frio
            lblp3.Text = "0";  //azucar
            lblp4.Text = "0"; //azucarm
            lblp5.Text = "0";  //splenda
            lblp6.Text = "0"; //canela
            lblp7.Text = "0";  //Leche Entera
            lblp8.Text = "0";  //Leche Deslactosada
            lblp9.Text = "0";   //Leche de Almendras

            ActualizarPedido();
        }

    }
}
