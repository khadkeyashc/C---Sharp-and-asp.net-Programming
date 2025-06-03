using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp44
{
    public abstract class Bank
    {
        public abstract void Bank1();
        

    }
    public class YesBank:Bank
    {
        public override void Bank1()
        {
            Console.WriteLine("WithDrawing cash from Yes Bank;");
        }
    }
    public class NoBank:Bank
    {
        public override void Bank1()
        {
            Console.WriteLine("WithDrawing cash From NoBank");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            YesBank s = new YesBank();
            s.Bank1();
            NoBank n=new NoBank();
            n.Bank1();
            Console.ReadKey();

        }
    }
}
