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
    public partial class Spol
    {
		#region Methods
		public void Save()
        {
			Validate<Spol>();
            Save<Spol>();
        }
		public async Task SaveAsync()
        {
			Validate<Spol>();
            await SaveAsync<Spol>();
        }
        public void Delete()
        {
            Delete<Spol>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<Spol>();
        }
		public void Validate()
		{
			Validate<Spol>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(Spol).GetType().Name;
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