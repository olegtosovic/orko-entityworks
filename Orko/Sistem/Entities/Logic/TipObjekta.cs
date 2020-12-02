// Generated on 11/29/2020 8:43 PM using EntityWorks code generation tool.
// Template version: 1.0
// Note: Intended for modification.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orko.EntityWorks;

namespace Orko.Sistem
{
    public partial class TipObjekta
    {
		#region Methods
		public void Save()
        {
			Validate<TipObjekta>();
            Save<TipObjekta>();
        }
		public async Task SaveAsync()
        {
			Validate<TipObjekta>();
            await SaveAsync<TipObjekta>();
        }
        public void Delete()
        {
            Delete<TipObjekta>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<TipObjekta>();
        }
		public void Validate()
		{
			Validate<TipObjekta>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(TipObjekta).GetType().Name;
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