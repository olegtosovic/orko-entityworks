// Generated on 12/22/2020 12:53 PM using EntityWorks code generation tool.
// Template version: 1.0
// Note: Intended for modification.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orko.EntityWorks;

namespace Northwind.Dbo
{
    public partial class Region
    {
		#region Methods
		public async Task SaveAsync()
        {
			Validate<Region>();
            await SaveAsync<Region>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<Region>();
        }
		public void Validate()
		{
			Validate<Region>();
		}
        public Region Clone()
		{
			return Clone<Region>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(Region).GetType().Name;
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