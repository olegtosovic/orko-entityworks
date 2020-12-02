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
    public partial class UputaUslugaBrod
    {
		#region Methods
		public void Save()
        {
			Validate<UputaUslugaBrod>();
            Save<UputaUslugaBrod>();
        }
		public async Task SaveAsync()
        {
			Validate<UputaUslugaBrod>();
            await SaveAsync<UputaUslugaBrod>();
        }
        public void Delete()
        {
            Delete<UputaUslugaBrod>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<UputaUslugaBrod>();
        }
		public void Validate()
		{
			Validate<UputaUslugaBrod>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(UputaUslugaBrod).GetType().Name;
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