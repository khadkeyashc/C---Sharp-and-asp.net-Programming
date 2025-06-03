using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp54
{
    public class Employee
    {
        int id;
        String Name;
        float Salary;
        public Employee(int i, string n, float f)
        {
            id = i;
            Name = n;
            Salary = f;


        }
        public void Display()
        {
            Console.WriteLine("id" + id + "name is" + Name + "Salart is:" + Salary);
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
            Employee e1 = new Employee(154, "Yash", 4565);
            Employee e2 = new Employee(158, "Ptetr", 889875);
            e1.Display();
            e2.Display();

            Employee e3 = new Employee(176, "ash", 08755);
            e3.Display();
            Console.ReadKey();

        }
    }
}
