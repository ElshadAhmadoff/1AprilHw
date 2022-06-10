using System;
using System.Runtime.Serialization;

namespace ConsoleApp1.Models
{
    [Serializable]
    internal class NotAviableException : Exception
    {
        public NotAviableException()
        {
        }

        public NotAviableException(string message) : base(message)
        {
        }

        public NotAviableException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NotAviableException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}