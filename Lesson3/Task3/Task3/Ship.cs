using System;

namespace Task3
{
    public class Ship:Vehicle
    {
        private int passangerCount;
        private string portOfRegistration;

        public int PassangerCount
        {
            get
            {
                return passangerCount;
            }
            set
            {
                if (value > 0)
                    passangerCount = value;
                else
                    Console.WriteLine("Число пассажиров должно быть больше нуля");
            }
        }

        public string PortOfRegistration
        {
            get
            {
                return portOfRegistration;
            }
            set
            {
                if (value != null)
                    portOfRegistration = value;
                else
                    Console.WriteLine("Не задан порт регистрации");
            }
        }

        public Ship(uint cost,uint speed, uint year, int x,int y)
            :base(cost,speed,year,x,y)
        {
            
        }

        public Ship(uint cost, uint speed, uint year)
            :base(cost,speed,year)
        {
            
        }
    }
}