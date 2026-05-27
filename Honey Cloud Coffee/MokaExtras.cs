using System;
using System.Windows.Forms;

namespace Honey_Cloud_Coffee
{
    public partial class MokaExtras : Form
    {
        private Bebida miBebidaSeleccionada;
        private Pedido pedido;

        public MokaExtras()
        {
            InitializeComponent();
            this.miBebidaSeleccionada = new Moka();
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
        private void calientemok_Click(object sender, EventArgs e)
        {
            int cantidadCaliente = int.Parse(lblmk1.Text);
            if (cantidadCaliente > 0)
            {
                cantidadCaliente--;
                lblmk1.Text = cantidadCaliente.ToString();
                ActualizarPedido();
            }
        }

        private void mokcaliente_Click(object sender, EventArgs e)
        {
            int cantidadCaliente = int.Parse(lblmk1.Text);
            cantidadCaliente++;
            lblmk1.Text = cantidadCaliente.ToString();
            ActualizarPedido();
        }

        // Frío
        private void friomok_Click(object sender, EventArgs e)
        {
            int cantidadFrio = int.Parse(lblmk2.Text);
            if (cantidadFrio > 0)
            {
                cantidadFrio--;
                lblmk2.Text = cantidadFrio.ToString();
                ActualizarPedido();
            }
        }

        private void mokfrio_Click(object sender, EventArgs e)
        {
            int cantidadFrio = int.Parse(lblmk2.Text);
            cantidadFrio++;
            lblmk2.Text = cantidadFrio.ToString();
            ActualizarPedido();
        }

        // Azúcar
        private void azucarmok_Click(object sender, EventArgs e)
        {
            int cantidadAzucar = int.Parse(lblmk3.Text);
            if (cantidadAzucar > 0)
            {
                cantidadAzucar--;
                lblmk3.Text = cantidadAzucar.ToString();
                ActualizarPedido();
            }
        }

        private void mokazucar_Click(object sender, EventArgs e)
        {
            int cantidadAzucar = int.Parse(lblmk3.Text);
            cantidadAzucar++;
            lblmk3.Text = cantidadAzucar.ToString();
            ActualizarPedido();
        }

        // Azúcar Mascabado
        private void azucarmmok_Click(object sender, EventArgs e)
        {
            int cantidadAzucarM = int.Parse(lblmk4.Text);
            if (cantidadAzucarM > 0)
            {
                cantidadAzucarM--;
                lblmk4.Text = cantidadAzucarM.ToString();
                ActualizarPedido();
            }
        }

        private void mokazucarm_Click(object sender, EventArgs e)
        {
            int cantidadAzucarM = int.Parse(lblmk4.Text);
            cantidadAzucarM++;
            lblmk4.Text = cantidadAzucarM.ToString();
            ActualizarPedido();
        }

        // Splenda
        private void splendamok_Click(object sender, EventArgs e)
        {
            int cantidadSplenda = int.Parse(lblmk5.Text);
            if (cantidadSplenda > 0)
            {
                cantidadSplenda--;
                lblmk5.Text = cantidadSplenda.ToString();
                ActualizarPedido();
            }
        }

        private void moksplenda_Click(object sender, EventArgs e)
        {
            int cantidadSplenda = int.Parse(lblmk5.Text);
            cantidadSplenda++;
            lblmk5.Text = cantidadSplenda.ToString();
            ActualizarPedido();
        }

        // Canela
        private void canelamok_Click(object sender, EventArgs e)
        {
            int cantidadCanela = int.Parse(lblmk6.Text);
            if (cantidadCanela > 0)
            {
                cantidadCanela--;
                lblmk6.Text = cantidadCanela.ToString();
                ActualizarPedido();
            }
        }

        private void mokcanela_Click(object sender, EventArgs e)
        {
            int cantidadCanela = int.Parse(lblmk6.Text);
            cantidadCanela++;
            lblmk6.Text = cantidadCanela.ToString();
            ActualizarPedido();
        }

        // Leche Entera
        private void enteramok_Click(object sender, EventArgs e)
        {
            int cantidadLechee = int.Parse(lblmk7.Text);
            if (cantidadLechee > 0)
            {
                cantidadLechee--;
                lblmk7.Text = cantidadLechee.ToString();
                ActualizarPedido();
            }
        }

        private void mokentera_Click(object sender, EventArgs e)
        {
            int cantidadLechee = int.Parse(lblmk7.Text);
            cantidadLechee++;
            lblmk7.Text = cantidadLechee.ToString();
            ActualizarPedido();
        }

        // Leche Deslactosada
        private void deslmok_Click(object sender, EventArgs e)
        {
            int cantidadLeched = int.Parse(lblmk8.Text);
            if (cantidadLeched > 0)
            {
                cantidadLeched--;
                lblmk8.Text = cantidadLeched.ToString();
                ActualizarPedido();
            }
        }

        private void mokdesl_Click(object sender, EventArgs e)
        {
            int cantidadLeched = int.Parse(lblmk8.Text);
            cantidadLeched++;
            lblmk8.Text = cantidadLeched.ToString();
            ActualizarPedido();
        }

        // Leche de Almendras
        private void almendmok_Click(object sender, EventArgs e)
        {
            int cantidadLechea = int.Parse(lblmk9.Text);
            if (cantidadLechea > 0)
            {
                cantidadLechea--;
                lblmk9.Text = cantidadLechea.ToString();
                ActualizarPedido();
            }
        }

        private void mokalmend_Click(object sender, EventArgs e)
        {
            int cantidadLechea = int.Parse(lblmk9.Text);
            cantidadLechea++;
            lblmk9.Text = cantidadLechea.ToString();
            ActualizarPedido();
        }

        private void ActualizarPedido()
        {
            if (miBebidaSeleccionada == null) return;

            // Iniciamos con la bebida base
            Bebida pedidoFinal = miBebidaSeleccionada;

            int cantCaliente = int.Parse(lblmk1.Text);
            for (int i = 0; i < cantCaliente; i++)
                pedidoFinal = new Caliente(pedidoFinal);

            int cantFrio = int.Parse(lblmk2.Text);
            for (int i = 0; i < cantFrio; i++)
                pedidoFinal = new Fria(pedidoFinal);

            int cantAzucar = int.Parse(lblmk3.Text);
            for (int i = 0; i < cantAzucar; i++)
                pedidoFinal = new Azucar(pedidoFinal);

            int cantAzucarM = int.Parse(lblmk4.Text);
            for (int i = 0; i < cantAzucarM; i++)
                pedidoFinal = new AzucarMascabado(pedidoFinal);

            int cantSplenda = int.Parse(lblmk5.Text);
            for (int i = 0; i < cantSplenda; i++)
                pedidoFinal = new Splenda(pedidoFinal);

            int cantCanela = int.Parse(lblmk6.Text);
            for (int i = 0; i < cantCanela; i++)
                pedidoFinal = new Canela(pedidoFinal);

            int cantLechee = int.Parse(lblmk7.Text);
            for (int i = 0; i < cantLechee; i++)
                pedidoFinal = new LecheEntera(pedidoFinal);

            int cantLeched = int.Parse(lblmk8.Text);
            for (int i = 0; i < cantLeched; i++)
                pedidoFinal = new LecheDeslactosada(pedidoFinal);

            int cantLechea = int.Parse(lblmk9.Text);
            for (int i = 0; i < cantLechea; i++)
                pedidoFinal = new LecheAlmendras(pedidoFinal);

            // Nota: pedidoFinal no se almacena; solo se construye.
        }

        private void btnPedidoMoka_Click(object sender, EventArgs e)
        {
            if (miBebidaSeleccionada == null) return;

            int cantCaliente = int.Parse(lblmk1.Text);
            int cantFrio = int.Parse(lblmk2.Text);
            int cantAzucar = int.Parse(lblmk3.Text);
            int cantAzucarM = int.Parse(lblmk4.Text);
            int cantSplenda = int.Parse(lblmk5.Text);
            int cantCanela = int.Parse(lblmk6.Text);
            int cantLechee = int.Parse(lblmk7.Text);
            int cantLeched = int.Parse(lblmk8.Text);
            int cantLechea = int.Parse(lblmk9.Text);

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
            lblmk1.Text = "0";
            lblmk2.Text = "0";
            lblmk3.Text = "0";
            lblmk4.Text = "0";
            lblmk5.Text = "0";
            lblmk6.Text = "0";
            lblmk7.Text = "0";
            lblmk8.Text = "0";
            lblmk9.Text = "0";

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