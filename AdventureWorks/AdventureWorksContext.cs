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
		#region Instance constructors
		/// <summary>
		/// Creates instance of AdventureWorks ambient context. 
		/// </summary>
		public AdventureWorksContext() : base("AdventureWorks", true)
		{

		}
		#endregion
	}
}
