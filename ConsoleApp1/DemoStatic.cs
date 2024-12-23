using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal static class DemoStatic
    {
        public static void Test3(this ExtentionDemo1 e, int i)
        {
            Console.WriteLine("Test 3 Method Called  " + i);
        }
        public static void Test4(this ExtentionDemo1 e, string s)
        {
            Console.WriteLine("Extention Test3 method called  " + s);
        }
        public static long Factorial(this Int32 i)
        {
            if (i == 0)
            {
                return 0;
            }
            if (i == 2)
            {
                return 2;
            }
            else
            {
                return i * Factorial(i-1);
            }
        }
    }
}
