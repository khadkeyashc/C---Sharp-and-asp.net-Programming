using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp40
{
    public class Shape
    {
        public virtual void Shape1()
        {
            Console.WriteLine("Drawing");
        }
    }
    public class Rectangle:Shape
    {
        public override void Shape1()
        {
            Console.WriteLine("Drawing Rectangle");
        }
    }
    public class Circle : Shape
    {
        public override void Shape1()
        {
            Console.WriteLine("Drawing Circle");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape s=new Shape();
            s.Shape1();
            s=new Rectangle();
            s.Shape1 ();
            s=new Circle();
            s.Shape1 ();    
            Console.ReadKey();
        }
    }
}
