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
    public partial class VrstaJahte
    {
		#region Methods
		public void Save()
        {
			Validate<VrstaJahte>();
            Save<VrstaJahte>();
        }
		public async Task SaveAsync()
        {
			Validate<VrstaJahte>();
            await SaveAsync<VrstaJahte>();
        }
        public void Delete()
        {
            Delete<VrstaJahte>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<VrstaJahte>();
        }
		public void Validate()
		{
			Validate<VrstaJahte>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(VrstaJahte).GetType().Name;
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