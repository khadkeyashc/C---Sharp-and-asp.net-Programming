using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number To Check It Is even Number Or Not");
            int num = Convert.ToInt32(Console.ReadLine());
            if(num%2==0)
            {
                Console.WriteLine("It Is An Even Number");
            }
            else
            {
                Console.WriteLine("It Is An Odd Number");
            }
            Console.ReadKey();
        }
    }
}
