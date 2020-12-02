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
    public partial class Brod
    {
		#region Methods
		public void Save()
        {
			Validate<Brod>();
            Save<Brod>();
        }
		public async Task SaveAsync()
        {
			Validate<Brod>();
            await SaveAsync<Brod>();
        }
        public void Delete()
        {
            Delete<Brod>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<Brod>();
        }
		public void Validate()
		{
			Validate<Brod>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(Brod).GetType().Name;
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