using System;

class Task3
{
    public static void Main(string[] args)
    {
        int n = 40;

        string[] words = new string[n];

        int numOfWords = 0;

        string pathBaseWords = Path.Combine(Directory.GetCurrentDirectory(), "FileWithEnglishWords.txt");
        string pathChangedWords = Path.Combine(Directory.GetCurrentDirectory(), "ChangedFileWithEnglishWords.txt");


        using (var sr = new StreamReader(pathBaseWords))
        {
            while (!sr.EndOfStream)
            {
                words[numOfWords] = sr.ReadLine();
                numOfWords++;
            }
        }

        SortArr(ref words, numOfWords);

        using (var sw = new StreamWriter(pathChangedWords))
        {
            for (int i = 0; i < numOfWords; i++)
            {
                sw.WriteLine(words[i]);
            }
        }
    }

    public static void SortArr(ref string[] words, int numOfWords)
    {
        string temp = "";

        int el1;
        int el2;

        int letter = 1;

        for (int i = 0; i < numOfWords - 1; i++)
        {
            el1 = Convert.ToInt32(words[i][0]);
            el2 = Convert.ToInt32(words[i + 1][0]);

            if (el1 >= 65 && el1 <= 90)
            {
                el1 += 32;
            }

            if (el2 >= 65 && el2 <= 90)
            {
                el2 += 32;
            }

            if (el1 > el2)
            {
                temp = words[i + 1];
                words[i + 1] = words[i];

                words[i] = temp;
                i = -1;
            }
            else if (el1 == el2)
            {
                while (el1 == el2 && letter < words[i].Length && letter < words[i + 1].Length)
                {
                    el1 = Convert.ToInt32(words[i][letter]);
                    el2 = Convert.ToInt32(words[i + 1][letter]);

                    if (el1 >= 65 && el1 <= 90)
                    {
                        el1 += 32;
                    }

                    if (el2 >= 65 && el2 <= 90)
                    {
                        el2 += 32;
                    }

                    if (el1 > el2)
                    {
                        temp = words[i + 1];
                        words[i + 1] = words[i];

                        words[i] = temp;
                        i = -1;
                        break;
                    }
                    else if (el1 < el2)
                    {
                        break;
                    }

                    letter++;
                }

                letter = 0;
            }
        }


    }

}


