using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Point(1, 2, 3);
            var p2 = new Point(4, 5, 6);

            var p3 = p1 + p2;

            Console.WriteLine("X {0} Y {1} Z {2}",p3.X,p3.Y,p3.Z);

            Console.ReadLine();
        }
    }
}
