using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int marks;
            marks = Convert.ToInt32(Console.ReadLine());
            if(marks<0&&marks>100)
            {
                Console.WriteLine("Invalid Marks");
            }
        }
    }
}
