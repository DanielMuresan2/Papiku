using System;
using System.Collections.Generic;
using System.Text;

namespace Papiku.Core.DBServices.Exceptions
{
    class IncompleteDataException :Exception
    {
        public IncompleteDataException(string message) : base(message)
        {
        }

        public IncompleteDataException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
