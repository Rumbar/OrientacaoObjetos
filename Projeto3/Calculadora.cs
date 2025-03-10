using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto3
{
     public class Calculadora
    {
         public static double Circunferencia(double r)
        {
            return 2 * r * Pi;
        }
        public static double Volume(double r)
        {
            return 4 / 3 * Pi * Math.Pow(r, 3);
        }

        public static double Pi = 3.14;
    }
}
