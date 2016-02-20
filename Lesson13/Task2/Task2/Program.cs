using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix;

            Console.SetWindowSize(80,40);

            for (int i = 0; i < 30; i++)
            {
                matrix=new Matrix(i*2);
                new Thread(matrix.Move).Start();
            }

            Console.ReadLine();
        }
    }
}
