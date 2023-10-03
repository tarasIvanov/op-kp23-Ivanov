using System;

class Task2
{
	const int n = 15;

	public static void Main(string[] args)
	{
		Random random = new Random();

		string pathMain = Path.Combine(Directory.GetCurrentDirectory(), "task2.txt");
		string pathMax = Path.Combine(Directory.GetCurrentDirectory(), "max.txt");

		using (var sw = new StreamWriter(pathMain))
		{
			for (int i = 0; i < n; i++)
			{
				sw.Write(random.Next(1, 70) + " ");
			}
		}

		using (var max = new StreamWriter(pathMax))
		{
			max.Write(GetMaxNumInFile(pathMain));
		}
	}

	public static int GetMaxNumInFile(string pathMain)
	{
       using (var sr = new StreamReader(pathMain))
       {
           int maxNumber = 0;

           while (!sr.EndOfStream)
           {
               string numInStr = "";
               char item = '\0';

               while (true)
               {
                   item = (char)sr.Read();

                   if (item == ' ')
                   {
                       break;
                   }

                   numInStr += item;
               }

               int digit = Convert.ToInt32(numInStr);

               if (digit > maxNumber)
               {
                   maxNumber = digit;
               }
           }

           return maxNumber;
       }
   }
}


