using System;
using System.Collections.Concurrent;
using System.Globalization;
using System.Numerics;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        //Var();
        //Switch();
        //CondicaoTernaria();
        //StringInterre();
        //Datetime();
        //Timespan();
        //OperaçõesCDateTime();
        OperaçõesCTimeSpan();
    }

    static void Var()
    {
        var x = 10;
        var y = 20.0;
        var z = "Maria";
        Console.WriteLine(x);
        Console.WriteLine(y);
        Console.WriteLine(z);
    }
    static void Switch()
    {
        int x = int.Parse(Console.ReadLine());
        string day;
        if (x == 1)
            day = "Sunday";
        else if (x == 2)
            day = "Monday";
        else if (x == 3)
            day = "Tuesday";
        else if (x == 4)
            day = "Wednesday";
        else if (x == 5)
            day = "Thursday";
        else if (x == 6)
            day = "Friday";
        else if (x == 7)
            day = "Satursday";
        else
            day = "Invalid Value";

        Console.WriteLine("Day: " + day);

        switch (x)
        {
            case 1:
                day = "Sunday";
                break;
            case 2:
                day = "Tuesday";
                break;
            case 3:
                day = "Tuesday";
                break;
            case 4:
                day = "Wednesday";
                break;
            case 5:
                day = "Thursday";
                break;
            case 6:
                day = "Friday";
                break;
            case 7:
                day = "Satursday";
                break;
            default:
                day = "Invalid Value";
                break;
        }
                    Console.WriteLine("Day: " + day);
        
    }
    static void CondicaoTernaria() 
    {
        double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;
        Console.WriteLine(desconto);
    }

    static void StringInterre()
    {
        string original = "abcde FGHIJ ABC abc DEFG   ";

        string s1 = original.ToUpper();
        string s2 = original.ToLower();
        string s3 = original.Trim();
        int n1 = original.IndexOf("bc");
        string s4 = original.Substring(3);
        string s5 = original.Substring(3,5);
        string s6 = original.Replace('a', 'x');
        string s7 = original.Replace("abc", "xy");
        bool b1 = String.IsNullOrEmpty(original);
        bool b2 = String.IsNullOrWhiteSpace(original);


        Console.WriteLine("Original: -"+ original + "-");
        //joga tudo para maisculo
        Console.WriteLine("ToUpper: -" + s1 + "-");
        //joga tudo para minusculo
        Console.WriteLine("ToLower: -" + s2 + "-");
        //tira os espaços do começo e do fim
        Console.WriteLine("Trim: -" + s3 + "-");
        //proucura uma ocorrencia na posição de memoria
        Console.WriteLine("Indexof ('bc'): " + n1);
        //last index acha a ultima ocorrencia
        //corta a sua string a partir de uma posição
        Console.WriteLine("Substring (30): " + s4);
        //corta uma string a partir de uma posição e pega x caracteres apos o corte 
        Console.WriteLine("Substring (3, 5): " + s5);
        //troca o char ou a string por outra podendo ser de tamanho diferente 
        Console.WriteLine("Replace ('a', 'x'): "+s6);
        Console.WriteLine("Replace ('abc','xy'): " + s7);
        //testa se esta vazio ou nao
        Console.WriteLine("IsNullOrEmpty: " + b1);
        //testa se e nulo ou se tem espaço em branco
        Console.WriteLine("IsNullOrWhiteSpace: " + b2);
    }
    static void Datetime()
    {
        DateTime d1 = DateTime.Parse("2000-08-15");
        DateTime d2 = DateTime.Parse("2000-08-15 13:05:58");

        DateTime d3 = DateTime.Parse("15/08/2000");

        DateTime d4 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd",CultureInfo.InvariantCulture);
        

        Console.WriteLine(d1);
        Console.WriteLine(d2);
        Console.WriteLine(d3);
        Console.WriteLine(d4);
    }

    static void Timespan()
    {
        TimeSpan t1 = new TimeSpan();
        TimeSpan t2 = new TimeSpan(900000000L);
        TimeSpan t3 = new TimeSpan (2, 11 , 21  );
        

        Console.WriteLine(t1);
        Console.WriteLine(t2);
        Console.WriteLine(t3);
    }
    static void OperaçõesCDateTime()
    {
        DateTime d = new DateTime(2002,02,01,19,47,47);
        DateTime c = new DateTime(2002, 03, 31, 8, 40, 34);
        DateTime d2 = d.AddHours(2);
        DateTime d3 = d.AddMinutes(8);
        DateTime d4 = d.AddDays(7);
        TimeSpan t = c.Subtract(d);
        //extrai a informação colocada apos o . do datetime
        Console.WriteLine(d);
        Console.WriteLine("1) Date: " + d.Date);
        Console.WriteLine("2) Day: " + d.Day);
        //adiciona horas dias ou diminui
        Console.WriteLine(d2);
        Console.WriteLine(d3);
        Console.WriteLine(d4);
        Console.WriteLine(t);
    }
    static void OperaçõesCTimeSpan()
    {
        TimeSpan t = new TimeSpan(2,3,5,7,11);

        Console.WriteLine(t);
        //extrai a informação colocada apos o . do datetime
        Console.WriteLine("Days: " + t.Days);
        
    }
}