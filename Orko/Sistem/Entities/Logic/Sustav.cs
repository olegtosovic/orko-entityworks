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
    public partial class Sustav
    {
		#region Methods
		public void Save()
        {
			Validate<Sustav>();
            Save<Sustav>();
        }
		public async Task SaveAsync()
        {
			Validate<Sustav>();
            await SaveAsync<Sustav>();
        }
        public void Delete()
        {
            Delete<Sustav>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<Sustav>();
        }
		public void Validate()
		{
			Validate<Sustav>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(Sustav).GetType().Name;
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