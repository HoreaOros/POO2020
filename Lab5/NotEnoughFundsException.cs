using System;
using System.Runtime.Serialization;

namespace Lab5
{
    [Serializable]
    internal class NotEnoughFundsException : Exception
    {
        public NotEnoughFundsException()
        {
        }

        public NotEnoughFundsException(string message) : base(message)
        {
        }

        public NotEnoughFundsException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NotEnoughFundsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}