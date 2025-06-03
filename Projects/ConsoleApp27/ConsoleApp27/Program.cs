using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter any two Number");

            try
            {
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                c = a / b;

                Console.WriteLine("C Value=" + c);
            }
            catch (DivideByZeroException ze)
            {
                Console.WriteLine("Second Number Should Not Be Zero");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Enter Only Integer Numbers");
            }
            Console.ReadKey();
        }

    }
}

