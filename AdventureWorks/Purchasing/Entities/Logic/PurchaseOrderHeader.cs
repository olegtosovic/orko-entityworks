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
    public partial class PurchaseOrderHeader
    {
		#region Methods
		public async Task SaveAsync()
        {
			Validate<PurchaseOrderHeader>();
            await SaveAsync<PurchaseOrderHeader>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<PurchaseOrderHeader>();
        }
		public void Validate()
		{
			Validate<PurchaseOrderHeader>();
		}
        public PurchaseOrderHeader Clone()
		{
			return Clone<PurchaseOrderHeader>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(PurchaseOrderHeader).GetType().Name;
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