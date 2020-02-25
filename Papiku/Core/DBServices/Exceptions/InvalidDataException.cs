using System;
using System.Collections.Generic;
using System.Text;

namespace Papiku.Core.DBServices.Exceptions
{
    class InvalidDataException :Exception 
    {
        public InvalidDataException(string message) : base(message)
        {
        }

        public InvalidDataException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
