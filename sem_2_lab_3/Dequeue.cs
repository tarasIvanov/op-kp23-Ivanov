using System;
namespace ForAll
{
    public class Deque<Item> : IIterator<Item>
    {
        public int Size { get; private set; }

        public bool HasNext;

        List<Item> _list;

        // construct an empty deque
        public Deque()
        {

        }

        // is the deque empty?
        public bool isEmpty()
        {
            
        }

        // return the number of items on the deque
        public int GetSize()
        {

        }
        // add the item to the front
        public void addFirst(Item item)
        {

        }
        // add the item to the back
        public void AddLast(Item item)
        {
            
        }
        // remove and return the item from the front
        public Item RemoveFirst()
        {
            
        }
        // remove and return the item from the back
        public Item RemoveLast()
        {
            
        }
        //// return an iterator over items in order from front to back
        public IIterator<Item> iterator()
        {

        }
        
    }


}

