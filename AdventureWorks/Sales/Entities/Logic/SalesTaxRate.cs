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
    public partial class SalesTaxRate
    {
		#region Methods
		public async Task SaveAsync()
        {
			Validate<SalesTaxRate>();
            await SaveAsync<SalesTaxRate>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<SalesTaxRate>();
        }
		public void Validate()
		{
			Validate<SalesTaxRate>();
		}
        public SalesTaxRate Clone()
		{
			return Clone<SalesTaxRate>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(SalesTaxRate).GetType().Name;
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