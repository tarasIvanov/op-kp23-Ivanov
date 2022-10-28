using System;
class Program
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Enter num");

        int num = Convert.ToInt32(Console.ReadLine());

        if (num == 2 || num == 3)
        {
            Console.WriteLine("num is simple");
        }
        else if (num > 0)
        {
            if (num % 2 != 0 && num % 3 != 0)
            {
                Console.WriteLine("num is simple");
            }
            else
            {
                Console.WriteLine("num is complex");
            }
        }
        else
        {
            Console.WriteLine("enter натуральне number");
        }
        

    }
}

