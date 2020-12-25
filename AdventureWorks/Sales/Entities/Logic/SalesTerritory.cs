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
    public partial class SalesTerritory
    {
		#region Methods
		public async Task SaveAsync()
        {
			Validate<SalesTerritory>();
            await SaveAsync<SalesTerritory>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<SalesTerritory>();
        }
		public void Validate()
		{
			Validate<SalesTerritory>();
		}
        public SalesTerritory Clone()
		{
			return Clone<SalesTerritory>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(SalesTerritory).GetType().Name;
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