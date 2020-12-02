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
    public partial class Lokacija
    {
		#region Methods
		public void Save()
        {
			Validate<Lokacija>();
            Save<Lokacija>();
        }
		public async Task SaveAsync()
        {
			Validate<Lokacija>();
            await SaveAsync<Lokacija>();
        }
        public void Delete()
        {
            Delete<Lokacija>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<Lokacija>();
        }
		public void Validate()
		{
			Validate<Lokacija>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(Lokacija).GetType().Name;
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