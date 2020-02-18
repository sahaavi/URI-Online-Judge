using System;

namespace Start
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C;
            string[] Values = Console.ReadLine().Split(' ');
            A = Convert.ToDouble(Values[0]);
            B = Convert.ToDouble(Values[1]);
            C = Convert.ToDouble(Values[2]);

            Console.WriteLine("TRIANGULO: " + (0.5 * A * C).ToString("0.000"));
            Console.WriteLine("CIRCULO: " + (3.14159 * Math.Pow(C, 2)).ToString("0.000"));
            Console.WriteLine("TRAPEZIO: " + (((A + B) / 2) * C).ToString("0.000"));
            Console.WriteLine("QUADRADO: " + Math.Pow(B, 2).ToString("0.000"));
            Console.WriteLine("RETANGULO: " + (A * B).ToString("0.000"));
            Console.ReadKey();
        }
    }
}
