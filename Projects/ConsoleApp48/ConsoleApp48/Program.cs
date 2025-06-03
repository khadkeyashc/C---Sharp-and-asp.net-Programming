using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48
{
    public interface drawable
    {
        void draw();
    }
    public class Rectangle:drawable
    {
        public void draw()
        {
            Console.WriteLine("Drawing Circle");
        }

    }
    public class circle : drawable
    {
        public void draw()
        {
            Console.WriteLine("Drawing Rectangle");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            drawable d = new Rectangle();
            d.draw();
            d= new circle();
            d.draw();
            Console.ReadKey();        }
    }
}
