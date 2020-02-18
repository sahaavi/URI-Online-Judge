using System;

namespace Start
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B;
            A = double.Parse(Console.ReadLine());
            B = double.Parse(Console.ReadLine());
            Console.WriteLine("MEDIA = " + ((A * 3.5 + B * 7.5) / (3.5 + 7.5)).ToString("0.00000"));
            Console.ReadKey();
        }
    }
}
