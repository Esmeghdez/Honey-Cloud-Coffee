using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Honey_Cloud_Coffee
{
    public class Pedido
    {
        public Bebida Bebida { get; set; }

        public IEstadoPedido Estado { get; private set; }

        public Pedido(Bebida bebida)
        {
            Bebida = bebida;

            // Estado inicial
            Estado = new EstadoEditando();
        }

        public void CambiarEstado(IEstadoPedido nuevoEstado)
        {
            Estado = nuevoEstado;
        }

        public void Avanzar()
        {
            Estado.SiguienteEstado(this);
        }

        public bool PuedeEditar()
        {
            return Estado.PuedeModificarExtras();
        }

        public string ObtenerEstado()
        {
            return Estado.NombreEstado();
        }
    }
}