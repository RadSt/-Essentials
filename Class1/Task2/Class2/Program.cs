using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите 1 сторону прямоугольника");
            var side1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите 2 сторону прямоугольника");
            var side2 = Convert.ToDouble(Console.ReadLine());
            Rectangle rectangle = new Rectangle(side1, side2);
            Console.WriteLine(String.Format("Площадь: {0} Пеиметр: {1}",rectangle.Area,rectangle.Perimiter));
            Console.ReadLine();
        }
    }
}
