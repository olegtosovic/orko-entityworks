// Generated on 11/29/2020 8:43 PM using EntityWorks code generation tool.
// Template version: 1.0
// Note: Intended for modification.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orko.EntityWorks;

namespace Orko.GuletCroatia
{
    public partial class CjenikJahte
    {
		#region Methods
		public void Save()
        {
			Validate<CjenikJahte>();
            Save<CjenikJahte>();
        }
		public async Task SaveAsync()
        {
			Validate<CjenikJahte>();
            await SaveAsync<CjenikJahte>();
        }
        public void Delete()
        {
            Delete<CjenikJahte>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<CjenikJahte>();
        }
		public void Validate()
		{
			Validate<CjenikJahte>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(CjenikJahte).GetType().Name;
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