using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Honey_Cloud_Coffee
{

    // DECORATOR BASE


    public abstract class LatteExtras : Bebida
    {
        protected Bebida bebida;

        public LatteExtras(Bebida bebida)
        {
            this.bebida = bebida;
        }
    }


    // CANELA


    public class Canela : LatteExtras
    {
        public Canela(Bebida bebida) : base(bebida)
        {
        }

        public override string Descripcion()
        {
            return bebida.Descripcion() + " + Canela";
        }

        public override double Costo()
        {
            return bebida.Costo() + 0;
        }
    }

 
    // LECHE ENTERA


    public class LecheEntera : LatteExtras
    {
        public LecheEntera(Bebida bebida) : base(bebida)
        {
        }

        public override string Descripcion()
        {
            return bebida.Descripcion() + " + Leche Entera";
        }

        public override double Costo()
        {
            return bebida.Costo() + 0;
        }
    }


    // LECHE DESLACTOSADA


    public class LecheDeslactosada : LatteExtras
    {
        public LecheDeslactosada(Bebida bebida) : base(bebida)
        {
        }

        public override string Descripcion()
        {
            return bebida.Descripcion() + " + Leche Deslactosada";
        }

        public override double Costo()
        {
            return bebida.Costo() + 15;
        }
    }


    // LECHE DE ALMENDRAS


    public class LecheAlmendras : LatteExtras
    {
        public LecheAlmendras(Bebida bebida) : base(bebida)
        {
        }

        public override string Descripcion()
        {
            return bebida.Descripcion() + " + Leche de Almendras";
        }

        public override double Costo()
        {
            return bebida.Costo() + 20;
        }
    }


    // AZÚCAR


    public class Azucar : LatteExtras
    {
        public Azucar(Bebida bebida) : base(bebida)
        {
        }

        public override string Descripcion()
        {
            return bebida.Descripcion() + " + Azúcar";
        }

        public override double Costo()
        {
            return bebida.Costo() + 0;
        }
    }

    // AZÚCAR MASCABADO


    public class AzucarMascabado : LatteExtras
    {
        public AzucarMascabado(Bebida bebida) : base(bebida)
        {
        }

        public override string Descripcion()
        {
            return bebida.Descripcion() + " + Azúcar Mascabado";
        }

        public override double Costo()
        {
            return bebida.Costo() + 5;
        }
    }


    // SPLENDA


    public class Splenda : LatteExtras
    {
        public Splenda(Bebida bebida) : base(bebida)
        {
        }

        public override string Descripcion()
        {
            return bebida.Descripcion() + " + Splenda";
        }

        public override double Costo()
        {
            return bebida.Costo() + 5;
        }
    }


    // CALIENTE


    public class Caliente : LatteExtras
    {
        public Caliente(Bebida bebida) : base(bebida)
        {
        }

        public override string Descripcion()
        {
            return bebida.Descripcion() + " (Caliente)";
        }

        public override double Costo()
        {
            return bebida.Costo();
        }
    }


    // FRÍA


    public class Fria : LatteExtras
    {
        public Fria(Bebida bebida) : base(bebida)
        {
        }

        public override string Descripcion()
        {
            return bebida.Descripcion() + " (Fría)";
        }

        public override double Costo()
        {
            return bebida.Costo() + 5;
        }
    }
}
