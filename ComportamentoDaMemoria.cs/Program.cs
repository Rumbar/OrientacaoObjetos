using System;
using System.Collections.Concurrent;
using System.Globalization;
using ComportamentoDaMemoria;
class Program
{
    static void Main(string[] args)
    {
        //TipoRefTipoVal();
        //Nullable();
        //Vetores();
        //Vetores2();
        ExercicioDeFixacao();

    static void TipoRefTipoVal()
    {
        Ponto p = new Ponto();
        Console.WriteLine(p);
    }
    static void Nullable()
    {
        double? x = null;
        double? y = 10.00;

        Console.WriteLine(x.GetValueOrDefault());
        Console.WriteLine(y.GetValueOrDefault());

        Console.WriteLine(x.HasValue);
        Console.WriteLine(y.HasValue);

        if (x.HasValue)
        {
            Console.WriteLine(x.Value);
        }
        else
            Console.WriteLine("X is null");

        if (y.HasValue)
        {
            Console.WriteLine(y.Value);
        }
        else
            Console.WriteLine("Y is null");

        double ? a  = x ?? 5;
        double ? b = y ?? 5;

        Console.WriteLine(a);
        Console.WriteLine(b);
    }

    static void Vetores()
    {
        Console.Write("Digite quantas alturas você vai digitar: ");
        int n = int.Parse(Console.ReadLine());

        double[] vect = new double[n];
        double a = 0;

        for (int i = 0; i < n; i++)
        {
            vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a += vect[i];
        }

        double media = a / n;

        Console.WriteLine("A media de altura é: " + media.ToString("F2"));

    }

    static void Vetores2()
    {
        int n=int.Parse(Console.ReadLine());
        Produto[] vect = new Produto[n];
        double soma = 0;
        for (int i = 0;i < n; i++)
        {
            string nome=Console.ReadLine();
            double preco=double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            vect[i] = new Produto { Name = nome, Price = preco };

            soma += vect[i].Price;
        }

       soma = soma / n;

        Console.WriteLine("A media de preços é " + soma.ToString("F2"));
    }

}
