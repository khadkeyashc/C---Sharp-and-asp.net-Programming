using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Nested While loop
            int i = 1;
            while (i <=3)
            {
                int j = 1;
                while (j<=3) 
                {
                    Console.WriteLine(i+" " +j);
                    j++;
                }
                i++;
            }
            Console.ReadKey();
        }
    }
}

