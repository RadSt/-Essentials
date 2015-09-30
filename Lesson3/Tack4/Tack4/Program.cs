using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tack4
{
    class Program
    {
        static void Main(string[] args)
        {
            Redaktor redaktor=new Redaktor();
            Console.WriteLine("Введите ключь");
            redaktor.Key=Console.ReadLine();

            redaktor.ChooseLisense();
            redaktor.Open();
            redaktor.Edit();
            redaktor.Save();

            Console.ReadKey();


        }
    }
}
