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
            Invoice instance=new Invoice(1,"Ivanov Ivan","internet Shop");
            instance.Article = "Ананас";
            instance.Quantity = 2;
            instance.CountCost(true);
            instance.CountCost(false);
            Console.ReadKey();
        }
    }
}
