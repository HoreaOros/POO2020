namespace Bars
{
    internal class Frame
    {
        private HorzBar h1, h2;
        private VertBar v;

        public Frame(int width, int height)
        {
            h1 = new HorzBar(width);
            v = new VertBar(height);
            h2 = new HorzBar(width);

            
        }
    }
}