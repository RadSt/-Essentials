using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter(54,60,10);
            converter.RubToEuro(1000);
            converter.EuroToRub(100);
            converter.RubToUsd(1000);
            converter.UsdToRub(100);
            converter.RubToGrivna(100);
            converter.GrivnaToRub(1000);
            Console.ReadLine();
        }
    }
}
