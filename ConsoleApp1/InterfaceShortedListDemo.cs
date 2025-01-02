using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public double Marks { get; set; }

    }
    internal class InterfaceShortedListDemo : IComparer<Student>
    {
        static void Main()
        {
            Student s1 = new Student { Id = 103, Name = "Shyam", Class = "10", Marks = 567.01f };
            Student s2 = new Student { Id = 106, Name = "Praveen", Class = "12", Marks = 255.09f };
            Student s3 = new Student { Id = 101, Name = "Nikhil", Class = "10", Marks = 678.07f };
            Student s4 = new Student { Id = 102, Name = "Nishant", Class = "10", Marks = 111.05f };

            List<Student> myList = new List<Student>() { s1, s2, s3, s4};
            InterfaceShortedListDemo obj = new InterfaceShortedListDemo();


            //List<int> list = new List<int>();
            //list.Add(1);
            //list.Add(3);
            //list.Add(5);
            //list.Add(4);
            //list.Add(2);



            //myList.Sort(obj);
            myList.Sort(1, 2, obj);
            foreach (var item in myList)
            {
                Console.WriteLine(item.Id + " " + item.Name + " " + item.Class + " " + item.Marks);
            }
            Console.ReadLine();
        }

        public int Compare(Student x, Student y)
        {
            if(x.Id > y.Id) 
                return 1;
            else if(x.Id < y.Id)
                return -1;
            else
                return 0;
        }
    }
}
