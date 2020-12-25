// Generated on 12/25/2020 11:27 AM using EntityWorks code generation tool.
// Template version: 1.0
// Note: Intended for modification.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orko.EntityWorks;

namespace AdventureWorks.Production
{
    public partial class ProductCostHistory
    {
		#region Methods
		public async Task SaveAsync()
        {
			Validate<ProductCostHistory>();
            await SaveAsync<ProductCostHistory>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<ProductCostHistory>();
        }
		public void Validate()
		{
			Validate<ProductCostHistory>();
		}
        public ProductCostHistory Clone()
		{
			return Clone<ProductCostHistory>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(ProductCostHistory).GetType().Name;
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