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
    public partial class TecajnaListaValuta
    {
		#region Methods
		public void Save()
        {
			Validate<TecajnaListaValuta>();
            Save<TecajnaListaValuta>();
        }
		public async Task SaveAsync()
        {
			Validate<TecajnaListaValuta>();
            await SaveAsync<TecajnaListaValuta>();
        }
        public void Delete()
        {
            Delete<TecajnaListaValuta>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<TecajnaListaValuta>();
        }
		public void Validate()
		{
			Validate<TecajnaListaValuta>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(TecajnaListaValuta).GetType().Name;
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