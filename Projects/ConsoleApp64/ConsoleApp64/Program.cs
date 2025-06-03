using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp64
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Marks");
            int num=Convert.ToInt32(Console.ReadLine());
            switch(num/10)
            {
                case 10: Console.WriteLine("Grade AA");
                    break;
                case 9:
                    Console.WriteLine("Grade AA");
                    break;
                case 8: Console.WriteLine("Grade AB");
                    break;
                case 7:Console.WriteLine("Grade BB");
                    break;
                default:Console.WriteLine("Invalid Marks");
                    break;
            }
            
            Console.ReadKey();
        }
    }
}
