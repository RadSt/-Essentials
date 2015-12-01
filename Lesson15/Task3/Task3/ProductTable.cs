using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Task3
{
    internal class ProductTable
    {
        public struct Product
        {
            private string name;
            private string shopName;
            private uint? price;


            public string Name
            {
                get { return name; }
            }

            public string ShopName
            {
                get { return shopName; }
            }

            public uint? Price
            {
                get { return price; }
            }

            public Product(string name, string shopName, uint? price)
            {
                this.name = name;
                this.shopName = shopName;
                this.price = price;
            }

            public string Show()
            {
                return String.Format("Продукт {0} в магазине {1} стоит {2}", name, shopName, price);
            }
        }

        private Product[] products;

        public ProductTable()
        {
            products = new Product[2];
            string name;
            string shopName;
            uint? price;

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine("Введите название товара");
                name = Console.ReadLine();
                Console.WriteLine("Введите имя магазина");
                shopName = Console.ReadLine();
                Console.WriteLine("Введите цену");
                try
                {
                    price = Convert.ToUInt32(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Попытка записи неверного значения");
                    Console.WriteLine(ex.Message);
                    price = null;
                }
                products[i] = new Product(name, shopName, price);
            }
            products = products.OrderBy(x => x.Name).ToArray<Product>();
        }

        public string this[int index]
        {
            get
            {
                try
                {
                    return products[Convert.ToInt32(index)].Show();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Попытка обращения за перделы массива");
                    Console.WriteLine(ex.Message);
                    return "";
                }
            }
        }

        public List<Product> this[string name]
        {
            get
            {
                var tempProductsList = new List<Product>();
                for (int i = 0; i < products.Length; i++)
                {
                    if (products[i].Name == name)
                    {
                        tempProductsList.Add(products[i]);
                    }
                }
                if (tempProductsList.Count>0)
                {
                    return tempProductsList;
                }
                Console.WriteLine("Данный продукт не найден");
                return tempProductsList;
            }
        }
    }
}