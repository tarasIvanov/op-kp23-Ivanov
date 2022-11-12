using System;
class Program
{
    const double b = 3.4;

    public static void Main(string[] args)
    {
        /*
         * x0 = 3
         * xn = 6
         * n = 3
         * x0 = 3
           y = 1.727029538649927
           x1 = 4
           y = 1.641418638703788
           x2 = 5
           y = 1.2116504326468218
           x3 = 6
           y = 0.46166866276634166


                x0 = 1
                xn = 5
                n = 4
                x0 = 1
                y = 0.8654150771257818
                x1 = 2
                y = 1.4617604278959757
                x2 = 3
                y = 1.727029538649927
                x3 = 4
                y = 1.641418638703788
                x4 = 5
                y = 1.2116504326468218
         * 
         */
        
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
