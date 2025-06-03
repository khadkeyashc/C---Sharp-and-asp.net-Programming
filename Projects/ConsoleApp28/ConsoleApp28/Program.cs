using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    public class a
    {
        public void DisplayParent()
        {
            Console.WriteLine("I am Parent");
        }
    }
    public class b :a
    {
        public void Displaychild()
        {
            Console.WriteLine("I am the child");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            b classb = new b();
            classb.DisplayParent();
            classb.Displaychild();
           
            Console.ReadKey();
        }
    }
}
