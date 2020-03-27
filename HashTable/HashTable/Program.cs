using System;
using System.Collections;

namespace HashTable
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Hashtable hashTable = new Hashtable()
            {
                    { 1, "One" },
                    { 2, "Two" },
                    { 3, "Three" },
                    { 4, "Four" },
                    { 5, null },
                    { "Fv", "Five" },
                    { 8.5F, 8.5 }
            };

            foreach (var key in hashTable.Keys)
                Console.WriteLine("Key:{0}, Value:{1}", key, hashTable[key]);

            Console.WriteLine("***All Values***");

            foreach (var value in hashTable.Values)
                Console.WriteLine("Value:{0}", value);
        }
    }
}
