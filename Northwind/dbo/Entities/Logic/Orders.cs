// Generated on 12/22/2020 12:53 PM using EntityWorks code generation tool.
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
    public partial class Orders
    {
		#region Methods
		public async Task SaveAsync()
        {
			Validate<Orders>();
            await SaveAsync<Orders>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<Orders>();
        }
		public void Validate()
		{
			Validate<Orders>();
		}
        public Orders Clone()
		{
			return Clone<Orders>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(Orders).GetType().Name;
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