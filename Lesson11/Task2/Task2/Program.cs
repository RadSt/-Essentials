using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Наш парк машин");
            var park=new CarCollection<string>();

            park.AddCar("Жигули", new DateTime(1985, 12, 5));
            park.AddCar("Тойота", new DateTime(2000, 4, 7));
            park.AddCar("Форд", new DateTime(2005, 5, 3));
            park.AddCar("Мерседес", new DateTime(2003, 11, 3));
            Console.WriteLine(park.ToString());

            Console.WriteLine("В парке находится {0} машин",park.Length);

            Console.WriteLine("Введите номер интересующей вас машины.");
            string str=Console.ReadLine();
        
            if (!string.IsNullOrEmpty(str))
            {
                Console.WriteLine(park[Convert.ToInt32(str) - 1]);
            }

            Console.ReadKey();
        }
    }
}
