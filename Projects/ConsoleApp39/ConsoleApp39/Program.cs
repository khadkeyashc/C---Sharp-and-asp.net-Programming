using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp39
{
    public class Parent
    {
        public void DisplayParent()
        {
            Console.WriteLine("A and B are My Parents");
        }

    }
    public class Child:Parent
        {
       public void           DisplayChild()
        {
            Console.WriteLine("I Am The Child C");
        }
        }
    internal class Program
    {
        static void Main(string[] args)
        {
            Child c = new Child();
            c.DisplayChild();
            c.DisplayParent();
            Console.ReadKey();
        }
    }
}
