using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp71
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[2][];
            arr[0] = new int[3] {10,20,30};
            arr[1] = new int[2] {11,22 };
            for(int i=0;i<=arr.Length;i++)
            {
                for(int j = 0; j <= arr[i].Length;j++)
                {
                    Console.WriteLine(arr[i][j] + "");
                }
                Console.WriteLine(" ");
            }

            Console.ReadKey();
        }
    }
}
