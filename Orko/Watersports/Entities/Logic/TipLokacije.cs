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
    public partial class TipLokacije
    {
		#region Methods
		public void Save()
        {
			Validate<TipLokacije>();
            Save<TipLokacije>();
        }
		public async Task SaveAsync()
        {
			Validate<TipLokacije>();
            await SaveAsync<TipLokacije>();
        }
        public void Delete()
        {
            Delete<TipLokacije>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<TipLokacije>();
        }
		public void Validate()
		{
			Validate<TipLokacije>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(TipLokacije).GetType().Name;
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