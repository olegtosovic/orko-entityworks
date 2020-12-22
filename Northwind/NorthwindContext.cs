using Orko.EntityWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind
{
	/// <summary>
	/// Represents strongly typed Northwind query context.
	/// </summary>
	public class NorthwindContext : QueryContext
	{
		#region Constructors
		/// <summary>
		/// Creates instance of Northwind ambient context. 
		/// </summary>
		public NorthwindContext() : base("Northwind")
		{

		}
		#endregion
	}
}
