using System;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ThreadTaskDemo
    {
        public static void Test()
        {
            Console.WriteLine("Test1 method start");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
            Console.WriteLine("Press Any Key to close");
            Console.ReadLine();
        }
        //static void Main()
        //{
        //    Thread t1 = new Thread(Test);
        //    t1.IsBackground = true;
        //    t1.Start();
        //    Console.ReadLine() ;
        //}
        static async Task Main()
        {
            Task ts = new Task(Test);
            ts.Start();

            await ts;

            Console.WriteLine("Press any key to close");
            Console.ReadLine();
        }
    }
}
