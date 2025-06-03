using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //To check Wheteher The Given number is palindrome or not
            int num, rev, temp,result;
            num = 121;
            result=0;
            temp = num;
            while(num!=0)
            {
                rev = num % 10;
                result = result * 10 + rev;
                num = num / 10;
               
            }
            Console.WriteLine(num);
            num = temp;
            Console.WriteLine(result);
            Console.WriteLine(num);
            if (num==result)
            {
                Console.WriteLine("It is palindrome ");
            }
            else
            {
                Console.WriteLine("It is not Palindrome");
            }
            Console.ReadKey();



        }
    }
}
