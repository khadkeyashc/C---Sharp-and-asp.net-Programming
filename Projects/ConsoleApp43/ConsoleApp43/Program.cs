using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp43
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter a number");
            try
            {
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                c = a / b;
                Console.WriteLine("The Value is:" + c);

            }
            catch(DivideByZeroException ze)
            {
                Console.WriteLine("Second Number Should not Be Zero");
            }
            catch(ArithmeticException ae)
            {
                Console.WriteLine("Enter Only Integer Numbwe");
            }
            catch(Exception e)
            {
                Console.WriteLine(e);    
            }
            Console.ReadKey();
        }
    }
}
