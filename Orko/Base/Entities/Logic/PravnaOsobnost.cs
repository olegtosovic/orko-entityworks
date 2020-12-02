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
    public partial class PravnaOsobnost
    {
		#region Methods
		public void Save()
        {
			Validate<PravnaOsobnost>();
            Save<PravnaOsobnost>();
        }
		public async Task SaveAsync()
        {
			Validate<PravnaOsobnost>();
            await SaveAsync<PravnaOsobnost>();
        }
        public void Delete()
        {
            Delete<PravnaOsobnost>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<PravnaOsobnost>();
        }
		public void Validate()
		{
			Validate<PravnaOsobnost>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(PravnaOsobnost).GetType().Name;
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