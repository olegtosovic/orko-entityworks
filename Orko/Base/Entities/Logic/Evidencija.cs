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
    public partial class Evidencija
    {
		#region Methods
		public void Save()
        {
			Validate<Evidencija>();
            Save<Evidencija>();
        }
		public async Task SaveAsync()
        {
			Validate<Evidencija>();
            await SaveAsync<Evidencija>();
        }
        public void Delete()
        {
            Delete<Evidencija>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<Evidencija>();
        }
		public void Validate()
		{
			Validate<Evidencija>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(Evidencija).GetType().Name;
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