using System;
class Program
{
    public static void Main(string[] args)
    {
        // This program is slightly optimized for convenience
        int n, x = 0;
        int sum = 1;
        int prog = 1;

        while (prog != 0)
        {

            Console.WriteLine("Enter 1 if you want to find factorial");
            Console.WriteLine("Enter 2 if you want to find a power of x");
            Console.WriteLine("Enter 0 if you want quit");

            prog = Convert.ToInt32(Console.ReadLine());

            if (prog == 1)
            {
                Console.WriteLine("Enter n");

                n = Convert.ToInt32(Console.ReadLine());

                sum = 1;

                for (int i = 1; i <= n; i++)
                {
                    sum *= i;
                }

                Console.WriteLine("A factorial of number " + n + " = " + sum);

            }
            else if (prog == 2)
            {
                Console.WriteLine("Enter x");
                x = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter a power");
                n = Convert.ToInt32(Console.ReadLine());

                sum = 1;

                for (int i = 0; i < n; i++)
                {
                    sum *= x;
                }

                Console.WriteLine("The " + x + " in " + n + " power = " + sum);

            }
            else
            {
                Console.WriteLine("Enter 1 or 2");
            }

            Console.WriteLine();

        }

    }
}
