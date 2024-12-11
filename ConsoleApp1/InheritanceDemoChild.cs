using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class InheritanceDemoChild : InheritanceDemo
    {
        public InheritanceDemoChild()
        {
            Console.WriteLine("Child class constructor called");
        }
        public void Test4()
        {
            Console.WriteLine("Test 4 method called");
        }
        static void Main()
        {   
            //creating object of child class
            InheritanceDemoChild obj = new InheritanceDemoChild();
            //reference of object obj is p
            InheritanceDemo p = obj;
            p.Test1();
            p.Test2();
            

            Console.ReadLine();

        }
    }
}
