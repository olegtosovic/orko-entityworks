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
    public partial class JahtaKabina
    {
		#region Methods
		public void Save()
        {
			Validate<JahtaKabina>();
            Save<JahtaKabina>();
        }
		public async Task SaveAsync()
        {
			Validate<JahtaKabina>();
            await SaveAsync<JahtaKabina>();
        }
        public void Delete()
        {
            Delete<JahtaKabina>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<JahtaKabina>();
        }
		public void Validate()
		{
			Validate<JahtaKabina>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(JahtaKabina).GetType().Name;
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