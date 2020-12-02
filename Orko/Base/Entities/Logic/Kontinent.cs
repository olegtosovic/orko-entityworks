// Generated on 11/29/2020 8:43 PM using EntityWorks code generation tool.
// Template version: 1.0
// Note: Intended for modification.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orko.EntityWorks;

namespace Orko.Base
{
    public partial class Kontinent
    {
		#region Methods
		public void Save()
        {
			Validate<Kontinent>();
            Save<Kontinent>();
        }
		public async Task SaveAsync()
        {
			Validate<Kontinent>();
            await SaveAsync<Kontinent>();
        }
        public void Delete()
        {
            Delete<Kontinent>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<Kontinent>();
        }
		public void Validate()
		{
			Validate<Kontinent>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(Kontinent).GetType().Name;
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