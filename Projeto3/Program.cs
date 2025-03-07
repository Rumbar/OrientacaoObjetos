using System;
using System.Collections.Concurrent;
using System.Globalization;
using Projeto3;
class Program
{
    static void Main(string[]args)
    {
        //ProblemaSemPoo();
        //Exercicio1();
        GerenciamentoEstoque();
    }
    static void ProblemaSemPoo()
    {
        Triangulo x, y;

        x = new Triangulo();
        y = new Triangulo();

        Console.WriteLine("ENTRE COM AS MEDIDAS DO TRIANGULO X");
        x.A= double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        x.B= double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        x.C= double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        Console.WriteLine("ENTRE COM AS MEDIDAS DO TRIANGULO Y");
        y.A= double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        y.B= double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        y.C= double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        
        double t1 = (x.A + x.B + x.C) / 2;
        double t2 = (y.A+ y.B + y.C ) / 2;

        double r1 = Math.Sqrt(t1 * (t1-x.A)*(t1- x.B) *(t1- x.C));
        double r2 = Math.Sqrt(t2 * (t2- y.A) *(t2- y.B) *(t2- y.C));

        Console.WriteLine("X = " + r1.ToString("F4", CultureInfo.InvariantCulture));
        Console.WriteLine("Y = " + r2.ToString("F4", CultureInfo.InvariantCulture));

        if ( r1 > r2 )
            Console.WriteLine("Maior área: X ");
        else Console.WriteLine("Maior área: Y");
    }
    static void Exercicio1()
    {
        Pessoa a, b;
        a = new Pessoa();
        b = new Pessoa();
        Console.WriteLine("Dados da primeira pessoa");
        a.nome = Console.ReadLine();
        a.idade = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o nome da segunda pessoa");
        b.nome = Console.ReadLine();
        b.idade = int.Parse(Console.ReadLine());

        if (b.idade > a.idade)
            Console.WriteLine("A pessoa mais velha é " + b.nome);
        else
            Console.WriteLine("A pessoa mais velha é " + a.nome);
    }
    static void GerenciamentoEstoque()
    {
        Produto produto = new Produto();

        Console.WriteLine("Entre com os dados do produto");
        Console.Write("Nome: ");
        produto.Nome = Console.ReadLine();
        Console.Write("Preço: ");
        produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Estoque: ");
        produto.Quant = int.Parse(Console.ReadLine());

        Console.WriteLine("Dados do Produto: " + produto);

        Console.WriteLine();

        Console.WriteLine("Digite o número de produtos a ser adicionados ao estoque: ");
        int atualizacao = int.Parse(Console.ReadLine());
        produto.AdicionarProdutos(atualizacao);
        Console.WriteLine("Dados Atualizados: " + produto);

        Console.WriteLine();

        Console.WriteLine("Digite o número de produtos a ser removido do estoque");
        int remocao = int.Parse(Console.ReadLine());
        produto.RemoverProduto(remocao);

        Console.WriteLine();

        Console.WriteLine("Dados do Produto: " + produto);
    }
}
 