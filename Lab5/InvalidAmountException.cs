using System;
using System.Runtime.Serialization;

namespace Lab5
{
    [Serializable]
    internal class InvalidAmountException : Exception
    {
        public InvalidAmountException()
        {
        }

        public InvalidAmountException(string message) : base(message)
        {
        }

        public InvalidAmountException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidAmountException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}