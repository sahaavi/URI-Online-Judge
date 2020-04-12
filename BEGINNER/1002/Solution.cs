using System;

namespace Start
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = 3.14159, A, R;
            R = double.Parse(Console.ReadLine());
            A = n*Math.Pow(R,2);
            Console.WriteLine("A=" + A.ToString("0.0000"));
            Console.ReadKey();
        }
    }
}
