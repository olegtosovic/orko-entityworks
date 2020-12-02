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
    public partial class KrevetnaDeklaracija
    {
		#region Methods
		public void Save()
        {
			Validate<KrevetnaDeklaracija>();
            Save<KrevetnaDeklaracija>();
        }
		public async Task SaveAsync()
        {
			Validate<KrevetnaDeklaracija>();
            await SaveAsync<KrevetnaDeklaracija>();
        }
        public void Delete()
        {
            Delete<KrevetnaDeklaracija>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<KrevetnaDeklaracija>();
        }
		public void Validate()
		{
			Validate<KrevetnaDeklaracija>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(KrevetnaDeklaracija).GetType().Name;
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