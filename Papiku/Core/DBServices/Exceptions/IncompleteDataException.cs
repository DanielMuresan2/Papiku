using System;

namespace Papiku.Core.DBServices.Exceptions
{
    internal class IncompleteDataException : Exception
    {
        public IncompleteDataException(string message) : base(message)
        {
        }

        public IncompleteDataException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}