namespace Tack2
{
    public class Rectangle
    {
        private double side1;
        private double side2;

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
           
            PerimetrCalculator();
        }
        public double Area { get { return this.AreaCalculator(); } }
        public double Perimeter { get { return this.PerimetrCalculator(); } }
        public double AreaCalculator()
        {
            return side1*side2;
        }

        public double PerimetrCalculator()
        {
            return side1 + side2;
        }
    }
}