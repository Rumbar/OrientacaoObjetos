using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Projeto3
{
     class Produto
    {
        public string Nome;
        public double Preco;
        public int Quant;
        
        


        public double ValorTotalEmEstoque()
        {
            return Preco * Quant;
        }

        public void AdicionarProdutos(int atualizacao)
        {

            Quant = atualizacao + Quant;

        }

        public void RemoverProduto(int remocao)
        {
            Quant = Quant - remocao;
        }


        public override string ToString()
        {
            return Nome 
                + ", $ " 
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                +", "
                + Quant
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);

        }

       

    }

}
