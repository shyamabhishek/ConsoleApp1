using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public delegate int AddDel(int x,  int y);
    
    internal class MultiCastDelegateDemo1
    {
        public int AddNum(int x, int y)
        {
            return x + y;
        }
        public int SubNum(int x, int y)
        {
            return (x - y);
        }
        static void Main()
        {
            MultiCastDelegateDemo1 obj = new MultiCastDelegateDemo1();
            AddDel ad = obj.AddNum;
            ad += obj.SubNum;
            ad(30, 20);
            int result = ad(30, 20);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
