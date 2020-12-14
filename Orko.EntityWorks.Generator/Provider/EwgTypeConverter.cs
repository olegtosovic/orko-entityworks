using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orko.EntityWorks.Generator
{
	/// <summary>
	/// Provides type conversions between specific database provider database types and net types.
	/// </summary>
	public class EwgTypeConverter
	{
		#region Constructor
		public EwgTypeConverter()
		{

		}
		#endregion

		#region Properties
		/// <summary>
		/// Database type to net member type container.
		/// </summary>
		public Dictionary<string, Type> NetTypes { get; protected set; }
		/// <summary>
		/// Net member type to db type container.
		/// </summary>
		public Dictionary<string, DbType> DbTypes { get; protected set; }
		#endregion
	}
}
