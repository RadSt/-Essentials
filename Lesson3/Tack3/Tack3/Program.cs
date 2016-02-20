using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tack3
{
    class Program
    {
        static void Main(string[] args)
        {
            Ship ship =new Ship(123,300,1980) {PassangerQuantity = 25,Port = "London"};
            Console.WriteLine("Price: {0} Speed: {1} Year: {2} PassangerQuantity: {3} Port: {4}",ship.Price,ship.Speed,ship.Year,ship.PassangerQuantity,ship.Port);
            Console.ReadKey();
        }
    }
}
