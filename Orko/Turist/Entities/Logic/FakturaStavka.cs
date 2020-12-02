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
    public partial class FakturaStavka
    {
		#region Methods
		public void Save()
        {
			Validate<FakturaStavka>();
            Save<FakturaStavka>();
        }
		public async Task SaveAsync()
        {
			Validate<FakturaStavka>();
            await SaveAsync<FakturaStavka>();
        }
        public void Delete()
        {
            Delete<FakturaStavka>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<FakturaStavka>();
        }
		public void Validate()
		{
			Validate<FakturaStavka>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(FakturaStavka).GetType().Name;
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