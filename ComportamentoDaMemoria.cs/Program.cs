using System;
using System.Collections.Concurrent;
using System.Globalization;
using System.Numerics;
using ComportamentoDaMemoria;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        //TipoRefTipoVal();
        //Nullable();
        //Vetores();
        //Vetores2();
        //ExercicioDeFixacao1();
        //Modificadores();
        //Foreach();
        //Lista();
        ExercicioDeFixacao2();

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

            double? a = x ?? 5;
            double? b = y ?? 5;

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
            int n = int.Parse(Console.ReadLine());
            Produto[] vect = new Produto[n];
            double soma = 0;
            for (int i = 0; i < n; i++)
            {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Produto { Name = nome, Price = preco };

                soma += vect[i].Price;
            }

            soma = soma / n;

            Console.WriteLine("A media de preços é " + soma.ToString("F2"));
        }
        static void ExercicioDeFixacao1()
        {
            Quarto[] vect = new Quarto[10];
            Console.WriteLine("Temos 10 quartos disponiveis, quantos serão alugados ?!");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Rent#" + i + ": ");

                Console.Write("Digite seu nome: ");
                string nome = Console.ReadLine();

                Console.Write("Digite seu e-mail: ");
                string email = Console.ReadLine();

                Console.Write("Room: ");
                int quarto = int.Parse(Console.ReadLine());

                vect[quarto] = new Quarto { Locatario = nome, Email = email, Id = quarto };

            }

            Console.WriteLine("Busy rooms: ");
            for (int i = 1; i != 10; i++)
            {
                if (vect[i] != null)
                {

                    Console.Write(vect[i].ToString());
                    Console.WriteLine();
                }

            }

        }
        static void Modificadores()
        {
            int a = 10;
            //ao usar o ref eu referencio o x na minha classe com o A 
            Calculadora.Triplicador(ref a);
            Console.WriteLine(a);


            //o out me permite referenciar a variavel sem inicia-lá 
            int b = 10;
            int triple;
            Calculadora.Triple(b, out triple);
            Console.WriteLine(triple);

        }
        static void Foreach()
        {
            string[] vect = new string[] { "Maria", "João", "Luiz" };

            foreach (string obj in vect)
            {
                Console.WriteLine(obj);
            }
        }

        static void Lista()
        {
            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");
            list.Insert(2, "Marco");
            

            foreach (string obj in list)
            {  Console.WriteLine(obj); }
            Console.WriteLine("List count: " + list.Count);

            //acha a primeira ocorrencia
            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("First A: " + s1);


            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last A: " + s2);

            //acha o index
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position 'A': " + pos1);

            //filta a lista baseado em um predicado 
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last position 'A': " + pos2);
            
            //foreach para todo o obj na list2 imprima o obj
            List<string> list2 = list.FindAll(x=> x.Length == 5);
            Console.WriteLine("-------------");
            foreach(string obj in list2) Console.WriteLine(obj);


            //espera um dado
            list.Remove("Alex");
            //remove do indice
            list.RemoveAt(3);
            Console.WriteLine("-------------");
            foreach (string obj in list) Console.WriteLine(obj);

            Console.WriteLine("-------------");
            //espera um predicado
            list.RemoveAll(x=> x[0] == 'M');
            foreach (string obj in list) Console.WriteLine(obj);

            Console.WriteLine("-------------");
            foreach (string obj in list) Console.WriteLine(obj);

            //remova 2 a partir do segundo indice 
            list.RemoveRange(2, 2);
            Console.WriteLine("-------------");
            foreach (string obj in list) Console.WriteLine(obj);
        }

        static void ExercicioDeFixacao2() 
        {
            List<Employeers> list = new List<Employeers>();
            Console.WriteLine("How many employeers will be registered");
            int num1 = int.Parse(Console.ReadLine());

            for (int i = 1; i == num1; i++) 
            {
                Console.WriteLine("Employeer#"+ i);
                Console.WriteLine("Id:" );
                int id = int.Parse(Console.ReadLine());

                Console.WriteLine("Name:");
                string name =(Console.ReadLine());

                Console.WriteLine("Salary:");
                double salary = double.Parse(Console.ReadLine());

                list.Add(new Employeers(name,id, salary));
            }
        }
    }
}
