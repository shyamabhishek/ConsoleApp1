using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public delegate string GetStringValue(string value);
    internal class AnonymousMethodDemo
    {
        //public static string GetStringData(string name)
        //{
        //    return "Hello " + name + "Good Morning";
        //}
        static void Main()
        {
            GetStringValue gt = (name) =>
            {
                return "Hello " + name + "Good Morning";
            };
            string result = gt("Shyam ");
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
