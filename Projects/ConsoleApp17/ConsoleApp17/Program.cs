using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, fact;
            num = Convert.ToInt32(Console.ReadLine());
            fact = 1;
            for(int i=1;i<=num;i++)
            {
                fact = fact * i;
            }
            Console.WriteLine(fact);
            Console.ReadKey();

        }
    }
}
