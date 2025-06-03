using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp58
{
    public class Drawable
    {
        public virtual void draw()
        {
            Console.WriteLine("Drawing...");
        }
    }
    public class Rectangle : Drawable
    {
        public override void draw()
        {
            Console.WriteLine("Drawing Rectangle");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Drawable d = new Rectangle();
            d.draw();   
            Console.ReadKey();
        }
    }
}
