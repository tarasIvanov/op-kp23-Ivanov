using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d = 0;

            Console.WriteLine("Enter number 1");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number 2");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number 3");
            c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number 4");
            d = Convert.ToInt32(Console.ReadLine());

            if (a >= b)
            {
                if (a >= c)
                {
                    if (a >= d)
                    {
                        Console.WriteLine("The max number is A: " + a);
                    }
                }
            }

            if (d >= b)
            {
                if (d >= c)
                {
                    if (d >= a)
                    {
                        Console.WriteLine("The max number is D: " + d);
                    }
                }
            }

            if (c >= b)
            {
                if (c >= a)
                {
                    if (c >= d)
                    {
                        Console.WriteLine("The max number is C: " + c);
                    }
                }
            }

            if (b >= a)
            {
                if (b >= c)
                {
                    if (b >= d)
                    {
                        Console.WriteLine("The max number is B: " + b);
                    }
                }
            }
        }
    }
}

