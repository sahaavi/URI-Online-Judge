using System;

namespace Start
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            x = double.Parse(Console.ReadLine());
            if (x > 100.00d)
            {
                Console.WriteLine("Fora de intervalo");
            }
            if (x < 0.00d)
            {
                Console.WriteLine("Fora de intervalo");
            }
            if (x >= 0.00d && x <= 25.0000d)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            if (x > 25.0000d && x <= 50.0000d)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            if (x > 50.0000d && x <= 75.0000d)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            if (x > 75.0000d && x <= 100.0000d)
            {
                Console.WriteLine("Intervalo (75,100]");
            }
            Console.ReadKey();
        }
    }
}
