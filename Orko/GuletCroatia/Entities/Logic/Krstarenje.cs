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
    public partial class Krstarenje
    {
		#region Methods
		public void Save()
        {
			Validate<Krstarenje>();
            Save<Krstarenje>();
        }
		public async Task SaveAsync()
        {
			Validate<Krstarenje>();
            await SaveAsync<Krstarenje>();
        }
        public void Delete()
        {
            Delete<Krstarenje>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<Krstarenje>();
        }
		public void Validate()
		{
			Validate<Krstarenje>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(Krstarenje).GetType().Name;
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