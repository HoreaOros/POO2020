using System;

namespace DP
{
    public class Text : IText
    {
        private string value;
        public Text(string value)
        {
            this.value = value;
        }

        public string GetValue()
        {
            return value;
        }
    }
}