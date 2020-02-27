namespace Bars
{
    internal class VertBar
    {
        private int height;

        public VertBar(int v)
        {
            this.height = v;
            for (int i = 0; i < height; i++)
            {
                System.Console.WriteLine("|");
            }
        }
    }
}