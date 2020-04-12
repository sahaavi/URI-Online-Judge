using System;

namespace Start
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] axis1 = Console.ReadLine().Split(' ');
            string[] axis2 = Console.ReadLine().Split(' ');
            double x1 = Convert.ToDouble(axis1[0]);
            double y1 = Convert.ToDouble(axis1[1]);
            double x2 = Convert.ToDouble(axis2[0]);
            double y2 = Convert.ToDouble(axis2[1]);

            Console.WriteLine( Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2)).ToString("0.0000") );
            Console.ReadKey();
        }
    }
}
