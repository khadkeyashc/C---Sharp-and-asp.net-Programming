using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp60
{
    public sealed class Animal
    {
        public void Dispalya()
        {
            Console.WriteLine("Animals are Eating");
        }
    }
    public class Dog:Animal
    {
        public void Displayd()
        {
            Console.WriteLine("Dogs Are Barking");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog d = new Dog();
            d.Displaya();
            d.Displayd();
        }
    }
}
