using System;
using System.Collections.Concurrent;
using System.Globalization;
using EnumeracaoeComposicao.Entities;
using EnumeracaoeComposicao.Entities.Enum;
class Program
{
    static void Main(string[] args)
    {
        Enumeracao();
    }
    static void Enumeracao()
    {
        Order order = new Order
        {
            Id = 12645,
            Moment = DateTime.Now,
            Status = OrderStatus.Delivered
        };
        Console.WriteLine(order);

        string txt = OrderStatus.PendingPayment.ToString();

        OrderStatus os= Enum.Parse<OrderStatus>("Delivered");

        Console.WriteLine(txt);
        Console.WriteLine(os);
    }
}