// Generated on 11/29/2020 8:43 PM using EntityWorks code generation tool.
// Template version: 1.0
// Note: Intended for modification.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orko.EntityWorks;

namespace Orko.Watersports
{
    public partial class VrstaTermina
    {
		#region Methods
		public void Save()
        {
			Validate<VrstaTermina>();
            Save<VrstaTermina>();
        }
		public async Task SaveAsync()
        {
			Validate<VrstaTermina>();
            await SaveAsync<VrstaTermina>();
        }
        public void Delete()
        {
            Delete<VrstaTermina>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<VrstaTermina>();
        }
		public void Validate()
		{
			Validate<VrstaTermina>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(VrstaTermina).GetType().Name;
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