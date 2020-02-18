using System;

namespace Start
{
    class Program
    {
        static void Main(string[] args)
        {
            int empNo, workHour;
            double salary;
            empNo = int.Parse(Console.ReadLine());
            workHour = int.Parse(Console.ReadLine());
            salary = double.Parse(Console.ReadLine());
            Console.WriteLine("NUMBER = " + empNo);
            Console.WriteLine("SALARY = U$ " + (workHour*salary).ToString("0.00"));
            Console.ReadKey();
        }
    }
}
