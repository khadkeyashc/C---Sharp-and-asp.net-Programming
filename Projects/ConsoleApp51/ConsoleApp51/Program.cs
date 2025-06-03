using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp51
{
    public class Employee
    {
        int id;
        String name;
        float salary;
        public Employee(int i, string n, float s)
        {
            id = i;
            name = n;
            salary = s;
        }
        public void Display()
        {
            Console.WriteLine("The Employee Id is:" +id);
            Console.WriteLine("The Employee Name is:" +name);
            Console.WriteLine("The Employee Salary is:" +salary);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee(1534, "Yash Khadke", 89000);
            e.Display();
            Console.ReadKey();
        }
    }
}
