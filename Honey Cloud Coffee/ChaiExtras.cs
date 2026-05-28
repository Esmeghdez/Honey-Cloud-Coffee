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
    public partial class ChaiExtras : Form
    {
        private Cafeteria fabricaChai;
        private Bebida miBebidaSeleccionada;
        private Pedido pedido;
        public ChaiExtras()
        {
            InitializeComponent();
            this.fabricaChai = new BebidasSinCafe();

            this.miBebidaSeleccionada = fabricaChai.CrearBebida("Chai");
            
            this.pedido = new Pedido(miBebidaSeleccionada);
            EstadoPedido.Text = pedido.ObtenerEstado();
            ActualizarPedido();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            SinCafe sincafe = new SinCafe();

            sincafe.Show();

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
        private void calientec_Click(object sender, EventArgs e)
        {


            int cantidadCaliente = int.Parse(lblc1.Text);
            if (cantidadCaliente > 0)
            {
                cantidadCaliente--;
                lblc1.Text = cantidadCaliente.ToString();
                ActualizarPedido();
            }
        }

        private void calientecm_Click(object sender, EventArgs e)
        {


            int cantidadCaliente = int.Parse(lblc1.Text);

            cantidadCaliente++;
            lblc1.Text = cantidadCaliente.ToString();
            ActualizarPedido();
        }

        //-------------------------------------------------------------
        //
        private void frioc_Click(object sender, EventArgs e)
        {


            int cantidadFrio = int.Parse(lblc2.Text);
            if (cantidadFrio > 0)
            {
                cantidadFrio--;
                lblc2.Text = cantidadFrio.ToString();
                ActualizarPedido();
            }
        }

        private void friocm_Click(object sender, EventArgs e)
        {


            int cantidadFrio = int.Parse(lblc2.Text);
            cantidadFrio++;
            lblc2.Text = cantidadFrio.ToString();
            ActualizarPedido();
        }

        //-------------------------------------------------------------
        //
        private void azucarc_Click(object sender, EventArgs e)
        {


            int cantidadAzucar = int.Parse(lblc3.Text);
            if (cantidadAzucar > 0)

            {
                cantidadAzucar--;
                lblc3.Text = cantidadAzucar.ToString();
                ActualizarPedido();
            }
        }

        private void azucarmc_Click(object sender, EventArgs e)
        {


            int cantidadAzucar = int.Parse(lblc3.Text);

            cantidadAzucar++;
            lblc3.Text = cantidadAzucar.ToString();
            ActualizarPedido();
        }

        //-------------------------------------------------------------
        //
        private void azucarmac_Click(object sender, EventArgs e)
        {

            int cantidadAzucarM = int.Parse(lblc4.Text);

            if (cantidadAzucarM > 0)
            {
                cantidadAzucarM--;
                lblc4.Text = cantidadAzucarM.ToString();
                ActualizarPedido();
            }
        }

        private void azucarmscm_Click(object sender, EventArgs e)
        {


            int cantidadAzucarM = int.Parse(lblc4.Text);

            cantidadAzucarM++;
            lblc4.Text = cantidadAzucarM.ToString();
            ActualizarPedido();
        }

        //-------------------------------------------------------------
        //
        private void splendac_Click(object sender, EventArgs e)
        {
 

            int cantidadSplenda = int.Parse(lblc5.Text);

            if (cantidadSplenda > 0)
            {
                cantidadSplenda--;
                lblc5.Text = cantidadSplenda.ToString();
                ActualizarPedido();
            }
        }

        private void splendam_Click(object sender, EventArgs e)
        {
 

            int cantidadSplenda = int.Parse(lblc5.Text);
            cantidadSplenda++;
            lblc5.Text = cantidadSplenda.ToString();

            ActualizarPedido();
        }

        //-------------------------------------------------------------
        //
        private void canelac_Click(object sender, EventArgs e)
        {

            int cantidadCanela = int.Parse(lblc6.Text);

            if (cantidadCanela > 0)
            {
                cantidadCanela--;
                lblc6.Text = cantidadCanela.ToString();
                ActualizarPedido();

            }
        }

        private void canelam_Click(object sender, EventArgs e)
        {

            int cantidadCanela = int.Parse(lblc6.Text);
            cantidadCanela++;
            lblc6.Text = cantidadCanela.ToString();

            ActualizarPedido();
        }

        //-------------------------------------------------------------
        //Leche Entera -
        private void lecheen_Click(object sender, EventArgs e)
        {

            int cantidadLechee = int.Parse(lblc7.Text);

            if (cantidadLechee > 0)
            {
                cantidadLechee--;
                lblc7.Text = cantidadLechee.ToString();

                ActualizarPedido();
            }
        }

        private void lecheenm_Click(object sender, EventArgs e)
        {


            int cantidadLechee = int.Parse(lblc7.Text);

            cantidadLechee++;
            lblc7.Text = cantidadLechee.ToString();

            ActualizarPedido();
        }

        //-------------------------------------------------------------
        //
        private void lechedes_Click(object sender, EventArgs e)
        {


            int cantidadLeched = int.Parse(lblc8.Text);

            if (cantidadLeched > 0)
            {
                cantidadLeched--;
                lblc8.Text = cantidadLeched.ToString();
                ActualizarPedido();
            }
        }

        private void lechedesm_Click(object sender, EventArgs e)
        {

            int cantidadLeched = int.Parse(lblc8.Text);

            cantidadLeched++;
            lblc8.Text = cantidadLeched.ToString();

            ActualizarPedido();
        }

        //-------------------------------------------------------------
        //
        private void lechealm_Click(object sender, EventArgs e)
        {
 

            int cantidadLechea = int.Parse(lblc9.Text);

            if (cantidadLechea > 0)
            {
                cantidadLechea--;
                lblc9.Text = cantidadLechea.ToString();

                ActualizarPedido();
            }
        }

        private void lechealmm_Click(object sender, EventArgs e)
        {
           

            int cantidadLechea = int.Parse(lblc9.Text);

            cantidadLechea++;
            lblc9.Text = cantidadLechea.ToString();
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
            int cantCaliente = int.Parse(lblc1.Text);
            for (int i = 0; i < cantCaliente; i++)
            {
                pedidoFinal = new Caliente(pedidoFinal);
            }

            // frío
            int cantFrio = int.Parse(lblc2.Text);
            for (int i = 0; i < cantFrio; i++)
            {
                pedidoFinal = new Fria(pedidoFinal);
            }

            // azúcar
            int cantAzucar = int.Parse(lblc3.Text);
            for (int i = 0; i < cantAzucar; i++)
            {
                pedidoFinal = new Azucar(pedidoFinal);
            }

            // azucar mascabado
            int cantAzucarM = int.Parse(lblc4.Text);
            for (int i = 0; i < cantAzucarM; i++)
            {
                pedidoFinal = new AzucarMascabado(pedidoFinal);
            }

            // splenda
            int cantSplenda = int.Parse(lblc5.Text);
            for (int i = 0; i < cantSplenda; i++)
            {
                pedidoFinal = new Splenda(pedidoFinal);
            }

            // canela
            int cantCanela = int.Parse(lblc6.Text);
            for (int i = 0; i < cantCanela; i++)
            {
                pedidoFinal = new Canela(pedidoFinal);
            }

            //Leche Entera
            int cantLechee = int.Parse(lblc7.Text);
            for (int i = 0; i < cantLechee; i++)
            {
                pedidoFinal = new LecheEntera(pedidoFinal);
            }

            // Leche Deslactosada
            int cantLeched = int.Parse(lblc8.Text);
            for (int i = 0; i < cantLeched; i++)
            {
                pedidoFinal = new LecheDeslactosada(pedidoFinal);
            }

            // Leche de Almendras
            int cantLechea = int.Parse(lblc9.Text);
            for (int i = 0; i < cantLechea; i++)
            {
                pedidoFinal = new LecheAlmendras(pedidoFinal);
            }
        }

        private void btnPedidoc_Click(object sender, EventArgs e)
        {
            if (miBebidaSeleccionada == null) return;



            // Leer las cantitades directamente de los label

            int cantCaliente = int.Parse(lblc1.Text);
            int cantFrio = int.Parse(lblc2.Text);
            int cantAzucar = int.Parse(lblc3.Text);
            int cantAzucarM = int.Parse(lblc4.Text);
            int cantSplenda = int.Parse(lblc5.Text);
            int cantCanela = int.Parse(lblc6.Text);
            int cantLechee = int.Parse(lblc7.Text);
            int cantLeched = int.Parse(lblc8.Text);
            int cantLechea = int.Parse(lblc9.Text);


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
            pedido.Avanzar();
            EstadoPedido.Text = pedido.ObtenerEstado();

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

            lblc1.Text = "0";  //caliente   
            lblc2.Text = "0";  //frio
            lblc3.Text = "0";  //azucar
            lblc4.Text = "0"; //azucarm
            lblc5.Text = "0";  //splenda
            lblc6.Text = "0"; //canela
            lblc7.Text = "0";  //Leche Entera
            lblc8.Text = "0";  //Leche Deslactosada
            lblc9.Text = "0";   //Leche de Almendras

            this.pedido = new Pedido(miBebidaSeleccionada);
            EstadoPedido.Text = pedido.ObtenerEstado();

            ActualizarPedido();
        }

        private void EstadoPedido_Click(object sender, EventArgs e)
        {
            pedido.Avanzar();
            MessageBox.Show($"Estado actual: {pedido.ObtenerEstado()}",
                            "Honey Cloud Coffee",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }
    }
}
