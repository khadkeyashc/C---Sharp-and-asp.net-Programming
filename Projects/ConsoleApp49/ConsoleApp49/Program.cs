using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp49
{
    public class Employee
    {
        int id;
        String Name;
        float salary;
        public Employee(int i, string n, float s)
        {
            id = i;
            Name = n;
            salary = s;
        }
        public void Display()
        {
            Console.WriteLine(id + " " + Name + " " + salary);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee t = new Employee(4235, "y",800000);
            t.Display();
            Console.ReadKey();
          
        }
    }
}
