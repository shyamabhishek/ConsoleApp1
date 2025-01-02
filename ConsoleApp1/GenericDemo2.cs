using System;

namespace ConsoleApp1
{
    internal class GenericDemo2<T>
    {
        public void Add(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 + d2);
        }
        public void Sub(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 - d2);
        }
        public void Mul(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 * d2);
        }
        public void Div(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 / d2);
        }

    }
    class TestGeneric
    {
        static void Main()
        {
            GenericDemo2<int> obj = new GenericDemo2<int>();
            obj.Add(1, 2);
            obj.Sub(1, 2);
            obj.Mul(1, 2);
            obj.Div(1, 2);
            Console.ReadLine();
        }
    }
}
