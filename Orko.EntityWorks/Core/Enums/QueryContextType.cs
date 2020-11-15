using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orko.EntityWorks
{
	/// <summary>
	/// Indicates what mapping type is used between data reader data and object instance.
	/// </summary>
	public enum QueryContextType
	{
		/// <summary>
		/// Guest query context is reserved for non authorized users.
		/// Any scenario.
		/// </summary>
		GuestQueryContext,

		/// <summary>
		/// Root query context is reserved for administrative sql connection that points to admin database.
		/// Multiple-database/tenant scenario.
		/// </summary>
		RootQueryContext,

		/// <summary>
		/// Additional user defined query context.
		/// Custom scenario.
		/// </summary>
		UserQueryContext
	}
}
