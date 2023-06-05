using System;
namespace ForAll
{
	class HashTable<KItem, VItem>
    {
        private readonly int _capasity = 0;

        private int _size;

        private Node[] _table;

        private class Node
        {
            public KItem key;

            public VItem value;

            public Node pNext;

            public Node(KItem key ,VItem value)
            {
                this.key = key;
                this.value = value;
            }
        }

        private int GetHash(KItem key)
        {
            return Math.Abs(key.GetHashCode()) % _capasity;
        }

        public HashTable(int initialCapacity = 0)
        {
            _capasity = initialCapacity;

            _table = new Node[initialCapacity];
        }

        public void Add(KItem key, VItem value)
        {
            int index = GetHash(key);

            if (_table[index] == null)
            {
                _table[index] = new Node(key, value);
            }
            else
            {
                Node tempNode = _table[index];

                do
                {
                    if (!tempNode.key.Equals(key) && !tempNode.value.Equals(value))
                    {
                        if (tempNode.pNext != null)
                        {
                            tempNode = tempNode.pNext;
                        }
                        else
                        {
                            tempNode.pNext = new Node(key, value);
                        }
                    }
                    else
                    {
                        throw new ArgumentException("An item with the same key or value already exists in the hashtable.");
                    }

                } while (tempNode.pNext != null);
            }

            _size++;
        }

        public void Remove(KItem key)
        {
            if (!Contains(key))
            {
                throw new ArgumentException("An item with this key no exists in the hashtable.");
            }

            int index = GetHash(key);

            Node tempLink;

            Node tempNode = _table[index];

            while (true)
            {
                if (tempNode.key.Equals(key))
                {
                    _table[index] = tempNode.pNext;

                    _size--;

                    return;
                }

                if (tempNode.pNext.key.Equals(key))
                {
                    if (tempNode.pNext.pNext != null)
                    {
                        tempNode.pNext = tempNode.pNext.pNext;
                    }
                    else
                    {
                        tempNode.pNext = null;
                    }

                    _size--;

                    return;
                }
            }
        }

        public VItem Get(KItem key)
        {
            if (!Contains(key))
            {
                throw new ArgumentException("An item with this key no exists in the hashtable.");
            }

            int index = GetHash(key);

            return _table[index].value;
        }

        public bool Contains(KItem key)
        {
            int index = GetHash(key);

            if (_table[index] != null)
            {
                Node tempNode = _table[index];

                while (tempNode != null)
                {
                    if (tempNode.key.Equals(key))
                    {
                        return true;
                    }

                    tempNode = tempNode.pNext;
                }
            }

            return false;
        }

        public void Clear()
        {
            _table = new Node[_capasity];
            _size = 0;
        }

        public int Size()
        {
            return _size;
        }

    }
}

