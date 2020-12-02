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
    public partial class PogledSmjestajneJedinice
    {
		#region Methods
		public void Save()
        {
			Validate<PogledSmjestajneJedinice>();
            Save<PogledSmjestajneJedinice>();
        }
		public async Task SaveAsync()
        {
			Validate<PogledSmjestajneJedinice>();
            await SaveAsync<PogledSmjestajneJedinice>();
        }
        public void Delete()
        {
            Delete<PogledSmjestajneJedinice>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<PogledSmjestajneJedinice>();
        }
		public void Validate()
		{
			Validate<PogledSmjestajneJedinice>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(PogledSmjestajneJedinice).GetType().Name;
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