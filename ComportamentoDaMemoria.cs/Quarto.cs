using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComportamentoDaMemoria
{
    internal class Quarto
    {

        public string Locatario { get; set; }
        public string Email { get; set; }
        public int Id { get; set; }

        public override string ToString()
        {
            return Id+": " + Locatario + ", " + Email;
        }


    }
}
