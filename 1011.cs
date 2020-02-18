using System;

namespace Start
{
    class Program
    {
        static void Main(string[] args)
        {
            double R;
            double pi = 3.14159d;
            R = double.Parse(Console.ReadLine());
            Console.WriteLine("VOLUME = " + ((4.0/3)*pi*Math.Pow(R,3)).ToString("0.000"));
            Console.ReadKey();
        }
    }
}
