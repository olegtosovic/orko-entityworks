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
    public partial class ProductReview
    {
		#region Methods
		public async Task SaveAsync()
        {
			Validate<ProductReview>();
            await SaveAsync<ProductReview>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<ProductReview>();
        }
		public void Validate()
		{
			Validate<ProductReview>();
		}
        public ProductReview Clone()
		{
			return Clone<ProductReview>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(ProductReview).GetType().Name;
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