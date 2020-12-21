// Generated on 12/21/2020 1:03 PM using EntityWorks code generation tool.
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
    public partial class Territories
    {
		#region Methods
		public async Task SaveAsync()
        {
			Validate<Territories>();
            await SaveAsync<Territories>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<Territories>();
        }
		public void Validate()
		{
			Validate<Territories>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(Territories).GetType().Name;
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