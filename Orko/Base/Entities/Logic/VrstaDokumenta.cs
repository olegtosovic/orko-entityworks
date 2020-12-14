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
    public partial class VrstaDokumenta
    {
		#region Methods
		public async Task SaveAsync()
        {
			Validate<VrstaDokumenta>();
            await SaveAsync<VrstaDokumenta>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<VrstaDokumenta>();
        }
		public void Validate()
		{
			Validate<VrstaDokumenta>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(VrstaDokumenta).GetType().Name;
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