using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {

            double a, b, c, p = 0;

            Console.WriteLine("Enter length 1 сторони");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter length 2 сторони");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter length 3 сторони");
            c = Convert.ToDouble(Console.ReadLine());

            p = (a + b + c) / 2;

            Console.WriteLine("S = " + Math.Sqrt(p * (p - a) * (p - b) * (p - c)));

        }
    }
}

