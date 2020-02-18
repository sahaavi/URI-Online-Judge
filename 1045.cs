using System;

namespace Start
{
    class Program
    {
        static void Main(string[] args)
        {
            double temp;
            string[] values = Console.ReadLine().Split(' ');
            double a = double.Parse(values[0]);
            double b = double.Parse(values[1]);
            double c = double.Parse(values[2]);
            if (a < b)
            {
                temp = a;
                a = b;
                b = temp;
            }
            if (b < c)
            {
                temp = b;
                b = c;
                c = temp;
            }
            if (a < b)
            {
                temp = a;
                a = b;
                b = temp;
            }
            if (a >= (b + c))
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            if(Math.Pow(a,2)==Math.Pow(b,2)+Math.Pow(c,2))
            {
                Console.WriteLine("TRIANGULO RETANGULO");
            }
            if (Math.Pow(a, 2) > Math.Pow(b, 2) + Math.Pow(c, 2))
            {
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            }
            if (Math.Pow(a, 2) < Math.Pow(b, 2) + Math.Pow(c, 2))
            {
                Console.WriteLine("TRIANGULO ACUTANGULO");
            }
            if (a == b && b == c)
            {
                Console.WriteLine("TRIANGULO EQUILATERO");
            }
            if ( (a == b && b != c ) || (a == c && b != c) || (b == c && b != a) )
            {
                Console.WriteLine("TRIANGULO ISOSCELES");
            }
            Console.ReadKey();
        }
    }
}
