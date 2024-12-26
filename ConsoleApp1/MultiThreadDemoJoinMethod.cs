using System;
using System.Threading;

namespace ConsoleApp1
{
    internal class MultiThreadDemoJoinMethod
    {
        public static void Test1()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine("Test1 " + i);
            }
            Console.WriteLine("Test 1 Method Exit");
        }
        public static void Test2()
        {
            for (int i = 0; i <= 100; i++)
            {
                if (i == 50)
                {
                    Console.WriteLine("Thread 2 Stop");
                    Thread.Sleep(5000);
                    Console.WriteLine("Test2 " + i);
                    Console.WriteLine("Thread 2 Start ");
                }
            }
            Console.WriteLine("Test 2 Method Exit");
        }
        public static void Test3()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine("Test3 " + i);
            }
            Console.WriteLine("Test 3 Method Exit");
        }
        static void Main()
        {
            Console.WriteLine("Main Thread Start");
            Thread t1 = new Thread(Test1);
            Thread t2 = new Thread(Test2);
            Thread t3 = new Thread(Test3);
            t1.Start(); t2.Start(); t3.Start();
            t1.Join(); t2.Join(); t3.Join();
            Console.WriteLine("Main Thread Exit");
            
            Console.ReadLine();
        }
    }
}
