using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность словаря");
            int razm = Convert.ToInt32(Console.ReadLine());

            MyDictionary<string,string> myDictionary=new MyDictionary<string, string>(razm);
            for (int i = 0; i < razm; i++)
            {
                myDictionary.Add(i,"table","Стол");
            }
            Console.WriteLine("Длина словаря "+myDictionary.Length);

            Console.WriteLine(myDictionary[1]);
            Console.ReadKey();


        }
    }
}
