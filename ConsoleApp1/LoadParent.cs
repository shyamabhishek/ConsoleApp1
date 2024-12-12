using System;

namespace ConsoleApp1
{
    internal class LoadParent
    {
        public void Show()
        {
            Console.WriteLine("Parent show method called");
        }
        public virtual void Test() //overriding
        {
            Console.WriteLine("Parent test method called");
        }
    }
    class LoadChild : LoadParent
    {
        public override void Test()  //overriding         
        {
            Console.WriteLine("Child Test Method called");
        }
        public void Show(int i)
        {
            Console.WriteLine("Child Show Method called");
        }
        //static void Main()
        //{
        //    LoadChild obj = new LoadChild();
        //    obj.Show();
        //    obj.Show(10);
        //    obj.Test();
        //    Console.ReadLine();
        //}
    }
    class LoadChild1 : LoadChild
    {
        public override void Test()
        {
            Console.WriteLine("LoadChild 1 test method called");
        }
        static void Main()
        {
            LoadChild1 obj = new LoadChild1();
            obj.Test();
            Console.ReadLine();
        }
    }
}
