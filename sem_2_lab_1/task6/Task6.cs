using System;

class Task6
{
    /*
     * Test cases:
     * 
     * Case 1:
     *    Input:
              First name: 2, Last name: 2, 93
              First name: 3, Last name: 3, 97
              First name: 4, Last name: 4, 82

           Output:
              First name: 3, Last name: 3, 97
              Num of best students is: 1
     * 
     */


    public static void Main(string[] args)
    {
        Random random = new Random();

        int countOfStudents = 0;
        int numOfBestStudents = 0;

        string pathTxtFile = Path.Combine(Directory.GetCurrentDirectory(), "Students.txt");
        string pathBinaryStudents = Path.Combine(Directory.GetCurrentDirectory(), "Binary_Students.dat");
        string pathBestStudents = Path.Combine(Directory.GetCurrentDirectory(), "BestStudents.dat");

        using (var sr = new StreamReader(pathTxtFile))
        {
            var bw = new BinaryWriter(File.Open(pathBinaryStudents, FileMode.OpenOrCreate));

            string str;

            while (!sr.EndOfStream)
            {
                str = sr.ReadLine();

                try
                {
                    //
                    Console.WriteLine(str);
                    bw.Write(str);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message + "Can't write to file");
                }

                countOfStudents++;
            }

            //
            Console.WriteLine();
            bw.Close();
        }

        using (var bw = new BinaryWriter(File.Open(pathBestStudents, FileMode.OpenOrCreate)))
        {
            var br = new BinaryReader(File.Open(pathBinaryStudents, FileMode.OpenOrCreate));

            string str = "";
            char el = '\0';
            int score = 0;
            string scoreStr = "";

            int counter = 0;
            int countOfSpases = 0;
            int countOfNumbers = 0;

            while (counter < countOfStudents)
            {
                do
                {
                    el = br.ReadChar();
                    str += el;

                    if (el == ' ')
                    {
                        countOfSpases++;
                    }

                } while (countOfSpases < 6);

                do
                {
                    el = br.ReadChar();

                    scoreStr += el;

                    countOfNumbers++;
                } while (countOfNumbers < 2);

                str += scoreStr;

                score = Convert.ToInt32(scoreStr);

                br.Read();

                if (score >= 95)
                {
                    numOfBestStudents++;

                    Console.WriteLine(str);
                    bw.Write(str);
                }

                scoreStr = "";
                str = "";
                score = 0;
                countOfNumbers = 0;
                countOfSpases = 0;


                counter++;
            }

            if (numOfBestStudents > 0)
            {
                Console.Write("Num of best students is: " + numOfBestStudents);
                bw.Write("Num of best students is: " + numOfBestStudents);
            }

            br.Close();
        }


    }

}


