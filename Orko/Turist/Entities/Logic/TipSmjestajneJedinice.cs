// Generated on 12/14/2020 9:29 PM using EntityWorks code generation tool.
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
    public partial class TipSmjestajneJedinice
    {
		#region Methods
		public async Task SaveAsync()
        {
			Validate<TipSmjestajneJedinice>();
            await SaveAsync<TipSmjestajneJedinice>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<TipSmjestajneJedinice>();
        }
		public void Validate()
		{
			Validate<TipSmjestajneJedinice>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(TipSmjestajneJedinice).GetType().Name;
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