using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            
            ProductTable productTable=new ProductTable();
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(productTable[i]);
            }
            

            Console.WriteLine("Введите имя товара для поиска");
            string name=Console.ReadLine();

            foreach (var elem in productTable[name])
            {
                Console.WriteLine(elem.Show());
            }

            Console.ReadLine();
        }
    }
}