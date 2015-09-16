using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tack4
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice=new Invoice(12313,"OlegP","Phph");
            invoice.Article = "laptop";
            invoice.Quantity = 5;
            invoice.CostCalculation(false);
            Console.ReadKey();
        }
    }
}
