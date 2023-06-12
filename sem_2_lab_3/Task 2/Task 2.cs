using System;
using System.Linq;
using System.Globalization;

namespace ForAll
{
    class Program
    {
        public static void Main(string[] args)
        {
            //RandomizedQueueArr<int> queue = new RandomizedQueueArr<int>(10);

            //queue.Enqueue(5);
            //queue.Enqueue(3);
            //queue.Enqueue(2);
            //queue.Enqueue(7);
            //queue.Enqueue(10);

            //Console.WriteLine("-:" + queue.Sample());
            //Console.WriteLine("-:" + queue.Sample());

            //queue.Dequeue();
            //queue.Dequeue();
            //queue.Dequeue();

            //RandomisedQueueNode<int> queue = new RandomisedQueueNode<int>();

            //queue.Enqueue(5);
            //queue.Enqueue(3);
            //queue.Enqueue(2);
            //queue.Enqueue(7);
            //queue.Enqueue(10);

            //IIterator<int> iterator = queue.iterator();

            //while (iterator.HasNext)
            //{
            //    Console.WriteLine(iterator.MoveNext());
            //}

            Console.WriteLine("Unit test: " + UnitTestNumOfEll());
            Console.WriteLine("Unit test: " + UnitTestHaveChangedEll());
        }

        public static bool UnitTestNumOfEll()
        {
            RandomisedQueueNode<int> queueNode = new RandomisedQueueNode<int>();

            queueNode.Enqueue(1);
            queueNode.Enqueue(2);
            queueNode.Enqueue(3);
            queueNode.Enqueue(4);

            int numOfEll = 4;

            return numOfEll == queueNode.Count;
        }

        public static bool UnitTestHaveChangedEll()
        {
            //Тут ми беремо 2 елементи, і дивимось чи вони різні, цим самим переконуємось чи працює ітератор
            int num1 = 0, num2 = 0;

            RandomisedQueueNode<int> queueNode = new RandomisedQueueNode<int>();
            
            queueNode.Enqueue(1);
            queueNode.Enqueue(2);
            queueNode.Enqueue(3);
            queueNode.Enqueue(4);

            IIterator<int> iterator = queueNode.iterator();

            for (int i = 0; i < 2; i++)
            {
                if (i == 0)
                {
                    num1 = iterator.MoveNext();
                }

                if (i == 1)
                {
                    num2 = iterator.MoveNext();
                }
            }

            return !(num1 == num2);
        }
    }
}