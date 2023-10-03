using System;

namespace ForAll
{
	class SalaryNote
	{
		public string Name { get; set; }
		public int Salary { get; set; }
		public int Withheld { get; set; } //Утримано
		public int Received { get; set; }

		public SalaryNote(string name, int salary, int withheld)
		{
			Name = name;
			Salary = salary;
			Withheld = withheld;

			ReceivedMoney();
		}

        public SalaryNote()
		{

		}

        private void ReceivedMoney()
		{
			Received = Salary - Withheld;
        }

        public void SetParams()
        {
			Console.WriteLine("Enter name");
            Name = Console.ReadLine();

			Console.WriteLine("Enter Salary");
            Salary = int.Parse(Console.ReadLine());

			Console.WriteLine("Enter withheld");
            Withheld = int.Parse(Console.ReadLine());

            ReceivedMoney();
        }

        public void SetParams(string name, int salary, int withheld)
		{
			Name = name;
			Salary = salary;
			Withheld = withheld;

            ReceivedMoney();
        }

		public void PrintCharacteristics()
		{
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Name: {Name}\tSalary: {Salary}\tWithheld: {Withheld}\tReceived: {Received}");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}

