using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp72
{
    internal class Program
    {
       public int addi(int x,int y)
        {
            Console.WriteLine("Addition is:");
            return (x + y);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            int c = p.addi(50, 70);
            Console.WriteLine(c);
           
            
            Console.ReadKey();
        }
    }
}
