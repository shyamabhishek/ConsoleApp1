using System;

namespace ConsoleApp1
{
    internal class GenericsDemo
    {
        //public bool CompareVal(object i, object j)
        //{ if(i.Equals(j)) return true; return false; }
        //public bool CompareVal(int i, int j)
        //{ if (i == j) return true; return false; }
        //public bool CompareVal(float i, float j)
        //{
        //    if (i == j) return true; return false;
        //}
        //public bool CompareVal(string i, string j)
        //{ if (i == j) return true; return false; }


        //Generic Collection

        public bool CompareVal<T>(T i, T j)
        {
            if (i.Equals(j)) return true; return false;
        }

        static void Main()
        {
            GenericsDemo gl = new GenericsDemo();
            bool res = gl.CompareVal<int>(10, 20);
            bool res1 = gl.CompareVal<float>(20.3f, 30.5f);
            bool res2 = gl.CompareVal<string>("abc", "abc");
            //bool res2 = gl.CompareVal("abc", "abc");
            Console.WriteLine(res);
            Console.WriteLine(res1);
            Console.WriteLine(res2);
            //Console.WriteLine(res2);
            Console.ReadLine();
        }
    }
}
