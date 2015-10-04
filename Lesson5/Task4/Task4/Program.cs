using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Store store = new Store();
            Console.WriteLine(store[1]);
            Console.WriteLine(store["Лапша"]);
            Console.WriteLine(store["Мясо"]);

            Console.ReadKey();
        }
    }
}
