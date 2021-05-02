using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taCompensando
{
    public abstract class Simulador
    {
        public static double Indicar(double a, double g)
        {
            return a / g;
        }

        public static double Calcular(double km, double l)
        {
            return km * l;
        }
    }
}
