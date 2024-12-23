using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class TestExtentionMethod
    {
        static void Main()
        {
            ExtentionDemo1 extentionDemo1 = new ExtentionDemo1();
            extentionDemo1.Test1();
            extentionDemo1.Test2();
            extentionDemo1.Test3(20);
            extentionDemo1.Test4("Shyam");
            int i = 5;
            long result = i.Factorial();
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
