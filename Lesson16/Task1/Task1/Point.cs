using System.CodeDom;

namespace Task1
{
    public struct Point
    {
        private int x;
        private int y;
        private int z;

        public int X { get { return x; }}
        public int Y { get { return y; }}
        public int Z { get { return z; }}

        public Point(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static Point operator +(Point p1, Point p2)
        {
            return new Point(p1.x + p2.x, p1.y + p2.y, p1.z + p2.z);
        }
    }
}