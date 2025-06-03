using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp73
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 20;
                int b = ioj, c;
                c = a / b;
                Console.WriteLine(c);
            }
            catch (DivideByZeroException ze)
            {
                Console.WriteLine("Second number should not be Zero");

            }
            catch (FormatException fe)
            {
                Console.WriteLine("Enter only integer ");


            }
            catch (Exception e)
            {
                Console.WriteLine(e);

            }
            Console.ReadKey();
        }
    }
}
