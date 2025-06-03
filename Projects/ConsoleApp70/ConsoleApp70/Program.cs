using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp70
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int marks = 120;
            if(marks<0 || marks>100)
            {
                Console.WriteLine("Invalid Marks");
            }    


            Console.ReadKey();
        }
    }
}
