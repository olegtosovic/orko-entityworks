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
    public partial class Obveznik
    {
		#region Methods
		public void Save()
        {
			Validate<Obveznik>();
            Save<Obveznik>();
        }
		public async Task SaveAsync()
        {
			Validate<Obveznik>();
            await SaveAsync<Obveznik>();
        }
        public void Delete()
        {
            Delete<Obveznik>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<Obveznik>();
        }
		public void Validate()
		{
			Validate<Obveznik>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(Obveznik).GetType().Name;
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