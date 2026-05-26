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
        private Bebida miBebidaSeleccionada;
        private Pedido pedido;
        public ManzanillaExtras()
        {
            InitializeComponent();
            this.miBebidaSeleccionada = new Capuccino();
            this.pedido = new Pedido(miBebidaSeleccionada);
            EstadoPedido.Text = pedido.ObtenerEstado();
            ActualizarPedido();
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        //------------------------------------------------------------------------------------
        //
        private void calienteman_Click(object sender, EventArgs e)
        {

            int cantidadCaliente = int.Parse(lblman1.Text);
            if (cantidadCaliente > 0)
            {
                cantidadCaliente--;
                lblman1.Text = cantidadCaliente.ToString();
                ActualizarPedido();
            }
        }

        private void macaliente_Click(object sender, EventArgs e)
        {

            int cantidadCaliente = int.Parse(lblman1.Text);

            cantidadCaliente++;
            lblman1.Text = cantidadCaliente.ToString();
            ActualizarPedido();
        }

        //------------------------------------------------------------------------------------
        //
        private void frioman_Click(object sender, EventArgs e)
        {

            int cantidadFrio = int.Parse(lblman2.Text);
            if (cantidadFrio > 0)
            {
                cantidadFrio--;
                lblman2.Text = cantidadFrio.ToString();
                ActualizarPedido();
            }
        }

        private void manfrio_Click(object sender, EventArgs e)
        {
 
            int cantidadFrio = int.Parse(lblman2.Text);
            cantidadFrio++;
            lblman2.Text = cantidadFrio.ToString();
            ActualizarPedido();
        }

        //------------------------------------------------------------------------------------
        //
        private void azucarman_Click(object sender, EventArgs e)
        {

            int cantidadAzucar = int.Parse(lblman3.Text);
            if (cantidadAzucar > 0)

            {
                cantidadAzucar--;
                lblman3.Text = cantidadAzucar.ToString();
                ActualizarPedido();
            }
        }

        private void maazucar_Click(object sender, EventArgs e)
        {

            int cantidadAzucar = int.Parse(lblman3.Text);

            cantidadAzucar++;
            lblman3.Text = cantidadAzucar.ToString();
            ActualizarPedido();
        }

        //------------------------------------------------------------------------------------
        //Azucar m-
        private void azucarmman_Click(object sender, EventArgs e)
        {

            int cantidadAzucarM = int.Parse(lblman4.Text);

            if (cantidadAzucarM > 0)
            {
                cantidadAzucarM--;
                lblman4.Text = cantidadAzucarM.ToString();
                ActualizarPedido();
            }
        }

        private void manazucarm_Click(object sender, EventArgs e)
        {

            int cantidadAzucarM = int.Parse(lblman4.Text);
            cantidadAzucarM++;
            lblman4.Text = cantidadAzucarM.ToString();
            ActualizarPedido();
        }

        //------------------------------------------------------------------------------------
        //splenda -
        private void splendaman_Click(object sender, EventArgs e)
        {

            int cantidadSplenda = int.Parse(lblman5.Text);

            if (cantidadSplenda > 0)
            {
                cantidadSplenda--;
                lblman5.Text = cantidadSplenda.ToString();
                ActualizarPedido();
            }
        }

        private void mansplenda_Click(object sender, EventArgs e)
        {

            int cantidadSplenda = int.Parse(lblman5.Text);
            cantidadSplenda++;
            lblman5.Text = cantidadSplenda.ToString();

            ActualizarPedido();
        }

        //------------------------------------------------------------------------------------
        //Canela -
        private void canelaman_Click(object sender, EventArgs e)
        {

            int cantidadCanela = int.Parse(lblman6.Text);

            if (cantidadCanela > 0)
            {
                cantidadCanela--;
                lblman6.Text = cantidadCanela.ToString();
                ActualizarPedido();
            }
        }

        private void mancanela_Click(object sender, EventArgs e)
        {

            int cantidadCanela = int.Parse(lblman6.Text);
            cantidadCanela++;
            lblman6.Text = cantidadCanela.ToString();

            ActualizarPedido();
        }

        //------------------------------------------------------------------------------------
        //Leche Entera -
        private void enteraman_Click(object sender, EventArgs e)
        {

            int cantidadLechee = int.Parse(lblman7.Text);

            if (cantidadLechee > 0)
            {
                cantidadLechee--;
                lblman7.Text = cantidadLechee.ToString();

                ActualizarPedido();
            }
        }

        private void manentera_Click(object sender, EventArgs e)
        {

            int cantidadLechee = int.Parse(lblman7.Text);

            cantidadLechee++;
            lblman7.Text = cantidadLechee.ToString();

            ActualizarPedido();
        }

        //------------------------------------------------------------------------------------
        //Leche Deslactosada -
        private void deslman_Click(object sender, EventArgs e)
        {

            int cantidadLeched = int.Parse(lblman8.Text);

            if (cantidadLeched > 0)
            {
                cantidadLeched--;
                lblman8.Text = cantidadLeched.ToString();
                ActualizarPedido();
            }
        }

        private void mandesl_Click(object sender, EventArgs e)
        {
 
            int cantidadLeched = int.Parse(lblman8.Text);

            cantidadLeched++;
            lblman8.Text = cantidadLeched.ToString();

            ActualizarPedido();
        }

        //------------------------------------------------------------------------------------
        //
        private void almendman_Click(object sender, EventArgs e)
        {

            int cantidadLechea = int.Parse(lblman9.Text);

            if (cantidadLechea > 0)
            {
                cantidadLechea--;
                lblman9.Text = cantidadLechea.ToString();

                ActualizarPedido();
            }
        }

        private void manalmend_Click(object sender, EventArgs e)
        {

            int cantidadLechea = int.Parse(lblman9.Text);

            cantidadLechea++;
            lblman9.Text = cantidadLechea.ToString();
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
            int cantCaliente = int.Parse(lblman1.Text);
            for (int i = 0; i < cantCaliente; i++)
            {
                pedidoFinal = new Caliente(pedidoFinal);
            }

            // frío
            int cantFrio = int.Parse(lblman2.Text);
            for (int i = 0; i < cantFrio; i++)
            {
                pedidoFinal = new Fria(pedidoFinal);
            }

            // azúcar
            int cantAzucar = int.Parse(lblman3.Text);
            for (int i = 0; i < cantAzucar; i++)
            {
                pedidoFinal = new Azucar(pedidoFinal);
            }

            // azucar mascabado
            int cantAzucarM = int.Parse(lblman4.Text);
            for (int i = 0; i < cantAzucarM; i++)
            {
                pedidoFinal = new AzucarMascabado(pedidoFinal);
            }

            // splenda
            int cantSplenda = int.Parse(lblman5.Text);
            for (int i = 0; i < cantSplenda; i++)
            {
                pedidoFinal = new Splenda(pedidoFinal);
            }

            // canela
            int cantCanela = int.Parse(lblman6.Text);
            for (int i = 0; i < cantCanela; i++)
            {
                pedidoFinal = new Canela(pedidoFinal);
            }

            //Leche Entera
            int cantLechee = int.Parse(lblman7.Text);
            for (int i = 0; i < cantLechee; i++)
            {
                pedidoFinal = new LecheEntera(pedidoFinal);
            }

            // Leche Deslactosada
            int cantLeched = int.Parse(lblman8.Text);
            for (int i = 0; i < cantLeched; i++)
            {
                pedidoFinal = new LecheDeslactosada(pedidoFinal);
            }

            // Leche de Almendras
            int cantLechea = int.Parse(lblman9.Text);
            for (int i = 0; i < cantLechea; i++)
            {
                pedidoFinal = new LecheAlmendras(pedidoFinal);
            }
        }

        private void btnPedidoManz_Click(object sender, EventArgs e)
        {
            if (miBebidaSeleccionada == null) return;



            // Leer las cantitades directamente de los label

            int cantCaliente = int.Parse(lblman1.Text);
            int cantFrio = int.Parse(lblman2.Text);
            int cantAzucar = int.Parse(lblman3.Text);
            int cantAzucarM = int.Parse(lblman4.Text);
            int cantSplenda = int.Parse(lblman5.Text);
            int cantCanela = int.Parse(lblman6.Text);
            int cantLechee = int.Parse(lblman7.Text);
            int cantLeched = int.Parse(lblman8.Text);
            int cantLechea = int.Parse(lblman9.Text);


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

            lblman1.Text = "0";  //caliente   
            lblman2.Text = "0";  //frio
            lblman3.Text = "0";  //azucar
            lblman4.Text = "0"; //azucarm
            lblman5.Text = "0";  //splenda
            lblman6.Text = "0"; //canela
            lblman7.Text = "0";  //Leche Entera
            lblman8.Text = "0";  //Leche Deslactosada
            lblman9.Text = "0";   //Leche de Almendras

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
