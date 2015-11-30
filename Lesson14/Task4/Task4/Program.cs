using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            var collection = new MyListCollection<string>();

            collection.Add("Привет");
            collection.Add("Пока");
            collection.Add("Смотри");
            collection.Add("На");
            collection.Add("Меня");
            collection.Add("Внимательно");

            foreach (var elem in collection)
            {
                Console.WriteLine(elem);
            }

            Console.ReadKey();
        }
    }
}
