using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Projeto3
{
    internal class Banco
    {

        public int NumConta { get;  private set; }
        public string Nome {  get; set; }
        public double Saldo { get; private set; }
        
        

        public Banco (int numConta, string nome)
        {
            NumConta = numConta;
            Nome = nome;
        }

        public Banco (int numConta, string nome, double depositoInicial) : this (numConta,nome)
        {
            Deposito(depositoInicial);
        }

        public void Deposito(double quantia)
        {
           Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia + 5;
        }

        public override string ToString()
        {
            return "Conta " + NumConta 
                +", Titular: "+ Nome
                +", Saldo: R$"+ Saldo.ToString("F2" + CultureInfo.InvariantCulture);
        }
    }
}
