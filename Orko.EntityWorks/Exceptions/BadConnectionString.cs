using System;

namespace Orko.EntityWorks
{
    class BadConnectionStringException : Exception
    {
        public BadConnectionStringException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}