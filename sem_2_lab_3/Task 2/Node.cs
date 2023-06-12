using System;
using System.Xml.Linq;

namespace ForAll.Task1
{
    class Node<T>
    {
        public T Data { get; }
        public Node<T> Next { get; set; }
        public Node<T> Previous { get; set; }

        public Node(T data)
        {
            Data = data;
        }
    }
}

