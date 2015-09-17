namespace Tack3
{
    public class Car:Vehicle
    {
        public Car(int xLocation, int yLocation, int price, int speed, int year)
            : base(xLocation, yLocation, price, speed, year)
        {
            
        }

        public Car(int price, int speed, int year)
            : base(price, speed, year)
        {
            
        }

    }
}