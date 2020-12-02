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
    public partial class VrstaSmjestajneJedinice
    {
		#region Methods
		public void Save()
        {
			Validate<VrstaSmjestajneJedinice>();
            Save<VrstaSmjestajneJedinice>();
        }
		public async Task SaveAsync()
        {
			Validate<VrstaSmjestajneJedinice>();
            await SaveAsync<VrstaSmjestajneJedinice>();
        }
        public void Delete()
        {
            Delete<VrstaSmjestajneJedinice>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<VrstaSmjestajneJedinice>();
        }
		public void Validate()
		{
			Validate<VrstaSmjestajneJedinice>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(VrstaSmjestajneJedinice).GetType().Name;
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