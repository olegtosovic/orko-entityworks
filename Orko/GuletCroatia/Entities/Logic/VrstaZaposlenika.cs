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
    public partial class VrstaZaposlenika
    {
		#region Methods
		public void Save()
        {
			Validate<VrstaZaposlenika>();
            Save<VrstaZaposlenika>();
        }
		public async Task SaveAsync()
        {
			Validate<VrstaZaposlenika>();
            await SaveAsync<VrstaZaposlenika>();
        }
        public void Delete()
        {
            Delete<VrstaZaposlenika>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<VrstaZaposlenika>();
        }
		public void Validate()
		{
			Validate<VrstaZaposlenika>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(VrstaZaposlenika).GetType().Name;
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