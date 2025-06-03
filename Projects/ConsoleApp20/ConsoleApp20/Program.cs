using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, rev, sum = 0;
           
            num=Convert.ToInt32(Console.ReadLine());
            int temp = num;
            while (num>0)
            {
                rev = num % 10;
                sum = sum + rev * rev * rev;
                num = num / 10;
            }
            Console.WriteLine(sum);
            if(temp==sum)
            {
                Console.WriteLine("It is amstrong ");

            }
            else
            {
                Console.WriteLine("it is not Amstrong ");
            }
            Console.ReadKey();



        }
    }
}
