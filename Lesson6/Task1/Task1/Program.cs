using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculator.Add(1,2));
            Console.WriteLine(Calculator.Multiply(2,3));
            Console.WriteLine(Calculator.Split(4,2));
            Console.WriteLine(Calculator.Substract(6,3));

            Console.ReadKey();
        }
    }
}
