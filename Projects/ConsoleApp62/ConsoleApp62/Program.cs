using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp62
{
    internal class Program
    {
        public static int addition(int a, int b)
        {
            int total;
            total = a + b;
            return total;

        }
        static void Main(string[] args)
        {
           
            Console.WriteLine("The Sum is:");
            int y=addition(12, 15);
            Console.WriteLine(y);
            Console.ReadKey();

        }
    }
}
