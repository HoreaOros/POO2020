using System.Xml;

namespace Curs11
{
    /// <summary>
    /// Stack implementat cu o lista inlantuita
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class SuperStack<T> : IStack<T>
    {
        private class Node
        {
            T item;
            Node next;
            public Node(T item, Node next)
            {
                this.item = item;
                this.next = next;
            }
            public T Item
            {
                get { return item; }
            }

            public Node Next
            {
                get { return next; }
            }
        }
        private Node top = null;
        public SuperStack()
        {
        }

        public bool Empty
        {
            get
            {
                return top == null;
            }
        }

        public T Peek()
        {
            if (!Empty)
            {
                return top.Item;
            }
            else
                throw new StackEmptyException();
        }

        public T Pop()
        {
            if (!Empty)
            {
                T value = top.Item;
                top = top.Next;
                return value;
            }
            else
                throw new StackEmptyException();
        }

        public void Push(T v)
        {
            Node node = new Node(v, top);
            top = node;
        }
    }
}