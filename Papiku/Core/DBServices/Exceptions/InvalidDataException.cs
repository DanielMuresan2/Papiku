using System;

namespace Papiku.Core.DBServices.Exceptions
{
    internal class InvalidDataException : Exception
    {
        public InvalidDataException(string message) : base(message)
        {
        }

        public InvalidDataException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}