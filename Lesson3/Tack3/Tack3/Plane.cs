namespace Tack3
{
    public class Plane:Vehicle
    {
        private int height;
        private int passangerQuantity;

        public Plane(int xLocation, int yLocation, int price, int speed, int year, int height, int passangerQuantity)
            :base(xLocation, yLocation, price, speed, year)
        {
            this.height = height;
            this.passangerQuantity = passangerQuantity;
        }

        public Plane(int price, int speed, int year, int height, int passangerQuantity)
            :base(price, speed, year)
        {
            this.height = height;
            this.passangerQuantity = passangerQuantity;
        }

        public int Height { get { return height; } }
        public int PassangerQuantity { get { return passangerQuantity; } }
    }
}