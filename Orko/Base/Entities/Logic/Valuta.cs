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
    public partial class Valuta
    {
		#region Methods
		public void Save()
        {
			Validate<Valuta>();
            Save<Valuta>();
        }
		public async Task SaveAsync()
        {
			Validate<Valuta>();
            await SaveAsync<Valuta>();
        }
        public void Delete()
        {
            Delete<Valuta>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<Valuta>();
        }
		public void Validate()
		{
			Validate<Valuta>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(Valuta).GetType().Name;
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