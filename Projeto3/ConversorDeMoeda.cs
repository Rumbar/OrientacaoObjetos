using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto3
{
    public class ConversorDeMoeda
    {
        public static double Conversor (double moeda, double cotacao)
        {
            double total = cotacao * moeda;
            return total + total * 6/100;
        }
    }
}
