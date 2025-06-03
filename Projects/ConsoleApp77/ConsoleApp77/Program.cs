using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp77
{
   public interface Shape
    {
        void draw();
    }
    public class Rectangle : Shape
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
          Shape s=new Rectangle();
            s.draw();


            Console.ReadKey();
        }
    }
}
