using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int marks;
            Console.WriteLine("Enter your Marks");
            marks=Convert.ToInt32(Console.ReadLine());
            switch(marks/10)
            {
                case 10:
                case 9:
                    Console.WriteLine("A Grade");
                    break;
                case 8:
                    Console.WriteLine("B Grade");
                    break;
                case 7: Console.WriteLine("c Grade");
                    break;
                case 6:
                    Console.WriteLine("D Grade");
                    break;
                default:
                    Console.WriteLine("Fail");
                    break;
            }
            Console.ReadKey();

            

        }
    }
}
