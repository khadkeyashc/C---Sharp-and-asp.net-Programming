using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp59
{
    public abstract class  Bank
    {
        public abstract void Bank1();
    }
    public class YesBank:Bank
    {
        public override void Bank1()
        {
            Console.WriteLine("Withdrawing Cash From YesBank");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank b = new YesBank();
            b.Bank1();
            Console.ReadKey();
        }
    }
}
