using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public delegate void AddDelegate(int x, int y);
    internal class MultiCastDelegateDemo
    {
        public void AddNum(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        public void SubNum(int x, int y) 
        {
            Console.WriteLine(x - y);
        }

        static void Main()
        {
            //if parameter and return type is same
            MultiCastDelegateDemo mobj = new MultiCastDelegateDemo();
            AddDelegate obj = mobj.AddNum;
            obj += mobj.SubNum;

            obj(30, 20);
            
            
            Console.ReadLine();
        }
    }
}
