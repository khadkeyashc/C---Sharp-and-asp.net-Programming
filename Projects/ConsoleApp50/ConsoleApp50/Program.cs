using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp50
{
    public class test
    {
        public test()
        {
            Console.WriteLine("Default Constructor Invoked");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            test t = new test();
            Console.ReadKey();
        }
        
    }
}
