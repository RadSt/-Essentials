using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Redactor redactor=new Redactor();
            redactor.ChooseDocument("letter.txt");
            redactor.Create();
            redactor.Open();
            redactor.Change();
            redactor.Save();
            Console.ReadKey();
        }
    }
}
