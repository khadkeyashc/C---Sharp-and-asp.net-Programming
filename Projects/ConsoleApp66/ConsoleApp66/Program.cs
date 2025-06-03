using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp66
{
    public class Employee
    {
        int id;
        String name;
        float salary;
        public Employee(int i, String n,float s)
        {
            id = i;
            name = n;
            salary = s;
        }
        public void Dispaly()
        {
            Console.WriteLine("id is:"+id+"name is:"+name+"Salary is"+salary);

        }
        ~Employee()
        {
            Console.WriteLine("destructor invoked");
        }
}
   
    

    internal class Program
    {
        static void Main(string[] args)
        {
           Employee e=new Employee(5,"Yash",788774);
            Employee e1 = new Employee(7, "Milind", 89547);
            e.Dispaly();
            e1.Dispaly();




            Console.ReadLine();
        }
    }
}
