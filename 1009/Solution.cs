using System;

namespace Start
{
    class Program
    {
        static void Main(string[] args)
        {
            string sellerName;
            double salary, salesTotal;

            sellerName = Console.ReadLine();
            salary = double.Parse(Console.ReadLine());
            salesTotal = double.Parse(Console.ReadLine());

            Console.WriteLine("TOTAL = R$ " + (salary + (salesTotal * 0.15)).ToString("0.00"));
            Console.ReadKey();

        }
    }
}
