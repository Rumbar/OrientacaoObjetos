using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ComportamentoDaMemoria
{
    internal class Calculadora
    {
    public static void Triplicador(ref int x)
        {
            x = x * 3;
        }

    public static void Triple(int origin, out int result)
        {
            result = origin * 3;
        }
    }
}
