using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    public class Shape
    {
        public virtual void shape()
        {
            Console.WriteLine("Drawing");
        }
    }
    public class Rectangle:Shape
    {
        public override void shape()
        {
            Console.WriteLine("Drawing A Rectangleggjyyhj");
        }
    }
    public class Circle:Shape
    {
        public override void shape()
        {
            Console.WriteLine("Drawing a Cricleuyyjuyj");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape s = new Shape();
            s.shape();
            s = new Rectangle();
            s.shape();
            s=new Circle();
            s.shape();

            Console.ReadKey();
        }
    }
}
