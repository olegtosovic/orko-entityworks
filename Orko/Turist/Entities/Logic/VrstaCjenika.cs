// Generated on 11/29/2020 8:43 PM using EntityWorks code generation tool.
// Template version: 1.0
// Note: Intended for modification.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orko.EntityWorks;

namespace Orko.Turist
{
    public partial class VrstaCjenika
    {
		#region Methods
		public void Save()
        {
			Validate<VrstaCjenika>();
            Save<VrstaCjenika>();
        }
		public async Task SaveAsync()
        {
			Validate<VrstaCjenika>();
            await SaveAsync<VrstaCjenika>();
        }
        public void Delete()
        {
            Delete<VrstaCjenika>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<VrstaCjenika>();
        }
		public void Validate()
		{
			Validate<VrstaCjenika>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(VrstaCjenika).GetType().Name;
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