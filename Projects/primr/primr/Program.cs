using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, k, a;
            a = Convert.ToInt32(Console.ReadLine());
            k = 0;
            for(i=1;i<=a;i++)
            {
                if (a % i == 0)
                {
                    k++;
                }
                Console.WriteLine(k);
            }

            if(k==2)
            {
                Console.WriteLine("it is prime Number");
            }
            else
            {
                Console.WriteLine("It is not prime");

            }
            Console.ReadKey();  
        }
    }
}
