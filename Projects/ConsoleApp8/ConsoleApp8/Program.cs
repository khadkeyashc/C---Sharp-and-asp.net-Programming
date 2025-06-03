using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your marks");
            int num = Convert.ToInt32(Console.ReadLine());
            if(num<0&&num>100)
            {
                Console.WriteLine("Invalid Marks"); 
            }
            else if(num>0&&num<=50)
            {
                Console.WriteLine("fAIL");
            }
            else if(num>=50&&num<=60)
            {
                Console.WriteLine("CC Grade");
            }
            else if(num>60&&num<=70)
                {
                Console.WriteLine("BC Grade");

            }
            else if(num>70&&num<=80)
            {
                Console.WriteLine("BB Grade");
            }
            else if(num>80&&num<=90)
            {
                Console.WriteLine("AB Grade");
            }
            else if(num>90&&num<=100)
            {
                Console.WriteLine("AA Grade");
            }
            Console.ReadKey();
        }
    }
}
