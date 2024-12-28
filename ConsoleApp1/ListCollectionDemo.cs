using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ListCollectionDemo
    {
        public class Customer
        {
            public string Name { get; set; }
            public string Description { get; set; }

        }
        static void Main()
        {
            List<int> li = new List<int>();

            li.Add(1); li.Add(2); li.Add(3);
            foreach (var item in li)
            {
                Console.WriteLine(item);
                
            }
            List<string> ls = new List<string>();
            List<Customer> list = new List<Customer>();
            Console.ReadLine();
        }
    }
}
