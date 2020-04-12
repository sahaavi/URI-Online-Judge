using System;

namespace Start
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C;
            A = double.Parse(Console.ReadLine());
            B = double.Parse(Console.ReadLine());
            C = double.Parse(Console.ReadLine());
            Console.WriteLine("MEDIA = " + ((A / 10 * 2) + (B / 10 * 3) + (C / 10 * 5)).ToString("0.0"));
            Console.ReadKey();
        }
    }
}
