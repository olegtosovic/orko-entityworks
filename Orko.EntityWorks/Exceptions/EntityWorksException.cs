using System;
using System.Collections.Generic;
using System.Text;

namespace Orko.EntityWorks.Exceptions
{
	/// <summary>
	/// Represents errors that ocur during entityworks initialization and execution.
	/// </summary>
	public class EntityWorksException : Exception
	{
		#region Constructors
		/// <summary>
		/// Default entityworks exception.
		/// </summary>
		/// <param name="message">EntityWorks exception message</param>
		internal EntityWorksException(string message)
		{

		}
		/// <summary>
		/// Wraped entityworks exception.
		/// </summary>
		/// <param name="message">EntityWorks exception message</param>
		internal EntityWorksException(string message, Exception innerException) : base(message, innerException)
		{

		}
		#endregion
	}
}
