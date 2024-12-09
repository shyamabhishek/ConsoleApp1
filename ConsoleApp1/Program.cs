using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        int i;
        string s;
        bool b;
        //constructor
        public Program() //default constructor
        {
            i = 10;
            s = "test constructor";
            b = true;
        }
        public Program(int val, string sval) //parameter constructor
        {
            Console.WriteLine("value of" + "" + sval + val);
        }
        public Program(string val, int sval)
        {
            Console.WriteLine("value of"  + val+ " " + sval);
        }
        public void Test()
        {
            Console.WriteLine("test method");
            Console.WriteLine(i);
            Console.WriteLine(s);
            Console.WriteLine(b);
        
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            Program obj1 = new Program(12, "sar");
            Program obj2= new Program(13, "sae");
            obj .Test();
            Console.ReadLine();
        }
    }
}
