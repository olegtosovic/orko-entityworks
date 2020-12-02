// Generated on 11/29/2020 8:43 PM using EntityWorks code generation tool.
// Template version: 1.0
// Note: Intended for modification.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orko.EntityWorks;

namespace Orko.Base
{
    public partial class KlasaVrsteDokumenta
    {
		#region Methods
		public void Save()
        {
			Validate<KlasaVrsteDokumenta>();
            Save<KlasaVrsteDokumenta>();
        }
		public async Task SaveAsync()
        {
			Validate<KlasaVrsteDokumenta>();
            await SaveAsync<KlasaVrsteDokumenta>();
        }
        public void Delete()
        {
            Delete<KlasaVrsteDokumenta>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<KlasaVrsteDokumenta>();
        }
		public void Validate()
		{
			Validate<KlasaVrsteDokumenta>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(KlasaVrsteDokumenta).GetType().Name;
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