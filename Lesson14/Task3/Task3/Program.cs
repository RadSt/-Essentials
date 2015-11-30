using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary=new MyDictionary<string, string>();

            dictionary.Add("Яблоко","Apple");
            dictionary.Add("Молоко", "Milk");
            dictionary.Add("Пиво", "Beer");
            dictionary.Add("Зелень", "Gross");
            dictionary.Add("Апельсин", "Orange");

            foreach (var elem in dictionary)
            {
                Console.WriteLine(elem);
            }

            Console.ReadLine();
        }
    }
}
