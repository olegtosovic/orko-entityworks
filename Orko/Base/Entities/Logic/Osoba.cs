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
    public partial class Osoba
    {
		#region Methods
		public void Save()
        {
			Validate<Osoba>();
            Save<Osoba>();
        }
		public async Task SaveAsync()
        {
			Validate<Osoba>();
            await SaveAsync<Osoba>();
        }
        public void Delete()
        {
            Delete<Osoba>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<Osoba>();
        }
		public void Validate()
		{
			Validate<Osoba>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(Osoba).GetType().Name;
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