// using System;
class Program
{
    public static void Main(string[] args)
    {
        /*
        test cases
        n = 5 - factorial = 120
        n = 10 - factorial = 3628800

        x = 5, n = 3 - power = 125
        x = 9, n = 3 - power = 729
        x = 5, n = 0 - power = 1
        x = -3, n = -3 - power = -0.037037037037037035
        x = 4, n = -1 - power = 0.25


        */

        double n = 0, x = 0;
        double sum = 1;
        int prog = 1;
        
        // This program is slightly optimized for convenience
        while (prog != 0)
        {

            Console.WriteLine("Enter 1 if you want to find factorial");
            Console.WriteLine("Enter 2 if you want to find a power of x");
            Console.WriteLine("Enter 0 if you want quit");

            prog = Convert.ToInt32(Console.ReadLine());

            switch (prog)
            {
                case 1:
                    Console.WriteLine("Enter n");
                    n = Convert.ToInt32(Console.ReadLine());

                    sum = 1;

                    if (n >= 1)
                    {
                        for (int i = 1; i <= n; i++)
                        {
                            sum *= i;
                        }
                    }
                    else
                    {
                        Console.WriteLine("n need to be bigger than 0");
                    }

                    Console.WriteLine("A factorial of number " + n + " = " + sum);
                    break;
                case 2:
                    Console.WriteLine("Enter x");
                    x = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter a power");
                    n = Convert.ToInt32(Console.ReadLine());

                    sum = Math.Pow(x, n);

                    Console.WriteLine("The " + x + " in " + n + " power = " + sum);
                    break;

                default:
                    Console.WriteLine("Enter 1, 2 or 0");
                    break;
            }

            Console.WriteLine();
        }

    }
}
