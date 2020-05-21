namespace Curs11
{
    public interface IStack<T>
    {
        bool Empty { get; }

        T Peek();
        T Pop();
        void Push(T v);
    }
}