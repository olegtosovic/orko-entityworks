// Generated on 11/29/2020 8:43 PM using EntityWorks code generation tool.
// Template version: 1.0
// Note: Intended for modification.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orko.EntityWorks;

namespace Orko.Watersports
{
    public partial class Hotel
    {
		#region Methods
		public void Save()
        {
			Validate<Hotel>();
            Save<Hotel>();
        }
		public async Task SaveAsync()
        {
			Validate<Hotel>();
            await SaveAsync<Hotel>();
        }
        public void Delete()
        {
            Delete<Hotel>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<Hotel>();
        }
		public void Validate()
		{
			Validate<Hotel>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(Hotel).GetType().Name;
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