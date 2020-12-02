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
    public partial class JahtaKategorija
    {
		#region Methods
		public void Save()
        {
			Validate<JahtaKategorija>();
            Save<JahtaKategorija>();
        }
		public async Task SaveAsync()
        {
			Validate<JahtaKategorija>();
            await SaveAsync<JahtaKategorija>();
        }
        public void Delete()
        {
            Delete<JahtaKategorija>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<JahtaKategorija>();
        }
		public void Validate()
		{
			Validate<JahtaKategorija>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(JahtaKategorija).GetType().Name;
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