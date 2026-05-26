using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Honey_Cloud_Coffee
{
    public interface IEstadoPedido
    {
        string NombreEstado();

        void SiguienteEstado(Pedido pedido);

        bool PuedeModificarExtras();
     

    }
}
