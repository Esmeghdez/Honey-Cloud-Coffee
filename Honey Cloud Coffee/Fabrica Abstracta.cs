using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Honey_Cloud_Coffee
{
    
    // CLASE ABSTRACTA BEBIDA

    public abstract class Bebida
    {
        public abstract string Descripcion();
        public abstract double Costo();
    }

    // ABSTRACT FACTORY

    public abstract class Cafeteria
    {
        public abstract Bebida CrearBebida(string tipo);
    }

 
    // BEBIDAS CON CAFÉ


    public class Latte : Bebida
    {
        public override string Descripcion()
        {
            return "Latte";
        }

        public override double Costo()
        {
            return 70;
        }
    }

    public class Capuccino : Bebida
    {
        public override string Descripcion()
        {
            return "Capuccino";
        }

        public override double Costo()
        {
            return 70;
        }
    }

    public class Moka : Bebida
    {
        public override string Descripcion()
        {
            return "Moka";
        }

        public override double Costo()
        {
            return 70;
        }
    }

    public class DirtyChai : Bebida
    {
        public override string Descripcion()
        {
            return "Dirty Chai";
        }

        public override double Costo()
        {
            return 70;
        }
    }


    // BEBIDAS SIN CAFÉ


    public class Chai : Bebida
    {
        public override string Descripcion()
        {
            return "Chai";
        }

        public override double Costo()
        {
            return 65;
        }
    }

    public class Matcha : Bebida
    {
        public override string Descripcion()
        {
            return "Matcha";
        }

        public override double Costo()
        {
            return 70;
        }
    }


    // TÉS


    public class FrutosRojos : Bebida
    {
        public override string Descripcion()
        {
            return "Té de Frutos Rojos";
        }

        public override double Costo()
        {
            return 60;
        }
    }

    public class Manzanilla : Bebida
    {
        public override string Descripcion()
        {
            return "Té de Manzanilla";
        }

        public override double Costo()
        {
            return 60;
        }
    }


    // FACTORY BEBIDAS CON CAFÉ


    public class BebidasConCafe : Cafeteria
    {
        public override Bebida CrearBebida(string tipo)
        {
            switch (tipo)
            {
                case "Latte":
                    return new Latte();

                case "Capuccino":
                    return new Capuccino();

                case "Moka":
                    return new Moka();

                case "Dirty Chai":
                    return new DirtyChai();

                default:
                    return null;
            }
        }
    }

    // FACTORY BEBIDAS SIN CAFÉ


    public class BebidasSinCafe : Cafeteria
    {
        public override Bebida CrearBebida(string tipo)
        {
            switch (tipo)
            {
                case "Chai":
                    return new Chai();

                case "Matcha":
                    return new Matcha();

                default:
                    return null;
            }
        }
    }

    // FACTORY TÉS


    public class Tes : Cafeteria
    {
        public override Bebida CrearBebida(string tipo)
        {
            switch (tipo)
            {
                case "Frutos Rojos":
                    return new FrutosRojos();

                case "Manzanilla":
                    return new Manzanilla();

                default:
                    return null;
            }
        }
    }
}