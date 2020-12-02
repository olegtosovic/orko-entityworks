using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orko.EntityWorks.Generator
{
    /// <summary>
    /// Represents errors that ocur during entityworks generator initialization and execution.
    /// </summary>
    public class EntityWorksGeneratorException : Exception
    {
		#region Constructors
		/// <summary>
		/// Default generator exception.
		/// </summary>
		/// <param name="message">EntityWorks generator exception message</param>
		internal EntityWorksGeneratorException(string message) : base(message)
        {

        }
        /// <summary>
        /// Wraped generator exception.
        /// </summary>
        /// <param name="message">EntityWorks generator exception message</param>
        internal EntityWorksGeneratorException(string message, Exception innerException) : base(message, innerException)
        {

        }
        #endregion
    }
}
