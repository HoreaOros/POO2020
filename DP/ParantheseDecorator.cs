namespace DP
{
    public class ParantheseDecorator : TextDecorator
    {

        public ParantheseDecorator(IText t): base(t)
        {
        }

        public override string GetValue()
        {
            return $"( {base.GetValue()} )";
        }
    }
}