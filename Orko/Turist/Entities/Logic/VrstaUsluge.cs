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
    public partial class VrstaUsluge
    {
		#region Methods
		public void Save()
        {
			Validate<VrstaUsluge>();
            Save<VrstaUsluge>();
        }
		public async Task SaveAsync()
        {
			Validate<VrstaUsluge>();
            await SaveAsync<VrstaUsluge>();
        }
        public void Delete()
        {
            Delete<VrstaUsluge>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<VrstaUsluge>();
        }
		public void Validate()
		{
			Validate<VrstaUsluge>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(VrstaUsluge).GetType().Name;
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