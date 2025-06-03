using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter any two numbers");
            try
            {
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                c = a / b;
                Console.WriteLine("The value of c is:" + c);
                    
            }
            catch(DivideByZeroException ze)
            {
                Console.WriteLine("Second number should not be Zero");

            }
            catch(FormatException fe)
            {
                Console.WriteLine("Enter only Integer number");
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            Console.ReadKey();
        }
    }
}
