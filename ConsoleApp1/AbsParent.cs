using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal abstract class AbsParent
    {
        public int I { get; set; }
        public string S {  get; set; }
        public bool B { get; set; }
        public void Add(int x, int y) //non abstract method
        {
            Console.WriteLine(x + y);
        }
        public void Sub(int x, int y)//non abstract method
        {
            Console.WriteLine(x - y);
        }
        public abstract void Mul(int x, int y); // abstract method

        public abstract void Div(int x, int y); //abstract method
    }
    class AbsChild : AbsParent
    {
        public override void Div(int x, int y)
        {
            Console.WriteLine(x / y);
        }

        public override void Mul(int x, int y)
        {
            Console.WriteLine(x * y);
        }
        static void Main ()
        {
            AbsChild obj = new AbsChild();
            AbsParent absParent = obj; //refference
            absParent.Add(1, 2);
            absParent.Sub(20, 10);
            absParent.Mul(20, 10);
            absParent.Div(20, 10);
            absParent.I = 10;
            absParent.S = "Testing";
            absParent.B = true;
            Console.WriteLine(absParent.I);
            Console.WriteLine(absParent.S);
            Console.WriteLine(absParent.B);
            Console.ReadLine ();
        }
    }
}
