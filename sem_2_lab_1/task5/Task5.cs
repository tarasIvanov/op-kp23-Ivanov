using System;

class Task5
{
    /*Test cases:
     * 
     * Case 1:
            Input:
                Read a CSV file that is specified in Task 4, Create a binary file that is based on the CSV file. Read the binary file and create another binary file that will contain the number of the students whose score is greater than 95 and all the records for those students.
                Unit tests are not required, but the test cases should be identified. The git history should contain at least 3 commits for each task (prototype of the system, several test cases and implementation of the system). Usually it contains more that just 3 commits (several commits for bug-fixing)
     
            Output:
                Read: 2
                a: 2
                CSV: 2
                file: 5
                that: 4
                is: 3
                specified: 1
                in: 1
                Task: 1
                Create: 1
                binary: 3
                based: 1
                on: 1
                the: 8
                and: 3
                create: 1
                another: 1
                will: 1
                contain: 2
                number: 1
                of: 3
                students: 2
                whose: 1
                score: 1
                greater: 1
                than: 1
                all: 1
                records: 1
                for: 3
                those: 1
                Unit: 1
                tests: 1
                are: 1
                not: 1
                required: 1
                but: 1
                test: 2
                cases: 2
                should: 2
                be: 1
                identified: 1
                The: 1
                git: 1
                history: 1
                at: 1
                least: 1
                commits: 3
                each: 1
                task: 1
                prototype: 1
                system: 2
                several: 2
                implementation: 1
                Usually: 1
                it: 1
                contains: 1
                more: 1
                just: 1
                bug: 1
                fixing: 1
      
      
        Case 2:
            Input:
                Read a CSV file that is specified in Task 4, Create a binary file that is based on the CSV file. Read the binary file and create another binary file that will contain the number of the students whose score is greater than 95 and all the records for those students.

            Output:
                Read: 2
                a: 2
                CSV: 2
                file: 5
                that: 3
                is: 3
                specified: 1
                in: 1
                Task: 1
                Create: 1
                binary: 3
                based: 1
                on: 1
                the: 5
                and: 2
                create: 1
                another: 1
                will: 1
                contain: 1
                number: 1
                of: 1
                students: 2
                whose: 1
                score: 1
                greater: 1
                than: 1
                all: 1
                records: 1
                for: 1
                those: 1
      
      
     */





    const int beginLettersInASCII = 65;
    const int endElttersInASCII = 122;

    public static void Main(string[] args)
    {
        int size = 5;

        string[] words = new string[size];
        int[] numOfRepetition = new int[size];

        string path = Path.Combine(Directory.GetCurrentDirectory(), "text_task5.txt");

        char el = '\0';
        string word = "";
        int counter = 0;

        using (var sr = new StreamReader(path))
        {
            while (!sr.EndOfStream)
            {
                do
                {
                    el = (char)sr.Read();

                    if ((int)el < beginLettersInASCII || (int)el > endElttersInASCII)
                    {
                        break;
                    }

                    word += el;
                } while ((int)el > beginLettersInASCII && (int)el < endElttersInASCII);


                for (int i = 0; i <= counter; i++)
                {
                    if (word == words[i])
                    {
                        numOfRepetition[i]++;
                        break;
                    }

                    if (i == counter && word != "")
                    {
                        words[counter] = word;
                        numOfRepetition[counter]++;
                        counter++;
                        break;
                    }
                }


                if (counter == words.Length - 1)
                {
                    Resize(ref words, ref numOfRepetition, ref size);
                }

                word = "";
            }

        }

        for (int i = 0; i < counter; i++)
        {
            Console.WriteLine(words[i] + ": " + numOfRepetition[i]);
        }

    }

    public static void Resize(ref string[] words, ref int[] numOfRepetition, ref int n, int addToLength = 20)
    {
        //Edit n
        n += addToLength;

        //Edit arr of words
        string[] tempArr = new string[words.Length + addToLength];

        for (var i = 0; i < words.Length; i++)
        {
            tempArr[i] = words[i];
        }

        words = tempArr;

        //Edit arr of numOfRepetition
        int[] tempArr2 = new int[numOfRepetition.Length + addToLength];

        for (var i = 0; i < numOfRepetition.Length; i++)
        {
            tempArr2[i] = numOfRepetition[i];
        }

        numOfRepetition = tempArr2;
    }

}
