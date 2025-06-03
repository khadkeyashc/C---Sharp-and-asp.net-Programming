using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp56
{
    public class GrandParent
    {
        public void DisplayGrandParent()
        {
            Console.WriteLine("A and B are My GrandParents");
        }
    }
    public class Parent:GrandParent
    {
        public void DisplayParent()
        {
            Console.WriteLine("C and D are My Parents");
        }
    }
    public class Child : GrandParent
    {
        public void DisplayChild()
        {
            Console.WriteLine("I am the child E");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Parent p = new Parent();
            p .DisplayParent();
            p.DisplayGrandParent();
            Child c = new Child();
            c.DisplayChild();
            c.DisplayGrandParent();
            Console.ReadKey();
        }
    }
}
