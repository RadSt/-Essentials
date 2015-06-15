using System.Collections.Specialized;

namespace Class4
{
    public class Point
    {
        private readonly string name;
        private readonly int x;
        private readonly int y;

        public string Name{ get { return name; }}
        public int X { get { return x; } }
        public int Y { get { return y; } }

        public Point(string name,int x,int y)
        {
            this.name = name;
            this.x = x;
            this.y = y;
        }

    }
}