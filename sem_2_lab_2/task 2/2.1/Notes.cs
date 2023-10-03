using System;
using System.Diagnostics.Metrics;

namespace ForAll
{
	class Notes
	{
		List<SalaryNote> notes = new List<SalaryNote>();

		public Notes(params SalaryNote[] notes)
		{
			for (int i = 0; i < notes.Length; i++)
			{
				this.notes[i] = notes[i];
			}
		}

		public Notes()
		{

		}

		public void AddNote()
		{
			SalaryNote newNote = new SalaryNote();

			newNote.SetParams();

			notes.Add(newNote);
        }

        public void AddNote(SalaryNote note)
        {
            notes.Add(note);
        }

        public void PrintNotes()
		{
            if (notes.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Empty");
                Console.ForegroundColor = ConsoleColor.White;
				return;
            }

            for (int i = 0; i < notes.Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"Id: {i + 1}\t");
                Console.ForegroundColor = ConsoleColor.White;

                notes[i].PrintCharacteristics();
            }
        }
	}
}

