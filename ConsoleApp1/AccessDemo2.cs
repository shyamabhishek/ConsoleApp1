using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class AccessDemo2 : AccessDemo
    {
        static void Main()
        {
            AccessDemo2 obj = new AccessDemo2();
            obj.Test1(); //public
            obj.Test3();   //protected
            obj.Test4();    //internal
            obj.Test5();    //protected Internal
            Console.ReadLine();
        }
    }   //protected class can only be called inside child derived class

}
