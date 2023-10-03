using System;
using System.Linq;
using System.Globalization;
using ForAll.task2;

class Program
{
    public static void Main(string[] args)
    {
        int digit = 0;

        while (true)
        {
            ChangeColorOfString("1)Choose transport\n2)End the program", ConsoleColor.Yellow);

            digit = int.Parse(Console.ReadLine());

            switch (digit)
            {
                case 1:
                    ChangeColorOfString("1)SailingVessel\n2)Submarine", ConsoleColor.Magenta);

                    Console.WriteLine("Enter chosen transport(digit)");
                    digit = int.Parse(Console.ReadLine());

                    switch (digit)
                    {
                        case 1:
                            SailingVessel sailingVessel = new SailingVessel();

                            MenuOfTransport(sailingVessel);

                            break;
                        case 2:
                            Submarine submarine = new Submarine();

                            MenuOfTransport(submarine);

                            break;
                        default:
                            ChangeColorOfString("Wrong digit", ConsoleColor.Red);
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("Goodbye");
                    return;
                default:
                    ChangeColorOfString("Wrong digit", ConsoleColor.Red);
                    break;
            }
        }
    }

    public static void MenuOfTransport(Vessel vessel)
    {
        int digit = 0;

        while (digit != 3)
        {
            ChangeColorOfString("Enter 1 to prepare to movement\nEnter 2 to move\nEnter 3 to exit", ConsoleColor.Cyan);
            digit = int.Parse(Console.ReadLine());

            switch (digit)
            {
                case 1:
                    vessel.PrepareToMovement();
                    break;
                case 2:
                    vessel.Move();
                    break;
                case 3:
                    continue;
                default:
                    ChangeColorOfString("Wrong digit", ConsoleColor.Red);
                    break;
            }
        }
    }

    

    public static void ChangeColorOfString(string str, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(str);
        Console.ForegroundColor = ConsoleColor.White;
    }
}

