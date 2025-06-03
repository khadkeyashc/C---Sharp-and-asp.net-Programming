using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;
            Console.WriteLine(a);
            Console.WriteLine(b);
            int c = a + b;
            Console.WriteLine(c);
            for(int i=0; i<10; i++) 
            {
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
                
            }
            Console.ReadKey();
        }
    }
}
