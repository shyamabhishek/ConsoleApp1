using System;
using System.Diagnostics;
using System.Text;

namespace ConsoleApp1
{
    internal class StringandStringBuilderDemo
    {
        static void Main()
        {
            string str = "Hello";

            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 1; i <= 100000; i++)
            {
                str = str + 1;
            }
            sw.Stop();
            StringBuilder sb = new StringBuilder();
            Stopwatch sw2 = new Stopwatch();
            sw2.Start();
            for (int i = 1; i <= 100000; i++)
            {
                sb.Append(i);
            }
            sw2.Stop();
            Console.WriteLine("Time taken by String " + sw.ElapsedMilliseconds);
            Console.WriteLine("Time taken by Stringbuilder " + sw2.ElapsedMilliseconds);

            StringBuilder sb2 = new StringBuilder("StringBuilder : ");
            sb2.AppendLine("Hello ");
            sb2.AppendLine("World");

            Console.WriteLine(sb2);
            Console.ReadLine();

        }
    }
}
