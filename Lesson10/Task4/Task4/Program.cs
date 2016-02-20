using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во эл-тов массива");
            int n = Convert.ToInt32(Console.ReadLine());
            MyList<string> list=new MyList<string>(n);
            for (int i = 0; i <list.Lenght; i++)
            {
                list.Add(i,"Hello");
            }

            var newlist=ExtensionMyList.GetArray(list);

            for (int i = 0; i < newlist.Length; i++)
            {
                Console.WriteLine(newlist[i]+" ");
            }

            Console.ReadKey();
        }
    }
}
