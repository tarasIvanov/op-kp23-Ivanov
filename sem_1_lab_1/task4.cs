using System;
class Program
{
    public static void Main(string[] args)
    {
        double sin1 = 0;
        int sign = 1;
        long f = 1;
        int p = 1;

        double x = 0;

        //для градусів
        //double m = 90;
        //x = (m * 3.1416) / 180;
        

        double sin2 = 1;
        double lim = 0.1;

        Console.WriteLine("enter x");
        x = Convert.ToInt32(Console.ReadLine());

        while (Math.Abs((sin2 - sin1)) > lim)
        {
            sin2 = sin1;
            sin1 = sin1 + sign * (power(x, p) / factorial(f));

            p += 2;
            f += 2;

            sign = -sign;
        }

        Console.WriteLine("sin x = " + sin1);

    }

    public static long factorial(double x)
    {
        int endN = 1;

        for (int i = 1; i <= x; i++)
        {
            endN *= i;
        }

        return endN;
    }

    public static double power(double x, double n)
    {
        double sum = x;

        for (int i = 1; i < n; i++)
        {
            sum *= x;
        }

        return sum;
    }
}

