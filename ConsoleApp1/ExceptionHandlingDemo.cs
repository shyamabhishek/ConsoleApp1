using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ExceptionHandlingDemo
    {
        public static void TestException()
        {
            try
            {
                int x = 10;
                int res = x / 0;
                Console.WriteLine(res);
            }
            catch (DivideByZeroException d)
            {
                Console.WriteLine("Message " + d.Message);
                Console.WriteLine("============================================");
                Console.WriteLine("StackTree " + d.StackTrace);
                Console.WriteLine("============================================");
                Console.WriteLine("InnerException " + d.InnerException);
                Console.WriteLine("============================================");
                Console.ReadLine();
            }
            
        }
        static void Main()
        {
            TestException();
            Console.ReadLine();
        }
    }
}
