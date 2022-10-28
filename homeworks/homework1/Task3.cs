using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {

            double x1, x2, y1, y2 = 0;

            Console.WriteLine("Enter x1");
            x1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter y1");
            y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter x2");
            x2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter y2");
            y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Length = " + Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));


        }
    }
}

