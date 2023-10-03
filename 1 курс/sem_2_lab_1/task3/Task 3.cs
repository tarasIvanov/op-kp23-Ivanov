using System;

class Task3
{
    /*  Test cases:
     *  
     *  Input:
            apple
            cSharp
            pen
            math
            phone
            light
            zero
            Cbip
            Door
            bear
            cat
            path
            Empty   
            ASCII
            iPhone

        Output:
            apple
            ASCII
            bear
            cat
            Cbip
            cSharp
            Door
            Empty   
            iPhone 
            light
            math
            path
            pen
            phone
            zero


        Input:
            apple
            cSharp
            pen
            math
            phone
            light
            zero
            Cbip
            Door
            bear
            cat
            path
            Empty   
            ASCII
            iPhone 
            Agree   
            smart
            good
            big
            Boy
            Ugly
            Defense

        Output:
            Agree   
            apple
            ASCII
            bear
            big
            Boy
            cat
            Cbip
            cSharp
            Defense
            Door
            Empty   
            good
            iPhone 
            light
            math
            path
            pen
            phone
            smart
            Ugly
            zero

    */



    const int beginBigLetters = 65;
    const int endBigLetters = 90;
    const int bigToSmall = 32;

    const int size = 40;

    public static void Main(string[] args)
    {
        string[] words = new string[size];

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

            if (el1 >= beginBigLetters && el1 <= endBigLetters)
            {
                el1 += bigToSmall;
            }

            if (el2 >= beginBigLetters && el2 <= endBigLetters)
            {
                el2 += bigToSmall;
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

                    if (el1 >= beginBigLetters && el1 <= endBigLetters)
                    {
                        el1 += bigToSmall;
                    }

                    if (el2 >= beginBigLetters && el2 <= endBigLetters)
                    {
                        el2 += bigToSmall;
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


