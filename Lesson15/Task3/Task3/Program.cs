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
            var products = new Product[2];
            Exception ex = new Exception("Данный магазин не найден");
            int i = 0;

            try
            {
                for (int i = 0; i < products.Length; i++)
                {
                    Console.WriteLine("Введите название товара");
                    products[i].Name = Console.ReadLine();
                    Console.WriteLine("Введите имя магазина");
                    products[i].ShopName = Console.ReadLine();
                    Console.WriteLine("Введите цену");
                    products[i].Price = Convert.ToDecimal(Console.ReadLine());
                }

                var sortedProducts = products.OrderBy(s => s.ShopName).ToArray();

                Console.WriteLine("Введите название товара");
                string productShopName = Console.ReadLine();

                for ( i < sortedProducts.Length; i++)
                {
                    if (sortedProducts[i].ShopName == productShopName)
                    {
                        Console.WriteLine("В этом магазине есть {0} ", sortedProducts[i].Name);
                    }
                    else
                    {
                        throw ex;
                    }
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc);
            }

            Console.ReadLine();
        }
    }
}