using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test4
{
    internal class Program
    {
        public int addi(int a, int b)
        {
            Console.WriteLine("Addition Is;");
            return (a + b);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            int addition = p.addi(4, 6);
            Console.WriteLine(addition);
            Console.ReadKey();
        }
    }
}
