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
    public partial class WebObjekt
    {
		#region Methods
		public void Save()
        {
			Validate<WebObjekt>();
            Save<WebObjekt>();
        }
		public async Task SaveAsync()
        {
			Validate<WebObjekt>();
            await SaveAsync<WebObjekt>();
        }
        public void Delete()
        {
            Delete<WebObjekt>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<WebObjekt>();
        }
		public void Validate()
		{
			Validate<WebObjekt>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(WebObjekt).GetType().Name;
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