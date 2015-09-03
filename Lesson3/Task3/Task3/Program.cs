using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Plane plane=new Plane(1000,300,1986,10,20){PlaneHight = 300,PlanePassCount = 25};
            Console.WriteLine("Цена самолета {0}, скорость {1}, год выпуска {2}, количество пасажиров {3}",plane.Cost,plane.Speed,plane.Year,
                plane.PlanePassCount);

            Ship ship = new Ship(1000, 300, 1986) { PassangerCount = 0, PortOfRegistration = "Glasgov" };
            Console.WriteLine("Цена самолета {0}, скорость {1}, год выпуска {2}, количество пасажиров {3}", ship.Cost, ship.Speed, ship.Year,
                ship.PassangerCount);

            Console.ReadKey();



        }
    }
}
