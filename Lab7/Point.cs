namespace Lab7
{
    internal class Point
    {


        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }

        public static Point randomPoint()
        {
            int x = Util.RND.Next(1, 50);
            int y = Util.RND.Next(1, 50);

            return new Point(x, y);
        }
    }
}