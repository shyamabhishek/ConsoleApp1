using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class CommonFigure
    {
        public double width, height, radius;
        public const float Pi = 3.14f;
        public abstract double GetArea();
    }
    public class Rectangle : CommonFigure 
    {
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public override double GetArea()
        {
            return width * height;
        }
    }
    public class Circle : CommonFigure
    {
        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double GetArea()
        {
           return Pi * radius*radius;
        }
    }
    public class Cone : CommonFigure
    {
        public Cone(double radius, double height)
        {
            this.radius = radius;
            this.height = height;
        }

        public override double GetArea()
        {
            return Pi * radius * radius + Pi * radius* height ;
        }
    }
    public class Triangle : CommonFigure
    {
        public Triangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public override double GetArea()
        {
            return 0.5 *width * height;
        }
    }
    public class TestClass
    {
        static void Main()
        {
            Rectangle rt = new Rectangle(30.33, 23.44);
            Console.WriteLine("Area of Rectangle" + rt.GetArea());
            Circle cs = new Circle(5.7);
            Console.WriteLine("Area of Circle" + cs.GetArea());
            Triangle tr = new Triangle(7.8, 8.1);
            Console.WriteLine("Area of Triangle" + tr.GetArea());
            Cone cn = new Cone(7.3, 9.4);
            Console.WriteLine("Area of Cone" + cn.GetArea());
            Console.ReadLine();
        }
    }
}
