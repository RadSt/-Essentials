using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1
{
    class Program
    {
        static void Main(string[] args)
        {
            Adress adress=new Adress()
            {
                Index="1234567",Country="Russia",City ="Chelny",
                Street = "Avtozavodskiy",House = "26",Apartment = "474"
            };

            Console.WriteLine("Index: {0},Country: {1},City: {2},Street: {3},House: {4},Apartment: {5}", 
                adress.Index, adress.Country, adress.City, adress.Street, adress.House, adress.Apartment);
            Console.ReadKey();
        }
    }
}
