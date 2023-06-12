using System;
using System.Linq;
using System.Globalization;

namespace ForAll
{
    class Program
    {
        public static void Main(string[] args)
        {
            HashTable<int, string> hashTable = new HashTable<int, string>(3);

            hashTable.Add(1, "taras1");
            hashTable.Add(2, "taras2");
            hashTable.Add(3, "taras3");
            hashTable.Add(4, "taras4");
            hashTable.Add(5, "taras5");

            Console.WriteLine("Contains?: " + hashTable.Contains(4)); //Contains?: True
            Console.WriteLine("Contains?: " + hashTable.Contains(5)); //Contains?: True
            Console.WriteLine("Contains?: " + hashTable.Contains(10)); //Contains?: False

            Console.WriteLine("Get: " + hashTable.Get(1)); // taras1

            Console.WriteLine("Size: " + hashTable.Size()); // 5

            hashTable.Remove(4);
            hashTable.Remove(5);

            Console.WriteLine("Contains?: " + hashTable.Contains(4)); //Contains?: False
            Console.WriteLine("Contains?: " + hashTable.Contains(5)); //Contains?: False

            Console.WriteLine("Size: " + hashTable.Size()); // 3
            hashTable.Clear();
            Console.WriteLine("Size: " + hashTable.Size()); // 0

            //Console.WriteLine("Get: " + hashTable.Get(1)); //Eror
        }
    }
}

