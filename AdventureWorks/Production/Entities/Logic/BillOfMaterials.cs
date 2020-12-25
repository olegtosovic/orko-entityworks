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
    public partial class BillOfMaterials
    {
		#region Methods
		public async Task SaveAsync()
        {
			Validate<BillOfMaterials>();
            await SaveAsync<BillOfMaterials>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<BillOfMaterials>();
        }
		public void Validate()
		{
			Validate<BillOfMaterials>();
		}
        public BillOfMaterials Clone()
		{
			return Clone<BillOfMaterials>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(BillOfMaterials).GetType().Name;
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