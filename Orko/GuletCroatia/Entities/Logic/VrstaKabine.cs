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
    public partial class VrstaKabine
    {
		#region Methods
		public void Save()
        {
			Validate<VrstaKabine>();
            Save<VrstaKabine>();
        }
		public async Task SaveAsync()
        {
			Validate<VrstaKabine>();
            await SaveAsync<VrstaKabine>();
        }
        public void Delete()
        {
            Delete<VrstaKabine>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<VrstaKabine>();
        }
		public void Validate()
		{
			Validate<VrstaKabine>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(VrstaKabine).GetType().Name;
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