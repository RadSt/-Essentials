using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tack3
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee=new Employee("Bob","Moroz");
            employee.Experience = 1;
            employee.Post = "manager";
            employee.CountSalary();
            employee.ShowSalary();
            Console.ReadKey();
        }
    }
}
