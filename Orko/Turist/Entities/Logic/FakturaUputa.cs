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
    public partial class FakturaUputa
    {
		#region Methods
		public void Save()
        {
			Validate<FakturaUputa>();
            Save<FakturaUputa>();
        }
		public async Task SaveAsync()
        {
			Validate<FakturaUputa>();
            await SaveAsync<FakturaUputa>();
        }
        public void Delete()
        {
            Delete<FakturaUputa>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<FakturaUputa>();
        }
		public void Validate()
		{
			Validate<FakturaUputa>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(FakturaUputa).GetType().Name;
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