using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp1
{
    internal class CollectionDemo1
    {
        static void Main()
        {
            //int[] arr = new int[10];
            //Array.Resize(ref arr, 5);
            ArrayList al = new ArrayList(10);
            Console.WriteLine(al.Capacity);
            al.Add(1); al.Add(2); al.Add(3); al.Add(4);
            Console.WriteLine(al.Capacity);
            foreach (int item in al)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            al.Insert(1, 300);
            foreach (int item in al)
            {
                Console.WriteLine(item + " ");
            }
            al.Remove(300);
            foreach (int item in al)
            {
                Console.WriteLine(item + " ");
            }
            Console.ReadLine();
        }
    }
}
