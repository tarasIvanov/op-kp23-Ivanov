using System;
using System.Linq;
using System.Globalization;

namespace ForAll
{
    class Program
    {
        public static void Main(string[] args)
        {
            //DequeForList<int> deque1 = new DequeForList<int>();

            //deque1.AddLast(5);
            //deque1.AddLast(5);
            //deque1.AddFirst(1);
            //deque1.AddLast(2);
            //deque1.AddLast(3);
            //deque1.AddFirst(1);

            //DequeForArr<string> deque2 = new DequeForArr<string>(5);

            //deque2.AddFirst("string 2");
            //deque2.AddLast("string 3");
            //deque2.AddLast("string 4");
            //deque2.AddFirst("string 1");

            //IIterator<string> iterator = deque2.iterator();

            //while (iterator.HasNext)
            //{
            //    Console.WriteLine(iterator.MoveNext());
            //}

            Console.WriteLine("Unit test: " + UnitTest());
        }

        public static bool UnitTest()
        {
            const int size = 4;

            string[] expectedArr = { "string 4", "string 3", "string 2", "string 1" };

            string[] arr = new string[size];
            int counter = 0;

            bool res = true;

            DequeForArr<string> deque2 = new DequeForArr<string>(5);

            deque2.AddFirst("string 2");
            deque2.AddLast("string 3");
            deque2.AddLast("string 4");
            deque2.AddFirst("string 1");

            IIterator<string> iterator = deque2.iterator();

            while (iterator.HasNext)
            {
                arr[counter] = iterator.MoveNext();
                counter++;
            }

            for (int i = 0; i < size; i++)
            {
                if (arr[i] != expectedArr[i])
                {
                    res = false;
                }
            }

            return res;
        }
    }
}