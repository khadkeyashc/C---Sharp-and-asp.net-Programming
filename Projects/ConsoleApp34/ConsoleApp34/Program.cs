using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a, b, c;
                Console.WriteLine("Enter Two Numbers");
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                c = a / b;
                Console.WriteLine("The Value of c is:" + c);
            }
            catch (DivideByZeroException ze)
            {
                Console.WriteLine("Second number should not be Zero");
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Enter only integer number");

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.ReadKey();
        }
    }
}
