namespace Class2
{
    public class Rectangle
    {
        private readonly double side1;
        private readonly double side2;
        public double Area { get { return this.PerimeterCalculator(); } }
        public double Perimiter { get { return this.AreaCalculator(); } }

        public Rectangle(double side1,double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        double PerimeterCalculator()
        {
            return 2 * (side1 + side2);
        }
        double AreaCalculator()
        {
            return side1 * side2;
        }

    }
}