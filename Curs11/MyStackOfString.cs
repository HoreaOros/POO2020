namespace Curs11
{
    public class MyStackOfString
    {
        private string[] data;
        private int count = 0;
        public MyStackOfString()
        {
            data = new string[10];
        }

        public bool Empty
        {
            get
            {
                return count == 0;
            }
        }

        public void Push(string v)
        {
            if (count < data.Length)
            {
                data[count++] = v;
            }
            else
                throw new StackFullException("Stiva este plina");

        }

        public string Pop()
        {
            if (!this.Empty)
            {
                count--;
                return data[count];
            }
            else
                throw new StackEmptyException("Stiva este goala");
        }
        public string Peek()
        {
            if (!this.Empty)
            {
                return data[count - 1];
            }
            else
                throw new StackEmptyException("Stiva este goala");
        }
    }
}