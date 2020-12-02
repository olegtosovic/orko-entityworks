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
    public partial class RazinaUsluge
    {
		#region Methods
		public void Save()
        {
			Validate<RazinaUsluge>();
            Save<RazinaUsluge>();
        }
		public async Task SaveAsync()
        {
			Validate<RazinaUsluge>();
            await SaveAsync<RazinaUsluge>();
        }
        public void Delete()
        {
            Delete<RazinaUsluge>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<RazinaUsluge>();
        }
		public void Validate()
		{
			Validate<RazinaUsluge>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(RazinaUsluge).GetType().Name;
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