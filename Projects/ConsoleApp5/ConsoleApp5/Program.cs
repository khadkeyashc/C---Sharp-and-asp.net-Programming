using System;

namespace ConsoleApp5
{
    internal class Program
    {
        public int addi(int a, int b)
        {
            System.Console.WriteLine("ADDition is");
            return (a + b);
        
        }
       
        static void Main(string[] args)
        {
            Program p = new Program();
            int addit = p.addi(7, 3);
            System.Console.WriteLine(addit);
            System.Console.ReadKey();
           
            
        }
    }
}
