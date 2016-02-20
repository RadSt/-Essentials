using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix;

            Console.SetWindowSize(80, 41);

            for (int i = 0; i < 26; i++)
            {
                matrix = new Matrix(i * 3,true);
                new Thread(matrix.Move).Start();
            }

            Console.ReadLine();
        }
    }
}
