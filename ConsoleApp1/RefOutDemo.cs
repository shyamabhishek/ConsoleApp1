using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class RefOutDemo
    {
        //using ref keyword
        //static void Main()
        //{
        //    int x = 20;
        //    TestFunction(ref x);
        //    Console.WriteLine(x);
        //    Console.ReadLine();
        //}

        //static void TestFunction(ref int Value)
        //{
        //    Value = Value + 10;
        //}


        //out Keyword
        static void Main()
        {
            int x = 20;
            TestFunction(out x);
            Console.WriteLine(x);
            Console.ReadLine();
        }

        static void TestFunction(out int Value)
        {
            Value = 0;
            Value = Value + 10;
        }
    }
}
