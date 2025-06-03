using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            switch(num)
            {
                case 10:Console.WriteLine("It IS 10");
                    break;
                case 20:Console.WriteLine("It is 20");
                    break;
                case 30:Console.WriteLine("It is 30");
                    break;
                default:Console.WriteLine("It Is Not Between 10,20,30");
                    break;
            }







            Console.ReadKey();
        }
    }
}
