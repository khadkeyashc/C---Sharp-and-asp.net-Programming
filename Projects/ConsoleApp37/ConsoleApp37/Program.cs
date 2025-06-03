using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37
{
    public abstract class Bank
    {
        public abstract void withdraw();
    }
    public class YesBank : Bank
    {
        public override void withdraw()
        {
            Console.WriteLine("Withdrawing Cash From YesBank");
        }
    }
    public class noBank:Bank
    {
        public override void withdraw()
        {
            Console.WriteLine("WithDrawing cash from no Bank");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank b = new YesBank();
            b.withdraw();
            b=new noBank();
            b.withdraw();
            Console.ReadKey();
        }
    }
}
