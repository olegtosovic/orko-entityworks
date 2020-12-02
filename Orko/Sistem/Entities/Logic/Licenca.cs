// Generated on 11/29/2020 8:43 PM using EntityWorks code generation tool.
// Template version: 1.0
// Note: Intended for modification.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orko.EntityWorks;

namespace Orko.Sistem
{
    public partial class Licenca
    {
		#region Methods
		public void Save()
        {
			Validate<Licenca>();
            Save<Licenca>();
        }
		public async Task SaveAsync()
        {
			Validate<Licenca>();
            await SaveAsync<Licenca>();
        }
        public void Delete()
        {
            Delete<Licenca>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<Licenca>();
        }
		public void Validate()
		{
			Validate<Licenca>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(Licenca).GetType().Name;
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