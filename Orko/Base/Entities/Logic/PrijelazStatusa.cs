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
    public partial class PrijelazStatusa
    {
		#region Methods
		public void Save()
        {
			Validate<PrijelazStatusa>();
            Save<PrijelazStatusa>();
        }
		public async Task SaveAsync()
        {
			Validate<PrijelazStatusa>();
            await SaveAsync<PrijelazStatusa>();
        }
        public void Delete()
        {
            Delete<PrijelazStatusa>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<PrijelazStatusa>();
        }
		public void Validate()
		{
			Validate<PrijelazStatusa>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(PrijelazStatusa).GetType().Name;
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