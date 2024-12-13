using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class MethodHidingDemo
    {
        public virtual void Show()
        {
            Console.WriteLine("Parent Show method called");

        }
        public void Test()
        {
            Console.WriteLine("Parent Test Method called ");
        }
    }
    class MethodHidingChildDemo : MethodHidingDemo
    {
        public override void Show()
        {
            Console.WriteLine("Child Show Method called");
        }
        public new void Test()
        {
            Console.WriteLine("Child Test method show");
        }
    
        static void Main()
        {
            MethodHidingChildDemo obj = new MethodHidingChildDemo();
            //MethodHidingDemo obj1 = new MethodHidingDemo();
            //obj1.Show();
            //obj1.Test();
            obj.Show();
            obj.Test();
            Console.ReadLine();
        }
    }
}
