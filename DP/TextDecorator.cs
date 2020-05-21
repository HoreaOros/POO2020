namespace DP
{
    public abstract class TextDecorator : IText
    {
        private readonly IText t;

        public TextDecorator(IText t)
        {
            this.t = t;
        }

        public virtual string GetValue()
        {
            return t.GetValue();
        }
    }
}