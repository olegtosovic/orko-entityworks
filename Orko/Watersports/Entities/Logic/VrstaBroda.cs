// Generated on 11/29/2020 8:43 PM using EntityWorks code generation tool.
// Template version: 1.0
// Note: Intended for modification.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orko.EntityWorks;

namespace Orko.Watersports
{
    public partial class VrstaBroda
    {
		#region Methods
		public void Save()
        {
			Validate<VrstaBroda>();
            Save<VrstaBroda>();
        }
		public async Task SaveAsync()
        {
			Validate<VrstaBroda>();
            await SaveAsync<VrstaBroda>();
        }
        public void Delete()
        {
            Delete<VrstaBroda>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<VrstaBroda>();
        }
		public void Validate()
		{
			Validate<VrstaBroda>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(VrstaBroda).GetType().Name;
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