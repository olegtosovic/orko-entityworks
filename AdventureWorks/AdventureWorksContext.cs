// Generated on [DATE] [TIME] using EntityWorks code generation tool.
// Template version: 1.0
// Note: Modify connection context name in base constructor if required.
// Except: Namespace.

using Orko.EntityWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorks
{
	/// <summary>
	/// Represents strongly typed AdventureWorks query context.
	/// </summary>
	public class AdventureWorksContext : QueryContext
	{
		#region Constructors
		/// <summary>
		/// Creates instance of AdventureWorks ambient context. 
		/// </summary>
		public AdventureWorksContext() : base("AdventureWorks")
		{

		}
		#endregion
	}
}
