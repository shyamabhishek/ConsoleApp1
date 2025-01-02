using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp1
{
    internal class DictionaryCollectionDemo
    {
        static void Main()
        {
            //Dictionary<string, string> dict = new Dictionary<string, string>();
            //dict.Add("1", "");
            //Dictionary<int, int> dict1 = new Dictionary<int, int>();
            Dictionary<string, object> dict2 = new Dictionary<string, object>();
            dict2.Add("Empid", 101);
            dict2.Add("Name", "Shyam");
            dict2.Add("Job", "SDE");
            dict2.Add("Department", "IT");
            dict2.Add("Salary", 50000);
            dict2.Add("Pincode", 411057);
            dict2.Add("City", "Pune");

            foreach (var item in dict2.Keys)
            {
                Console.WriteLine(item + " : " + dict2[item]);
            }
            Console.ReadLine();

        }
    }
}
