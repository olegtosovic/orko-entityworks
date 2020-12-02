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
    public partial class Firma
    {
		#region Methods
		public void Save()
        {
			Validate<Firma>();
            Save<Firma>();
        }
		public async Task SaveAsync()
        {
			Validate<Firma>();
            await SaveAsync<Firma>();
        }
        public void Delete()
        {
            Delete<Firma>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<Firma>();
        }
		public void Validate()
		{
			Validate<Firma>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(Firma).GetType().Name;
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