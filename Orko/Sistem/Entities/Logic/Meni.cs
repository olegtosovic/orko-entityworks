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
    public partial class Meni
    {
		#region Methods
		public void Save()
        {
			Validate<Meni>();
            Save<Meni>();
        }
		public async Task SaveAsync()
        {
			Validate<Meni>();
            await SaveAsync<Meni>();
        }
        public void Delete()
        {
            Delete<Meni>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<Meni>();
        }
		public void Validate()
		{
			Validate<Meni>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(Meni).GetType().Name;
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