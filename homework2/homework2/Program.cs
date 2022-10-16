using System;
namespace homework2
{
    class Program
    {
        public static void Main()
        {

            int rows = 5;
            int num = 1;
            int i, j, n = 0;

            
            for (i = 0; i < rows; i++)
            {
                for (n = 1; n <= rows - i; n++)
                    Console.Write(" ");
                for (j = 0; j <= i; j++)
                {
                    if (j == 0 || i == 0)
                        num = 1;
                    else
                        num = num * (i - j + 1) / j;
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }





        }
    }
}