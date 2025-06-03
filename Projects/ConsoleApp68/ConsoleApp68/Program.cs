using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace ConsoleApp68
{
    public sealed class Animal
    {
        public void DisplayAnimal()
        {
            Console.WriteLine("Animals Are eating");
        }
    }
    public class Dog:Animal
    {
        public void DisplayDog()
        {
            Console.WriteLine("Dogs Are Eating");
        }
    }
   



    internal class Program
    {
        static void Main(String[] args)
        {
            Dog d = new Dog();
            d.DisplayDog();
            d.DisplayAnimal();


        Console.ReadKey();
        }
    }
}
