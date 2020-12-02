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
    public partial class Status
    {
		#region Methods
		public void Save()
        {
			Validate<Status>();
            Save<Status>();
        }
		public async Task SaveAsync()
        {
			Validate<Status>();
            await SaveAsync<Status>();
        }
        public void Delete()
        {
            Delete<Status>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<Status>();
        }
		public void Validate()
		{
			Validate<Status>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(Status).GetType().Name;
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