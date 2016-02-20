using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tack1
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address=new Address ();
            address.Apartment = 1313;
            address.City = "Kazan";
            address.Country = "Russia";
            address.House = "34";
            address.Index = 231;
            address.Street = "Lenin st.";

            Console.WriteLine("Apartment: {0}, City: {1}, Country: {2}, House: {3}, Index: {4}, Street: {5} ",
                address.Apartment,address.City,address.Country,address.House,address.Index,address.Street);
            Console.ReadKey();
        }
    }
}
