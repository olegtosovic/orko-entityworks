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
    public partial class JahtaGalerija
    {
		#region Methods
		public void Save()
        {
			Validate<JahtaGalerija>();
            Save<JahtaGalerija>();
        }
		public async Task SaveAsync()
        {
			Validate<JahtaGalerija>();
            await SaveAsync<JahtaGalerija>();
        }
        public void Delete()
        {
            Delete<JahtaGalerija>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<JahtaGalerija>();
        }
		public void Validate()
		{
			Validate<JahtaGalerija>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(JahtaGalerija).GetType().Name;
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