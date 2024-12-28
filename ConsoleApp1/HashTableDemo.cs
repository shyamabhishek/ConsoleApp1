using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class HashTableDemo
    {
        static void Main()
        {
            Hashtable ht = new Hashtable();
            ht.Add("empid", 123);
            ht.Add("Name", "Shyam");
            ht.Add("Contact", 1234567890);
            ht.Add("email", "shyam@gmail.com");


            Console.WriteLine("Name".GetHashCode());


            foreach(var item in ht.Keys)
            {
                Console.WriteLine(item + ":" + ht[item]);
            }
            Console.ReadLine();
        }
    }
}
