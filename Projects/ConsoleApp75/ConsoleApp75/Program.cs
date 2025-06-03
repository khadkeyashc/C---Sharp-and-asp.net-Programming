using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp75
{
    public class Animal
    {
        public virtual void Movement()
        {

        }
        public virtual void Sleeping()
        {

        }
    }
    public class Dog:Animal
    {
        public override void Movement()
        {
            Console.WriteLine("Barking");
        }
        public sealed override void Sleeping()
        {
            Console.WriteLine("Yes");
        }
    }
    public class Cat : Dog
    {
        public override void Movement()
        {
            Console.WriteLine("Eating");
        }
        public override void Sleeping()
        {
            Console.WriteLine("No");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Dog();
            a.Movement();
            a.Sleeping();
            a=new Cat();
            a.Movement();
            a.Sleeping();
            Console.ReadLine();
        }
    }
}
