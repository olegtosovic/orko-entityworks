using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orko.EntityWorks
{
	/// <summary>
	/// Indicates what table locking hint is used.
	/// </summary>
	public enum LockHint
	{
		/// <summary>
		/// Guest query context is reserved for non authorized users.
		/// Any scenario.
		/// </summary>
		UpdateLock,

		/// <summary>
		/// Root query context is reserved for administrative sql connection that points to admin database.
		/// Multiple-database/tenant scenario.
		/// </summary>
		ExclusiveLock,

		/// <summary>
		/// Root query context is reserved for administrative sql connection that points to admin database.
		/// Multiple-database/tenant scenario.
		/// </summary>
		TableLock,

		/// <summary>
		/// Root query context is reserved for administrative sql connection that points to admin database.
		/// Multiple-database/tenant scenario.
		/// </summary>
		ExclusiveTableLock,
	}
}
