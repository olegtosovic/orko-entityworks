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
    public partial class Currency
    {
		#region Methods
		public async Task SaveAsync()
        {
			Validate<Currency>();
            await SaveAsync<Currency>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<Currency>();
        }
		public void Validate()
		{
			Validate<Currency>();
		}
        public Currency Clone()
		{
			return Clone<Currency>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(Currency).GetType().Name;
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