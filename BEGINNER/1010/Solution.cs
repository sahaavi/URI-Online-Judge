using System;

namespace Start
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] product1 = Console.ReadLine().Split(' ');
            int A1 = Convert.ToInt32(product1[0]);
            int B1 = Convert.ToInt32(product1[1]);
            double C1 = Convert.ToDouble(product1[2]);

            string[] product2 = Console.ReadLine().Split(' ');
            int A2 = Convert.ToInt32(product2[0]);
            int B2 = Convert.ToInt32(product2[1]);
            double C2 = Convert.ToDouble(product2[2]);

            Console.WriteLine("VALOR A PAGAR: R$ " + ( (B1*C1) + (B2*C2) ).ToString("0.00"));
            Console.ReadKey();
        }
    }
}
