// Generated on 11/29/2020 8:43 PM using EntityWorks code generation tool.
// Template version: 1.0
// Note: Intended for modification.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orko.EntityWorks;

namespace Orko.GuletCroatia
{
    public partial class TipUslugeHrane
    {
		#region Methods
		public void Save()
        {
			Validate<TipUslugeHrane>();
            Save<TipUslugeHrane>();
        }
		public async Task SaveAsync()
        {
			Validate<TipUslugeHrane>();
            await SaveAsync<TipUslugeHrane>();
        }
        public void Delete()
        {
            Delete<TipUslugeHrane>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<TipUslugeHrane>();
        }
		public void Validate()
		{
			Validate<TipUslugeHrane>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(TipUslugeHrane).GetType().Name;
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