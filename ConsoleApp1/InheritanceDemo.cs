using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class InheritanceDemo
    {
        public InheritanceDemo()
        {
            Console.WriteLine("Parent constructor called");
        }
        public void Test1()
        {
            Console.WriteLine("Test 1 Method called");
        }
        public void Test2()
        {
            Console.WriteLine("Test 2 method called");
        }
        private void Test3()
        {
            Console.WriteLine("Test 3 Method called");
        }
    }
}
