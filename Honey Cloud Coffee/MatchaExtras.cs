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
    public partial class MatchaExtras : Form
    {
        private Bebida miBebidaSeleccionada;
        private Pedido pedido;

        public MatchaExtras()
        {
            InitializeComponent();
            this.miBebidaSeleccionada = new Matcha();
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
        // Caliente -
        private void calientemat_Click(object sender, EventArgs e)
        {
            int cantidadCaliente = int.Parse(lblm1.Text);
            if (cantidadCaliente > 0)
            {
                cantidadCaliente--;
                lblm1.Text = cantidadCaliente.ToString();
                ActualizarPedido();
            }
        }

        private void matcaliente_Click(object sender, EventArgs e)
        {
            int cantidadCaliente = int.Parse(lblm1.Text);
            cantidadCaliente++;
            lblm1.Text = cantidadCaliente.ToString();
            ActualizarPedido();
        }

        //-------------------------------------------------------------
        // Frio -
        private void friomat_Click(object sender, EventArgs e)
        {
            int cantidadFrio = int.Parse(lblm2.Text);
            if (cantidadFrio > 0)
            {
                cantidadFrio--;
                lblm2.Text = cantidadFrio.ToString();
                ActualizarPedido();
            }
        }

        private void matfrio_Click(object sender, EventArgs e)
        {
            int cantidadFrio = int.Parse(lblm2.Text);
            cantidadFrio++;
            lblm2.Text = cantidadFrio.ToString();
            ActualizarPedido();
        }

        //-------------------------------------------------------------
        // Azucar -
        private void azucarmat_Click(object sender, EventArgs e)
        {
            int cantidadAzucar = int.Parse(lblm3.Text);
            if (cantidadAzucar > 0)
            {
                cantidadAzucar--;
                lblm3.Text = cantidadAzucar.ToString();
                ActualizarPedido();
            }
        }

        private void matazucar_Click(object sender, EventArgs e)
        {
            int cantidadAzucar = int.Parse(lblm3.Text);
            cantidadAzucar++;
            lblm3.Text = cantidadAzucar.ToString();
            ActualizarPedido();
        }

        //-------------------------------------------------------------
        // Azucar Mascabado -
        private void azucarmmat_Click(object sender, EventArgs e)
        {
            int cantidadAzucarM = int.Parse(lblm4.Text);
            if (cantidadAzucarM > 0)
            {
                cantidadAzucarM--;
                lblm4.Text = cantidadAzucarM.ToString();
                ActualizarPedido();
            }
        }

        private void matazucarm_Click(object sender, EventArgs e)
        {
            int cantidadAzucarM = int.Parse(lblm4.Text);
            cantidadAzucarM++;
            lblm4.Text = cantidadAzucarM.ToString();
            ActualizarPedido();
        }

        //-------------------------------------------------------------
        // Splenda -
        private void splendamat_Click(object sender, EventArgs e)
        {
            int cantidadSplenda = int.Parse(lblm5.Text);
            if (cantidadSplenda > 0)
            {
                cantidadSplenda--;
                lblm5.Text = cantidadSplenda.ToString();
                ActualizarPedido();
            }
        }

        private void matsplenda_Click(object sender, EventArgs e)
        {
            int cantidadSplenda = int.Parse(lblm5.Text);
            cantidadSplenda++;
            lblm5.Text = cantidadSplenda.ToString();
            ActualizarPedido();
        }

        //-------------------------------------------------------------
        // Canela -
        private void canelamat_Click(object sender, EventArgs e)
        {
            int cantidadCanela = int.Parse(lblm6.Text);
            if (cantidadCanela > 0)
            {
                cantidadCanela--;
                lblm6.Text = cantidadCanela.ToString();
                ActualizarPedido();
            }
        }

        private void matcanela_Click(object sender, EventArgs e)
        {
            int cantidadCanela = int.Parse(lblm6.Text);
            cantidadCanela++;
            lblm6.Text = cantidadCanela.ToString();
            ActualizarPedido();
        }

        //-------------------------------------------------------------
        // Leche Entera -
        private void enteramat_Click(object sender, EventArgs e)
        {
            int cantidadLechee = int.Parse(lblm7.Text);
            if (cantidadLechee > 0)
            {
                cantidadLechee--;
                lblm7.Text = cantidadLechee.ToString();
                ActualizarPedido();
            }
        }

        private void matentera_Click(object sender, EventArgs e)
        {
            int cantidadLechee = int.Parse(lblm7.Text);
            cantidadLechee++;
            lblm7.Text = cantidadLechee.ToString();
            ActualizarPedido();
        }

        //-------------------------------------------------------------
        // Leche Deslactosada -
        private void deslmat_Click(object sender, EventArgs e)
        {
            int cantidadLeched = int.Parse(lblm8.Text);
            if (cantidadLeched > 0)
            {
                cantidadLeched--;
                lblm8.Text = cantidadLeched.ToString();
                ActualizarPedido();
            }
        }

        private void matdesl_Click(object sender, EventArgs e)
        {
            int cantidadLeched = int.Parse(lblm8.Text);
            cantidadLeched++;
            lblm8.Text = cantidadLeched.ToString();
            ActualizarPedido();
        }

        //-------------------------------------------------------------
        // Leche de Almendras -
        private void almenmat_Click(object sender, EventArgs e)
        {
            int cantidadLechea = int.Parse(lblm9.Text);
            if (cantidadLechea > 0)
            {
                cantidadLechea--;
                lblm9.Text = cantidadLechea.ToString();
                ActualizarPedido();
            }
        }

        private void matalmend_Click(object sender, EventArgs e)
        {
            int cantidadLechea = int.Parse(lblm9.Text);
            cantidadLechea++;
            lblm9.Text = cantidadLechea.ToString();
            ActualizarPedido();
        }

        //-------------------------------------------------------------
        private void ActualizarPedido()
        {
            if (miBebidaSeleccionada == null) return;

            Bebida pedidoFinal = miBebidaSeleccionada;

            int cantCaliente = int.Parse(lblm1.Text);
            for (int i = 0; i < cantCaliente; i++)
                pedidoFinal = new Caliente(pedidoFinal);

            int cantFrio = int.Parse(lblm2.Text);
            for (int i = 0; i < cantFrio; i++)
                pedidoFinal = new Fria(pedidoFinal);

            int cantAzucar = int.Parse(lblm3.Text);
            for (int i = 0; i < cantAzucar; i++)
                pedidoFinal = new Azucar(pedidoFinal);

            int cantAzucarM = int.Parse(lblm4.Text);
            for (int i = 0; i < cantAzucarM; i++)
                pedidoFinal = new AzucarMascabado(pedidoFinal);

            int cantSplenda = int.Parse(lblm5.Text);
            for (int i = 0; i < cantSplenda; i++)
                pedidoFinal = new Splenda(pedidoFinal);

            int cantCanela = int.Parse(lblm6.Text);
            for (int i = 0; i < cantCanela; i++)
                pedidoFinal = new Canela(pedidoFinal);

            int cantLechee = int.Parse(lblm7.Text);
            for (int i = 0; i < cantLechee; i++)
                pedidoFinal = new LecheEntera(pedidoFinal);

            int cantLeched = int.Parse(lblm8.Text);
            for (int i = 0; i < cantLeched; i++)
                pedidoFinal = new LecheDeslactosada(pedidoFinal);

            int cantLechea = int.Parse(lblm9.Text);
            for (int i = 0; i < cantLechea; i++)
                pedidoFinal = new LecheAlmendras(pedidoFinal);
        }

        //-------------------------------------------------------------
        // Pedido terminado
        private void btnPedidoMatcha_Click(object sender, EventArgs e)
        {
            if (miBebidaSeleccionada == null) return;

            int cantCaliente = int.Parse(lblm1.Text);
            int cantFrio = int.Parse(lblm2.Text);
            int cantAzucar = int.Parse(lblm3.Text);
            int cantAzucarM = int.Parse(lblm4.Text);
            int cantSplenda = int.Parse(lblm5.Text);
            int cantCanela = int.Parse(lblm6.Text);
            int cantLechee = int.Parse(lblm7.Text);
            int cantLeched = int.Parse(lblm8.Text);
            int cantLechea = int.Parse(lblm9.Text);

            Bebida pedidoFinal = miBebidaSeleccionada;

            for (int i = 0; i < cantCaliente; i++) pedidoFinal = new Caliente(pedidoFinal);
            for (int i = 0; i < cantFrio; i++) pedidoFinal = new Fria(pedidoFinal);
            for (int i = 0; i < cantAzucar; i++) pedidoFinal = new Azucar(pedidoFinal);
            for (int i = 0; i < cantAzucarM; i++) pedidoFinal = new AzucarMascabado(pedidoFinal);
            for (int i = 0; i < cantSplenda; i++) pedidoFinal = new Splenda(pedidoFinal);
            for (int i = 0; i < cantCanela; i++) pedidoFinal = new Canela(pedidoFinal);
            for (int i = 0; i < cantLechee; i++) pedidoFinal = new LecheEntera(pedidoFinal);
            for (int i = 0; i < cantLeched; i++) pedidoFinal = new LecheDeslactosada(pedidoFinal);
            for (int i = 0; i < cantLechea; i++) pedidoFinal = new LecheAlmendras(pedidoFinal);

            double precioFinal = pedidoFinal.Costo();
            string nombreBebidaBase = miBebidaSeleccionada.Descripcion();
            string especificacionesLimpias = "";

            if (cantCaliente > 0) especificacionesLimpias += $"\n   , Caliente (x{cantCaliente})";
            if (cantFrio > 0) especificacionesLimpias += $"\n   , Frío (x{cantFrio})";
            if (cantAzucar > 0) especificacionesLimpias += $"\n   , Azucar (x{cantAzucar})";
            if (cantAzucarM > 0) especificacionesLimpias += $"\n   , Azucar Mascabado (x{cantAzucarM})";
            if (cantSplenda > 0) especificacionesLimpias += $"\n   , Splenda (x{cantSplenda})";
            if (cantCanela > 0) especificacionesLimpias += $"\n   , Canela (x{cantCanela})";
            if (cantLechee > 0) especificacionesLimpias += $"\n   , Leche Entera (x{cantLechee})";
            if (cantLeched > 0) especificacionesLimpias += $"\n   , Leche deslactosada (x{cantLeched})";
            if (cantLechea > 0) especificacionesLimpias += $"\n   , Leche de Almendras (x{cantLechea})";

            // ✅ Avanzar estado: Editando → Confirmado
            pedido.Avanzar();
            EstadoPedido.Text = pedido.ObtenerEstado();

            MessageBox.Show($"¡Pedido Completado Exitosamente!\n\n" +
                            $"Bebida: {nombreBebidaBase}\n" +
                            $"Especificaciones:{especificacionesLimpias}\n\n" +
                            $"Total a Pagar: ${precioFinal.ToString("N2", System.Globalization.CultureInfo.InvariantCulture)}",
                            "Honey Cloud Coffee",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            // Reset labels
            lblm1.Text = "0";
            lblm2.Text = "0";
            lblm3.Text = "0";
            lblm4.Text = "0";
            lblm5.Text = "0";
            lblm6.Text = "0";
            lblm7.Text = "0";
            lblm8.Text = "0";
            lblm9.Text = "0";

            // ✅ Nuevo pedido en estado inicial
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