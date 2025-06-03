using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp46
{
    internal class Employee
    {
        public Employee()
        {
            Console.WriteLine("Constructor Invoked");
        }
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            Employee e2 = new Employee();
            Console.ReadKey();
        }
    }
}
