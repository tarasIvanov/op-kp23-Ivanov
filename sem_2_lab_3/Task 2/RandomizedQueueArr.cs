using System;
using System.Collections.Generic;

namespace ForAll
{
	public class RandomizedQueue<Item> : IIterator<Item>
	{
        Random random = new Random();

        public bool HasNext { get; private set; } = true;

        private Item[] arr;

        private int Count = 0;
        private int CapaciryOfArr;

        private bool[] arrOfRepeatItems;
        private Item _currentItem;

        private int counterIterator = 0;

        // construct an empty randomized queue
        public RandomizedQueue(int sizeOfArr)
        {
            arr = new Item[sizeOfArr];
        }

        // is the randomized queue empty?
        public bool IsEmpty()
        {
            if (Count == 0)
            {
                return true;
            }

            return false;
        }

        // return the number of items on the randomized queue
        public int Size()
        {
            return Count;
        }

        // add the item
        public void Enqueue(Item item)
        {
            if (Count >= CapaciryOfArr)
            {
                Resize(ref arr, ref CapaciryOfArr);
            }

            arr[Count] = item;

            Count++;
        }

        // remove and return a random item
        public Item Dequeue()
        {
            if (Count <= 0)
            {
                return default!;
            }

            int randomNum = random.Next(0, Count);
            Item tempItem = arr[randomNum];

            var tmp = new List<Item>(arr);
            tmp.RemoveAt(randomNum);
            arr = tmp.ToArray();

            Count--;

            return tempItem;
        }

        // return a random item (but do not remove it)
        public Item Sample()
        {
            return arr[random.Next(0, Count)];
        }

        // return an independent iterator over items in random order
        public IIterator<Item> iterator()
        {
            arrOfRepeatItems = new bool[Count];

            return this;
        }

        Item IIterator<Item>.MoveNext()
        {
            if (counterIterator >= Count)
            {
                this.HasNext = false;

                return _currentItem;
            }

            int randomNum = random.Next(0, Count);

            if (counterIterator == 0)
            {
                _currentItem = arr[randomNum];
                arrOfRepeatItems[randomNum] = true;

                counterIterator++;
            }

            while (true)
            {
                if (arrOfRepeatItems[randomNum])
                {
                    randomNum = random.Next(0, Count);
                }
                else
                {
                    break;
                }
            }

            var temp = _currentItem;

            _currentItem = arr[randomNum];

            arrOfRepeatItems[randomNum] = true;

            counterIterator++;

            return temp;
        }

        private static void Resize(ref Item[] arr, ref int CapaciryOfArr, int addToLength = 10)
        {
            CapaciryOfArr += 20;

            Item[] tempArr = new Item[arr.Length + addToLength];

            for (var i = 0; i < arr.Length; i++)
            {
                tempArr[i] = arr[i];
            }

            arr = tempArr;
        }
    }
}

