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
    public partial class Location
    {
		#region Methods
		public async Task SaveAsync()
        {
			Validate<Location>();
            await SaveAsync<Location>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<Location>();
        }
		public void Validate()
		{
			Validate<Location>();
		}
        public Location Clone()
		{
			return Clone<Location>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(Location).GetType().Name;
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