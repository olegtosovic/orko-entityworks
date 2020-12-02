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
    public partial class CjenikHrane
    {
		#region Methods
		public void Save()
        {
			Validate<CjenikHrane>();
            Save<CjenikHrane>();
        }
		public async Task SaveAsync()
        {
			Validate<CjenikHrane>();
            await SaveAsync<CjenikHrane>();
        }
        public void Delete()
        {
            Delete<CjenikHrane>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<CjenikHrane>();
        }
		public void Validate()
		{
			Validate<CjenikHrane>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(CjenikHrane).GetType().Name;
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