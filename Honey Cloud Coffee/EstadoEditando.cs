using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Honey_Cloud_Coffee
{
    public class EstadoEditando : IEstadoPedido
    {
        public string NombreEstado() => "Editando";
        public bool PuedeModificarExtras() => true;
        public void SiguienteEstado(Pedido pedido) =>
            pedido.CambiarEstado(new EstadoConfirmado());
    }
}
