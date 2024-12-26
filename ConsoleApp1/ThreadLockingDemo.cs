using System;
using System.Threading;

namespace ConsoleApp1
{
    internal class ThreadLockingDemo
    {
        public void Show()
        {
            try
            {
                lock (this)
                {
                    Console.Write("C sharp is an ");
                    Thread.Sleep(2000);
                    Console.WriteLine("Object Oriented Concept");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {

            }
        }
        static void Main()
        {

            ThreadLockingDemo obj = new ThreadLockingDemo();
            //obj.Show();
            //obj.Show();
            //obj.Show();
            Thread t1 = new Thread(obj.Show);
            Thread t2 = new Thread(obj.Show);
            Thread t3 = new Thread(obj.Show);
            t1.Start(); t2.Start(); t3.Start();
            Console.ReadLine();
        }
    }
}
