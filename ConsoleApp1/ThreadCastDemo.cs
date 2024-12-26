using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ThreadCastDemo
    {
        public static void Test1(object num)
        {
            int number = Convert.ToInt32(num);
            for (int i = 0; i <= number; i++)
            {
                Console.WriteLine("Test1 " + i);
            }
        }
        static void Main()
        {
            //ThreadStart ts = new ThreadStart(Test1);
            //ThreadStart ts = Test1;
            //ThreadStart ts = delegate { Test1 (); };
            //ThreadStart ts () => Test1();

            //ParameterizedThreadStart pt = new ParameterizedThreadStart(Test1);
            //Thread t2 = new Thread(pt);
            Thread t2 = new Thread(Test1);
            t2.Start(50);
            //or
            //Thread t1 = new Thread(Test1);
            //t1.Start(50);
            Console.ReadLine();
        }
    }
}
