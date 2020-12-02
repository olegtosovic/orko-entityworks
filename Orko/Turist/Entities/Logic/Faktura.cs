// Generated on 11/29/2020 8:43 PM using EntityWorks code generation tool.
// Template version: 1.0
// Note: Intended for modification.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orko.EntityWorks;

namespace Orko.Turist
{
    public partial class Faktura
    {
		#region Methods
		public void Save()
        {
			Validate<Faktura>();
            Save<Faktura>();
        }
		public async Task SaveAsync()
        {
			Validate<Faktura>();
            await SaveAsync<Faktura>();
        }
        public void Delete()
        {
            Delete<Faktura>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<Faktura>();
        }
		public void Validate()
		{
			Validate<Faktura>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(Faktura).GetType().Name;
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