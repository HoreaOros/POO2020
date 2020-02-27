namespace Bars
{
    internal class Ladder
    {
        Frame f1, f2;
        VertBar v;

        public Ladder(int width, int height)
        {
            f1 = new Frame(width, height);
            v = new VertBar(height);
            f2 = new Frame(width, height);
        }
    }
}