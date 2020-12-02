// Generated on 11/29/2020 8:43 PM using EntityWorks code generation tool.
// Template version: 1.0
// Note: Intended for modification.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orko.EntityWorks;

namespace Orko.SebastianArt
{
    public partial class NovostGalerija
    {
		#region Methods
		public void Save()
        {
			Validate<NovostGalerija>();
            Save<NovostGalerija>();
        }
		public async Task SaveAsync()
        {
			Validate<NovostGalerija>();
            await SaveAsync<NovostGalerija>();
        }
        public void Delete()
        {
            Delete<NovostGalerija>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<NovostGalerija>();
        }
		public void Validate()
		{
			Validate<NovostGalerija>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(NovostGalerija).GetType().Name;
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