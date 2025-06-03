using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Constructor
namespace ConsoleApp53
{
    public class Employee
    {
        public Employee()
        {
            Console.WriteLine("Default Constructor invoked");
        }
    }
    internal class Program
    {
       
        static void Main(string[] args)
        { 
         Employee e = new Employee();
            Console.ReadKey();
        }
    }
}
