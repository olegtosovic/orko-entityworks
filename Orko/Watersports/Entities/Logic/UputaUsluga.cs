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
    public partial class UputaUsluga
    {
		#region Methods
		public void Save()
        {
			Validate<UputaUsluga>();
            Save<UputaUsluga>();
        }
		public async Task SaveAsync()
        {
			Validate<UputaUsluga>();
            await SaveAsync<UputaUsluga>();
        }
        public void Delete()
        {
            Delete<UputaUsluga>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<UputaUsluga>();
        }
		public void Validate()
		{
			Validate<UputaUsluga>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(UputaUsluga).GetType().Name;
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