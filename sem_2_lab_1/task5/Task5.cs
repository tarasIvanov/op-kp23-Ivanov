using System;

class Task5
{
    const int beginLettersInASCII = 65;
    const int endElttersInASCII = 122;

    const int size = 5;

    public static void Main(string[] args)
    {
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
