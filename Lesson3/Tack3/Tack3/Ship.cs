namespace Tack3
{
    public class Ship:Vehicle
    {
        private int passangerQuantity;
        private string port;

        public Ship(int xLocation, int yLocation, int price, int speed, int year)
            :base(xLocation, yLocation, price, speed, year)
        {
           
        }

        public Ship(int price, int speed, int year)
            :base(price, speed, year)

        {
           
        }

        public int PassangerQuantity
        {
            get { return passangerQuantity; }
            set { passangerQuantity = value; }
        }

        public string Port
        {
            get { return port; }
            set { port = value; }
        }
    }
}