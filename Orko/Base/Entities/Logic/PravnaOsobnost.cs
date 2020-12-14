// Generated on 12/14/2020 9:29 PM using EntityWorks code generation tool.
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
		public async Task SaveAsync()
        {
			Validate<PravnaOsobnost>();
            await SaveAsync<PravnaOsobnost>();
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