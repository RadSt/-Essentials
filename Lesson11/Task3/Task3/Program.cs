using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict=new Dictionary<string, string>();

            dict.Add("table", "стол");
            dict.Add("apple", "яблоко");
            dict.Add("sun", "солнце");
            dict.Add("pencil", "карандаш");
            dict.Add("cap", "чашка");
            dict.Add("tea", "чай");

            Console.WriteLine(dict.ToString());
            Console.WriteLine("В массиве {0} элементов",dict.Length);
            Console.WriteLine(new string('-',30));

            Console.WriteLine("Введите номер элемента");
            string num = Console.ReadLine();
            if (!string.IsNullOrEmpty(num))
            {
                Console.WriteLine("Элемент "+dict[Convert.ToInt32(num)-1]);
            }else
                Console.WriteLine("Нет эл-та под таким номером");

            Console.WriteLine("Введите значение элемента");
            string val = Console.ReadLine();

            if (!string.IsNullOrEmpty(val))
            {
                Console.WriteLine("Элемент "+dict[val]);
            }else
                Console.WriteLine("Данный элемент не найден");



            Console.ReadKey();


        }
    }
}
