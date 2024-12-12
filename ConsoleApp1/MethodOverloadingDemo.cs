using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class MethodOverloadingDemo
    {
        //polymorphism or Method Overloading
        public void Test(int i) //method with same name can only be called with different parameter
        {
            Console.WriteLine("Test Method called " + i);
        }
        public void Test()
        {
            Console.WriteLine("Test Method called ");
        }
        public void Test(string s)
        {
            Console.WriteLine("Test Method String Called");
        }

        //public void Test() //var can not be overloaded compiletime check
        //{
        //    var i = ""
        //}
        public void Test(dynamic i) //it's not safe to use bcs it is runtime check
        {
            Console.WriteLine("Test Dynamic Method called" + i);
        }
        static void Main()
        {
            MethodOverloadingDemo obj= new MethodOverloadingDemo();
            obj.Test();
            obj.Test(10);
            obj.Test("Test");
            Console.ReadLine();
        }
    }
}
