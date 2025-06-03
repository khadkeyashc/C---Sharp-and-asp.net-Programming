using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp65
{
    internal class Program
    {
        public static int addition (int a, int b)
            {
            int total;
            total = a + b;
            return total;   

            }

    
    static void Main(string[] args)
    {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int y = addition(a, b);
            Console.WriteLine("The Sum is:" + y);
            Console.ReadLine();

        }
}
    }

