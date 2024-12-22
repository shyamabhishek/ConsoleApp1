using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class DelegateDemo
    {
        //step 1 : defining of delegate
        public delegate void AddDelegate(int x, int y);
        public delegate string ShowDelegate(string name);
        public void AddNum(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public static string Show(string name)
        {
            return "Hello" + name;
        }
        static void Main()
        {
            DelegateDemo d = new DelegateDemo();

            //Step 2 : Instantiation of delegates
            AddDelegate ad = new AddDelegate(d.AddNum);
            
            ShowDelegate sd = new ShowDelegate(Show);
            //Step 3 : Calling Delegates
            ad(10, 20);
            string result = sd("Shyam");
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
