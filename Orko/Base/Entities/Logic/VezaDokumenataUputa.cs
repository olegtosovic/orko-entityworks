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
    public partial class VezaDokumenataUputa
    {
		#region Methods
		public void Save()
        {
			Validate<VezaDokumenataUputa>();
            Save<VezaDokumenataUputa>();
        }
		public async Task SaveAsync()
        {
			Validate<VezaDokumenataUputa>();
            await SaveAsync<VezaDokumenataUputa>();
        }
        public void Delete()
        {
            Delete<VezaDokumenataUputa>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<VezaDokumenataUputa>();
        }
		public void Validate()
		{
			Validate<VezaDokumenataUputa>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(VezaDokumenataUputa).GetType().Name;
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