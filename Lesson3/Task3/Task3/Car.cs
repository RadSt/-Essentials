namespace Task3
{
    public class Car:Vehicle
    {
        public Car(uint cost, uint speed, uint year, int x, int y)
            :base(cost,speed,year,x,y)
        {
            
        }

        public Car(uint cost, uint speed, uint year)
            :base(cost,speed,year)
        {
            
        }
    }
}