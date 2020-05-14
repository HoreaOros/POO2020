namespace Curs11
{
    public class MyStack<T> : IStack<T>
    {
        private T[] data;
        private int count = 0;
        public MyStack()
        {
            data = new T[10];
        }

        public bool Empty
        {
            get
            {
                return count == 0;
            }
        }

        public void Push(T v)
        {
            if (count < data.Length)
            {
                data[count++] = v;
            }
            else
                throw new StackFullException("Stiva este plina");

        }

        public T Pop()
        {
            if (!this.Empty)
            {
                count--;
                return data[count];
            }
            else
                throw new StackEmptyException("Stiva este goala");
        }
        public T Peek()
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
