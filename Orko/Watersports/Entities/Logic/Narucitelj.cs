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
    public partial class Narucitelj
    {
		#region Methods
		public void Save()
        {
			Validate<Narucitelj>();
            Save<Narucitelj>();
        }
		public async Task SaveAsync()
        {
			Validate<Narucitelj>();
            await SaveAsync<Narucitelj>();
        }
        public void Delete()
        {
            Delete<Narucitelj>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<Narucitelj>();
        }
		public void Validate()
		{
			Validate<Narucitelj>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(Narucitelj).GetType().Name;
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