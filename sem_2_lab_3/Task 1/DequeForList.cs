using System;
namespace ForAll
{
    public class DequeForList<Item> : IIterator<Item>
    {
        public bool HasNext { get; private set; } = true;

        List<Item> _list;

        Item _currentItem;

        private int counterIterator = 0;

        // construct an empty deque
        public DequeForList()
        {
            _list = new List<Item>();
        }

        // is the deque empty?
        public bool isEmpty()
        {
            if (_list.Count == 0)
            {
                return true;
            }

            return false;
        }

        // return the number of items on the deque
        public int GetSize()
        {
            return _list.Count;
        }

        // add the item to the front
        public void AddFirst(Item item)
        {
            _list.Add(default!);

            for (int i = _list.Count - 1; i > 0; i--)
            {
                _list[i] = _list[i - 1];
            }

            _list[0] = item;
        }

        // add the item to the back
        public void AddLast(Item item)
        {
            _list.Add(item);
        }

        // remove and return the item from the front
        public Item RemoveFirst()
        {
            if (_list.Count > 0)
            {
                Item temp = _list[0];

                _list.Remove(_list[0]);

                return temp;
            }
            
            return default!;
        }

        // remove and return the item from the back
        public Item RemoveLast()
        {
            if (_list.Count > 0)
            {
                Item temp = _list[_list.Count - 1];

                _list.Remove(_list[_list.Count - 1]);

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
                _currentItem = _list[_list.Count - 1];

                counterIterator++;
            }

            if (counterIterator >= _list.Count)
            {
                this.HasNext = false;

                return _currentItem;
            }

            var temp = _currentItem;

            _currentItem = _list[_list.Count - counterIterator - 1];

            counterIterator++;

            return temp;
        }
    }


}

