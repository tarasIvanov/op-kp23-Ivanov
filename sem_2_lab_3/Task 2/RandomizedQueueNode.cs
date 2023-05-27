using System;
using System.Xml.Linq;
using Bogus.DataSets;
using ForAll.Task1;

namespace ForAll
{
    class RandomisedQueueNode<Item> : IIterator<Item>
    {
        Random random = new Random();

        public bool HasNext { get; private set; } = true;

        private Node<Item> head;
        private Node<Item> tail;

        public int Count { get; private set; } = 0;

        private bool[] _arrOfRepeatItems;
        private int _counterIterator = 0;

        private Node<Item> _currentItem;

        // construct an empty randomized queue
        public RandomisedQueueNode()
        {

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

        // add the item
        public void Enqueue(Item item)
        {
            Node<Item> newNode = new Node<Item>(item);

            if (tail == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.Previous = tail;
                tail.Next = newNode;
                tail = newNode;
            }

            Count++;
        }

        // remove and return a random item
        public Item Dequeue()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Queue is empty.");
            }

            int randomIndex = random.Next(Count);
            Item result;

            if (randomIndex == 0)
            {
                result = head.Data;
                head = head.Next;
            }
            else
            {
                Node<Item> previous = null;
                Node<Item> current = head;

                for (int i = 0; i < randomIndex; i++)
                {
                    previous = current;
                    current = current.Next;
                }

                result = current.Data;
                previous.Next = current.Next;
            }

            Count--;

            return result;
        }

        // return a random item (but do not remove it)
        public Item Sample()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Queue is empty.");
            }

            int randomIndex = random.Next(Count);

            Node<Item> current = head;

            for (int i = 0; i < randomIndex; i++)
            {
                current = current.Next;
            }

            return current.Data;
        }

        // return an independent iterator over items in random order
        public IIterator<Item> iterator()
        {
            _arrOfRepeatItems = new bool[Count];

            return this;
        }

        Item IIterator<Item>.MoveNext()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Queue is empty.");
            }

            if (_counterIterator == Count - 1)
            {
                HasNext = false;
            }

            Node<Item> current = head;

            int randomIndex = random.Next(Count);

            while (true)
            {
                if (_arrOfRepeatItems[randomIndex])
                {
                    randomIndex = random.Next(Count);
                }
                else
                {
                    break;
                }
            }

            for (int i = 0; i < randomIndex; i++)
            {
                current = current.Next;
            }

            _arrOfRepeatItems[randomIndex] = true;
            _counterIterator++;

            return current.Data;
        }
    }


}



