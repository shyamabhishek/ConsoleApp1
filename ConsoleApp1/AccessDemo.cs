using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class AccessDemo
    {
        public void Test1()
        {
            Console.WriteLine("public Method Called");
        }
        private void Test2()
        {
            Console.WriteLine("private Method Called");
        }
        protected void Test3()
        {
            Console.WriteLine("protected Method called");
        }
        internal void Test4()
        {
            Console.WriteLine("internal Method called");
        }
        protected internal void Test5()
        {
            Console.WriteLine("protected internal method called");
        }
    }
}
