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
    public partial class Destinacija
    {
		#region Methods
		public void Save()
        {
			Validate<Destinacija>();
            Save<Destinacija>();
        }
		public async Task SaveAsync()
        {
			Validate<Destinacija>();
            await SaveAsync<Destinacija>();
        }
        public void Delete()
        {
            Delete<Destinacija>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<Destinacija>();
        }
		public void Validate()
		{
			Validate<Destinacija>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(Destinacija).GetType().Name;
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