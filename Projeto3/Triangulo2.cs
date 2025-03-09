using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto3
{
    public class Triangulo2
    {
        public double altura;
        public double largura;



         public double Area()
         {
            return altura * largura;
         }

        public double Perimetro()
        {
            return 2*(altura + largura);
        }

        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(altura, 2) + (Math.Pow(largura, 2)));
        }

        public override string ToString()
        {
            return "Area:" + Area()
                + " "
                + "Perimetro: " + Perimetro()
                + " "
                + "Diagona: " + Diagonal();
        }


    }
}
