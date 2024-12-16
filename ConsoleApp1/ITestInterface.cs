using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface ITestInterface
    {
        void Add(int x, int y);
        void Mul(int x, int y);
    }
    interface ITestInterface2 : ITestInterface
    {
        void Sub(int x, int y);
        void Div(int x, int y);
    }
    class ImplementationTest : ITestInterface2
    {
        public void Add(int x, int y)
        {
            Console.WriteLine(x + y);
        }

        public void Div(int x, int y)
        {
            Console.WriteLine(x / y);
        }

        public void Mul(int x, int y)
        {
            Console.WriteLine(x * y);
        }

        public void Sub(int x, int y)
        {
            Console.WriteLine(x - y);
        }
        static void Main()
        {
            ImplementationTest obj = new ImplementationTest();
            ITestInterface2 obj1 = obj;
            obj1.Add(1, 2);
            obj1.Mul(10, 20);
            obj1.Sub(30, 20);
            obj1.Div(30, 10);
            Console.ReadLine();
        }
    }
}
