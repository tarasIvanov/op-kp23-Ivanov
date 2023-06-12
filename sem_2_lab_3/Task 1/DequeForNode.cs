using System;
using System.Xml.Linq;
using Bogus.DataSets;
using ForAll.Task1;

namespace ForAll
{
    public class DequeForNode<Item> : IIterator<Item>
    {
        public bool HasNext { get; private set; } = true;

        private Node<Item> head;
        private Node<Item> tail;

        private int Count = 0;

        private Node<Item> _currentItem;

        // construct an empty deque
        public DequeForNode()
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

        // add the item to the front
        public void AddFirst(Item item)
        {
            Node<Item> newNode = new Node<Item>(item);

            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.Next = head;
                head.Previous = newNode;
                head = newNode;
            }

            Count++;
        }

        // add the item to the back
        public void AddLast(Item item)
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

        // remove and return the item from the front
        public Item RemoveFirst()
        {
            if (head == null)
                throw new InvalidOperationException("Deque is empty.");

            Item data = head.Data;
            head = head.Next;

            if (head != null)
                head.Previous = null;
            else
                tail = null;

            Count--;

            return data;
        }

        // remove and return the item from the back
        public Item RemoveLast()
        {
            if (tail == null)
                throw new InvalidOperationException("Deque is empty.");

            Item temp = tail.Data;
            tail = tail.Previous;

            if (tail != null)
                tail.Next = null;
            else
                head = null;

            Count--;

            return temp;
        }

        //// return an iterator over items in order from front to back
        public IIterator<Item> iterator()
        {
            _currentItem = tail;

            return this;
        }

        Item IIterator<Item>.MoveNext()
        {
            if (_currentItem.Previous == null)
            {
                HasNext = false;

                return _currentItem.Data;
            }

            Item data = _currentItem.Data;
            _currentItem = _currentItem.Previous;

            return data;
        }
    }


}

