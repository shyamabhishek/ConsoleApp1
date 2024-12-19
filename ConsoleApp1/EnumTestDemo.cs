using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public enum Days : byte
    {
        Monday = 1,
        Tuesday = 4,
        Wednesday = 6,
        Thursday = 10,
        Friday = 12
    }

    internal class EnumTestDemo
    {
        public static Days MeetingDate { get; set; } = Days.Monday;
        static void Main()
        {
            //Console.BackgroundColor = ConsoleColor.Red;
            //Console.WriteLine("Welcome to Dotnet");
            //Console.ReadLine();
            //Days d = Days.Monday;
            //Days d = 0;
            //Console.WriteLine(d);
            //foreach(byte i in Enum.GetValues(typeof(Days)))
            //{
            //    Console.WriteLine(i +":" +(Days)i);
            //}
            Console.WriteLine(MeetingDate); //static block can always directly called into static
            MeetingDate = Days.Wednesday; //reschdule meeting on wednesday instead of thursday
            Console.ReadLine();
        }
    }
}
