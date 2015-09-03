using System;

namespace Task3
{
    public class Plane:Vehicle
    {
        private int planeHight;
        private int planePassCount;

        public int PlaneHight
        {
            get { return planeHight; }
            set
            {
                if (value > 0)
                    planeHight = value;
                else
                    Console.WriteLine("Длинна не может быть меньше нуля.");
            }
        }

        public int PlanePassCount
        {
            get
            {
                return planePassCount;
            }
            set
            {
                if (value > 0)
                    planePassCount = value;
                else
                    Console.WriteLine("Число пассажиров не может быть меньше нуля.");
            }
        }

        public Plane(uint cost, uint speed, uint year, int x, int y)
            :base(cost,speed,year,x,y)
        {
            
        }

        public Plane(uint cost, uint speed, uint year)
            :base(cost,speed,year)
        {
            
        }
    }
}