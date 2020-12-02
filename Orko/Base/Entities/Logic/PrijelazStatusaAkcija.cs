// Generated on 11/29/2020 8:43 PM using EntityWorks code generation tool.
// Template version: 1.0
// Note: Intended for modification.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orko.EntityWorks;

namespace Orko.Base
{
    public partial class PrijelazStatusaAkcija
    {
		#region Methods
		public void Save()
        {
			Validate<PrijelazStatusaAkcija>();
            Save<PrijelazStatusaAkcija>();
        }
		public async Task SaveAsync()
        {
			Validate<PrijelazStatusaAkcija>();
            await SaveAsync<PrijelazStatusaAkcija>();
        }
        public void Delete()
        {
            Delete<PrijelazStatusaAkcija>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<PrijelazStatusaAkcija>();
        }
		public void Validate()
		{
			Validate<PrijelazStatusaAkcija>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(PrijelazStatusaAkcija).GetType().Name;
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