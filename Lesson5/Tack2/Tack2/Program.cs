using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Tack2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArray myArray=new MyArray(100);
            myArray.MinMaxValue();
            myArray.Average();
            myArray.Odd();

            Console.ReadKey();
        }
    }
}
