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
            Employee instance=new Employee("Ivanov","Ivan");
            instance.Post = "director";
            instance.Expirience = 2;
            instance.ShowSallary();
            Console.ReadKey();

        }
    }
}
