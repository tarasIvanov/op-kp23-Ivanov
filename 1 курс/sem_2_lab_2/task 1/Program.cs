using System;
using System.Linq;
using System.Globalization;

namespace ForAll
{
    /* Test case:
        Input:
            SalaryNote salaryNote1 = new SalaryNote("arnold", 1000, 300);
            SalaryNote salaryNote2 = new SalaryNote("mark", 1300, 700);

        Output:
            Name: arnold    Salary: 1000    Withheld: 300   Received: 700
            Name: mark      Salary: 1300    Withheld: 700   Received: 600

    */
    class Program
    {
        const int n = 10;

        public static void Main(string[] args)
        {
            SalaryNote[] salaryNotes = new SalaryNote[n];

            int counter = 0;

            int digit = 0;

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("1)Create new note");
                Console.WriteLine("2)Show notes");
                Console.WriteLine("3)End the program");
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("Enter digit:");
                digit = int.Parse(Console.ReadLine());

                switch (digit)
                {
                    case 1:
                        salaryNotes[counter] = CreateNewNote();

                        counter++;

                        break;

                    case 2:
                        if (counter == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("Empty");
                            Console.ForegroundColor = ConsoleColor.White;
                            continue;
                        }

                        for (int i = 0; i < counter; i++)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write($"Id: {i + 1}\t");
                            Console.ForegroundColor = ConsoleColor.White;

                            salaryNotes[i].PrintCharacteristics();
                        }

                        break;

                    case 3:
                        Console.WriteLine("Goodbye");
                        return;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Wrong digit");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }
            }
        }

        public static SalaryNote CreateNewNote()
        {
            SalaryNote salaryNote = new SalaryNote();
            salaryNote.SetParams();

            return salaryNote;
        }
    }
}

