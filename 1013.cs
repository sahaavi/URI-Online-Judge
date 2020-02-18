using System;

namespace Start
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] value = Console.ReadLine().Split(' ');
            int A = int.Parse(value[0]);
            int B = int.Parse(value[1]);
            int C = int.Parse(value[2]);
            int maiorAB =( ( A+B + Math.Abs(A-B) ) /2 );
            Console.WriteLine(((maiorAB + C + Math.Abs(maiorAB - C)) / 2) + " eh o maior");
            Console.ReadKey();
        }
    }
}
