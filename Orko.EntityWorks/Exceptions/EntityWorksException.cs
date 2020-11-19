using System;
using System.Collections.Generic;
using System.Text;

namespace Orko.EntityWorks.Exceptions
{
	/// <summary>
	/// Represents entityworks exception.
	/// </summary>
	public class EntityWorksException : Exception
	{
		#region Constructors
		/// <summary>
		/// Entity works exception only constructor.
		/// </summary>
		internal EntityWorksException(string message, Exception innerException = null) : base(message, innerException)
		{

		}
		#endregion
	}
}
