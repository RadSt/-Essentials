using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность массива ");
            string str = Console.ReadLine();
            int ras=string.IsNullOrEmpty(str)?0:Convert.ToInt32(str);

            Random rand=new Random();
            MyList<int> list=new MyList<int>();

            for (int i = 0; i < ras; i++)
            {
                list.Add(rand.Next(100));
            }

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]+" ");
            }
            Console.WriteLine("Массив содержит {0} элемент", list.Count);
            Console.WriteLine("Введите значение для поиска в массиве");
            string index = Console.ReadLine();
            if (list.Contains(Convert.ToInt32(index)))
            {
                Console.WriteLine("Массив содержит элементов");
            }
            else
            {
                Console.WriteLine("Элемент в массиве отсутствует");
            }
            Console.ReadKey();

        }
    }
}
