// Generated on 12/25/2020 11:27 AM using EntityWorks code generation tool.
// Template version: 1.0
// Note: Intended for modification.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orko.EntityWorks;

namespace AdventureWorks.Sales
{
    public partial class SalesPerson
    {
		#region Methods
		public async Task SaveAsync()
        {
			Validate<SalesPerson>();
            await SaveAsync<SalesPerson>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<SalesPerson>();
        }
		public void Validate()
		{
			Validate<SalesPerson>();
		}
        public SalesPerson Clone()
		{
			return Clone<SalesPerson>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(SalesPerson).GetType().Name;
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