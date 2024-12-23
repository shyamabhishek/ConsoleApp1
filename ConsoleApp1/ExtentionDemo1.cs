using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ExtentionDemo1
    {
        public void Test1()
        {
            Console.WriteLine("Test 1 Method Called");
        }
        public void Test2() 
        {
            Console.WriteLine("Test 2 Method Called");
        }
        static void Main()
        {
            ExtentionDemo1 obj = new ExtentionDemo1();
            obj.Test1();
            obj.Test2();
            Console.ReadLine();
        }
    }
}
