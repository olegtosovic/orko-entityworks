using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orko.EntityWorks
{
    /// <summary>
    /// EntityWorks configuration exception.
    /// </summary>
    public class EntityWorksConfigException : Exception
    {
        #region Constructors
        public EntityWorksConfigException(string message) : base(message)
        {

        }
        public EntityWorksConfigException(string message, Exception innerException) : base(message, innerException)
        {

        }
        #endregion
    }
}
