using System;
namespace ForAll
{
    public class DequeForArr<Item> : IIterator<Item>
    {
        public bool HasNext { get; private set; } = true;

        private Item[] arr;

        private int Count = 0;
        private int CapaciryOfArr;

        private Item _currentItem;

        private int counterIterator = 0;

        // construct an empty deque
        public DequeForArr(int sizeOfArr)
        {
            arr = new Item[sizeOfArr];

            this.CapaciryOfArr = sizeOfArr;
        }

        // is the deque empty?
        public bool isEmpty()
        {
            if (Count == 0)
            {
                return true;
            }

            return false;
        }

        // return the number of items on the deque
        public int GetSize()
        {
            return Count;
        }

        // add the item to the front
        public void AddFirst(Item item)
        {
            if (Count >= CapaciryOfArr)
            {
                Resize(ref arr, ref CapaciryOfArr);
            }

            for (int i = Count; i > 0; i--)
            {
                arr[i] = arr[i - 1];
            }

            arr[0] = item;

            Count++;
        }

        // add the item to the back
        public void AddLast(Item item)
        {
            if (Count >= CapaciryOfArr)
            {
                Resize(ref arr, ref CapaciryOfArr);
            }

            arr[Count] = item;

            Count++;
        }

        // remove and return the item from the front
        public Item RemoveFirst()
        {
            if (Count > 0)
            {
                Item temp = arr[0];

                for (int i = 0; i < Count; i++)
                {
                    arr[i] = arr[i + 1];
                }

                arr[Count - 1] = default!;

                Count--;

                return temp;
            }

            return default!;
        }

        // remove and return the item from the back
        public Item RemoveLast()
        {
            if (Count > 0)
            {
                Item temp = arr[Count - 1];

                arr[Count - 1] = default!;

                Count--;

                return temp;
            }

            return default!;
        }

        //// return an iterator over items in order from front to back
        public IIterator<Item> iterator()
        {
            return this;
        }

        Item IIterator<Item>.MoveNext()
        {
            if (counterIterator == 0)
            {
                _currentItem = arr[Count - 1];

                counterIterator++;
            }

            if (counterIterator >= Count)
            {
                this.HasNext = false;

                return _currentItem;
            }

            var temp = _currentItem;

            _currentItem = arr[Count - counterIterator - 1];

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

