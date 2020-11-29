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
    public partial class TableWhitespace
    {
		#region Methods
		public void Save()
        {
			Validate<TableWhitespace>();
            Save<TableWhitespace>();
        }
		public async Task SaveAsync()
        {
			Validate<TableWhitespace>();
            await SaveAsync<TableWhitespace>();
        }
        public void Delete()
        {
            Delete<TableWhitespace>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<TableWhitespace>();
        }
		public void Validate()
		{
			Validate<TableWhitespace>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(TableWhitespace).GetType().Name;
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