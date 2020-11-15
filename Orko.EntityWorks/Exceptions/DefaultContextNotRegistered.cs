using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orko.EntityWorks
{
    /// <summary>
    /// Should be thrown when there is no registered default context for entity type that is requesting it.
    /// </summary>
    public class DefaultContextNotRegisteredException : Exception
    {
        #region Constructors
        public DefaultContextNotRegisteredException(string message) : base(message)
        { 

        }
        #endregion
    }
}
