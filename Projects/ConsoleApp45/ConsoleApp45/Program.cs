using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp45
{
    public class Grandparents
    {
        public void DisplayGrandparents()
        {
            Console.WriteLine("A and B are My Grandparents");
        }
    }
    public class parent : Grandparents
    {
        public void DisplayParent()
        {
            Console.WriteLine("C and D are my parents");

        }
    }
        public class child:parent
        {
            public void DisplayChild()
            {
                Console.WriteLine("I am the Son E");
            }
        }



    internal class Program
    {
        static void Main(string[] args)
        {
            child c = new child();
            c.DisplayChild();
            c.DisplayParent();
            c.DisplayGrandparents();
            Console.ReadKey();
        }
    }
}
