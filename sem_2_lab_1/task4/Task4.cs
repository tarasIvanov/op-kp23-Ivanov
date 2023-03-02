using System;
using System.IO;

class Task4
{
   const int numOfStudents = 5;

   public static void Main(string[] args)
   {
       Random random = new Random();

       string path = Path.Combine(Directory.GetCurrentDirectory(), "Students.txt");

       using (var sw = new StreamWriter(path))
       {
           for (int i = 0; i < numOfStudents; i++)
           {
               sw.WriteLine($"First name: {i + 1}, Last name: {i + 1}, " + random.Next(30, 100));
           }
       }

       PrintStudentsLessSixtyPoints(path);
   }


   public static void PrintStudentsLessSixtyPoints(string path)
   {
       using (var sr = new StreamReader(path))
       {
           int counter = 0;
           int studentsHaveLess = 0;

           string student = "";
           char el = '\0';
           string score = "";

           while (!sr.EndOfStream)
           {

               while (counter < 2)
               {
                   el = (char)sr.Read();
                   student += el;

                   if (el == ',')
                   {
                       counter++;
                   }
               }

               el = (char)sr.Read();
               student += el;

               score = sr.ReadLine();
               student += score;

               if (Convert.ToInt32(score) < 60)
               {
                   Console.WriteLine(student + " --- this student has less than 60 points");
                   studentsHaveLess++;
               }
               student = "";
               counter = 0;
           }

           if (studentsHaveLess <= 0)
           {
               Console.WriteLine("0 students have less than 60");
           }

       }
   }
}

