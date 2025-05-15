using System;
using System.Collections.Concurrent;
using System.Globalization;
using EnumeracaoeComposicao.Entities;
using EnumeracaoeComposicao.Entities.Enum;
class Program
{
    static void Main(string[] args)
    {
        //Enumeracao();
        Contratos();
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
    static void Contratos() 
    {
        Console.Write("Enter department's name: ");
        string deptname = Console.ReadLine();
        Console.WriteLine("Enter worker data: ");
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Level (Junior/MidLeve/Senior):");
        WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
        Console.Write("Base salary: ");
        double basesalary = Double.Parse(Console.ReadLine());

        Department dept = new Department(deptname);

        Worker worker = new Worker(name,level,basesalary,dept);

        Console.Write("How Many contract to this worker? ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++) 
        {
            Console.WriteLine($"Enter #{i} contract data:");
            Console.Write("Date(DD/MM/YYYY): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.Write("Value per hour: ");
            double valuePerHour = Double.Parse(Console.ReadLine());
            Console.Write("Duration(hours): ");
            int hours = int.Parse(Console.ReadLine());

            HourContract contract = new HourContract(date,valuePerHour,hours);
            worker.addContract(contract);
        }
        Console.WriteLine();
        Console.WriteLine("Enter month and year to calculate income(MM/YYYY): ");
        string monthAndYear = Console.ReadLine();
        int month = int.Parse(monthAndYear.Substring(0,2));
        int year = int.Parse(monthAndYear.Substring(3));
        Console.WriteLine("Name: " + worker.Name);
        Console.WriteLine("Department: " + worker.Department.Name);
        Console.WriteLine("Income for " + monthAndYear + ": " + worker.Income(year, month));
    }
}