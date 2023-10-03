using System;
using System.IO;

class Task4
{
    /*Test cases:
     * 
     * Case 1:
         * Input: 
             * First name: 1, Last name: 1, 46
               First name: 2, Last name: 2, 58
               First name: 3, Last name: 3, 52
               First name: 4, Last name: 4, 80
               First name: 5, Last name: 5, 72

           Output:   
               First name: 1, Last name: 1, 46 --- this student has less than 60 points
               First name: 2, Last name: 2, 58 --- this student has less than 60 points
               First name: 3, Last name: 3, 52 --- this student has less than 60 points


        Case2:
            Input:
                First name: 1, Last name: 1, 73
                First name: 2, Last name: 2, 54
                First name: 3, Last name: 3, 78
                First name: 4, Last name: 4, 93
                First name: 5, Last name: 5, 45
                First name: 6, Last name: 6, 79
                First name: 7, Last name: 7, 73
                First name: 8, Last name: 8, 34
                First name: 9, Last name: 9, 95
                First name: 10, Last name: 10, 88

            Output:
                First name: 2, Last name: 2, 54 --- this student has less than 60 points
                First name: 5, Last name: 5, 45 --- this student has less than 60 points
                First name: 8, Last name: 8, 34 --- this student has less than 60 points



        Case3:
            Input:
                First name: 1, Last name: 1, 69
                First name: 2, Last name: 2, 93
                First name: 3, Last name: 3, 97
                First name: 4, Last name: 4, 82

            Output:
                0 students have less than 60
     * 
     * 
     */


    const int numOfStudents = 4;

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

