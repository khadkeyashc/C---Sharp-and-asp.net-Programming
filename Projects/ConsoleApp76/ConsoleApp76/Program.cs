using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp76
{
    public class Employee
    {
       public Employee()
        {
            Console.WriteLine("Constructor invoked");
        }
        ~Employee()
        {
            Console.WriteLine("Destructor Invoked");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            Employee e2 = new Employee();
          
            
           



            Console.ReadKey();
        }
    }
}
