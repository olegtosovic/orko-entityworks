// Generated on 12/25/2020 11:27 AM using EntityWorks code generation tool.
// Template version: 1.0
// Note: Intended for modification.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orko.EntityWorks;

namespace AdventureWorks.Production
{
    public partial class Culture
    {
		#region Methods
		public async Task SaveAsync()
        {
			Validate<Culture>();
            await SaveAsync<Culture>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<Culture>();
        }
		public void Validate()
		{
			Validate<Culture>();
		}
        public Culture Clone()
		{
			return Clone<Culture>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(Culture).GetType().Name;
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