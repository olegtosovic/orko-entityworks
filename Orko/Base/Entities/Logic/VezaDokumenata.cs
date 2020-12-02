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
    public partial class VezaDokumenata
    {
		#region Methods
		public void Save()
        {
			Validate<VezaDokumenata>();
            Save<VezaDokumenata>();
        }
		public async Task SaveAsync()
        {
			Validate<VezaDokumenata>();
            await SaveAsync<VezaDokumenata>();
        }
        public void Delete()
        {
            Delete<VezaDokumenata>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<VezaDokumenata>();
        }
		public void Validate()
		{
			Validate<VezaDokumenata>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(VezaDokumenata).GetType().Name;
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