using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class SortedListUsingComparison
    {
        public static int CompareNames(Student s1, Student s2)
        {
            return s1.Name.CompareTo(s2.Name);
        }
        static void Main()
        {
            Student s1 = new Student { Id = 103, Name = "Shyam", Class = "10", Marks = 567.01f };
            Student s2 = new Student { Id = 106, Name = "Praveen", Class = "12", Marks = 255.09f };
            Student s3 = new Student { Id = 101, Name = "Nikhil", Class = "10", Marks = 678.07f };
            Student s4 = new Student { Id = 102, Name = "Nishant", Class = "10", Marks = 111.05f };

            List<Student> myList = new List<Student>() { s1, s2, s3, s4 };
            Comparison<Student> obj = new Comparison<Student>(CompareNames);
            //myList.Sort(obj);
            myList.Sort(obj);
            foreach (var item in myList)
            {
                Console.WriteLine(item.Id + " " + item.Name + " " + item.Class + " " + " " + item.Marks);
            }
            Console.ReadLine();

        }
        public int Compare(Student x, Student y)
        {
            if (x.Marks > y.Marks)
                return 1;
            else if (x.Marks < y.Marks)
                return -1;
            else
                return 0;
        }
    }
}
