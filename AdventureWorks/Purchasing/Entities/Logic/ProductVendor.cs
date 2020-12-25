// Generated on 12/25/2020 11:27 AM using EntityWorks code generation tool.
// Template version: 1.0
// Note: Intended for modification.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orko.EntityWorks;

namespace AdventureWorks.Purchasing
{
    public partial class ProductVendor
    {
		#region Methods
		public async Task SaveAsync()
        {
			Validate<ProductVendor>();
            await SaveAsync<ProductVendor>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<ProductVendor>();
        }
		public void Validate()
		{
			Validate<ProductVendor>();
		}
        public ProductVendor Clone()
		{
			return Clone<ProductVendor>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(ProductVendor).GetType().Name;
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