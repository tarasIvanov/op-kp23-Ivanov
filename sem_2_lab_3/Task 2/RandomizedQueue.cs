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
            
        }

        // is the randomized queue empty?
        public bool IsEmpty()
        {
            
        }

        // return the number of items on the randomized queue
        public int Size()
        {
            
        }

        // add the item
        public void Enqueue(Item item)
        {
           
        }

        // remove and return a random item
        public Item Dequeue()
        {
            
        }

        // return a random item (but do not remove it)
        public Item Sample()
        {
            
        }

        // return an independent iterator over items in random order
        public IIterator<Item> iterator()
        {
            
        }

        Item IIterator<Item>.MoveNext()
        {
            
        }

        private static void Resize(ref Item[] arr, ref int CapaciryOfArr, int addToLength = 10)
        {
            
        }
    }
}

