// Generated on 12/14/2020 9:21 PM using EntityWorks code generation tool.
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
    public partial class ProductPhoto
    {
		#region Methods
		public async Task SaveAsync()
        {
			Validate<ProductPhoto>();
            await SaveAsync<ProductPhoto>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<ProductPhoto>();
        }
		public void Validate()
		{
			Validate<ProductPhoto>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(ProductPhoto).GetType().Name;
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