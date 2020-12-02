// Generated on 11/29/2020 8:43 PM using EntityWorks code generation tool.
// Template version: 1.0
// Note: Intended for modification.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orko.EntityWorks;

namespace Orko.Blog
{
    public partial class Clanak
    {
		#region Methods
		public void Save()
        {
			Validate<Clanak>();
            Save<Clanak>();
        }
		public async Task SaveAsync()
        {
			Validate<Clanak>();
            await SaveAsync<Clanak>();
        }
        public void Delete()
        {
            Delete<Clanak>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<Clanak>();
        }
		public void Validate()
		{
			Validate<Clanak>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(Clanak).GetType().Name;
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