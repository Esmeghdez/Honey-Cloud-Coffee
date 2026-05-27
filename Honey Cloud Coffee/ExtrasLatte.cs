using System;
using System.Windows.Forms;

namespace Honey_Cloud_Coffee
{
    public partial class ExtrasLatte : Form
    {
        private Bebida miBebidaSeleccionada;
        private Pedido pedido;

        public ExtrasLatte()
        {
            InitializeComponent();
            this.miBebidaSeleccionada = new Latte();
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
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMenu menu = new FormMenu();
            menu.Show();
            this.Hide();
        }

        // Caliente
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

        // Frío
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

        // Azúcar
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

        // Azúcar Mascabado
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

        // Splenda
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

        // Canela
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

        // Leche Entera
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

        // Leche Deslactosada
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

        // Leche de Almendras
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

        private void ActualizarPedido()
        {
            if (miBebidaSeleccionada == null) return;

            // Iniciamos con la bebida base
            Bebida pedidoFinal = miBebidaSeleccionada;

            int cantCaliente = int.Parse(lbll1.Text);
            for (int i = 0; i < cantCaliente; i++)
                pedidoFinal = new Caliente(pedidoFinal);

            int cantFrio = int.Parse(lbll2.Text);
            for (int i = 0; i < cantFrio; i++)
                pedidoFinal = new Fria(pedidoFinal);

            int cantAzucar = int.Parse(lbll3.Text);
            for (int i = 0; i < cantAzucar; i++)
                pedidoFinal = new Azucar(pedidoFinal);

            int cantAzucarM = int.Parse(lbll4.Text);
            for (int i = 0; i < cantAzucarM; i++)
                pedidoFinal = new AzucarMascabado(pedidoFinal);

            int cantSplenda = int.Parse(lbll5.Text);
            for (int i = 0; i < cantSplenda; i++)
                pedidoFinal = new Splenda(pedidoFinal);

            int cantCanela = int.Parse(lbll6.Text);
            for (int i = 0; i < cantCanela; i++)
                pedidoFinal = new Canela(pedidoFinal);

            int cantLechee = int.Parse(lbll7.Text);
            for (int i = 0; i < cantLechee; i++)
                pedidoFinal = new LecheEntera(pedidoFinal);

            int cantLeched = int.Parse(lbll8.Text);
            for (int i = 0; i < cantLeched; i++)
                pedidoFinal = new LecheDeslactosada(pedidoFinal);

            int cantLechea = int.Parse(lbll9.Text);
            for (int i = 0; i < cantLechea; i++)
                pedidoFinal = new LecheAlmendras(pedidoFinal);

            // Nota: pedidoFinal no se almacena, solo se construye.
            // Si se desea mostrar precio actualizado, se puede agregar aquí.
        }

        private void btnPedidolatte_Click(object sender, EventArgs e)
        {
            if (miBebidaSeleccionada == null) return;

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
            lbll1.Text = "0";
            lbll2.Text = "0";
            lbll3.Text = "0";
            lbll4.Text = "0";
            lbll5.Text = "0";
            lbll6.Text = "0";
            lbll7.Text = "0";
            lbll8.Text = "0";
            lbll9.Text = "0";

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