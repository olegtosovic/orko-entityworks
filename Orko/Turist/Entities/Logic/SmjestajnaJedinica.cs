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
    public partial class SmjestajnaJedinica
    {
		#region Methods
		public void Save()
        {
			Validate<SmjestajnaJedinica>();
            Save<SmjestajnaJedinica>();
        }
		public async Task SaveAsync()
        {
			Validate<SmjestajnaJedinica>();
            await SaveAsync<SmjestajnaJedinica>();
        }
        public void Delete()
        {
            Delete<SmjestajnaJedinica>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<SmjestajnaJedinica>();
        }
		public void Validate()
		{
			Validate<SmjestajnaJedinica>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(SmjestajnaJedinica).GetType().Name;
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