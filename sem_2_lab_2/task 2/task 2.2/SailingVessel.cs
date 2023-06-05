using System;
namespace ForAll.task2
{
	class SailingVessel : Vessel
	{
        public override void Move()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Парусник поїхав");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public override void PrepareToMovement()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Парусник готується до руху");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}

