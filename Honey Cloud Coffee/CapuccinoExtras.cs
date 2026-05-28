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
        private Pedido pedido;
        private Cafeteria fabricaCafe;

        public CapuccinoExtras()
        {
            InitializeComponent();
            this.fabricaCafe = new BebidasConCafe();

            this.miBebidaSeleccionada = fabricaCafe.CrearBebida("Capuccino");

            this.pedido = new Pedido(miBebidaSeleccionada);
            EstadoPedido.Text = pedido.ObtenerEstado();
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

        // Caliente
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

        // Frío
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

        // Azúcar
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

        // Azúcar mascabado
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

        // Splenda
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

        // Canela
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

        // Leche entera
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

        // Leche deslactosada
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

        // Leche de almendras
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

            Bebida pedidoFinal = miBebidaSeleccionada;

            int cantCaliente = int.Parse(lblp1.Text);
            for (int i = 0; i < cantCaliente; i++)
                pedidoFinal = new Caliente(pedidoFinal);

            int cantFrio = int.Parse(lblp2.Text);
            for (int i = 0; i < cantFrio; i++)
                pedidoFinal = new Fria(pedidoFinal);

            int cantAzucar = int.Parse(lblp3.Text);
            for (int i = 0; i < cantAzucar; i++)
                pedidoFinal = new Azucar(pedidoFinal);

            int cantAzucarM = int.Parse(lblp4.Text);
            for (int i = 0; i < cantAzucarM; i++)
                pedidoFinal = new AzucarMascabado(pedidoFinal);

            int cantSplenda = int.Parse(lblp5.Text);
            for (int i = 0; i < cantSplenda; i++)
                pedidoFinal = new Splenda(pedidoFinal);

            int cantCanela = int.Parse(lblp6.Text);
            for (int i = 0; i < cantCanela; i++)
                pedidoFinal = new Canela(pedidoFinal);

            int cantLechee = int.Parse(lblp7.Text);
            for (int i = 0; i < cantLechee; i++)
                pedidoFinal = new LecheEntera(pedidoFinal);

            int cantLeched = int.Parse(lblp8.Text);
            for (int i = 0; i < cantLeched; i++)
                pedidoFinal = new LecheDeslactosada(pedidoFinal);

            int cantLechea = int.Parse(lblp9.Text);
            for (int i = 0; i < cantLechea; i++)
                pedidoFinal = new LecheAlmendras(pedidoFinal);

            // Si se desea actualizar el precio o estado visible, se puede hacer aquí.
            // Por ahora solo se construye el objeto (no se almacena).
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (miBebidaSeleccionada == null) return;

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

            pedido.Avanzar();
            EstadoPedido.Text = pedido.ObtenerEstado();

            MessageBox.Show($"¡Pedido Completado Exitosamente!\n\n" +
                            $"Bebida: {nombreBebidaBase}\n" +
                            $"Especificaciones:{especificacionesLimpias}\n\n" +
                            $"Total a Pagar: ${precioFinal.ToString("N2", System.Globalization.CultureInfo.InvariantCulture)}",
                            "Honey Cloud Coffee",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            // Reiniciar contadores
            lblp1.Text = "0";
            lblp2.Text = "0";
            lblp3.Text = "0";
            lblp4.Text = "0";
            lblp5.Text = "0";
            lblp6.Text = "0";
            lblp7.Text = "0";
            lblp8.Text = "0";
            lblp9.Text = "0";

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