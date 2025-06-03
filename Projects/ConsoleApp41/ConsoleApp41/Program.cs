using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp41
{
    //Sealed class
    public  class Animal
    {
        public  void DisplayAnimal()
        {
            Console.WriteLine("Eating");
        }
    }
    public class Dog : Animal
    {
        public void Dogs()
        {
            Console.WriteLine("Dog Eating");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog d = new Dog();
            d.Dogs();
            d.DisplayAnimal();
        }
    }
}
