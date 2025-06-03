using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp52
{
    public interface drawable
    {
        void draw();
    }
    public class Rectangle:drawable
    {
        public void draw()
        {
            Console.WriteLine("Drawing Rectangle");
        }
    }
    public class Circlr : drawable
    {
        public void draw()
        {
            Console.WriteLine("Drawing circle");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            drawable d = new Rectangle();
            d.draw();
            d=new Circlr();
            d.draw();
            Console.ReadKey();
        }
    }
}
