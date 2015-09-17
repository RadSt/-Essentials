namespace Tack3
{
    public class Vehicle
    {
        private int xLocation;
        private int yLocation;
        private int price;
        private int speed;
        private int year;
        public Vehicle(int xLocation, int yLocation, int price, int speed, int year)
        {
            this.xLocation = xLocation;
            this.yLocation = yLocation;
            this.price = price;
            this.speed = speed;
            this.year = year;
        }

        public Vehicle(int price, int speed, int year)
            :this(0,0,price,speed,year)
        {
            
        }
        public int XLocation { get { return xLocation; } }
        public int YLocation { get { return yLocation; } }
        public int Price { get { return price; } }
        public int Speed { get { return speed; } }
        public int Year { get { return year; } }
    }
}