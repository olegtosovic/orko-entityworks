// Generated on 11/29/2020 8:43 PM using EntityWorks code generation tool.
// Template version: 1.0
// Note: Intended for modification.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orko.EntityWorks;

namespace Orko.Turist
{
    public partial class SkupinaSmjestajnogObjekta
    {
		#region Methods
		public void Save()
        {
			Validate<SkupinaSmjestajnogObjekta>();
            Save<SkupinaSmjestajnogObjekta>();
        }
		public async Task SaveAsync()
        {
			Validate<SkupinaSmjestajnogObjekta>();
            await SaveAsync<SkupinaSmjestajnogObjekta>();
        }
        public void Delete()
        {
            Delete<SkupinaSmjestajnogObjekta>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<SkupinaSmjestajnogObjekta>();
        }
		public void Validate()
		{
			Validate<SkupinaSmjestajnogObjekta>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(SkupinaSmjestajnogObjekta).GetType().Name;
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