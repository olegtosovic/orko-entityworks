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
    public partial class CjenikJahteSlobodno
    {
		#region Methods
		public void Save()
        {
			Validate<CjenikJahteSlobodno>();
            Save<CjenikJahteSlobodno>();
        }
		public async Task SaveAsync()
        {
			Validate<CjenikJahteSlobodno>();
            await SaveAsync<CjenikJahteSlobodno>();
        }
        public void Delete()
        {
            Delete<CjenikJahteSlobodno>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<CjenikJahteSlobodno>();
        }
		public void Validate()
		{
			Validate<CjenikJahteSlobodno>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(CjenikJahteSlobodno).GetType().Name;
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