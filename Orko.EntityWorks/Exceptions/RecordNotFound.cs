using System;

namespace Orko.EntityWorks
{
    public class RecordNotFoundException : Exception
    {
        public RecordNotFoundException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
