using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    public  class Animal
    {
        public void eat()
        {
            Console.WriteLine("eating");
        }
    }
    public class Dog:Animal
    {
        public void dog()
        {
            Console.WriteLine("Dog Eating");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
          
            Dog g= new Dog();
            g.eat();
            g.dog();
            Console.ReadKey();
        }
    }
}
