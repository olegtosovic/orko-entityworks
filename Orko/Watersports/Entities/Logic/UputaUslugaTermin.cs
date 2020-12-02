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
    public partial class UputaUslugaTermin
    {
		#region Methods
		public void Save()
        {
			Validate<UputaUslugaTermin>();
            Save<UputaUslugaTermin>();
        }
		public async Task SaveAsync()
        {
			Validate<UputaUslugaTermin>();
            await SaveAsync<UputaUslugaTermin>();
        }
        public void Delete()
        {
            Delete<UputaUslugaTermin>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<UputaUslugaTermin>();
        }
		public void Validate()
		{
			Validate<UputaUslugaTermin>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(UputaUslugaTermin).GetType().Name;
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