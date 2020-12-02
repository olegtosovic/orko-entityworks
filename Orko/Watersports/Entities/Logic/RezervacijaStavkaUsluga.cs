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
    public partial class RezervacijaStavkaUsluga
    {
		#region Methods
		public void Save()
        {
			Validate<RezervacijaStavkaUsluga>();
            Save<RezervacijaStavkaUsluga>();
        }
		public async Task SaveAsync()
        {
			Validate<RezervacijaStavkaUsluga>();
            await SaveAsync<RezervacijaStavkaUsluga>();
        }
        public void Delete()
        {
            Delete<RezervacijaStavkaUsluga>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<RezervacijaStavkaUsluga>();
        }
		public void Validate()
		{
			Validate<RezervacijaStavkaUsluga>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(RezervacijaStavkaUsluga).GetType().Name;
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