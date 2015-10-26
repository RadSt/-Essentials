using System;

namespace Task3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во часов");

            var hours = Convert.ToInt32(Console.ReadLine());

            var accauntant = new Accauntant();

            if (accauntant.AskForBonus(Workers.Worker, hours))
            {
                Console.WriteLine("Нужно дать премию");
            }
            else
            {
                Console.WriteLine("Обойдется");
            }

            Console.ReadKey();
        }
    }
}