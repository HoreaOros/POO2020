using System;
using System.Runtime.Serialization;

namespace Curs11
{
    [Serializable]
    internal class StackFullException : Exception
    {
        public StackFullException()
        {
        }

        public StackFullException(string message) : base(message)
        {
        }

        public StackFullException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected StackFullException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}