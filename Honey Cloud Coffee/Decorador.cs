using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Honey_Cloud_Coffee
{

    // DECORATOR BASE


    public abstract class Extras : Bebida
    {
        protected Bebida bebida;

        public Extras(Bebida bebida)
        {
            this.bebida = bebida;
        }
    }


    // CANELA


    public class Canela : Extras
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


    public class LecheEntera : Extras
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


    public class LecheDeslactosada : Extras
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


    public class LecheAlmendras : Extras
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


    public class Azucar : Extras
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


    public class AzucarMascabado : Extras
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


    public class Splenda : Extras
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


    public class Caliente : Extras
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


    public class Fria : Extras
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
