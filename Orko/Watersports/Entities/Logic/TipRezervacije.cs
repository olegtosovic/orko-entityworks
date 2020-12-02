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
    public partial class TipRezervacije
    {
		#region Methods
		public void Save()
        {
			Validate<TipRezervacije>();
            Save<TipRezervacije>();
        }
		public async Task SaveAsync()
        {
			Validate<TipRezervacije>();
            await SaveAsync<TipRezervacije>();
        }
        public void Delete()
        {
            Delete<TipRezervacije>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<TipRezervacije>();
        }
		public void Validate()
		{
			Validate<TipRezervacije>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(TipRezervacije).GetType().Name;
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