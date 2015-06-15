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
            DerivedColour instanceDerived = new DerivedColour(ConsoleColor.Blue);
            instanceDerived.Print("Hello");
            DerivedColour instanceDerived2 = new DerivedColour(ConsoleColor.Yellow);
            instanceDerived2.Print("Hello");
            DerivedColour instanceDerived3 = new DerivedColour(ConsoleColor.Green);
            instanceDerived3.Print("Hello");
            Console.ReadKey();
        }
    }
}
