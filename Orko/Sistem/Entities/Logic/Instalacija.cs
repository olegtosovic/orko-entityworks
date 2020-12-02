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
    public partial class Instalacija
    {
		#region Methods
		public void Save()
        {
			Validate<Instalacija>();
            Save<Instalacija>();
        }
		public async Task SaveAsync()
        {
			Validate<Instalacija>();
            await SaveAsync<Instalacija>();
        }
        public void Delete()
        {
            Delete<Instalacija>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<Instalacija>();
        }
		public void Validate()
		{
			Validate<Instalacija>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(Instalacija).GetType().Name;
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