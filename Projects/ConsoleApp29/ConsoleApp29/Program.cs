using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    public class parent
    {
        public void displayParent()
        {
            Console.WriteLine("A and B are my parents");
        }
    }
    public class childc:parent
    {
        public void Childc()
        { Console.WriteLine("I am The Child C "); }
    }
    public class childd:parent
    {
        public  void ChildD()
        {
            Console.WriteLine("I am the child D");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
          
            Console.ReadKey();
            childc c = new childc();
            childd d=new childd();
            c.Childc();
            c.displayParent();
            d.ChildD();
            d.displayParent();
            Console.ReadKey();
        }
    }
}
