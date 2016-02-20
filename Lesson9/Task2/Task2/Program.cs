using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        public delegate double MyDelegate(int a, int b);
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число 1");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число 2");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите знак ");
            string sign = Console.ReadLine();

            MyDelegate myDelegate=null;

            switch (sign)
            {
                case "+":
                    myDelegate = (a, b) => a + b;
                    break;
                case "-":
                    myDelegate = (a, b) => a - b;
                    break;
                case "*":
                    myDelegate = (a, b) => a*b;
                    break;
                case "/":
                    myDelegate = (a, b) =>
                    {
                        if (b > 0)
                        {
                            return a / b;
                        }
                        else
                        {
                            Console.WriteLine("На ноль делить НЕЛЬЗЯ!!!");
                            return 0;
                        }
                    };
                    break;
                default:
                    Console.WriteLine("Вы ввели неправильный знак");
                    break;

            }
            if (myDelegate !=null)
            Console.WriteLine("Результат {0}",myDelegate(num1,num2));

            Console.ReadKey();
        }
    }
}
