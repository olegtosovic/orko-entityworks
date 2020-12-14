// Generated on 12/14/2020 9:21 PM using EntityWorks code generation tool.
// Template version: 1.0
// Note: Intended for modification.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orko.EntityWorks;

namespace Northwind.Dbo
{
    public partial class Shippers
    {
		#region Methods
		public async Task SaveAsync()
        {
			Validate<Shippers>();
            await SaveAsync<Shippers>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<Shippers>();
        }
		public void Validate()
		{
			Validate<Shippers>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(Shippers).GetType().Name;
        }
        public override string GetDisplayValue()
        {
            return base.GetDisplayValue();
        }
		public static string GetTooltipValue()
		{
            return string.Empty;
		}
        #endregion
    }
}