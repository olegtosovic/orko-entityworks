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
    public partial class Naselje
    {
		#region Methods
		public void Save()
        {
			Validate<Naselje>();
            Save<Naselje>();
        }
		public async Task SaveAsync()
        {
			Validate<Naselje>();
            await SaveAsync<Naselje>();
        }
        public void Delete()
        {
            Delete<Naselje>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<Naselje>();
        }
		public void Validate()
		{
			Validate<Naselje>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(Naselje).GetType().Name;
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