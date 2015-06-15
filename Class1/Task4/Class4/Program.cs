using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class4
{
    class Program
    {
        private static void Main(string[] args)
        {
            Figure figure = new Figure(new Point("A", 1, 1), new Point("B", 2, 3), new Point("C", 3, 4));


            Console.Write("{0}, P = ", figure.Type);

            figure.PerimeterCalculator();

            // Delay.
            Console.ReadKey();
        }
    }
}
