// Generated on 11/29/2020 8:43 PM using EntityWorks code generation tool.
// Template version: 1.0
// Note: Intended for modification.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orko.EntityWorks;

namespace Orko.Sistem
{
    public partial class VrstaLicence
    {
		#region Methods
		public void Save()
        {
			Validate<VrstaLicence>();
            Save<VrstaLicence>();
        }
		public async Task SaveAsync()
        {
			Validate<VrstaLicence>();
            await SaveAsync<VrstaLicence>();
        }
        public void Delete()
        {
            Delete<VrstaLicence>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<VrstaLicence>();
        }
		public void Validate()
		{
			Validate<VrstaLicence>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(VrstaLicence).GetType().Name;
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