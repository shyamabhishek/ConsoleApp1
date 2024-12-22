using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal static class StaticDemo
    {
        public static string Name;
        static StaticDemo()
        {
            Console.WriteLine("Static Constructor Called");
        }
        public static void Test()
        {
            Console.WriteLine("Test Method Called");
        }
        //public static void Show() => Console.WriteLine("testing");
        //public void Test2()
        //{
        //    Console.WriteLine("Test 2 Method Called");
        //}
        static void Main()
        {
            StaticDemo.Test();
            StaticDemo.Name = "Testing Name";
            Console.WriteLine(StaticDemo.Name);
            Console.ReadLine();
        }
    }
}
