using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class MultiThreadDemo
    {
        public static void Test1()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine("Test 1 " + i);
            }
            Console.WriteLine("Test 1 Method Exit");
        }
        public static void Test2()
        {
            for(int i = 0;i <= 100;i++)
            {
                Console.WriteLine("Test 2 " + i);
                if (i==50)
                {
                    Console.WriteLine("Test 2 Method Stop");
                    Thread.Sleep(5000);
                    Console.WriteLine("Test 2 Method Stop");
                    
                }
                Console.WriteLine("Test 2 Method Exit");

            }
        }
        public static void Test3()
        {
            for(int i = 0;i <= 100;i++)
            {
                Console.WriteLine("Test 3 " + i);
            }
            Console.WriteLine("Test 3 Method Exit");
        }
        public static void Test4(int number, string message)
        {
            //Console.WriteLine("Test 4 Received: Number = , Message = ");
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine("Message " + number, "Number " + message);
            }
            Console.WriteLine("Test 4 Method Exit");
        }
        static void Main()
        {
            //Thread t = Thread.CurrentThread;
            //t.Name = "Main Thread";
            //Console.WriteLine("Current execution thread : " + Thread.CurrentThread.Name);
            //Console.ReadLine();


            Thread T1 = new Thread(Test1);
            Thread T2 = new Thread(Test2);
            Thread T3 = new Thread(Test3);
            Thread T4 = new Thread(() => Test4(20, "Hello from Test4"));
            T1.Start();
            T2.Start();
            T3.Start();
            T4.Start();    
            Console.WriteLine("Main Thread Exit");
            Console.ReadLine();
        }
    }
}
