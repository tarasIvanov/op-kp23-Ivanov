using System;
class Program
{
    const double b = 3.4;

    public static void Main(string[] args)
    {
        double x0 = 0;
        double xn = 0;
        double n = 0;
        double dx = 0;
        double x = 0;
        double y = 0;


        Console.WriteLine("Enter x0");
        x0 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter xn");
        xn = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter n");
        n = Convert.ToDouble(Console.ReadLine());

        x = x0;

        dx = (xn - x0) / n;

        for (double i = 0; i <= n; i++)
        {
            Console.WriteLine("x" + i + " = " + x);

            y = x * Math.Sin(Math.Sqrt(x + b - 0.0084));

            Console.WriteLine("y = " + y);

            x += dx;
        }


    }
}
