namespace DP
{
    public class StarDecorator : TextDecorator
    {

        public StarDecorator(IText t): base(t)
        {
        }

        public override string GetValue()
        {
            return $"*** {base.GetValue()} ***";
        }
    }
}