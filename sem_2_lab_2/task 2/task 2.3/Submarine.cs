using System;
namespace ForAll.task2
{
    class Submarine : IVessel
    {
        public void Move()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Підводний човен поїхав");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void PrepareToMovement()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Підводний човен готується до руху");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}

