using System;

namespace Start
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            double y;
            x = int.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            Console.WriteLine((x / y).ToString("0.000") + " km/l");
            Console.ReadKey();
        }
    }
}
