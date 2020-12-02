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
    public partial class RezervacijaUsluga
    {
		#region Methods
		public void Save()
        {
			Validate<RezervacijaUsluga>();
            Save<RezervacijaUsluga>();
        }
		public async Task SaveAsync()
        {
			Validate<RezervacijaUsluga>();
            await SaveAsync<RezervacijaUsluga>();
        }
        public void Delete()
        {
            Delete<RezervacijaUsluga>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<RezervacijaUsluga>();
        }
		public void Validate()
		{
			Validate<RezervacijaUsluga>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(RezervacijaUsluga).GetType().Name;
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