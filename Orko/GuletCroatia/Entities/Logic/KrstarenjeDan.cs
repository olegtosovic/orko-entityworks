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
    public partial class KrstarenjeDan
    {
		#region Methods
		public void Save()
        {
			Validate<KrstarenjeDan>();
            Save<KrstarenjeDan>();
        }
		public async Task SaveAsync()
        {
			Validate<KrstarenjeDan>();
            await SaveAsync<KrstarenjeDan>();
        }
        public void Delete()
        {
            Delete<KrstarenjeDan>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<KrstarenjeDan>();
        }
		public void Validate()
		{
			Validate<KrstarenjeDan>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(KrstarenjeDan).GetType().Name;
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