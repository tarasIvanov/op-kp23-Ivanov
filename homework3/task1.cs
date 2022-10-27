using System;
class homework3
{
    const int numb = 6;

    public static void Main(string[] args)
    {

        int midnum = numb - (numb / 2);

        if (numb > 0)
        {
            Console.WriteLine("     ################################# ");

            if (numb % 2 == 1)
            {
                for (int i = 1; i <= numb; i++)
                {
                    if (i == midnum)
                    {
                        Console.WriteLine("  (               smile)                )");
                    }
                    else if (i == (midnum - 1) || i == (midnum + 1))
                    {
                        Console.WriteLine("     +             +++               +");
                    }
                    else
                    {
                        Console.WriteLine("     =                               =");
                    }
                }
            }
            else
            {
                for (int i = 1; i <= numb; i++)
                {
                    if (i == midnum)
                    {
                        Console.WriteLine("     -           no  smile 0  0      -");
                    }
                    else if (i == midnum + 1)
                    {
                        Console.WriteLine("     -                      --       -");
                    } else
                    {
                        Console.WriteLine("     =                               =");
                    }
                }

            }
            Console.WriteLine("     ################################# ");

        }
        else
        {
            Console.WriteLine("Enter numb > 0");
        }
        
        





    }
}

