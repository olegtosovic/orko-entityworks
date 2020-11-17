using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Orko.AspNetCore.Models
{
	/// <summary>
	/// Example model.
	/// </summary>
	public class Country
	{
		#region Properties
		public string Name { get; set; }
		public string Code { get; set; }
		public string TwoLetterCode { get; set; }
		public string ThreeLetterCode { get; set; }
		#endregion
	}
}
