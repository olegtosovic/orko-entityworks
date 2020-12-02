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
    public partial class TecajnaLista
    {
		#region Methods
		public void Save()
        {
			Validate<TecajnaLista>();
            Save<TecajnaLista>();
        }
		public async Task SaveAsync()
        {
			Validate<TecajnaLista>();
            await SaveAsync<TecajnaLista>();
        }
        public void Delete()
        {
            Delete<TecajnaLista>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<TecajnaLista>();
        }
		public void Validate()
		{
			Validate<TecajnaLista>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(TecajnaLista).GetType().Name;
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