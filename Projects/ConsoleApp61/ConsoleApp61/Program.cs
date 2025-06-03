using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Net.Security;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp61
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number upto you Want to print Fibonachi series");
            int n=Convert.ToInt32(Console.ReadLine());
            int a = 0,b = 1,c;
            Console.WriteLine(a);
            Console.WriteLine(b);
            
            for(int i = 0; i < n; i++)
            {
                c = a + b;
                a = b;
                b = c;
                Console.WriteLine(c);
            }

                
            

            Console.ReadLine(); 
        }
    }
}
