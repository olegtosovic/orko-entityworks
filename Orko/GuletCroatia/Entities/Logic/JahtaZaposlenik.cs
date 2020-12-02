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
    public partial class JahtaZaposlenik
    {
		#region Methods
		public void Save()
        {
			Validate<JahtaZaposlenik>();
            Save<JahtaZaposlenik>();
        }
		public async Task SaveAsync()
        {
			Validate<JahtaZaposlenik>();
            await SaveAsync<JahtaZaposlenik>();
        }
        public void Delete()
        {
            Delete<JahtaZaposlenik>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<JahtaZaposlenik>();
        }
		public void Validate()
		{
			Validate<JahtaZaposlenik>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(JahtaZaposlenik).GetType().Name;
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