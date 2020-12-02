// Generated on 11/29/2020 8:43 PM using EntityWorks code generation tool.
// Template version: 1.0
// Note: Intended for modification.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orko.EntityWorks;

namespace Orko.GuletCroatia
{
    public partial class JahtaOprema
    {
		#region Methods
		public void Save()
        {
			Validate<JahtaOprema>();
            Save<JahtaOprema>();
        }
		public async Task SaveAsync()
        {
			Validate<JahtaOprema>();
            await SaveAsync<JahtaOprema>();
        }
        public void Delete()
        {
            Delete<JahtaOprema>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<JahtaOprema>();
        }
		public void Validate()
		{
			Validate<JahtaOprema>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(JahtaOprema).GetType().Name;
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