using System;
using System.CodeDom;

namespace Tack4
{
    public class Figure
    {
        private Point[] point;
        private string type;

        public string Type
        {
            get { return type; }
        }


        public Figure(Point point1, Point point2, Point point3)
        {
            point = new Point[3];
            point[1] = point1;
            point[2] = point2;
            point[3] = point3;
            type = "Triangle";

        }
        public Figure(Point point1,Point point2,Point point3,Point point4)
        {
            point = new Point[4];
            point[1] = point1;
            point[2] = point2;
            point[3] = point3;
            point[4] = point4;
            type = "Tetragon";

        }
        public Figure(Point point1, Point point2, Point point3, Point point4,Point point5)
        {
            point=new Point[5];
            point[1] = point1;
            point[2] = point2;
            point[3] = point3;
            point[4] = point4;
            point[5] = point5;
            type = "Pentagon";
        }

        double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow((B.Y - A.Y), 2) + Math.Pow((B.X - A.X), 2));
        }

        public void PerimeterCalculator()
        {
            double sum = 0;

            for (int i = 0; i < point.Length - 1; i++)
            {
                sum += LengthSide(point[i], point[i + 1]);
            }

            sum += LengthSide(point[point.Length - 1], point[0]);
            Console.Write(sum);
        }
    }
}