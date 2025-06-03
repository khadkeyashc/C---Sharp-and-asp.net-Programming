using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp74
{
     public interface shape
    {
        void draw();
    }
    public class rectangle : shape
    {
        public void draw()
        {
            Console.WriteLine("Drawing Shape");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            shape p=new rectangle();
            p.draw();
            Console.ReadKey();
        }
    }
}
