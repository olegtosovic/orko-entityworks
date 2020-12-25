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
    public partial class ProductProductPhoto
    {
		#region Methods
		public async Task SaveAsync()
        {
			Validate<ProductProductPhoto>();
            await SaveAsync<ProductProductPhoto>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<ProductProductPhoto>();
        }
		public void Validate()
		{
			Validate<ProductProductPhoto>();
		}
        public ProductProductPhoto Clone()
		{
			return Clone<ProductProductPhoto>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(ProductProductPhoto).GetType().Name;
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