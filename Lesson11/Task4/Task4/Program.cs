using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList=new ArrayList();

            arrayList.Add("one");
            arrayList.Add("two");
            arrayList.Add("free");
            arrayList.Add("four");
            arrayList.Add("five");

            Console.WriteLine(arrayList.ToString());
            Console.WriteLine("В массиве {0} элементов",arrayList.Count);
            Console.WriteLine(new string('-',40));

            //Console.WriteLine("Введите номер элемента");
            //string num = Console.ReadLine();
            //if (!string.IsNullOrEmpty(num))
            //{
            //    Console.WriteLine(arrayList[Convert.ToInt32(num)-1]);
            //}else
            //    Console.WriteLine("Вы ввели пустое значение");
            //Console.WriteLine(new string('-', 40));

            Console.WriteLine("Введите значение элемента");
            string val = Console.ReadLine();
            if (arrayList.Contains(val))
            {
                Console.WriteLine("Элемент содержится в масиве");
            }else
                Console.WriteLine("Элемент отсутсвует");

            Console.ReadKey();
        }
    }
}
