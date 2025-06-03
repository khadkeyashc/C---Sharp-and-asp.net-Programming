using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, rev, temp, result;
            num = 55;
            result = 0;
            temp = num;
            while(num!=0)
            {
                rev = num % 10;
                result = result*10 + rev;
                num = num / 10;
            }
            num = temp;
            Console.WriteLine(result);
            if(num==result)
            {
                Console.WriteLine("It is Palindrome number");
            }
            else
            {
                Console.WriteLine("It is not palindrome");
            }
            Console.ReadKey();
        }
    }
}
