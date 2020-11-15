using System;

namespace Orko.EntityWorks
{
    class TableDefinitionException : Exception
    {
        public TableDefinitionException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}