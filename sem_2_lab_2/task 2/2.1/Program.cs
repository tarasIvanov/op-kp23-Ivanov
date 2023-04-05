using System;
using System.Linq;
using System.Globalization;

namespace ForAll
{
    class Program
    {
        public static void Main(string[] args)
        {
            Notes notes = new Notes();

            notes.AddNote(new SalaryNote("artur", 1000, 300));
            notes.AddNote(new SalaryNote("marci", 1200, 200));

            int digit = 0;

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("1)Add new note");
                Console.WriteLine("2)Show all notes");
                Console.WriteLine("3)End the program");
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("Enter digit:");
                digit = int.Parse(Console.ReadLine());

                switch (digit)
                {
                    case 1:
                        notes.AddNote();
                        break;

                    case 2:
                        notes.PrintNotes();
                        break;

                    case 3:
                        Console.WriteLine("Goodbye!");
                        return;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Wrong digit");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }
            }
        }
    }
}

