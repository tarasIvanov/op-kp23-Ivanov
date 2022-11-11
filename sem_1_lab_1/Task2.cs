using System;
class Program
{
    public static void Main(string[] args)
    {
        int num = 0;

        Console.WriteLine("Enter num");
        num = Convert.ToInt32(Console.ReadLine());

        if (num >= 1)
        {
            if (isSimple(num) == true)
            {
                Console.WriteLine("Num is simple");
            } else
            {
                Console.WriteLine("Num is complex");
            }

        } else
        {
            Console.WriteLine("Enter num >= 1");
        }


    }

    public static bool isSimple(int num)
    {
        for (int i = 2; i < num; i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }

        return true;
    }

}

