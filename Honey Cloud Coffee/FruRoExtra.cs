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
    public partial class FruRoExtra : Form
    {
        private Bebida miBebidaSeleccionada;
        private Pedido pedido;
        public FruRoExtra()
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

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }
        //--------------------------------------------------------------------------
        //Caliente
        private void fcaliente_Click(object sender, EventArgs e)
        {

            int cantidadCaliente = int.Parse(lblfc.Text);
            if (cantidadCaliente > 0)
            {
                cantidadCaliente--;
                lblfc.Text = cantidadCaliente.ToString();
                ActualizarPedido();
            }
        }

        private void fcalientem_Click(object sender, EventArgs e)
        {

            int cantidadCaliente = int.Parse(lblfc.Text);

            cantidadCaliente++;
            lblfc.Text = cantidadCaliente.ToString();
            ActualizarPedido();
        }

        //--------------------------------------------------------------------------
        //
        private void friof_Click(object sender, EventArgs e)
        {

            int cantidadFrio = int.Parse(lblff.Text);
            if (cantidadFrio > 0)
            {
                cantidadFrio--;
                lblff.Text = cantidadFrio.ToString();
                ActualizarPedido();
            }
        }

        private void ffriom_Click(object sender, EventArgs e)
        {

            int cantidadFrio = int.Parse(lblff.Text);
            cantidadFrio++;
            lblff.Text = cantidadFrio.ToString();
            ActualizarPedido();
        }

        //--------------------------------------------------------------------------
        //Azucar -
        private void azucarf_Click(object sender, EventArgs e)
        {

            int cantidadAzucar = int.Parse(lblfa.Text);
            if (cantidadAzucar > 0)

            {
                cantidadAzucar--;
                lblfa.Text = cantidadAzucar.ToString();
                ActualizarPedido();
            }
        }

        private void azucarfm_Click(object sender, EventArgs e)
        {
  
            int cantidadAzucar = int.Parse(lblfa.Text);

            cantidadAzucar++;
            lblfa.Text = cantidadAzucar.ToString();
            ActualizarPedido();
        }


        //--------------------------------------------------------------------------
        //Azucar mascabado -
        private void azumasf_Click(object sender, EventArgs e)
        {

            int cantidadAzucarM = int.Parse(lblfam.Text);

            if (cantidadAzucarM > 0)
            {
                cantidadAzucarM--;
                lblfam.Text = cantidadAzucarM.ToString();
                ActualizarPedido();
            }
        }

        private void azucarmasm_Click(object sender, EventArgs e)
        {

            int cantidadAzucarM = int.Parse(lblfam.Text);
            cantidadAzucarM++;
            lblfam.Text = cantidadAzucarM.ToString();
            ActualizarPedido();
        }

        //--------------------------------------------------------------------------
        //Splenda -
        private void splendaf_Click(object sender, EventArgs e)
        {

            int cantidadSplenda = int.Parse(lblfs.Text);

            if (cantidadSplenda > 0)
            {
                cantidadSplenda--;
                lblfs.Text = cantidadSplenda.ToString();
                ActualizarPedido();

            }
        }

        private void splendam_Click(object sender, EventArgs e)
        {
            int cantidadSplenda = int.Parse(lblfs.Text);
            cantidadSplenda++;
            lblfs.Text = cantidadSplenda.ToString();

            ActualizarPedido();
        }

        //--------------------------------------------------------------------------
        //Canela
        private void canelaf_Click(object sender, EventArgs e)
        {

            int cantidadCanela = int.Parse(lblfcan.Text);

            if (cantidadCanela > 0)
            {
                cantidadCanela--;
                lblfcan.Text = cantidadCanela.ToString();
                ActualizarPedido();

            }
        }
        private void canelam_Click(object sender, EventArgs e)
        {

            int cantidadCanela = int.Parse(lblfcan.Text);
            cantidadCanela++;
            lblfcan.Text = cantidadCanela.ToString();

            ActualizarPedido();
        }
        //--------------------------------------------------------------------------
        //Leche entera
        private void lecheen_Click(object sender, EventArgs e)
        {

            int cantidadLechee = int.Parse(lblfle.Text);

            if (cantidadLechee > 0)
            {
                cantidadLechee--;
                lblfle.Text = cantidadLechee.ToString();

                ActualizarPedido();
            }
        }

        private void lecheentm_Click(object sender, EventArgs e)
        {

            int cantidadLechee = int.Parse(lblfle.Text);

            cantidadLechee++;
            lblfle.Text = cantidadLechee.ToString();

            ActualizarPedido();
        }
        //--------------------------------------------------------------------------
        //Leche deslactosada
        private void lechedes_Click(object sender, EventArgs e)
        {

            int cantidadLeched = int.Parse(lblfld.Text);

            if (cantidadLeched > 0)
            {
                cantidadLeched--;
                lblfld.Text = cantidadLeched.ToString();
                ActualizarPedido();
            }
        }

        private void lechedesm_Click(object sender, EventArgs e)
        {
            int cantidadLeched = int.Parse(lblfld.Text);

            cantidadLeched++;
            lblfld.Text = cantidadLeched.ToString();

            ActualizarPedido();
        }

        //--------------------------------------------------------------------------
        //Leche de almendras -
        private void lecheal_Click(object sender, EventArgs e)
        {

            int cantidadLechea = int.Parse(lblfla.Text);
            if (cantidadLechea > 0)
            {
                cantidadLechea--;
                lblfla.Text = cantidadLechea.ToString();
                ActualizarPedido();
            }
        }

        private void lechealm_Click(object sender, EventArgs e)
        {

            int cantidadLechea = int.Parse(lblfla.Text);

            cantidadLechea++;
            lblfla.Text = cantidadLechea.ToString();
            ActualizarPedido();
        }


        //--------------------------------------------------------------------------
        private void ActualizarPedido()
        {
            if (miBebidaSeleccionada == null) return;

            // Iniciamos con la bebida base
            Bebida pedidoFinal = miBebidaSeleccionada;

            // caliente
            int cantCaliente = int.Parse(lblfc.Text);
            for (int i = 0; i < cantCaliente; i++)
            {
                pedidoFinal = new Caliente(pedidoFinal);
            }

            // frío
            int cantFrio = int.Parse(lblff.Text);
            for (int i = 0; i < cantFrio; i++)
            {
                pedidoFinal = new Fria(pedidoFinal);
            }

            // azúcar
            int cantAzucar = int.Parse(lblfa.Text);
            for (int i = 0; i < cantAzucar; i++)
            {
                pedidoFinal = new Azucar(pedidoFinal);
            }

            // azucar mascabado
            int cantAzucarM = int.Parse(lblfam.Text);
            for (int i = 0; i < cantAzucarM; i++)
            {
                pedidoFinal = new AzucarMascabado(pedidoFinal);
            }

            // splenda
            int cantSplenda = int.Parse(lblfs.Text);
            for (int i = 0; i < cantSplenda; i++)
            {
                pedidoFinal = new Splenda(pedidoFinal);
            }

            // canela
            int cantCanela = int.Parse(lblfcan.Text);
            for (int i = 0; i < cantCanela; i++)
            {
                pedidoFinal = new Canela(pedidoFinal);
            }

            //Leche Entera
            int cantLechee = int.Parse(lblfle.Text);
            for (int i = 0; i < cantLechee; i++)
            {
                pedidoFinal = new LecheEntera(pedidoFinal);
            }

            // Leche Deslactosada
            int cantLeched = int.Parse(lblfld.Text);
            for (int i = 0; i < cantLeched; i++)
            {
                pedidoFinal = new LecheDeslactosada(pedidoFinal);
            }

            // Leche de Almendras
            int cantLechea = int.Parse(lblfla.Text);
            for (int i = 0; i < cantLechea; i++)
            {
                pedidoFinal = new LecheAlmendras(pedidoFinal);
            }
        }

        private void btnPedidoF_Click(object sender, EventArgs e)
        {
            if (miBebidaSeleccionada == null) return;



            // Leer las cantitades directamente de los label

            int cantCaliente = int.Parse(lblfc.Text);
            int cantFrio = int.Parse(lblff.Text);
            int cantAzucar = int.Parse(lblfa.Text);
            int cantAzucarM = int.Parse(lblfam.Text);
            int cantSplenda = int.Parse(lblfs.Text);
            int cantCanela = int.Parse(lblfcan.Text);
            int cantLechee = int.Parse(lblfle.Text);
            int cantLeched = int.Parse(lblfld.Text);
            int cantLechea = int.Parse(lblfla.Text);


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

            lblfc.Text = "0";  //caliente   
            lblff.Text = "0";  //frio
            lblfa.Text = "0";  //azucar
            lblfam.Text = "0"; //azucarm
            lblfs.Text = "0";  //splenda
            lblfcan.Text = "0"; //canela
            lblfle.Text = "0";  //Leche Entera
            lblfld.Text = "0";  //Leche Deslactosada
            lblfla.Text = "0";   //Leche de Almendras

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
