using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public delegate int MyDelegate(int a,int b,int c);
    class Program
    {
        static void Main(string[] args)
        {

            MyDelegate myDelegate;
            myDelegate =(a, b, c) => ((a + b + c) / 3);
            Console.WriteLine("Результат среднего арифмитического {0}", myDelegate(1, 2, 3));

            Console.ReadKey();
        }
    }
}
