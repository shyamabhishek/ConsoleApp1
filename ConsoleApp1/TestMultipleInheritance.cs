using System;

namespace ConsoleApp1
{
    interface Interface1
    {
        void Test();
    }
    interface Interface2
    {
        void Test();
    }
    internal class TestMultipleInheritance : Interface1, Interface2
    {
        public void Test()
        {
            Console.WriteLine("Interface Method Called");
        }
        void Interface1.Test()
        {
            Console.WriteLine("Interface 1 Method Called");
        }
        void Interface2.Test()
        {
            Console.WriteLine("Interface 2 Method Called");
        }

        //static void Main()
        //{ 
        //    TestMultipleInheritance obj = new TestMultipleInheritance();
        //    Interface1 i = obj;
        //    Interface2 i2 = obj;
        //    i.Test();
        //    i2.Test();
        //    obj.Test();
        //    Console.ReadLine();
        //}
        class MIH : TestMultipleInheritance
        {
            static void Main()
            {
                MIH obj = new MIH();
                Interface1 obj1 = obj;
                Interface1 obj2 = obj;
                obj.Test();
                obj1.Test();
                obj2.Test();
                Console.ReadLine();
            }
        }
    }
}
