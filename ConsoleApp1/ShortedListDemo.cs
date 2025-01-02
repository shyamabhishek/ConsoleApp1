using System;
using System.Collections;

namespace ConsoleApp1
{
    internal class ShortedListDemo
    {
        static void Main()
        {
            Hashtable ht = new Hashtable();
            ht.Add(3, "Number 3");
            ht.Add(4, "Number 4");
            ht.Add(1, "Number 1");
            ht.Add(5, "Number 5");
            ht.Add(2, "Number 2");
            foreach (var item in ht.Keys)
            {
                Console.WriteLine(item + " : " + ht[item]);
            }
            Console.WriteLine("========================================");
            SortedList al = new SortedList();
            al.Add(3, "Number 3");
            al.Add(4, "Number 4");
            al.Add(1, "Number 1");
            al.Add(5, "Number 5");
            al.Add(2, "Number 2");
            foreach (var item in al.Keys)
            {
                Console.WriteLine(item + " : " + al[item]);
            }
            //Console.WriteLine("===============================");
            //for (int i = al.Count - 1; i >= 0; i--) // Reverse iteration for descending order
            //{
            //    var key = al.GetKey(i);
            //    var value = al.GetByIndex(i);
            //    Console.WriteLine(key + " : " + value);
            //}
            Console.ReadLine();

        }
    }
}
