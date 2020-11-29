// Generated on 11/25/2020 11:00 PM using EntityWorks code generation tool.
// Template version: 1.0
// Note: Intended for modification.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orko.EntityWorks;

namespace OrkoEntityWorks.Abstract
{
    public partial class Table6
    {
		#region Methods
		public void Save()
        {
			Validate<Table6>();
            Save<Table6>();
        }
		public async Task SaveAsync()
        {
			Validate<Table6>();
            await SaveAsync<Table6>();
        }
        public void Delete()
        {
            Delete<Table6>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<Table6>();
        }
		public void Validate()
		{
			Validate<Table6>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(Table6).GetType().Name;
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