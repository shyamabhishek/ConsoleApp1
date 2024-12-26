using System;
using System.Threading;

namespace ConsoleApp1
{
    internal class ThreadPriorityDemo
    {
        static long count1;
        static long count2;

        public static void Test1()
        {
            while (true)
            {
                count1 += 1;
            }
        }

        public static void Test2()
        {
            while (true)
            {
                count2 += 1;
            }
        }

        static void Main()
        {
            Thread t1 = new Thread(Test1);
            Thread t2 = new Thread(Test2);

            // Set thread priorities
            t1.Priority = ThreadPriority.Lowest;
            t2.Priority = ThreadPriority.Highest;

            // Start threads
            t1.Start();
            t2.Start();

            // Allow threads to run for 10 seconds
            Thread.Sleep(10000);

            // Output counts
            Console.WriteLine("Test 1 (Low Priority) Count: " + count1);
            Console.WriteLine("Test 2 (High Priority) Count: " + count2);
            Console.ReadLine();
        }
    }
}
