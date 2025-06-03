using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {



    

    static void Main(string[] args)
    {
        int[][] arr = new int[2][];
        arr[0] = new int[3] { 23, 45, 67 };
        arr[1] = new int[2] { 34, 56 };

        //Travese the array
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr[i].Length; j++)
            {
                System.Console.WriteLine(arr[i][j] + " ");
            }
            System.Console.WriteLine();

        }


        Console.ReadKey();
    }

    }
}
