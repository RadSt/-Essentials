using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            House house=new House(new Street("Мира"),11);

            House clone = house.DeepClone();

            Console.WriteLine("Original: {0} , {1}",house.Street.Str,house.FlatNumber);
            Console.WriteLine("Clon: {0} , {1}",clone.Street.Str,clone.FlatNumber);
            Console.WriteLine(new string('-',50));


            clone.Street = new Street("Avto");
            clone.FlatNumber = 35;

            Console.WriteLine("Original: {0} , {1}",house.Street.Str,house.FlatNumber);
            Console.WriteLine("Clon: {0} , {1}",clone.Street.Str,clone.FlatNumber);
            Console.WriteLine(new string('-',50));


            Console.ReadKey();



        }
    }
}
