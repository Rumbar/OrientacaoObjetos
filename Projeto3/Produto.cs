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
        private string _nome;
        public double Preco { get; private set; }
        public int Quant {  get; private set; }

        public Produto() {}
        public Produto(string nome, double preco, int quant) 
        {
            _nome = nome;
            Preco = preco;
            Quant = quant;
        }

        public string Nome
        {
            get { return _nome;}
            set {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

               
    
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
            return _nome
                + ", $ " 
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                +", "
                + Quant
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);

        }

       

    }

}
