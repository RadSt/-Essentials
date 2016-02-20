using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tack2
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter converter=new Converter(35,40,20);
            converter.ToEuro(10);
            converter.FromEuro(400);
            Console.ReadKey();
        }
    }
}
