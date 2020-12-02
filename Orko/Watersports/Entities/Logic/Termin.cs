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
    public partial class Termin
    {
		#region Methods
		public void Save()
        {
			Validate<Termin>();
            Save<Termin>();
        }
		public async Task SaveAsync()
        {
			Validate<Termin>();
            await SaveAsync<Termin>();
        }
        public void Delete()
        {
            Delete<Termin>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<Termin>();
        }
		public void Validate()
		{
			Validate<Termin>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(Termin).GetType().Name;
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