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
    public partial class DirtyChaiExtras : Form
    {
        private Bebida miBebidaSeleccionada;
        public DirtyChaiExtras()
        {
            InitializeComponent();
            this.miBebidaSeleccionada = new DirtyChai();

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

        //-------------------------------------------------------------
        //Caliente
        private void Caliented_Click(object sender, EventArgs e)
        {
            int cantidadCaliente = int.Parse(lbld1.Text); 
            if (cantidadCaliente > 0)
            {
                cantidadCaliente--;
                lbld1.Text = cantidadCaliente.ToString();
                ActualizarPedido();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            int cantidadCaliente = int.Parse(lbld1.Text);

            cantidadCaliente++;
            lbld1.Text = cantidadCaliente.ToString();
            ActualizarPedido();
        }


        //--------------------------------------------------------
        //Frio
        private void friod_Click(object sender, EventArgs e)
        {
            int cantidadFrio = int.Parse(lbld2.Text); 
            if (cantidadFrio > 0)
            {
                cantidadFrio--;
                lbld2.Text = cantidadFrio.ToString();
                ActualizarPedido();
            }
        }

        private void Friodm_Click(object sender, EventArgs e)
        {
            int cantidadFrio = int.Parse(lbld2.Text); 
            cantidadFrio++;
            lbld2.Text = cantidadFrio.ToString();
            ActualizarPedido();
        }

        //---------------------------------------------------------------------------
        //azucar
        private void azucard_Click(object sender, EventArgs e)
        {
            int cantidadAzucar = int.Parse(lbld3.Text);
            if (cantidadAzucar > 0)

            {
                cantidadAzucar--;
                lbld3.Text = cantidadAzucar.ToString();
                ActualizarPedido();
            }
        }

        private void Azucarm_Click(object sender, EventArgs e)
        {
            int cantidadAzucar = int.Parse(lbld3.Text);

            cantidadAzucar++;
            lbld3.Text = cantidadAzucar.ToString();
            ActualizarPedido();
        }

        //----------------------------------------------------------------------------------------------------------
        //Azucar M
        private void azucarmd_Click(object sender, EventArgs e)
        {
            int cantidadAzucarM = int.Parse(lbld4.Text);

            if (cantidadAzucarM > 0)
            {
                cantidadAzucarM--;
                lbld4.Text = cantidadAzucarM.ToString();
                ActualizarPedido();
            }
        }

        private void azucardmm_Click(object sender, EventArgs e)
        {
            int cantidadAzucarM = int.Parse(lbld4.Text);
            cantidadAzucarM++;
            lbld4.Text = cantidadAzucarM.ToString();
            ActualizarPedido();
        }

        //--------------------------------------------------------------------------------------------------------------------
        //Splenda
        private void Splenda_Click(object sender, EventArgs e)
        {
            int cantidadSplenda = int.Parse(lbld5.Text);

            if (cantidadSplenda > 0)
            {
                cantidadSplenda--;
                lbld5.Text = cantidadSplenda.ToString();
                ActualizarPedido();
            }

        }


        private void Splendam_Click(object sender, EventArgs e)
        {
            int cantidadSplenda = int.Parse(lbld5.Text);
            cantidadSplenda++;
            lbld5.Text = cantidadSplenda.ToString();

            ActualizarPedido();
        }

        //-----------------------------------------------------------------------------------------------------------------------
        //Canela
        private void Canela_Click(object sender, EventArgs e)
        {
            int cantidadCanela = int.Parse(lbld6.Text);

            if (cantidadCanela > 0)
            {
                cantidadCanela--;
                lbld6.Text = cantidadCanela.ToString();
                ActualizarPedido();

            }
        }

        private void Canelam_Click(object sender, EventArgs e)
        {
            int cantidadCanela = int.Parse(lbld6.Text);
            cantidadCanela++;
            lbld6.Text = cantidadCanela.ToString();

            ActualizarPedido();
        }

        //-----------------------------------------------------------------------------------------------------------------------
        //Leche Entera -
        private void LecheEn_Click(object sender, EventArgs e)
        {
            int cantidadLechee = int.Parse(lbld7.Text);

            if (cantidadLechee > 0)
            {
                cantidadLechee--;
                lbld7.Text = cantidadLechee.ToString();

                ActualizarPedido();
            }
        }

        private void LecheEnm_Click(object sender, EventArgs e)
        {
            int cantidadLechee = int.Parse(lbld7.Text);

            cantidadLechee++;
            lbld7.Text = cantidadLechee.ToString();

            ActualizarPedido();
        }


        //-----------------------------------------------------------------------------------------------------------------------
        //Leche Deslactosada -
        private void Lechedes_Click(object sender, EventArgs e)
        {
            int cantidadLeched = int.Parse(lbld8.Text);

            if (cantidadLeched > 0)
            {
                cantidadLeched--;
                lbld8.Text = cantidadLeched.ToString();
                ActualizarPedido();
            }
        }

        private void lecheDesm_Click(object sender, EventArgs e)
        {
            int cantidadLeched = int.Parse(lbld8.Text);

            cantidadLeched++;
            lbld8.Text = cantidadLeched.ToString();

            ActualizarPedido();
        }

        //-----------------------------------------------------------------------------------------------------------------------
        //
        private void Lecheal_Click(object sender, EventArgs e)
        {
            int cantidadLechea = int.Parse(lbld9.Text);

            if (cantidadLechea > 0)
            {
                cantidadLechea--;
                lbld9.Text = cantidadLechea.ToString();

                ActualizarPedido();
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            int cantidadLechea = int.Parse(lbld9.Text);

            cantidadLechea++;
            lbld9.Text = cantidadLechea.ToString();
            ActualizarPedido();
        }
 
        //-----------------------------------------------------------------------------------------------------------------------------
        //
        private void ActualizarPedido()
        {
            if (miBebidaSeleccionada == null) return;

            // Iniciamos con la bebida base
            Bebida pedidoFinal = miBebidaSeleccionada;

            // caliente
            int cantCaliente = int.Parse(lbld1.Text);
            for (int i = 0; i < cantCaliente; i++)
            {
                pedidoFinal = new Caliente(pedidoFinal);
            }

            // frío
            int cantFrio = int.Parse(lbld2.Text);
            for (int i = 0; i < cantFrio; i++)
            {
                pedidoFinal = new Fria(pedidoFinal);
            }

            // azúcar
            int cantAzucar = int.Parse(lbld3.Text);
            for (int i = 0; i < cantAzucar; i++)
            {
                pedidoFinal = new Azucar(pedidoFinal);
            }

            // azucar mascabado
            int cantAzucarM = int.Parse(lbld4.Text);
            for (int i = 0; i < cantAzucarM; i++)
            {
                pedidoFinal = new AzucarMascabado(pedidoFinal);
            }

            // splenda
            int cantSplenda = int.Parse(lbld5.Text);
            for (int i = 0; i < cantSplenda; i++)
            {
                pedidoFinal = new Splenda(pedidoFinal);
            }

            // canela
            int cantCanela = int.Parse(lbld6.Text);
            for (int i = 0; i < cantCanela; i++)
            {
                pedidoFinal = new Canela(pedidoFinal);
            }

            //Leche Entera
            int cantLechee = int.Parse(lbld7.Text);
            for (int i = 0; i < cantLechee; i++)
            {
                pedidoFinal = new LecheEntera(pedidoFinal);
            }

            // Leche Deslactosada
            int cantLeched = int.Parse(lbld8.Text);
            for (int i = 0; i < cantLeched; i++)
            {
                pedidoFinal = new LecheDeslactosada(pedidoFinal);
            }

            // Leche de Almendras
            int cantLechea = int.Parse(lbld9.Text);
            for (int i = 0; i < cantLechea; i++)
            {
                pedidoFinal = new LecheAlmendras(pedidoFinal);
            }
        }

        //---------------------------------------------------------------------------------------------------------------
        private void btnPedido_Click(object sender, EventArgs e)
        {
            if (miBebidaSeleccionada == null) return;



            // Leer las cantitades directamente de los label

            int cantCaliente = int.Parse(lbld1.Text);
            int cantFrio = int.Parse(lbld2.Text);
            int cantAzucar = int.Parse(lbld3.Text);
            int cantAzucarM = int.Parse(lbld4.Text);
            int cantSplenda = int.Parse(lbld5.Text);
            int cantCanela = int.Parse(lbld6.Text);
            int cantLechee = int.Parse(lbld7.Text);
            int cantLeched = int.Parse(lbld8.Text);
            int cantLechea = int.Parse(lbld9.Text);

              
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

            lbld1.Text = "0";  //caliente   
            lbld2.Text = "0";  //frio
            lbld3.Text = "0";  //azucar
            lbld4.Text = "0"; //azucarm
            lbld5.Text = "0";  //splenda
            lbld6.Text = "0"; //canela
            lbld7.Text = "0";  //Leche Entera
            lbld8.Text = "0";  //Leche Deslactosada
            lbld9.Text = "0";   //Leche de Almendras

            ActualizarPedido();
        }


    }
}




