namespace Tack4
{
    public class Point
    {
        private int x;
        private int y;
        private string name;
        public Point(string name,int x,int y)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }
        public int X { get; }
        public int Y { get; }
        public string Name { get; }
    }
}