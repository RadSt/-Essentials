using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Redactor redactor=new Redactor();
            redactor.ChooseDocument("Hello.txt");
            redactor.Open();

            Console.ReadKey();
        }
    }
}
